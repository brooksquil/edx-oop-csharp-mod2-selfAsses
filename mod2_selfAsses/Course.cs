using System;
namespace mod2_selfAsses
{
    public class Course
    {
        public Course(string courseName, Student stud1, Student stud2, Student stud3, Teacher teach)
        {
            CourseName = courseName;
            student1 = stud1;
            student2 = stud2;
            student3 = stud3;
            teacher = teach;

        }

        public string CourseName { get; set; }

        public Student student1;
        public Student student2;
        public Student student3;

        public Teacher teacher;


        public override string ToString()
        {
            return string.Format(CourseName, student1, student2, student3, teacher);
        }

    }

}
