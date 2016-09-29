using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fesoc.Forepart.Test.App_Start.Bunding
{
    public static class StylePaths
    {
        //样式表文件路径

        //前端框架
        public const string AdminLTE = "~/libs/bower_components/adminLTE/dist/css/AdminLTE.min.css";
        public const string AdminLTESkins = "~/libs/bower_components/adminLTE/dist/css/skins/_all-skins.min.css";

        //Bootstrap
        public const string Bootstrap = "~/libs/bower_components/bootstrap/dist/css/bootstrap.min.css";

        //FontAwesome
        public const string FontAwesome = "~/libs/bower_components/font-awesome/css/font-awesome.min.css";

        //JQuery DataTable
        public const string JQuery_DataTable = "~/libs/bower_components/datatables.net-bs/css/dataTables.bootstrap.min.css";

        //弹窗
        public const string Sweet_Alert = "~/libs/bower_components/sweetalert/dist/sweetalert.css";


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