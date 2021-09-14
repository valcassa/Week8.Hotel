using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3._3
{
    public class Cerchio :FigureGeometriche
    {
        public Cerchio(string nomeFig, double diametro, double raggio)
            
        {
            NomeFig = nomeFig;
            Diametro = diametro;
            Raggio = raggio;
        }


        public string NomeFig { get; set; }
        public double Diametro { get; set; }
        public double Raggio { get; set; }
         
        public void InserimentoDati()
        {


            bool controlp;
            double diametro;
            double raggio;

            Console.WriteLine($"Inserisci il Diametro del {NomeFig}");
            controlp = double.TryParse(Console.ReadLine(), out diametro);
            if (controlp == true) { Diametro = diametro; }

            Console.WriteLine($"Inserisci il Raggio del {NomeFig}");
            controlp = double.TryParse(Console.ReadLine(), out raggio);
            if (controlp == true) { Raggio = raggio; }


        }
        public double Perimetro()
        {
            double p;
 
            p = 2 * Math.PI * Raggio;
            return p;
        }

        public double Area()
        {
            double a;
 
            a = Raggio *2  * Math.PI;
            return a;

        }
        public string Stampa()
        {
            Console.WriteLine($"Il {NomeFig} ha le seguenti proprietà:/n Raggio:{Raggio} /n Diametro: {Diametro} /n Perimetro: {Perimetro()} /n Area: {Area()}");
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
