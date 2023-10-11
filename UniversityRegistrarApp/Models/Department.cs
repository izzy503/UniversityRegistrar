using System.Collections.Generic;

namespace UniversityRegistrar.Models
{
  public class Department
  {
    public int DepartmentId { get; set; }
    public int DepartmentCode { get; set; }
    public string Name  { get; set; }
    // public List<StudentTag> JoinEntities { get; }
    // public List<CourseTag> JoinEntities { get; }
  }
}