using PizzaStoreMvc.Client.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaStoreMvc.Client.Controllers
{
  public class CustomerController : Controller
  {
    // GET: Customer
    public ActionResult Index()
    {
      return View();
    }


    //[HttpPost]
    //[ValidateAntiForgeryToken]
    //public ActionResult Create(Customer customer)
    //{
    //  if (ModelState.IsValid)
    //  {
    //    cl.Add(customer);
    //    ViewBag.Message = "the customer in";

    //    return View("Success");

    //  }
    //  ViewBag.Message = "the customer out";
    //  return View("Failure");

    //}


  }
}
