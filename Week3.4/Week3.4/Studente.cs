using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3._4
{
    class Studente
    {

        public Dictionary<CorsoDiLaurea, int> Ranks = new Dictionary<CorsoDiLaurea, int>();

        public int Nome { set; get; }
        public int Cognome { set; get; }
        public int AnnoDiNascita { set; get; }
        public bool Esami { set; get; }
        public bool RichiestaLaurea { set; get; }
        public Immatricolazione Immatricolazione { get; set; }
 
        public Studente(int n, int c, int nascita, bool esami, bool richiestal, Immatricolazione im)
        {
            Nome = n;
            Cognome = c;
            AnnoDiNascita = nascita;
            Esami = true;
            RichiestaLaurea = false;
            Immatricolazione = im;

        }

    }



 
}
