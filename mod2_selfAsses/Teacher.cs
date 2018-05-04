using System;
namespace mod2_selfAsses
{
    public class Teacher
    {




        public Teacher(string teacherName)
        {
            this.TeacherName = teacherName;
        }

        public string TeacherName { get; set; }

        public override string ToString()
        {
            return string.Format(TeacherName);
        }


    }
}
