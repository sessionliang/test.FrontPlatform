(function () {
    appModule.controller('common.views.staffs.index', [
        '$scope',
        function ($scope) {
            var vm = this;

            vm.init = function () {
                $('#dt').DataTable({
                    ajax: {
                        //指定数据源
                        url: "/api/staffs",
                        data: function (d) {
                            if (d.search) {
                                d.search = d.search["value"];
                            }
                            if (d.order[0]) {
                                d.orderCol = d.columns[d.order[0]["column"]]["data"];
                                d.orderDir = d.order[0]["dir"];
                            }
                        }
                    },
                    serverSide: true,
                    processing: true,
                    columns: [
                        { 'data': 'name' },
                        { 'data': 'position' },
                        { 'data': 'office' },
                        { 'data': 'age' },
                        { 'data': 'startDate' },
                        { 'data': 'salary' },
                        { 'data': null }
                    ],
                    columnDefs: [
                        {
                            'render': function (data, type, row, meta) {
                                return "<a href='javascript:alert(\"修改\");'>修改</a>";
                            },
                            'targets': 6

                        }
                    ]
                });
            };


            vm.init();

        }]);
})();