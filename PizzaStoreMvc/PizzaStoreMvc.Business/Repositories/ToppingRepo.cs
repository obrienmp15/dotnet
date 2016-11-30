using PizzaStoreMvc.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreMvc.Business.Repositories
{
  public static class ToppingRepo
  {
    private static List<Toppings> Toppings = new List<Toppings>
    {
      new Toppings() { Name = "Pepperoni", Price = 2M, Quantity = 100},
      new Toppings() { Name = "Sausage", Price = 2M, Quantity = 100},
      new Toppings() { Name = "Black Olives", Price = 2M, Quantity = 100},
      new Toppings() { Name = "Pineapple", Price = 2M, Quantity = 100},
      new Toppings() { Name = "Green Peppers", Price = 2M, Quantity = 100},
      new Toppings() { Name = "Onions", Price = 2M, Quantity = 100},
      new Toppings() { Name = "None", Price = 0M, Quantity = 1}
    };

    public static List<Toppings> GetToppings()
    {
      return Toppings;
    }
  }
}
