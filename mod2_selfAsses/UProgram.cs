using System;
namespace mod2_selfAsses
{
    public class UProgram
    {
        public string UProgramName { get; set; }

        public Degree BS;

        public UProgram(string uprogramName, Degree bs)
        {
            UProgramName = uprogramName;
            BS = bs;
        }

        public override string ToString()
        {
            return string.Format(UProgramName, BS);
        }

    }

}
