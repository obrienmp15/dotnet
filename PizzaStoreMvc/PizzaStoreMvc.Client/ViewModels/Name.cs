using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzaStoreMvc.Client.ViewModels
{
  public class Name
  {
    [Required(ErrorMessage ="it is required")]
    [Display(Name = "First Name")]
    [DataType(DataType.Text, ErrorMessage = "it is text")]
    public string First { get; set; }

    [Required(ErrorMessage = "it is required")]
    [Display(Name = "Last Name")]
    [DataType(DataType.Text, ErrorMessage = "it is text")]
    public string Last { get; set; }

  }
}