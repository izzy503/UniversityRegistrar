using System.Collections.Generic;

namespace UniversityRegistrar.Models
{
  public class Course
  {
    public int CourseId { get; set; }
    public int CourseNumber { get; set; }
    public string Name { get; set; }
    // public list<StudentTag> JoinEntities { get; } 
    // public list<DepartmentTag> JoinEntities { get; }
  }
}
