(function () {
    appModule.controller('common.views.staffs.create', [
        '$scope', '$stateParams',
        function ($scope, $stateParams) {
            var vm = this;
            vm.genders = [
                            { key: '保密', value: 0 },
                            { key: '男', value: 1 },
                            { key: '女', value: 2 }
            ];
            vm.returnUrl = $stateParams.returnUrl ? ('#/' + $stateParams.returnUrl) : '';
            vm.staff = {
                gender: vm.genders[0]
            };



            vm.save = function () {
                fesco.message.info("添加成功");
            };

            $scope.$on('$viewContentLoaded', function () {

            });

        }]);
})();