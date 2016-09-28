using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace Fesoc.Forepart.Test.Core
{
    public static class CultureHelper
    {
        public static bool IsRtl
        {
            get { return Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft; }
        }
    }
}