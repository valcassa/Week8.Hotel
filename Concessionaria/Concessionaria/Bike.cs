using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concessionaria
{
    class Bike
    {

        public string Marca { get; set; }
        public string Modello { get; set; }
        public string AnnoProduzione { get; set; }


        public Bike(string brand, string model, string year)
        {
            Marca = brand;
            Modello = model;
            AnnoProduzione = year;
        }
    }

}