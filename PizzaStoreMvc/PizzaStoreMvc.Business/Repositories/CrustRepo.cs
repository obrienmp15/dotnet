using PizzaStoreMvc.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreMvc.Business.Repositories
{
  public static class CrustRepo
  {
    private static List<Crust> crusts = new List<Crust>
    {
      new Crust() { Name = "Hand Tossed", Price = 2M, Quantity = 100},
      new Crust() { Name = "Thin Crust", Price = 2.5M, Quantity = 100},
      new Crust() { Name = "Deep Dish", Price = 3M, Quantity = 100}
    };

    public static List<Crust> GetCrusts()
    {
      return crusts;
    }
  }
}
