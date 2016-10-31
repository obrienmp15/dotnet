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
  public class Course
  {
    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public int TeacherId { get; set; }
    public int Capacity { get; set; }
    public int Credit { get; set; }
    public int EnrollmentId { get; set; }
    public int DepartmentId { get; set; }
    public int ScheduleId { get; set; }
    public bool Active { get; set; }
  }
}
