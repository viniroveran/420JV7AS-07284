using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterArena
{
    class Slimoblin : Monster
    {
        public Slimoblin(string name) : base(name)
        {
            AddBonusVitality(90);
            AddBonusLuck(5);
            AddBonusStrength(20);
        }
    }
}
