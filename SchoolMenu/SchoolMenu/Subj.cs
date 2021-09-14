using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMenu
{
    class Subj : User
    {
        public SubjEnum Subject { get; set; }

        public List<Student> Student { get; set; } = new List<Student>();

        public Subj() { }

        public Subj(string code, string name, string lastname, string psw, SubjEnum subject, List<Student> student)
       : base(code, name, lastname, psw, false)
        {
            Subject = subject;
            Student = student;
        }
        public enum SubjEnum
        {
            Literature,
            Math,
            French,
            Science,
        }
    }
}
    

 
