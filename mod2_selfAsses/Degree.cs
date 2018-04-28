using System;
namespace mod2_selfAsses
{
    public class Degree
    {
        public string DegreeName { get; set; }

        private Course course;

        public Degree(string degreeName, Course compSci)
        {
            DegreeName = degreeName;
            course = compSci;
        }

    }
}
