var fesco = fesco || {};

(function ($) {

    /* fesco配置 Start*/
    fesco.appPath = fesco.appPath || '/';
    fesco.pageLoadTime = new Date();
    /* fesco配置 End*/


    /* 权限管理 Start*/
    fesco.auth = fesco.auth || {};
    //所有权限
    fesco.auth.allPermissions = fesco.auth.allPermissions || {};
    //拥有权限
    fesco.auth.grantedPermissions = fesco.auth.grantedPermissions || {};

    fesco.auth.hasPermission = function (permissionName) {
        return true;
        //return fesco.auth.isGranted.apply(this, permissionName);
    };
    fesco.auth.isGranted = function (permissionName) {
        //return fesco.auth.allPermissions[permissionName] != undefined && fesco.auth.grantedPermissions[permissionName] != undefined;
    };
    /* 权限管理 End*/

    /* Log Start */
    fesco.log = fesco.log || {};
    fesco.log.levels = {
        DEBUG: 1,//调试信息
        INFO: 2,//信息
        WARN: 3,//警告
        ERROR: 4,//错误
        FATAL: 5//严重错误
    };

    fesco.log.level = fesco.log.levels.DEBUG;

    //输出日志
    fesco.log.log = function (logObj, logLevel) {
        if (!window.console || !window.console.log) {
            return;
        }

        if (logLevel != undefined && logLevel < fesco.log.level) {
            return;
        }
        console.log(logObj);
    };

    //debug
    fesco.log.debug = function (logObj) {
        fesco.log.log("DEBUG: ", fesco.log.levels.DEBUG);
        fesco.log.log(logObj, fesco.log.levels.DEBUG);
    };
    //info
    fesco.log.info = function (logObj) {
        fesco.log.log("INFO: ", fesco.log.levels.INFO);
        fesco.log.log(logObj, fesco.log.levels.INFO);
    };
    //warn
    fesco.log.warn = function (logObj) {
        fesco.log.log("WARN: ", fesco.log.levels.WARN);
        fesco.log.log(logObj, fesco.log.levels.WARN);
    };
    //error
    fesco.log.error = function (logObj) {
        fesco.log.log("ERROR: ", fesco.log.levels.ERROR);
        fesco.log.log(logObj, fesco.log.levels.ERROR);
    };
    //fatal
    fesco.log.fatal = function (logObj) {
        fesco.log.log("FATAL: ", fesco.log.levels.FATAL);
        fesco.log.log(logObj, fesco.log.levels.FATAL);
    };
    /* Log End */

    /* Message Start*/
    fesco.message = fesco.message || {};
    var showMessage = function (message, title, messageType) {
        alert((title || '') + '' + message);
        if (!$) {
            fesco.log.warn('fesco.message can not return promise since jQuery is not defined!');
            return null;
        }
        //返回deferred对象，实现done,fail,progress链式编程
        return $.Deferred(function ($dfd) {
            $dfd.resolve();
        });
    };
    fesco.message.info = function (message, title) {
        fesco.log.warn('fesco.message.info is not implemented!');
        return showMessage(message, title, 1);
    };
    fesco.message.success = function (message, title) {
        fesco.log.warn('fesco.message.success is not implemented!');
        return showMessage(message, title, 2);
    };
    fesco.message.warn = function (message, title) {
        fesco.log.warn('fesco.message.warn is not implemented!');
        return showMessage(message, title, 4);
    };
    fesco.message.error = function (message, title) {
        fesco.log.warn('fesco.message.error is not implemented!');
        return showMessage(message, title, 3);
    };
    fesco.message.confirm = function (message, titleOrCallback, callback) {
        fesco.log.warn('fesco.message.confirm is not implemented!');
        if (titleOrCallback && !(typeof titleOrCallback == 'string')) {
            callback = titleOrCallback;
        }

        var result = confirm(message);
        callback && callback(result);

        if (!$) {
            fesco.log.warn('fesco.message can not return promise since jQUery is not defined!');
            return null;
        }
        return $.Deferred(function ($dfd) {
            $dfd.resolve();
        });
    };
    /* Message End*/
})(jQuery);