using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PizzaStoreData.Client.Models
{
  [DataContract]
  public class OrderDAO
  {
    [DataMember]
    public int OrderId { get; set; }

    [DataMember]
    public CustomerDAO CustomerId { get; set; }

    [DataMember]
    public PizzaDAO PizzaId { get; set; }

    [DataMember]
    public decimal Price { get; set; }
  }
}