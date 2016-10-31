using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Models
{
  public class Items
  {
    public int ItemId { get; set; }
    public string ItemName { get; set; }
    public bool Complete { get; set; }
    public bool Active { get; set; }
  }
}
