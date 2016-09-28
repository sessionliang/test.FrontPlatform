appModule.config([
    '$stateProvider', '$urlRouterProvider',
    function ($stateProvider, $urlRouterProvider) {
        //test data
        fesco.auth.allPermissions["Pages.Administration.Users"] = true;
        fesco.auth.grantedPermissions["Pages.Administration.Users"] = true;

        //配置路由
        if (fesco.auth.hasPermission('Pages.Administration.Users')) {
            $stateProvider.state('users', {
                url: '/users',
                templateUrl: '~/App/common/views/users/index.cshtml',
                menu:'Administration.Users'
            });
        }
    }
]);