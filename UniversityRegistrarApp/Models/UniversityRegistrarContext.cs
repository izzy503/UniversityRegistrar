using Microsoft.EntityFrameworkCore;


namespace UniversityRegistrar.Models
{
  public class UniversityRegistrar : DbContext
  {
    public DbSet<Student> Students { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Course> Courses { get; set; }
    // public DbSet<Tag> Tags { get; set; }
    // public DbSet<ItemTag> ItemTags { get; set; }

    public UniversityRegistrarContext(DbContextOptions options) : base(options) { }
  }
}
