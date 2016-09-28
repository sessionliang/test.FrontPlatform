using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fesoc.Forepart.Test.Controllers
{
    public class FescoAppViewController : Controller
    {
        /// <summary>
        /// 前段利用angularJS的http interceptor传入viewUrl参数
        /// 后台在此解析，并返回对应View
        /// </summary>
        /// <param name="viewUrl"></param>
        /// <returns></returns>
        public ActionResult Load(string viewUrl)
        {
            if (!viewUrl.StartsWith("~"))
            {
                viewUrl = "~" + viewUrl;
            }
            return View(viewUrl);
        }
    }
}