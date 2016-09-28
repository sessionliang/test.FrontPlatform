using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Fesoc.Forepart.Test.App_Start.Bunding
{
    public static class CommonBundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            AddCommonCss(bundles);
            AddCommonJs(bundles);
        }

        private static void AddCommonJs(BundleCollection bundles)
        {
            bundles.Add(
                new ScriptBundle("~/Bundles/Common/js")
                .IncludeDirectory(ScriptPaths.CommonJsDirectory, "*.js", true)
                );
        }

        private static void AddCommonCss(BundleCollection bundles)
        {
            bundles.Add(
          new StyleBundle("~/Bundles/Common/css")
          .IncludeDirectory(StylePaths.CommonCssDirectory, "*.css", true)
          );
        }
    }
}