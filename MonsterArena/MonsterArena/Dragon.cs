using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterArena
{
    class Dragon : Monster
    {
        public Dragon(string name) : base(name)
        {
            AddBonusVitality(50);
            AddBonusLuck (25);
            AddBonusStrength(25);
        }
    }
}
