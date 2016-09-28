(function () {
    appModule.controller('common.views.staffs.create', [
        '$scope', '$stateParams',
        function ($scope, $stateParams) {
            var vm = this;
            vm.returnUrl = $stateParams.returnUrl ? ('#/' + $stateParams.returnUrl) : '';
            vm.staff = {};
            vm.save = function () {
                fesco.message.info("添加成功");
            };

            $scope.$on('$viewContentLoaded', function () {

            });

        }]);
})();