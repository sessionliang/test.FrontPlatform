(function () {
    appModule.controller('common.views.layout.menu', [
        '$scope',
        function ($scope) {
            var vm = this;
            vm.menu = {};
            vm.menu.items = [
                {
                    name: '首页',
                    items: [],
                    icon: 'fa fa-desktop',
                    href: '#/tenant/dashboard'
                },
                {
                    name: '社保公积金',
                    items: [
                        {
                            name: '增员',
                            items: [
                                    {
                                        name: '添加人员',
                                        items: [],
                                        icon: 'fa fa-genderless',
                                        href: '#/tenant/staffsCreate/'
                                    },
                                    {
                                        name: '批量导入',
                                        items: [],
                                        icon: 'fa fa-genderless',
                                        href: '#/tenant/staffsBatchAdd'
                                    }
                            ],
                            icon: 'fa fa-dot-circle-o',
                            href: '#'
                        },
                        {
                            name: '减员',
                            items: [
                                 {
                                     name: '减少人员',
                                     items: [],
                                     icon: 'fa fa-genderless',
                                     href: '#/tenant/staffs/remove'
                                 },
                                    {
                                        name: '批量减员',
                                        items: [],
                                        icon: 'fa fa-genderless',
                                        href: '#/tenant/staffs/batchRemove'
                                    }
                            ],
                            icon: 'fa fa-dot-circle-o',
                            href: '#'
                        },
                        {
                            name: '查询修改',
                            items: [],
                            icon: 'fa fa-dot-circle-o',
                            href: '#/tenant/staffs'
                        }
                    ],
                    icon: 'fa fa-tags',
                    href: '#'
                },
                {
                    name: '账单管理',
                    items: [],
                    icon: 'fa fa-shopping-cart',
                    href: '#'
                },
                {
                    name: '保险福利',
                    items: [],
                    icon: 'fa fa-cube',
                    href: '#'
                },
                {
                    name: '全国政策文件查询',
                    items: [],
                    icon: 'fa fa-book',
                    href: '#'
                }

            ];

            $scope.$on('$viewContentLoaded', function () {

            });

            $scope.$on('$viewContentLoaded', function () {
                //搜索初始化
                debugger
                Admin.Search.init();
            });
        }
    ]);
})();