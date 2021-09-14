using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SchoolMenu.Subj;

namespace SchoolMenu
{
    class UserManage
    {
        static Student S1 = new Student()
        {
            Name = "Claudio",
            Lastname = "Bruno",
            Code = "St1",
            Password = "123",
            Ranks = new Dictionary<SubjEnum, int>() {
                { SubjEnum.French, 8 },
                { SubjEnum.Science, 7 }
            }
        };
        


        static Student S2 = new Student()
        {
            Name = "Sofia",
            Lastname = "Bianco",
            Code = "St2",
            Password = "123",
            Ranks = new Dictionary<SubjEnum, int>() {
                { SubjEnum.Literature, 8 },
                { SubjEnum.Science, 5}
            }
        
        };

          

        static List<User> users = new List<User>()
        {
                 new Subj{Name = "Giorgio", Lastname = "Rossi", Code = "St1",
                     Password = "123", Subject = SubjEnum.Literature, Student = {S1, S2 } },
                    new Subj{Name = "Sara", Lastname = "Cine", Code = "St2",
                        Password = "123", Subject = SubjEnum.Math },
                      S1,
                      S2
        };


        public static User Exists(string code, string password)
        {
            foreach (var u in users)
            {
                if (u.Code == code && u.Password == password)
                {
                    Console.WriteLine($"Benvenuto {u.Name}");
                    return u;
                }
            }

            return null;
        }
    }

    
}

