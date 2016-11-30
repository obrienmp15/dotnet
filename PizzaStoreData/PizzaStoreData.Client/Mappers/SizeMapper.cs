using DataAccess;
using PizzaStoreData.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreData.Client.Mappers
{
  public class SizeMapper
  {
    public static SizeDAO MapToSizeDAO(Size size)
    {
      var s = new SizeDAO();
      s.Id = size.SizeId;
      s.Name = size.SizeName;
      s.Price = size.Price;

      return s;
    }

    public static Size MapToSize(SizeDAO size)
    {
      var s = new Size();
      s.SizeId = size.Id;
      s.SizeName = size.Name;
      s.Price = size.Price;

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