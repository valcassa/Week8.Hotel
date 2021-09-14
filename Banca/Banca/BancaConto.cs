using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banca
{
    class BancaConto
    {
        public int iban { get; set; }
        public string user { get; }
        public decimal saldo { private set; get; }

        public BancaConto(int iban, string user)
        {
            iban = IBAN;
            user = User;

        }

 }
    }
}
