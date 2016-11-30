using PizzaStoreMvc.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreMvc.Business.Repositories
{
  public static class SizeRepo
  {
    private static List<Size> sizes = new List<Size>
    {
      new Size() { Name = "Small", Price = 1M, Quantity = 100},
      new Size() { Name = "Medium", Price = 1.5M, Quantity = 100},
      new Size() { Name = "Large", Price = 2M, Quantity = 100}
    };

    public static List<Size> GetSizes()
    {
      return sizes;
    }

  }
}
