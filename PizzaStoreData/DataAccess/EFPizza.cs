using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
  public class EFPizza
  {
    private PizzaStoreDBEntities db = new PizzaStoreDBEntities();
    //stuff
    #region Get as a List
    public List<Cheese> GetCheeses()
    {
      return db.Cheese.ToList();
    }

    public List<Crust> GetCrusts()
    {
      return db.Crusts.ToList();
    }

    public List<Customer> GetCustomers()
    {
      return db.Customers.ToList();
    }

    public List<Pizza> GetPizzas()
    {
      return db.Pizzas.ToList();
    }

    public List<Sauce> GetSauces()
    {
      return db.Sauces.ToList();
    }

    public List<Size> GetSizes()
    {
      return db.Sizes.ToList();
    }

    public List<Topping> GetToppings()
    {
      return db.Toppings.ToList();
    }
    #endregion

    #region Get as an Item
    public Cheese GetCheese(int id)
    {
      return db.Cheese.Where(c => c.CheeseId == id).Single();
    }

    public Crust GetCrust(int id)
    {
      return db.Crusts.Where(c => c.CrustId == id).Single();
    }

    public Customer GetCustomer(int id)
    {
      return db.Customers.Where(c => c.CustomerId == id).Single();
    }

    public Pizza GetPizza(int id)
    {
      return db.Pizzas.Where(p => p.PizzaId == id).Single();
    }

    public Sauce GetSauce(int id)
    {
      return db.Sauces.Where(s => s.SauceId == id).Single();
    }

    public Size GetSize(int id)
    {
      return db.Sizes.Where(s => s.SizeId == id).Single();
    }

    public Topping GetTopping(int id)
    {
      return db.Toppings.Where(t => t.ToppingId == id).Single();
    }
    #endregion

    #region Insert
    public bool InsertCheese(Cheese newCheese)
    {
      db.Cheese.Add(newCheese);

      return db.SaveChanges() > 0;
    }

    public bool InsertCrust(Crust newCrust)
    {
      db.Crusts.Add(newCrust);

      return db.SaveChanges() > 0;
    }

    public bool InsertCustomer(Customer newCustomer)
    {
      db.Customers.Add(newCustomer);

      return db.SaveChanges() > 0;
    }

    public bool InsertPizza(Pizza newPizza)
    {
      db.Pizzas.Add(newPizza);

      return db.SaveChanges() > 0;
    }

    public bool InsertSauce(Sauce newSauce)
    {
      db.Sauces.Add(newSauce);

      return db.SaveChanges() > 0;
    }

    public bool InsertSize(Size newSize)
    {
      db.Sizes.Add(newSize);

      return db.SaveChanges() > 0;
    }

    public bool InsertTopping(Topping newTopping)
    {
      db.Toppings.Add(newTopping);

      return db.SaveChanges() > 0;
    }
    #endregion

    #region Modify
    public bool ChangeCheese(Cheese cheese)
    {
      if (db.Cheese.Where(c => c.CheeseId == cheese.CheeseId).Count() != 0)
      {
        var entry = db.Entry<Cheese>(cheese);

        entry.State = EntityState.Modified;
      }

      return db.SaveChanges() > 0;
    }

    public bool ChangeCrust(Crust crust)
    {
      if (db.Crusts.Where(c => c.CrustId == crust.CrustId).Count() != 0)
      {
        var entry = db.Entry<Crust>(crust);

        entry.State = EntityState.Modified;
      }

      return db.SaveChanges() > 0;
    }

    public bool ChangeCustomer(Customer customer)
    {
      if (db.Customers.Where(c => c.CustomerId == customer.CustomerId).Count() != 0)
      {
        var entry = db.Entry<Customer>(customer);

        entry.State = EntityState.Modified;
      }

      return db.SaveChanges() > 0;
    }

    public bool ChangePizza(Pizza pizza)
    {
      if (db.Pizzas.Where(p => p.PizzaId == pizza.PizzaId).Count() != 0)
      {
        var entry = db.Entry<Pizza>(pizza);

        entry.State = EntityState.Modified;
      }

      return db.SaveChanges() > 0;
    }

    public bool ChangeSauce(Sauce sauce)
    {
      if (db.Sauces.Where(s => s.SauceId == sauce.SauceId).Count() != 0)
      {
        var entry = db.Entry<Sauce>(sauce);

        entry.State = EntityState.Modified;
      }

      return db.SaveChanges() > 0;
    }

    public bool ChangeSize(Size size)
    {
      if (db.Sizes.Where(s => s.SizeId == size.SizeId).Count() != 0)
      {
        var entry = db.Entry<Size>(size);

        entry.State = EntityState.Modified;
      }

      return db.SaveChanges() > 0;
    }
    
    public bool ChangeTopping(Topping Topping)
    {
      if (db.Toppings.Where(t => t.ToppingId == Topping.ToppingId).Count() != 0)
      {
        var entry = db.Entry<Topping>(Topping);

        entry.State = EntityState.Modified;
      }

      return db.SaveChanges() > 0;
    }
    #endregion

    #region Delete
    public bool DeleteCheese(Cheese cheese)
    {
      if (db.Cheese.Where(c => c == cheese).Count() != 0)
      {
        var entry = db.Entry<Cheese>(cheese);

        entry.State = EntityState.Deleted;
      }

      return db.SaveChanges() > 0;
    }

    public bool DeleteCrust(Crust crust)
    {
      if (db.Crusts.Where(c => c == crust).Count() != 0)
      {
        var entry = db.Entry<Crust>(crust);

        entry.State = EntityState.Deleted;
      }

      return db.SaveChanges() > 0;
    }

    public bool DeleteCustomer(Customer customer)
    {
      if (db.Customers.Where(c => c == customer).Count() != 0)
      {
        var entry = db.Entry<Customer>(customer);

        entry.State = EntityState.Deleted;
      }

      return db.SaveChanges() > 0;
    }

    public bool DeletePizza(Pizza pizza)
    {
      if (db.Pizzas.Where(p => p == pizza).Count() != 0)
      {
        var entry = db.Entry<Pizza>(pizza);

        entry.State = EntityState.Deleted;
      }

      return db.SaveChanges() > 0;
    }

    public bool DeleteSauce(Sauce sauce)
    {
      if (db.Sauces.Where(s => s == sauce).Count() != 0)
      {
        var entry = db.Entry<Sauce>(sauce);

        entry.State = EntityState.Deleted;
      }

      return db.SaveChanges() > 0;
    }

    public bool DeleteSize(Size size)
    {
      if (db.Sizes.Where(s => s == size).Count() != 0)
      {
        var entry = db.Entry<Size>(size);

        entry.State = EntityState.Deleted;
      }

      return db.SaveChanges() > 0;
    }

    public bool DeleteTopping(Topping Topping)
    {
      if (db.Toppings.Where(t => t == Topping).Count() != 0)
      {
        var entry = db.Entry<Topping>(Topping);

        entry.State = EntityState.Deleted;
      }

      return db.SaveChanges() > 0;
    }
    #endregion

  }
}
