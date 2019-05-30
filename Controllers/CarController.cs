using Microsoft.AspNetCore.Mvc;

namespace CarApp.Controllers
{
    public class CarController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult List()
        {
            return View();
        }

    }
}