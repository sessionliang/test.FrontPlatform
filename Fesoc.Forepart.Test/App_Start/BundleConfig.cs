using Fesoc.Forepart.Test.App.Startup;
using Fesoc.Forepart.Test.App_Start.Bunding;
using Fesoc.Forepart.Test.Core;
using System.Web;
using System.Web.Optimization;

namespace Fesoc.Forepart.Test
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //添加前台样式表
            FrontEndBundleConfig.RegisterBundles(bundles);
            ///添加通用样式表
            CommonBundleConfig.RegisterBundles(bundles);
            //添加后台样式表
            AppBundleConfig.RegisterBundles(bundles);

            BundleTable.EnableOptimizations = false;
        }
    }
}
