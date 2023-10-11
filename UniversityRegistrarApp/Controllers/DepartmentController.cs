using System.Collections.Generic;
using UniversityRegistrar.Models;

public class Department
{
  public int DepartmentId { get; set; }
    public string DepartmentName { get; set; }

    public ICollection<Student> Students { get; set; }
    public ICollection<Course> Courses { get; set; }

    public Department()
    {
        Students = new List<Student>();
        Courses = new List<Course>(); 
    }
  }

