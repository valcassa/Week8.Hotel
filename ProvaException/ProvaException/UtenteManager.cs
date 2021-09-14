using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaException
{
    class UtenteManager
    {
        public static List<Utente> users = new List<Utente>();
        public static List<Utente> Login()
        {

            Console.WriteLine("Inserisci Nome Utente");
            string NomeUtente = Console.ReadLine();

            if (NomeUtente == null) throw new ArgumentNullException("L'utente non esiste");

            Console.WriteLine("Inserisci Password");
            string Password = Console.ReadLine();

            Console.WriteLine("Login Avvenuto con Successo");

            return users;
        }

        private static Utente  AddUser(string username, string password)
        {
            if (username == null) throw new ArgumentNullException("username null");
            if (password == null) throw new ArgumentNullException("password null");

            Utente u = new Utente { NomeUtente = username, Password = password };

            return u;
        }

    }
}
