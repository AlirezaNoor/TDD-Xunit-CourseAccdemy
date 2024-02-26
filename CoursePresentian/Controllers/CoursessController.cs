using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CoursePresentian.Models;
using ServicesCourse;

namespace CoursePresentian.Controllers;

public class CoursessController : Controller
{
     private readonly ICourseService _courseService;

     public CoursessController(ICourseService courseService)
     {
          _courseService = courseService;
     }

     public IActionResult test()
     {
         _courseService.GetAll();
         return Ok();
     }
}