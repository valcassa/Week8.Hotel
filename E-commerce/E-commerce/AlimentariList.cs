using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce
{
    class AlimentariList : ProdRep<ProdottiAlimentari>
    {

        static List<ProdottiAlimentari> alimentari = new List<ProdottiAlimentari>();
        public List<ProdottiAlimentari> Fetch()
        {
            alimentari.Add(new ProdottiAlimentari(002, 1.02, "Tè Limone", new DateTime(2022,03,02)));
            alimentari.Add(new ProdottiAlimentari(010, 2.99, "Pasta Integrale", new DateTime(2024,12,9)));
            alimentari.Add(new ProdottiAlimentari(103, 3.50, "Bottigliex6 Acqua", new DateTime(2023,8,1)));

            return alimentari;
        }
       
    }
}
