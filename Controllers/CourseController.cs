using Microsoft.AspNetCore.Mvc;
using SetTask.Models;

namespace SatTask.Controllers
{
	public class CourseController : Controller
	{

		static public List<Course> courses = new List<Course>
		{
			new  Course
			{
				courseID=1,
				name= "math",
				description = "goes here",
				instructor="zaid"
			},
			new  Course
			{
				courseID=2,
				name= "c++",
				description = "goes here",
				instructor="ahmad"
			},
			new  Course
			{
				courseID=3,
				name= "java",
				description = "goes here",
				instructor="khaled"
			}
		};



		public IActionResult Index()
		{
			var course = CourseDataSourse.courses;

			ViewBag.courses = courses;
			return View();
		}
		public IActionResult Add()
		{
			return View();
		}
		public IActionResult Create(Course newCourse)
		{
			newCourse.courseID = CourseDataSourse.courses.Count + 1;
			CourseDataSourse.courses.Add(newCourse);
			return RedirectToAction("Index");
		}
	}
}
