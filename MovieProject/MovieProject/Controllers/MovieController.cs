using System;
using Microsoft.AspNetCore.Mvc;

namespace MovieProject.Controllers
{
    public class MovieController : Controller
    {
       public ActionResult Index()
        {
            return View();
        }
    }
}
