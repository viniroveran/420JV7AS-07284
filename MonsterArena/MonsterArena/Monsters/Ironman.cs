using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterArena
{
    class Ironman : Monster
    {
        public Ironman(string name) : base(name)
        {
            AddBonusVitality(10);
            AddBonusLuck(50);
            AddBonusStrength(20);

        }
    }
}
