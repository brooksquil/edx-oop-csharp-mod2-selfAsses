using System;
namespace mod2_selfAsses
{
    public class Course
    {
        public Course(string courseName, Student stud1, Student stud2, Student stud3, Teacher teach)
        {
            this.CourseName = courseName;
            this.student1 = stud1;
            this.student2 = stud2;
            this.student3 = stud3;
            this.teacher = teach;

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
