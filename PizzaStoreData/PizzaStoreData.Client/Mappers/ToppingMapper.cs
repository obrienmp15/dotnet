using DataAccess;
using PizzaStoreData.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreData.Client.Mappers
{
  public class ToppingMapper
  {
    public static ToppingDAO MapToToppingDAO(Topping topping)
    {
      var t = new ToppingDAO();
      t.Id = topping.ToppingId;
      t.Name = topping.ToppingName;
      t.Price = topping.Price;

      return t;
    }

    public static Topping MapToTopping(ToppingDAO topping)
    {
      var t = new Topping();
      t.ToppingId = topping.Id;
      t.ToppingName = topping.Name;
      t.Price = topping.Price;

      return t;
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
