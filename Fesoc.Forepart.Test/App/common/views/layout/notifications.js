(function () {
    appModule.controller('common.views.layout.notifications', [
        '$scope',
        function ($scope) {
            var vm = this;
            vm.messageTypeOptions = {
                INFO: 1,
                SUCCESS: 2,
                FAIL: 3,
                COMFIRM: 4
            };
            vm.messageType = 0;
            vm.message = vm.title = '';
        }
    ]);
})();