using System;

namespace Week3._3
{

    public class Triangolo : FigureGeometriche
    {
        public Triangolo(string nomeFig, double lato1, double lato2, double lato3, double baset, double altezza);
        base: FigureGeometriche {
            NomeFig = nomeFig;
            Lato1 = lato1;
            Lato2 = lato2;
            Lato3 = lato3;
            Base = baset;
            Altezza = altezza;
        }

        public string NomeFig { get; set; }
        public double Lato1 { get; set; }
        public double Lato2 { get; set; }
        public double Lato3 { get; set; }
        public double Base { get; set; }
        public double Altezza { get; set; } 


        public void InserimentoDati() { 


            bool controlp;
            double lato1;
            double lato2;
            double lato3;

            Console.WriteLine("Inserisci il primo lato del Triangolo");
             controlp = double.TryParse(Console.ReadLine(), out lato1);
            if (controlp == true) { Lato1 = lato1; } 

            Console.WriteLine("Inserisci il secondo lato del Triangolo");
            controlp = double.TryParse(Console.ReadLine(), out lato2);
            if (controlp == true) { Lato2 = lato2; }


            Console.WriteLine("Inserisci l'ultimo lato del Triangolo");
            controlp = double.TryParse(Console.ReadLine(), out lato3);
            if (controlp == true) { Lato3 = lato3; }



        }
        public double Perimetro()
        {
            double p;

             p = Lato1 + Lato2 + Lato3;
            return p;        }

        public double Area()
        {
            double a;
            a = Base * Altezza / 2;
            return a;

        }
         
        public string Stampa()
        { 
             
            Console.WriteLine($"Il {NomeFig} ha le seguenti proprietà:/n Base:{Base} /n Altezza: {Altezza} /n Somma dei Lati: {Lato1 + Lato2 + Lato3} /n Perimetro: {Perimetro()} /n Area: {Area()}");
                  return null;

        }
         
    }
} 