using Microsoft.AspNetCore.Mvc;

namespace MovieProject.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
