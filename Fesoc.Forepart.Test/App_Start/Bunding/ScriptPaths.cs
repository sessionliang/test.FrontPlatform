using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fesoc.Forepart.Test.App_Start.Bunding
{
    public static class ScriptPaths
    {
        //样式表文件路径
        public const string JQuery = "~/libs/bower_components/jquery/dist/jquery.min.js";
        public const string Angular = "~/libs/bower_components/angular/angular.min.js";
        public const string Angular_Sanitize = "~/libs/bower_components/angular-sanitize/angular-sanitize.min.js";
        public const string Angular_Touch = "~/libs/bower_components/angular-touch/angular-touch.min.js";
        public const string Angular_Ui_Router = "~/libs/bower_components/angular-ui-router/release/angular-ui-router.min.js";
        public const string Angular_Ui_Utils = "~/Scripts/angular-ui/ui-utils.min.js";
        public const string Angular_Ui_Bootstrap_Tpls = "~/libs/bower_components/angular-bootstrap/ui-bootstrap-tpls.min.js";
        public const string Angular_Ui_Grid = "~/libs/bower_components/angular-ui-grid/ui-grid.min.js";
        public const string Bootstrap = "~/libs/bower_components/bootstrap/dist/js/bootstrap.min.js";
        public const string AdminLTE = "~/libs/bower_components/adminLTE/dist/js/app.min.js";
        public const string Typeahead = "~/libs/bower_components/typeahead.js/dist/typeahead.bundle.min.js";

        //jquery.dataTable
        public const string JQuery_DataTable = "~/libs/bower_components/datatables.net/js/jquery.dataTables.min.js";
        public const string JQuery_DataTable_Bootstrap = "~/libs/bower_components/datatables.net-bs/js/dataTables.bootstrap.min.js";

        //sweet alert
        public const string Sweet_Alert = "~/libs/bower_components/sweetalert/dist/sweetalert.min.js";

        /// <summary>
        /// 通用js文件夹，在此文件夹的js文件自动加载
        /// </summary>
        public const string CommonJsDirectory = "~/Common/Scripts";

        /// <summary>
        /// 后台js文件夹
        /// </summary>
        public const string AppJsDirectory = "~/App";
    }
}