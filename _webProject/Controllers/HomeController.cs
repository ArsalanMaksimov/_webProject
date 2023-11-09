
using System.Web.Mvc;

namespace _webProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Message";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Message";

            return View();
        }
    }
}