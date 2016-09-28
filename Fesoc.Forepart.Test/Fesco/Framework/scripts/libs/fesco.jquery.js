var fesco = fesco || {};
(function ($) {

    if (!$) {
        return;
    }

    /* JQUERY ENHANCEMENTS ***************************************************/

    // fesco.ajax -> uses $.ajax ------------------------------------------------

    fesco.ajax = function (userOptions) {
        userOptions = userOptions || {};

        var options = $.extend({}, fesco.ajax.defaultOpts, userOptions);
        options.success = undefined;
        options.error = undefined;

        return $.Deferred(function ($dfd) {
            $.ajax(options)
                .done(function (data, textStatus, jqXHR) {
                    if (data.__fesco) {
                        fesco.ajax.handleResponse(data, userOptions, $dfd, jqXHR);
                    } else {
                        $dfd.resolve(data);
                        userOptions.success && userOptions.success(data);
                    }
                }).fail(function (jqXHR) {
                    if (jqXHR.responseJSON && jqXHR.responseJSON.__fesco) {
                        fesco.ajax.handleResponse(jqXHR.responseJSON, userOptions, $dfd, jqXHR);
                    } else {
                        fesco.ajax.handleNonfescoErrorResponse(jqXHR, userOptions, $dfd);
                    }
                });
        });
    };

    $.extend(fesco.ajax, {
        defaultOpts: {
            dataType: 'json',
            type: 'POST',
            contentType: 'application/json'
        },

        defaultError: {
            message: 'An error has occurred!',
            details: 'Error detail not sent by server.'
        },

        defaultError401: {
            message: 'You are not authenticated!',
            details: 'You should be authenticated (sign in) in order to perform this operation.'
        },

        defaultError403: {
            message: 'You are not authorized!',
            details: 'You are not allowed to perform this operation.'
        },

        defaultError404: {
            message: 'Resource not found!',
            details: 'The resource requested could not found on the server.'
        },

        logError: function (error) {
            fesco.log.error(error);
        },

        showError: function (error) {
            if (error.details) {
                return fesco.message.error(error.details, error.message);
            } else {
                return fesco.message.error(error.message || fesco.ajax.defaultError.message);
            }
        },

        handleTargetUrl: function (targetUrl) {
            if (!targetUrl) {
                location.href = fesco.appPath;
            } else {
                location.href = targetUrl;
            }
        },

        handleNonfescoErrorResponse: function (jqXHR, userOptions, $dfd) {
            if (userOptions.fescoHandleError !== false) {
                switch (jqXHR.status) {
                    case 401:
                        fesco.ajax.handleUnAuthorizedRequest(
                            fesco.ajax.showError(fesco.ajax.defaultError401),
                            fesco.appPath
                        );
                        break;
                    case 403:
                        fesco.ajax.showError(fesco.ajax.defaultError403);
                        break;
                    case 404:
                        fesco.ajax.showError(fesco.ajax.defaultError404);
                        break;
                    default:
                        fesco.ajax.showError(fesco.ajax.defaultError);
                        break;
                }
            }

            $dfd.reject.apply(this, arguments);
            userOptions.error && userOptions.error.apply(this, arguments);
        },

        handleUnAuthorizedRequest: function (messagePromise, targetUrl) {
            if (messagePromise) {
                messagePromise.done(function () {
                    fesco.ajax.handleTargetUrl(targetUrl);
                });
            } else {
                fesco.ajax.handleTargetUrl(targetUrl);
            }
        },

        handleResponse: function (data, userOptions, $dfd, jqXHR) {
            if (data) {
                if (data.success === true) {
                    $dfd && $dfd.resolve(data.result, data, jqXHR);
                    userOptions.success && userOptions.success(data.result, data, jqXHR);

                    if (data.targetUrl) {
                        fesco.ajax.handleTargetUrl(data.targetUrl);
                    }
                } else if (data.success === false) {
                    var messagePromise = null;

                    if (data.error) {
                        if (userOptions.fescoHandleError !== false) {
                            messagePromise = fesco.ajax.showError(data.error);
                        }
                    } else {
                        data.error = fesco.ajax.defaultError;
                    }

                    fesco.ajax.logError(data.error);

                    $dfd && $dfd.reject(data.error, jqXHR);
                    userOptions.error && userOptions.error(data.error, jqXHR);

                    if (jqXHR.status === 401 && userOptions.fescoHandleError !== false) {
                        fesco.ajax.handleUnAuthorizedRequest(messagePromise, data.targetUrl);
                    }
                } else { //not wrapped result
                    $dfd && $dfd.resolve(data, null, jqXHR);
                    userOptions.success && userOptions.success(data, null, jqXHR);
                }
            } else { //no data sent to back
                $dfd && $dfd.resolve(jqXHR);
                userOptions.success && userOptions.success(jqXHR);
            }
        },

        blockUI: function (options) {
            if (options.blockUI) {
                if (options.blockUI === true) { //block whole page
                    fesco.ui.setBusy();
                } else { //block an element
                    fesco.ui.setBusy(options.blockUI);
                }
            }
        },

        unblockUI: function (options) {
            if (options.blockUI) {
                if (options.blockUI === true) { //unblock whole page
                    fesco.ui.clearBusy();
                } else { //unblock an element
                    fesco.ui.clearBusy(options.blockUI);
                }
            }
        },

        //ajaxSendHandler: function (event, request, settings) {
        //    if (!settings.headers || settings.headers[fesco.security.antiForgery.tokenHeaderName] === undefined) {
        //        request.setRequestHeader(fesco.security.antiForgery.tokenHeaderName, fesco.security.antiForgery.getToken());
        //    }
        //}
    });

    //$(document).ajaxSend(function (event, request, settings) {
    //    return fesco.ajax.ajaxSendHandler(event, request, settings);
    //});

    /* JQUERY PLUGIN ENHANCEMENTS ********************************************/

    /* jQuery Form Plugin 
     * http://www.malsup.com/jquery/form/
     */

    // fescoAjaxForm -> uses ajaxForm ------------------------------------------

    if ($.fn.ajaxForm) {
        $.fn.fescoAjaxForm = function (userOptions) {
            userOptions = userOptions || {};

            var options = $.extend({}, $.fn.fescoAjaxForm.defaults, userOptions);

            options.beforeSubmit = function () {
                fesco.ajax.blockUI(options);
                userOptions.beforeSubmit && userOptions.beforeSubmit.apply(this, arguments);
            };

            options.success = function (data) {
                fesco.ajax.handleResponse(data, userOptions);
            };

            //TODO: Error?

            options.complete = function () {
                fesco.ajax.unblockUI(options);
                userOptions.complete && userOptions.complete.apply(this, arguments);
            };

            return this.ajaxForm(options);
        };

        $.fn.fescoAjaxForm.defaults = {
            method: 'POST'
        };
    }

})(jQuery);