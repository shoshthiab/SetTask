using SetTask.Models;

namespace SatTask.Models
{
    public class Student
    {
        public  int  studentId { get; set; }
        public string   name { get; set; }
        public string   email { get; set; }
        public Course   course { get; set; }
        //public List<Course> courses { get; set; }
    }
}
