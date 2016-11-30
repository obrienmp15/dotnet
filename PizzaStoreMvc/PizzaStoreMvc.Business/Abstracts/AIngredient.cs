using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreMvc.Business.Abstracts
{
  public abstract class AIngredient
  {
    public virtual long IngredientId { get; private set; }
    public virtual string Name { get; set; }
    public virtual decimal Price { get; set; }
    public virtual int Quantity { get; set; }

    public AIngredient()
    {
      IngredientId = DateTime.Now.Ticks;
    }

  }
}
