using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce
{
    class ProdottiElettronica
    {

        public int CodiceProdotto { get; set; }
        public double Prezzo { get; set; }
        public string Descrizione { get; set; }
        public string Marca { get; set; }
        public string Modello { get; set; }


        public ProdottiElettronica(int code, double prezzoe, string desce, string marca, string mod)
        {
            CodiceProdotto = code;
            Prezzo = prezzoe;
            Descrizione = desce;
            Marca = marca;
            Modello = mod;

        }
    }
}
