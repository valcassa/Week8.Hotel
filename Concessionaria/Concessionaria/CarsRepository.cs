using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concessionaria
{
    class CarsRepository : ICarsDBManager
    {
        static List<Cars> auto = new List<Cars>();

        public void Delete(Cars car)
        {
            throw new NotImplementedException();
        }

        public List<Cars> Fetch()
        {
            throw new NotImplementedException();
        }

        public Cars Get()
        {
            throw new NotImplementedException();
        }

        public void Insert(Cars cars)
        {
            throw new NotImplementedException();
        }

        public void Update(Cars cars)
        {
            throw new NotImplementedException();
        }
    }

    internal interface ICarsDBManager
    {
    }
}

}
