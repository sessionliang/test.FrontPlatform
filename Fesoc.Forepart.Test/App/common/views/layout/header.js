(function () {
    appModule.controller('common.views.layout.header', [
        '$scope', '$timeout',
        function ($scope, $timeout) {
            var vm = this;

            $scope.$on('$includeContentLoaded', function () {
                $timeout(function () {
                    Admin.Search.init();
                }, 1000);
            });
        }
    ]);
})();