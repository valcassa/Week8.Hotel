using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMenu
{
    public class User
    {

        internal string Code { set; get; }
        internal string Name { set; get; }
        internal string Lastname { set; get; }
        internal string Password { set; get; }
        internal bool IsAdmin { set; get; }



        public User(string code, string name, string lastname, string psw, bool isadmin)
        {
            Code = code;
            Name = name;
            Lastname = lastname;
            Password = psw;
            IsAdmin = isadmin;

        }
        public User() { }


    };

}

