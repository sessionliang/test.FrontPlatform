using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fesoc.Forepart.Test.App_Start.Bunding
{
    public static class StylePaths
    {
        //样式表文件路径
        public const string Styles = "~/Content/styles.css";
        public const string StylesRTL = "~/Content/styles.rtl.css";
        public const string AdminLTE = "~/Content/adminLTE/AdminLTE-2.3.0.min.css";
        public const string AdminLTERTL = "~/Content/adminLTE/AdminLTE-2.3.0.rtl.css";
        public const string AdminLTESkins = "~/Content/adminLTE/skins/_all-skins.min.css";
        public const string Bootstrap = "~/libs/bootstrap/css/bootstrap.min.css";
        public const string BootstrapRTL = "~/libs/bootstrap/css/bootstrap-rtl.min.css";
        public const string Typeahead = "~/Content/typeahead/typeahead.css";
        public const string FontAwesome = "~/Content/fontAwesome/css/font-awesome-4.6.3.min.css";

        //JQuery DataTable
        public const string JQuery_DataTable = "~/libs/jquery-dataTable/css/dataTables.bootstrap.min.css";

        public const string Sweet_Alert = "~/libs/sweetalert/sweet-alert.css";


        /// <summary>
        /// 通用样式文件夹，在此文件夹的css文件自动加载
        /// </summary>
        public const string CommonCssDirectory = "~/Common/Styles";

        /// <summary>
        /// 后台css文件夹
        /// </summary>
        public const string AppCssDirectory = "~/App";
    }
}