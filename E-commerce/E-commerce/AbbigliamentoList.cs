using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce
{
    class AbbigliamentoList : ProdRep<ProdottiAbbigliamento>
    {

        static List<ProdottiAbbigliamento> abbigliamento = new List<ProdottiAbbigliamento>();
        public List<ProdottiAbbigliamento> Fetch()
        {
            abbigliamento.Add(new ProdottiAbbigliamento(6060, 12.99, "T-shirt donna", 42, "H&M"));
            abbigliamento.Add(new ProdottiAbbigliamento(50055, 40.00, "Pantalone elegante", 38, "Zara"));
            abbigliamento.Add(new ProdottiAbbigliamento(9979, 340.00, "Abito da Sera", 44, "Chanel"));

            return abbigliamento;

        }
    }
}
