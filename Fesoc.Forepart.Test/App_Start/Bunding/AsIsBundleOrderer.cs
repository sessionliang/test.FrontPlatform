using System.Collections.Generic;
using System.Web.Optimization;

namespace Fesoc.Forepart.Test.App_Start.Bunding
{
    public class AsIsBundleOrderer : IBundleOrderer
    {
        public IEnumerable<BundleFile> OrderFiles(BundleContext context, IEnumerable<BundleFile> files)
        {
            return files;
        }
    }
}