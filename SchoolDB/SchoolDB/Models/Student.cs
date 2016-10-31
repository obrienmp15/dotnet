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
  public class Student
  {
    public int StudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int MajorId { get; set; }
    public int ScheduleId { get; set; }    
    public bool Active { get; set; }
  }
}
