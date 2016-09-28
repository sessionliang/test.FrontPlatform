using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Fesoc.Forepart.Test.App_Start.Bunding
{
    public static class FrontEndBundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            AddFrontendCssLibs(bundles, false);
            AddFrontendCssLibs(bundles, true);

            AddFrontendJsLibs(bundles);
        }

        private static void AddFrontendJsLibs(BundleCollection bundles)
        {
            bundles.Add(
                new ScriptBundle("~/Bundles/Frontend/libs/js")
                .Include(
                    ScriptPaths.JQuery,
                    ScriptPaths.Bootstrap,
                    ScriptPaths.AdminLTE,
                    ScriptPaths.Typeahead,
                    ScriptPaths.AdminCommon,
                    ScriptPaths.AdminNavigation,
                    ScriptPaths.AdminSearch
                    )
                );
        }

        private static void AddFrontendCssLibs(BundleCollection bundles, bool isRTL)
        {
            bundles.Add(
                new StyleBundle("~/Bundles/Frontend/libs/css" + (isRTL ? "RTL" : ""))
                .Include(StylePaths.AdminLTESkins, new CssRewriteUrlWithVirtualDirectoryTransform())
                    .Include(StylePaths.Typeahead, new CssRewriteUrlWithVirtualDirectoryTransform())
                    .Include(StylePaths.FontAwesome, new CssRewriteUrlWithVirtualDirectoryTransform())
                    .Include(isRTL ? StylePaths.BootstrapRTL : StylePaths.Bootstrap, new CssRewriteUrlWithVirtualDirectoryTransform())
                    .Include(isRTL ? StylePaths.AdminLTERTL : StylePaths.AdminLTE, new CssRewriteUrlWithVirtualDirectoryTransform())
                    .Include(isRTL ? StylePaths.StylesRTL : StylePaths.Styles, new CssRewriteUrlWithVirtualDirectoryTransform()
                    )
                );
        }
    }
}