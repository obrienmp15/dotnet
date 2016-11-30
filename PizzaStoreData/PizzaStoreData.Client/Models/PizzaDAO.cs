using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PizzaStoreData.Client.Models
{
  [DataContract]
  public class PizzaDAO
  {
    [DataMember]
    public int PizzaId { get; set; }

    [DataMember]
    public CheeseDAO CheeseId { get; set; }

    [DataMember]
    public SauceDAO SauceId { get; set; }

    [DataMember]
    public SizeDAO SizeId { get; set; }

    [DataMember]
    public ToppingDAO ToppingId { get; set; }

    [DataMember]
    public CrustDAO CrustId { get; set; }

    [DataMember]
    public OrderDAO OrderId { get; set; }
        
    [DataMember]
    public decimal Price { get; set; }
  }
}