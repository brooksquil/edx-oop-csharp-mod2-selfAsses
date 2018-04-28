using System;
namespace mod2_selfAsses
{
    public class Student
    {

        public Student(string studentName)
        {
            StudentName = studentName;

            // Every time the constructor runs, increment "instances"
            instances++;
        }
        public string StudentName { get; set; }


        public static int instances = 0;

        public Student()
        {
            // Every time the constructor runs, increment "instances"
            instances++;
        }

        //
        public static int CountStudents()
        {
            return instances;
        }

        public override string ToString()
        {
            return string.Format(StudentName);
        }
    }
}
