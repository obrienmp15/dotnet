using DataAccess;
using PizzaStoreData.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreData.Client.Mappers
{
  public class SauceMapper
  {
    public static SauceDAO MapToSauceDAO(Sauce sauce)
    {
      var s = new SauceDAO();
      s.Id = sauce.SauceId;
      s.Name = sauce.SauceName;
      s.Price = sauce.Price;

      return s;
    }

    public static Sauce MapToSauce(SauceDAO sauce)
    {
      var s = new Sauce();
      s.SauceId = sauce.Id;
      s.SauceName = sauce.Name;
      s.Price = sauce.Price;

      return s;
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