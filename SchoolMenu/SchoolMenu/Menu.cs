using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMenu
{
    class Menu
    {

        internal static void Start()
        {
            Console.WriteLine("Benvenuto, inserisci i tuoi dati:");

            User user;
            string code, password;
            do
            {
                Console.Write("Inserisci il tuo codice univoco: ");
                code = Console.ReadLine();

                Console.Write("Inserisci la tua password: ");
                password = Console.ReadLine();

                user = UserManage.Exists(code, password);

            } while (user == null);


            if (user.IsAdmin == true)
            {
                Console.WriteLine("Benvenuto");
            }
            else
            {
                if (user is Subj)
                {
                    int choice;

                    do
                    {
                        Console.WriteLine("1- Visualizza Lista Studenti");
                        Console.WriteLine("2- Visualizza Voti");
                        Console.WriteLine("0- Esci");

                        while (!(int.TryParse(Console.ReadLine(), out choice)) || choice < 0 || choice > 2)
                        {
                            Console.WriteLine("Inserisci un'opzione valida");
                        }
                        switch (choice)
                        {
                            case 1:
                                break;
                            case 2:
                                break;

                            default:
                                Console.WriteLine("Scelta non valida");
                                break;
                            case 0:
                                return;
                        }
                    }
                    while (choice != 0);
                }
            };
        }

    }
}

