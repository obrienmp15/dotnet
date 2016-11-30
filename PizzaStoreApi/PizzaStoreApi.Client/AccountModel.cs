using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PizzaStoreApi.Client
{
  public class AccountModel : DbContext
  {
    public AccountModel() : base("DefaultCollection"){

    }

  }
}