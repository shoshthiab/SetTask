using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using SatTask.Models;
using SetTask.Models;

namespace SatTask.Controllers
{
	public class StudentController : Controller
	{
		static List<Student> students = new List<Student>
	  {
		  new Student
		{
		studentId =1,
		name = "Ahmad",
		email = "ahmad@htu.edu.jo",
		course = CourseDataSourse.courses[1]

	},
	new Student
	{
		studentId =2,
		name = "Sara",
		email = "sara@htu.edu.jo",
		course = CourseDataSourse.courses[2]

	},
	new Student
	{
		studentId =3,
		name = "Leen",
		email = "leen@htu.edu.jo",
	   course = CourseDataSourse.courses[2]

	}
};
		public IActionResult Index()
		{
			ViewBag.students = students;

			return View();
		}

		public IActionResult Add()
		{
			ViewBag.courses = CourseDataSourse.courses;

			return View();
		}
		public IActionResult Create(string name, string email, int courseId)
		{
			Student newStu = new Student();
			newStu.course = new Course();
			newStu.studentId = students.Count + 1;
			newStu.name = name;
			newStu.email = email;

			newStu.course = CourseDataSourse.courses.SingleOrDefault(x => x.courseID == courseId);

			students.Add(newStu);
			return RedirectToAction("Index");
		}

		//public IActionResult Create(string name, string email,int courseId, List<int> courseIds)
		//{
		//	Student newStu = new Student
		//	{
		//		studentId = students.Count + 1,
		//		name = name,
		//		email = email,
		//		courses = CourseDataSourse.courses
		//					 .Where(c => courseIds.Contains(c.courseID))
		//					 .ToList()
		//	};

		//	students.Add(newStu);
		//	return RedirectToAction("Index");
		//}


		public IActionResult Edit(int stuId)
		{
			Student stu = students.SingleOrDefault(x => x.studentId == stuId);

			return View(stu);

		}

		public IActionResult update(Student newStu)
		{
			var oldStu = students.SingleOrDefault(x => x.studentId == newStu.studentId);

			oldStu.name = newStu.name;
			oldStu.email = newStu.email;
			oldStu.course = CourseDataSourse.courses.SingleOrDefault(x => x.courseID == newStu.course.courseID);


			return RedirectToAction("Index");
		}

	}
}
