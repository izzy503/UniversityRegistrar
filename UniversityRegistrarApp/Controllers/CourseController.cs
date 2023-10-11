using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using UniversityRegistrar.Models;
using System.Collections.Generic;
using System.Linq;

namespace UniversityRegistrar.Controllers
{
  public class CourseController : Controller
  {
    private readonly ApplicationDbContext _context;

    public CourseController(ApplicationDbContext context)
    {
      _context = context;
    }

    public IActionResult Index()
    {
      var courses = _context.Courses.ToList();
      return View(courses);
    }

  }


}
