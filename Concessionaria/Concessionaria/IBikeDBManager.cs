using System.Collections.Generic;

namespace Concessionaria
{
   interface IBikeDBManager<T>
    {         
        public List<T> Fetch();

        }
    }