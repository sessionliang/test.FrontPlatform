appModule.config([
    '$stateProvider', '$urlRouterProvider',
    function ($stateProvider, $urlRouterProvider) {
        //test data
        fesco.auth.allPermissions["Pages.Tenant.Dashboard"] = true;
        fesco.auth.grantedPermissions["Pages.Tenant.Dashboard"] = true;
        fesco.auth.grantedPermissions["Pages.Tenant.Staffs"] = true;

        //配置路由
        $stateProvider.state('tenant', {
            'abstract': true,
            url: '/tenant',
            template: '<div ui-view></div>'
        });

        //控制面板
        if (fesco.auth.hasPermission('Pages.Tenant.Dashboard')) {
            $urlRouterProvider.otherwise('/tenant/dashboard');
            $stateProvider.state('tenant.dashboard', {
                url: '/dashboard',
                templateUrl: '~/App/tenant/views/dashboard/index.cshtml',
                menu: 'Tenant.Dashboard'
            });
        }

        //员工
        if (fesco.auth.hasPermission('Pages.Tenant.Staffs')) {
            $stateProvider.state('tenant.staffs', {
                url: '/staffs',
                templateUrl: '~/App/tenant/views/staffs/index.cshtml',
                menu: 'Tenant.Staffs'
            });
            $stateProvider.state('tenant.staffsCreate', {
                url: '/staffsCreate/{returnUrl:.*}',
                templateUrl: '~/App/tenant/views/staffs/create.cshtml',
                menu: 'Tenant.StaffsCreate'
            });
            $stateProvider.state('tenant.staffsBatchAdd', {
                url: '/staffsBatchAdd',
                templateUrl: '~/App/tenant/views/staffs/batchAdd.cshtml',
                menu: 'Tenant.StaffsBatchAdd'
            });
        }


    }
]);