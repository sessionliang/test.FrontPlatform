using System.Web.Optimization;

namespace Fesoc.Forepart.Test.App_Start.Bunding
{
    public static class BundleExtensions
    {
        public static Bundle ForceOrdered(this Bundle bundle)
        {
            bundle.Orderer = new AsIsBundleOrderer();
            return bundle;
        }
    }
}