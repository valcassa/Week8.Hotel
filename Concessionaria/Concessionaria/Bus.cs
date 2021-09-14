using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concessionaria
{
    class Bus
    {
        public string Marca { get; set; }
        public string Modello { get; set; }
        public string NPosti { get; set; } 


        public Bus(string brand, string model, string seats)
        {
            Marca = brand;
            Modello = model;
            NPosti = seats;        }
    }

}
