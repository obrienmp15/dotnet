using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDB.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class Department
  {
    public int DepartmentId { get; set; }
    public string DepartmentName { get; set; }
    public bool Active { get; set; }
  }
}
