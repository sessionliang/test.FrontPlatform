using System.Web;
using System.Web.Optimization;

namespace Fesoc.Forepart.Test.App_Start.Bunding
{
    public class CssRewriteUrlWithVirtualDirectoryTransform : IItemTransform
    {
        private readonly CssRewriteUrlTransform _rewriteUrlTransform;

        public CssRewriteUrlWithVirtualDirectoryTransform()
        {
            _rewriteUrlTransform = new CssRewriteUrlTransform();
        }

        public string Process(string includedVirtualPath, string input)
        {
            var result = _rewriteUrlTransform.Process(includedVirtualPath, input);

            if (!string.IsNullOrEmpty(HttpRuntime.AppDomainAppVirtualPath) && HttpRuntime.AppDomainAppVirtualPath != "/")
            {
                result = result.Replace(@"url(/", @"url(" + HttpRuntime.AppDomainAppVirtualPath + @"/");
            }

            return result;
        }
    }
}