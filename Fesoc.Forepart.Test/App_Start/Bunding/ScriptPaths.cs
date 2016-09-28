using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fesoc.Forepart.Test.App_Start.Bunding
{
    public static class ScriptPaths
    {
        //样式表文件路径
        public const string JQuery = "~/Scripts/jquery-1.10.2.min.js";
        public const string Angular = "~/Scripts/angular.min.js";
        public const string Angular_Sanitize = "~/Scripts/angular-sanitize.min.js";
        public const string Angular_Touch = "~/Scripts/angular-touch.min.js";
        public const string Angular_Ui_Router = "~/Scripts/angular-ui-router.min.js";
        public const string Angular_Ui_Utils = "~/Scripts/angular-ui/ui-utils.min.js";
        public const string Angular_Ui_Bootstrap_Tpls = "~/Scripts/angular-ui/ui-bootstrap-tpls.min.js";
        public const string Angular_Ui_Grid = "~/libs/angular-ui-grid/ui-grid.min.js";
        public const string Bootstrap = "~/Scripts/bootstrap/bootstrap.min.js";
        public const string AdminLTE = "~/Scripts/adminLTE/app.min.js";
        public const string Typeahead = "~/Scripts/typeahead/typeahead.bundle.min.js";
        public const string AdminSearch = "~/Scripts/admin.search.js";
        public const string AdminNavigation = "~/Scripts/admin.navigation.js";
        public const string AdminCommon = "~/Scripts/admin.common.js";

        //jquery.dataTable
        public const string JQuery_DataTable = "~/libs/jquery-dataTable/js/jquery.dataTables.min.js";
        public const string JQuery_DataTable_Bootstrap = "~/libs/jquery-dataTable/js/dataTables.bootstrap.min.js";

        //sweet alert
        public const string Sweet_Alert = "~/libs/sweetalert/sweet-alert.min.js";

        /// <summary>
        /// 通用样式文件夹，在此文件夹的css文件自动加载
        /// </summary>
        public const string CommonJsDirectory = "~/Common/Scripts";

        /// <summary>
        /// 后台js文件夹
        /// </summary>
        public const string AppJsDirectory = "~/App";
    }
}