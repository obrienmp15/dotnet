using DataAccess;
using PizzaStoreData.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreData.Client.Mappers
{
  public class CheeseMapper
  {
    public static CheeseDAO MapToCheeseDAO(Cheese cheese)
    {
      var c = new CheeseDAO();
      c.Id = cheese.CheeseId;
      c.Name = cheese.CheeseName;
      c.Price = cheese.Price;

      return c;
    }

    public static Cheese MapToCheese(CheeseDAO cheese)
    {
      var c = new Cheese();
      c.CheeseId = cheese.Id;
      c.CheeseName = cheese.Name;
      c.Price = cheese.Price;

      return c;
    }

    public static object MapTo(object o)
    {
      var properties = 0.GetType().GetProperties();
      var ob = new object();

      foreach (var item in properties.ToList())
      {
        ob.GetType().GetProperty(item.Name).SetValue(ob, item.GetValue(item));
      }

      return ob;
    }
  }
}