using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banca
{
    class BancaManager
    {
        internal static void AddNewAcc(string iban)
        {
            int num = GenerateAccountNumb();
            BancaConto account = new BancaConto(num, iban);
            BancaConto.Add(account);
            return account;
                }

        private static int GenerateAccountNumb()
        {
            int index = BancaConto.Count;
            int lastNum = 0;
            int newNum;

            if (index > 0)
            {
                lastNum = BancaConto[index - 1].Number;
                newNum = lastNum + 1;

            }
            else 
            {
                newNum = 1;

            }

            return newNum;
        }
        }
        

    }
}
