using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concessionaria
{
    class ListCars:ICarsDBManager<Cars>

    {
        static List<Cars> cars = new List<Cars>();

        public List<Cars> Fetch()
        {

            cars.Add(new Cars("Toyota", "ModelloA", "Diesel", "5"));
            cars.Add(new Cars("Lancia", "ModelloY", "Benzina", "3"));
            cars.Add(new Cars("Fiat", "ModelloP", "Elettrica", "5"));


            return cars;

        }


    }
}
