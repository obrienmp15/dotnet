using PizzaStoreMvc.Business.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaStoreMvc.Client.ViewModels
{
  public class PizzaOrderOption
  {
    [Required]
    [Display(Name ="Your Sauce Options")]
    public List<SelectListItem> Sauces { get; set; }

    [Required]
    [Display(Name = "Your Crust Options")]
    public List<SelectListItem> Crusts { get; set; }
        
    [Required]
    [Display(Name = "Your Size Options")]
    public List<SelectListItem> Sizes { get; set; }

    [Required]
    [Display(Name = "Your Cheese Options")]
    public List<SelectListItem> Cheeses { get; set; }

    [Required]
    [Display(Name = "Your Topping Options")]
    public List<SelectListItem> Toppings1 { get; set; }

    [Required]
    [Display(Name = "Your Topping Options")]
    public List<SelectListItem> Toppings2 { get; set; }

    public PizzaOrderOption()
    {
      Sauces = GetSauceOptions();
      Crusts = GetCrustOptions();
      Sizes = GetSizeOptions();
      Cheeses = GetCheeseOptions();
      Toppings1 = GetToppingsOptions1();
      Toppings2 = GetToppingsOptions2();
    }

    private List<SelectListItem> GetSauceOptions()
    {
      var sauces = SauceRepo.GetSauces();
      var sauceOptions = new List<SelectListItem>();

      foreach (var sauce in sauces)
      {
        sauceOptions.Add(new SelectListItem() { Text = sauce.Name, Value = sauce.IngredientId.ToString() });

      }
      return sauceOptions;

    }

    private List<SelectListItem> GetCrustOptions()
    {
      var crusts = CrustRepo.GetCrusts();
      var crustOptions = new List<SelectListItem>();

      foreach (var crust in crusts)
      {
        crustOptions.Add(new SelectListItem() { Text = crust.Name, Value = crust.IngredientId.ToString() });

      }
      return crustOptions;

    }

    private List<SelectListItem> GetSizeOptions()
    {
      var sizes = SizeRepo.GetSizes();
      var sizeOptions = new List<SelectListItem>();

      foreach (var size in sizes)
      {
        sizeOptions.Add(new SelectListItem() { Text = size.Name, Value = size.IngredientId.ToString() });

      }
      return sizeOptions;

    }

    private List<SelectListItem> GetCheeseOptions()
    {
      var cheeses = CheeseRepo.GetCheeses();
      var cheeseOptions = new List<SelectListItem>();

      foreach (var cheese in cheeses)
      {
        cheeseOptions.Add(new SelectListItem() { Text = cheese.Name, Value = cheese.IngredientId.ToString() });

      }
      return cheeseOptions;

    }

    private List<SelectListItem> GetToppingsOptions1()
    {
      var toppings = ToppingRepo.GetToppings();
      var toppingOptions = new List<SelectListItem>();

      foreach (var topping in toppings)
      {
        toppingOptions.Add(new SelectListItem() { Text = topping.Name, Value = topping.IngredientId.ToString() });

      }
      return toppingOptions;

    }

    private List<SelectListItem> GetToppingsOptions2()
    {
      var toppings = ToppingRepo.GetToppings();
      var toppingOptions = new List<SelectListItem>();

      foreach (var topping in toppings)
      {
        toppingOptions.Add(new SelectListItem() { Text = topping.Name, Value = topping.IngredientId.ToString() });

      }
      return toppingOptions;

    }
  }
}