using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3._4
{
    class CorsoDiLaurea
    {
       int Nome {get; set;  }
       int AnniDiCorso { get; set; }
        int CFU { get; set; }     
        bool Esame { get; set; }

        public List<Studente> ListaCorsi { get; set; } = new List<Studente>();


        public CorsoDiLaurea(int nc, int annic, int cfu, bool superato)

        {
            Nome = nc;
            AnniDiCorso = annic;
            CFU = cfu;
            Esame = superato;



        }
     }
}
