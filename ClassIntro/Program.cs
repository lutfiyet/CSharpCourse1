using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Mete";
            int age = 25;

            Course course1 = new Course();
            course1.CourseName = "C#";
            course1.Instructor = "Mete";
            course1.View = 70;

            Course course2 = new Course();
            course2.CourseName = "Java";
            course2.Instructor = "Oguz";
            course2.View = 45;

            Course course3 = new Course();
            course3.CourseName = "C++";
            course3.Instructor = "Mehmet";
            course3.View = 55;

            Course[] courses = new Course[] {course1,course2,course3};

            foreach (Course course in courses)
            {
                Console.WriteLine(course.CourseName+ " : " + course.Instructor);
            }

            //Console.WriteLine(course1.CourseName + " " + course1.Instructor);
        }
    }

    class Course
    {
        public string CourseName { get; set; }
        public string Instructor { get; set; }
        public int View { get; set; }
    }
}
