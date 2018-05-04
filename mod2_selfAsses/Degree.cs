using System;
namespace mod2_selfAsses
{
    public class Degree
    {
        public string DegreeName { get; set; }

        public Course course;

        public Degree(string degreeName, Course compSci)
        {
            this.DegreeName = degreeName;
            this.course = compSci;
        }

        public override string ToString()
        {
            return string.Format(DegreeName);
        }

    }
}
