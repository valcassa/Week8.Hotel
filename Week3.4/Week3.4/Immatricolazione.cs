using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3._4
{
    class Immatricolazione
    {

        public int Matricola { get; set; }
        public int DataInizio { get; set; }
        public bool FuoriCorso { get; set; }
        public int CFUAccumulati { get; set; }
        public CorsoDiLaurea CorsoDiLaurea {get; set;}


        public Immatricolazione(int m, int data, bool fcorso, int cfu, CorsoDiLaurea corsol)
        {
            Matricola = m;
            DataInizio = data;
            FuoriCorso = fcorso;
            CFUAccumulati = cfu;
            CorsoDiLaurea = corsol;

        }
    }
}

