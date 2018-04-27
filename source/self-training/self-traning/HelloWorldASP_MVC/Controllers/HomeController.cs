using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloWorldASP_MVC.Models;

namespace HelloWorldASP_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var message = new MessgeModels();
            message.Welcome = "Chào mừng đến với Models !";
            return View(message);
        }
    }
}