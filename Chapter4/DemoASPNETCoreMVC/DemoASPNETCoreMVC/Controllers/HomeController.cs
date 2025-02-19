using DemoASPNETCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoASPNETCoreMVC.Controllers
{
    public class HomeController : Controller

    {

        public IActionResult Index()

        {

            //Create HomeModel object

            HomeModel message = new HomeModel();

            //Invoke to the view with message object

            return View(message);

        }

    }
}
