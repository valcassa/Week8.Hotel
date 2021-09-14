using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce
{
    class ProdottiAlimentari
    {
        public int CodiceProdotto { get; set; }
        public double Prezzo { get; set; }
        public string Descrizione { get; set; }
        public DateTime DataDiScadenza { get; set; }


        public ProdottiAlimentari(int codp, double prezzo, string desc, DateTime scad)
        {
            CodiceProdotto = codp;
            Prezzo = prezzo;
            Descrizione = desc;
            DataDiScadenza = scad;


        }

    }
}
