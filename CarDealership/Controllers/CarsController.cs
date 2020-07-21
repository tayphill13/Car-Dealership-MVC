using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
  public class CarsController : Controller
  {
    [HttpGet("/cars")]
    public ActionResult Index()
    {
      List<Car> AllCars = Car.GetAll();
      return View(AllCars);
    }

    [HttpGet("/cars/addCar")]
    public ActionResult CreateCarsForm()
    {
      return View();
    }

    [HttpPost("/cars/addCar")]
    public ActionResult Create(string makeModel, int price, int miles)
    {
      Car myCar = new Car(makeModel, price, miles);
      return RedirectToAction("Index");
    }

    [HttpGet("/cars/price")]
    public ActionResult CreatePriceForm()
    {
      return View();
    }

    [HttpPost("/cars/price")]
    public ActionResult WorthBuying(int maxPrice)
    {
      return RedirectToAction("Index");
    }

  }
}