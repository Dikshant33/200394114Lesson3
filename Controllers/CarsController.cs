using _200394114Lesson3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace _200394114Lesson3.Controllers
{
    public class CarsController : Controller
    {
        List<Car> carList = new List<Car>()
        {
            new Car {id = 1, Brand ="Toyota", Model = "Corolla", Type ="Compact", Year = 2017 },
            new Car {id = 2, Brand ="Ford", Model = "F-150", Type ="Truck", Year = 2018 },
            new Car {id = 3, Brand ="Dodge", Model = "Carvan", Type ="Minivan", Year = 2019 }

        };
        // GET: Cars
        public ActionResult Index()
        {
            return View(carList);
        }
        // Get car details
        public ActionResult Details(int? id)
        {
            if(id == null || id > carList.Count)
            {
                return Content("Invaid car id");
            }
            var ind = Convert.ToInt32(id) - 1;
            var car = carList[ind];

            return View(car);
        }
    }

    
}