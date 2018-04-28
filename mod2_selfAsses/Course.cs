using System;
namespace mod2_selfAsses
{
    public class Course
    {
        public string CourseName { get; set; }

        private Student student1;
        private Student student2;
        private Student student3;

        private Teacher teacher;

        public Course(string courseName, Student stud1, Student stud2, Student stud3, Teacher teach)
        {
            CourseName = courseName;
            student1 = stud1;
            student2 = stud2;
            student3 = stud3;
            teacher = teach;

        }

    }

}
