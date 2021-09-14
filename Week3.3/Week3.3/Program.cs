using System;

//Tutte le classi dovranno implementare la propria versione del metodo di calcolo dell’area, il perimetro e di disegno



//Aggiungere un'interfaccia che permetta di salvare e leggere i risultati da un file
//I metodi riceveranno in ingresso il nome del file



//Creare una istanza di ogni classe nel metodo Main e visualizzare il risultato dell’esecuzione dei metodi.

namespace Week3._3
{
    class Program
    {

        static void Main(string[] args)
        {


            static void Start()
            {

                int choice;

                do
                {
                    Console.WriteLine("*** Programma eseguito ***");
                    Console.WriteLine("Funzioni Geometriche");
                    Console.WriteLine("1- Triangolo");
                    Console.WriteLine("2- Rettangolo");
                    Console.WriteLine("3- Cerchio");
                    Console.WriteLine("4- Esci");

                }
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > 4);
                {
                    Console.WriteLine("Inserisci un'opzione valida");
                }

                switch (choice)
                {
                    case 1:
                        public FigureGeometriche.Triangolo();
                        break;
                    case 2:
                        FigureGeometriche.Rettangolo();
                        break;
                    case 3:
                        FigureGeometriche.Cerchio();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Inserisci scelta valida");
                        break;
                    case 0:
                        break;
                }




            }
        }
    }
}