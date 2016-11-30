using PizzaStoreMvc.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreMvc.Business.Repositories
{
  public static class CheeseRepo
  {
    private static List<Cheese> cheeses = new List<Cheese>
    {
      new Cheese() { Name = "American", Price = 2M, Quantity = 100},
      new Cheese() { Name = "Provalone", Price = 2M, Quantity = 100},
      new Cheese() { Name = "Swiss", Price = 2M, Quantity = 100}
    };

    public static List<Cheese> GetCheeses()
    {
      return cheeses;
    }

  }
}
