using Fesoc.Forepart.Test.App_Start.Bunding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Fesoc.Forepart.Test.App.Startup
{
    public static class AppBundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            AddAppCssLibs(bundles, false);
            AddAppCssLibs(bundles, true);

            AddAppJsLibs(bundles);

            //App文件夹中的js，css文件自动加载
            //统一加载，优点代码容易管理，缺点页面加载速度慢
            bundles.Add(
                new StyleBundle("~/Bundles/App/css")
                    .IncludeDirectory(StylePaths.AppCssDirectory, "*.css", true)
                    .ForceOrdered()
                );

            bundles.Add(
                new ScriptBundle("~/Bundles/App/js")
                    .IncludeDirectory(ScriptPaths.AppJsDirectory, "*.js", true)
                    .ForceOrdered()
                );
        }

        private static void AddAppJsLibs(BundleCollection bundles)
        {
            bundles.Add(
                new ScriptBundle("~/Bundles/App/libs/js")
                .Include(
                    ScriptPaths.JQuery,
                    ScriptPaths.Angular,
                    ScriptPaths.Angular_Sanitize,
                    ScriptPaths.Angular_Touch,
                    ScriptPaths.Angular_Ui_Router,
                    ScriptPaths.Angular_Ui_Utils,
                    ScriptPaths.Angular_Ui_Bootstrap_Tpls,
                    ScriptPaths.Angular_Ui_Grid,
                    ScriptPaths.Bootstrap,
                    ScriptPaths.JQuery_DataTable,
                    ScriptPaths.JQuery_DataTable_Bootstrap,
                    ScriptPaths.Sweet_Alert
                    )
                );
        }

        private static void AddAppCssLibs(BundleCollection bundles, bool isRTL)
        {
            bundles.Add(
                new StyleBundle("~/Bundles/App/libs/css" + (isRTL ? "RTL" : ""))
                .Include(StylePaths.AdminLTESkins, new CssRewriteUrlWithVirtualDirectoryTransform())
                .Include(StylePaths.Typeahead, new CssRewriteUrlWithVirtualDirectoryTransform())
                .Include(StylePaths.FontAwesome, new CssRewriteUrlWithVirtualDirectoryTransform())
                .Include(isRTL ? StylePaths.BootstrapRTL : StylePaths.Bootstrap, new CssRewriteUrlWithVirtualDirectoryTransform())
                .Include(isRTL ? StylePaths.AdminLTERTL : StylePaths.AdminLTE, new CssRewriteUrlWithVirtualDirectoryTransform())
                .Include(isRTL ? StylePaths.StylesRTL : StylePaths.Styles, new CssRewriteUrlWithVirtualDirectoryTransform())
                .Include(StylePaths.JQuery_DataTable, new CssRewriteUrlWithVirtualDirectoryTransform())
                .Include(StylePaths.Sweet_Alert,new CssRewriteUrlWithVirtualDirectoryTransform())
                );
        }
    }
}