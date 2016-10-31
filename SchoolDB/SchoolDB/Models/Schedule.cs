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
  public class Schedule
  {
    public int ScheduleId { get; set; }
    public int CourseId { get; set; }
    public int ClassDateId { get; set; }    
    public string CourseName { get; set; }
    public bool Active { get; set; }
  }
}
