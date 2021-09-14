using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMenu
{
    class Student : User
    {
        public Dictionary<Subj.SubjEnum, int> Ranks = new Dictionary<Subj.SubjEnum, int>();
         
        public Student() { }

        public Student(string code, string name, string lastname, string psw, Dictionary<Subj.SubjEnum, int> ranks)
         : base(code, name, lastname, psw, false)
        {
            Ranks = ranks;

        }

    }
}
     
