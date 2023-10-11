using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using UniversityRegistrar.Models;
using System.Collections.Generic;
using System.Linq;

namespace UniversityRegistrar.Controllers
{
  public class StudentController : Controller
  {
    private readonly UniversityRegistrarContext _db;
    public StudentController(UniversityRegistrarContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Student> model = _db.Student.ToList();
      return View(model);
    }

    public ActionResult create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(StudentController student)
    {
      _db.Student.Add(student);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Student thisStudent = _db.Student
        .Include( stud => stud.Courses)
        .ThenInclude( stud => StudentController.JoinEntities)
        .ThenInclude( join => join.Tag)
        .FirstOrDefault( course => course.CourseID == id);
      return View(thisStudent);
    }



  }
}