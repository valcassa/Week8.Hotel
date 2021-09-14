using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaException
{
    class UtenteListRepository : IUtenteRepository 
    {
        public static List<Utente> users = new List<Utente>
        {
             new Utente("MarioWhite56", "123456", null),
             new Utente("Carlotta", "920101", null),
             new Utente("Gaetano87", "123456", null),
         };

    }
}
