using Microsoft.EntityFrameworkCore;
using UniversityRegistrar.Models;
public class ApplicationDbContext : DbContext
{
  public DbSet<Student> Students { get; set; }
  public DbSet<Course> Courses { get; set; }
  public DbSet<Department> Departments { get; set; }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {

    //Remember this as a example of many-to-many Relationships
    modelBuilder.Entity<Students>()
        .HasMany(student => student.Courses)
        .WithMany(course => course.Students)
        .UsingEntity<StudentCourse>(j => j.ToTable("StudentCourse")
        .HasKey(sc => new { sc.StudentID, sc.CourseID })
        );
  }
}