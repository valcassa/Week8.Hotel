using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3._3
{
    public class Rettangolo : FigureGeometriche
    {
        public Rettangolo(string nomeFig, double baser, double altezza)
        {
            NomeFig = nomeFig;
            Base = baser;
            Altezza = altezza;
        }

        public string NomeFig { get; set; } 
        public double Base { get; set; }
        public double Altezza { get; set; }
         

        public void InserimentoDati()
        {


            bool controlp;
            double altezza;
            double baser; 

            Console.WriteLine($"Inserisci la Base del {NomeFig}");
            controlp = double.TryParse(Console.ReadLine(), out baser);
            if (controlp == true) { Base = baser; }

            Console.WriteLine($"Inserisci l'Altezza del {NomeFig}");
            controlp = double.TryParse(Console.ReadLine(), out altezza);
            if (controlp == true) { Base = altezza; }


        }
        public double Perimetro()
        {
            double p;

            p = Base *2 + Altezza*2;
            return p;
        }

        public double Area()
        {
            double a;
            a = Base * Altezza;
            return a;

        }

        public string Stampa()
        {
            Console.WriteLine($"Il {NomeFig} ha le seguenti proprietà:/n Base:{Base} /n Altezza: {Altezza} /n Perimetro: {Perimetro()} /n Area: {Area()}");
                  return null;

        }

        public override double Rettangolo()
        {
            throw new NotImplementedException();
        }

        public override double Cerchio()
        {
            throw new NotImplementedException();
        }

        public override string Stampa()
        {
            throw new NotImplementedException();
        }
    }
}
