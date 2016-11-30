using PizzaStoreMvc.Client.DomainModels;
using PizzaStoreMvc.Client.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaStoreMvc.Client.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet]
    public ActionResult Index()
    {
      var orderModel = new PizzaOrder();

      return View(orderModel);
    }

    [HttpPost]
    public string Index(PizzaOrder order)
    {
      //var sauce = order.Options.Sauces.FirstOrDefault(s => s.Selected);
      //var crust = order.Options.Crusts.FirstOrDefault(s => s.Selected);
      //var size = order.Options.Sizes.FirstOrDefault(s => s.Selected);
      //var cheese = order.Options.Cheeses.FirstOrDefault(s => s.Selected);
      //var topping1 = order.Options.Toppings1.FirstOrDefault(s => s.Selected);
      //var topping2 = order.Options.Toppings2.FirstOrDefault(s => s.Selected);
      
    }

  }
}