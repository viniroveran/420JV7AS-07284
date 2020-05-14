using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterArena
{
    class dragon : Monster
    {
        public dragon(string name) : base(name)
        {
            AddBonusDexterity(55);
            AddBonusLuck(25);
            AddBonusStrength(10);
            AddBonusVitality(10);
        }
    }
}
