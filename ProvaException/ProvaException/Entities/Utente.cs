using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaException
{
    public class Utente
    {
        public  string NomeUtente { get; set; }
        public  string Password { get; set; }
        public int? Id { get; set; }

        public Utente(string user, string psw, int? id)
        {
            NomeUtente = user;
            Password = psw;
            Id = id;
        }
    }
}
