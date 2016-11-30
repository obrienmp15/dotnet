using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzaStoreMvc.Client.DomainModels
{
  public class Phone
  {
    [Required(ErrorMessage = "Please enter your phone number")]
    //[Display(Phone = "Phone Number")]
    [DataType(DataType.PhoneNumber)]
    //[StringLength(50)]
    public string Number { get; set; }

  }
}