using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaException
{
    class Menu
    {
        internal static void Start()
        {
            Console.WriteLine("**** LOGIN ****");

            UtenteManager.Login();
        }
    }
}
