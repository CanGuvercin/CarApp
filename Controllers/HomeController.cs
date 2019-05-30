using Microsoft.AspNetCore.Mvc;
using CarApp.Models;
using CarApp.Data;
using System.Linq;

namespace CarApp.Controllers
{
    public class HomeController:Controller
    {
        //[HttpGet]
        public IActionResult Index(int? id)
        {
            var cars=CarRepository.Cars;
            if(id!=null){
                cars= cars.Where(i=>i.EngineId==id).ToList();
            }


            //ProductRepository.Cars

           //CarCategoryModel model = new CarCategoryModel();
            //model.Categories = CategoryRepository.Categories;
            //model.Cars= CarRepository.Cars;
            return View(cars);
        }
        
        public IActionResult Details(int id)
        {
            //CarCategoryModel model = new CarCategoryModel();
            //model.Categories= CategoryRepository.Categories;
            //model.Cars= CarRepository.GetById(id);
            return View(CarRepository.GetById(id));
        }
        public IActionResult Contact()
        {
            return View();
        }


    }
}