using System;

namespace mod2_selfAsses
{
    class Program
    {
        static void Main(string[] args)
        {

            Student stud1 = new Student("Barbie");
            Student stud2 = new Student("GI Jane");
            Student stud3 = new Student("Rainbow Bright");

            Teacher teach = new Teacher("Professor Quack");

            Course compSci = new Course("Intro to Computer Science", stud1, stud2, stud3, teach);

            Degree bs = new Degree("Bachelor of Science", compSci);

            UProgram infoSci = new UProgram("Information Science", bs);

            int studentCount = Student.CountStudents();

            Console.WriteLine($"The university has a wonderful {infoSci.UProgramName} program, which offers a {bs.DegreeName}. Visit our {compSci.CourseName} lecture and speak with {teach.TeacherName}; I'm sure she wouldn't mind if you speak to our top {studentCount} students, {stud1.StudentName}, {stud2.StudentName}, {stud3.StudentName}. They all love the University.");
        }
    }
}
