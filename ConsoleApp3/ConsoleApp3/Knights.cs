using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6.EF
{
    class Knights
    {

        public int Id { get; set; }
        public string Name { get; set; }

        //Relazione 1 a molti con le armi
        public List<Weapon> Weapons { get; set; } = new List<Weapon>();
        public List<Battle> Battles { get; set; }  = new List<Battle>();
    }
}
