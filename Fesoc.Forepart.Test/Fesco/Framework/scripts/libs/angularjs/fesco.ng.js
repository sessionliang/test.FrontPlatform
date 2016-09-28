(function (fesco, angular) {

    if (!angular) {
        return;
    }

    fesco.ng = fesco.ng || {};

    fesco.ng.http = {
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
                return fesco.message.error(error.details, error.message || fesco.ng.http.defaultError.message);
            } else {
                return fesco.message.error(error.message || fesco.ng.http.defaultError.message);
            }
        },

        handleTargetUrl: function (targetUrl) {
            if (!targetUrl) {
                location.href = fesco.appPath;
            } else {
                location.href = targetUrl;
            }
        },

        handleNonfescoErrorResponse: function (response, defer) {
            if (response.config.fescoHandleError !== false) {
                switch (response.status) {
                    case 401:
                        fesco.ng.http.handleUnAuthorizedRequest(
                            fesco.ng.http.showError(fesco.ng.http.defaultError401),
                            fesco.appPath
                        );
                        break;
                    case 403:
                        fesco.ng.http.showError(fesco.ajax.defaultError403);
                        break;
                    case 404:
                        fesco.ng.http.showError(fesco.ajax.defaultError404);
                        break;
                    default:
                        fesco.ng.http.showError(fesco.ng.http.defaultError);
                        break;
                }
            }

            defer.reject(response);
        },

        handleUnAuthorizedRequest: function (messagePromise, targetUrl) {
            if (messagePromise) {
                messagePromise.done(function () {
                    fesco.ng.http.handleTargetUrl(targetUrl || fesco.appPath);
                });
            } else {
                fesco.ng.http.handleTargetUrl(targetUrl || fesco.appPath);
            }
        },

        handleResponse: function (response, defer) {
            var originalData = response.data;

            if (originalData.success === true) {
                response.data = originalData.result;
                defer.resolve(response);

                if (originalData.targetUrl) {
                    fesco.ng.http.handleTargetUrl(originalData.targetUrl);
                }
            } else if (originalData.success === false) {
                var messagePromise = null;

                if (originalData.error) {
                    if (response.config.fescoHandleError !== false) {
                        messagePromise = fesco.ng.http.showError(originalData.error);
                    }
                } else {
                    originalData.error = defaultError;
                }

                fesco.ng.http.logError(originalData.error);

                response.data = originalData.error;
                defer.reject(response);

                if (response.status == 401 && response.config.fescoHandleError !== false) {
                    fesco.ng.http.handleUnAuthorizedRequest(messagePromise, originalData.targetUrl);
                }
            } else { //not wrapped result
                defer.resolve(response);
            }
        }
    }

    var fescoModule = angular.module('fesco', []);

    fescoModule.config([
        '$httpProvider', function ($httpProvider) {
            $httpProvider.interceptors.push(['$q', function ($q) {

                return {

                    'request': function (config) {
                        if (endsWith(config.url, '.cshtml')) {
                            config.url = fesco.appPath + 'fescoAppView/Load?viewUrl=' + config.url + '&_t=' + fesco.pageLoadTime.getTime();
                        }

                        return config;
                    },

                    'response': function (response) {
                        if (!response.data || !response.data.__fesco) {
                            //Non fesco related return value
                            return response;
                        }

                        var defer = $q.defer();
                        fesco.ng.http.handleResponse(response, defer);
                        return defer.promise;
                    },

                    'responseError': function (ngError) {
                        var defer = $q.defer();

                        if (!ngError.data || !ngError.data.__fesco) {
                            fesco.ng.http.handleNonfescoErrorResponse(ngError, defer);
                        } else {
                            fesco.ng.http.handleResponse(ngError, defer);
                        }

                        return defer.promise;
                    }

                };
            }]);
        }
    ]);

    function endsWith(str, suffix) {
        if (suffix.length > str.length) {
            return false;
        }

        return str.indexOf(suffix, str.length - suffix.length) !== -1;
    }


})((fesco || (fesco = {})), (angular || undefined));