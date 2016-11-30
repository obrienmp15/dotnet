using DataAccess;
using PizzaStoreData.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreData.Client.Mappers
{
  public class CrustMapper
  {
    public static CrustDAO MapToCrustDAO(Crust crust)
    {
      var c = new CrustDAO();
      c.Id = crust.CrustId;
      c.Name = crust.CrustName;
      c.Price = crust.Price;

      return c;
    }

    public static Crust MapToCrust(CrustDAO crust)
    {
      var c = new Crust();
      c.CrustId = crust.Id;
      c.CrustName = crust.Name;
      c.Price = crust.Price;

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