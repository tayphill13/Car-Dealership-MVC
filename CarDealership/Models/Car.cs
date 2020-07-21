using System;
using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Car
  {
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles  { get; set; }
    public int MaxPrice { get; set; }
    
    private static List<Car> _instances = new List<Car>{};

    private static List<Car> _carsMatchingPrice = new List<Car>{};

    public static string MakeSound(string sound)
    {
      return "Our cars sound like " + sound;
    }
    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      _instances.Add(this);
    }

    public static List<Car> WorthBuying(int MaxPrice)
    {
      foreach (Car y in _instances)
      {
        if (y.Price < MaxPrice)
        {
          _carsMatchingPrice.Add(y);
        }
      }
      return _carsMatchingPrice;
    }
    public static List<Car> GetAll()
    {
      return _instances;
    }
  }
}