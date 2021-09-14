using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce
{
    class ElettronicaList : ProdRep<ProdottiElettronica>
    {

        static List<ProdottiElettronica> elettronica = new List<ProdottiElettronica>();
        public List<ProdottiElettronica> Fetch()
        {
            elettronica.Add(new ProdottiElettronica(20001, 540.00, "Mobile Phone", "Iphone", "SE"));
            elettronica.Add(new ProdottiElettronica(12001, 240.00, "Aspirapolvere", "Bosch", "Modello Leggero"));
            elettronica.Add(new ProdottiElettronica(4000, 40.00, "Macchina Fotografica", "Fujifilm", "Instax Pro"));

            return elettronica;

        }
    }
}
