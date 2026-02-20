using System.Net.NetworkInformation;

namespace consol_studant_class_01
{
    internal class Program
    {
        private static object mathmatics;

        static void Main(string[] args)
        {
            Course course = new Course
            {
                CourseID = 1,
                CourseName = "Mathematics",
                CourseCode = "MATH101",
                CourseCredit = 3
            };
            Course course2 = new Course
            {
                CourseID = 2,
                CourseName = "Physics",
                CourseCode = "PHYS101",
                CourseCredit = 4
            };
            Course course3 = new Course
            {
                CourseID = 3,
                CourseName = "Chemistry",
                CourseCode = "CHEM101",
                CourseCredit = 3
            };
            List<Course> courses = new List<Course> { course, course2, course3 };
            List<Student> students = new List<Student>();

            List<Course> courselist = new List<Course>();
            List<Student> studentlist = new List<Student>();

            Console.WriteLine("course count"+, (Couselist.count()>0?Count()):"0"));
            Console.ReadLine();
            
         

        }
    }
}
