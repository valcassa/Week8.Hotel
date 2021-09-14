using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concessionaria
{
    class Cars
    {
        public string Marca { get; set; }
        public string Modello { get; set; }
        public string Alimentazione { get; set; }
        public string NPorte { get; set; }


        public Cars(string brand, string model, string power, string seats)
        {
            Marca = brand;
            Modello = model;
            Alimentazione = power;
            NPorte = seats;
        }
    }

}
