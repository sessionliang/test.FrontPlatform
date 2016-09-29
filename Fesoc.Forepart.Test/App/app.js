/* app模块定义 */
var appModule = angular.module("app", [
    //angularjs base start
    "ui.router",
    "ui.bootstrap",
    'ui.grid',
    'ui.grid.pagination',
    //angularjs base end

    'fesco'
]);

/*插件配置*/

/* 路由定义 */
appModule.config([
    '$stateProvider', '$urlRouterProvider',
    function ($stateProvider, $urlRouterProvider) {

        //默认访问地址
        $urlRouterProvider.otherwise("/welcome");

        $stateProvider.state('welcome', {
            url: '/welcome',
            templateUrl: '~/App/common/views/welcome/index.cshtml'
        });

        //通用路由配置

    }
]);
