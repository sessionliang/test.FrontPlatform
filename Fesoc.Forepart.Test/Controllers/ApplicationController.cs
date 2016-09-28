using System.Web.Mvc;

namespace Fesoc.Forepart.Test.Controllers
{
    public class ApplicationController : Controller
    {
        public ActionResult Index()
        {
            return View("~/App/common/views/layout/layout.cshtml"); 
        }
    }
}