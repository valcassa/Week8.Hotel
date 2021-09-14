using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6.EF
{

    class Battle
    {
        public int BattleId { get; set; }
        public List<Knights> KnightId { get; set; } = new List<Knights>();
    }
}
