using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce
{
     
    class ProdottiAbbigliamento
    {
        public int CodiceProdotto { get; set; }
        public double Prezzo { get; set; }
        public string Descrizione { get; set; }
        public int Taglia { get; set; }
        public string Brand { get; set; }


        public ProdottiAbbigliamento(int coda, double prezzoa, string desca, int tg, string brand)
        {
            CodiceProdotto = coda;
            Prezzo = prezzoa;
            Descrizione = desca;
            Taglia = tg;
            Brand = brand;

        }
    }
}
