using System.Collections.Generic;
using System;

namespace UniversityRegistrar.Models
{
  public class Student
  {
    public int StudentID { get; set; }
    public string Name { get; set; }
    public DateTime EnrollmentDate { get; set; }
    // public list<CourseTag> JoinEntities { get; }
    // public list<DepartmentTag> JoinEntities { get; }
  }
}