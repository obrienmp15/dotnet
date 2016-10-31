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
  public class Teacher
  {
    public int TeacherId { get; set; }
    public int CourseId { get; set; }
    public int ScheduleId { get; set; }    
    public string FirstName { get; set; }
    public string LasttName { get; set; }
    public bool Active { get; set; }
  }
}
