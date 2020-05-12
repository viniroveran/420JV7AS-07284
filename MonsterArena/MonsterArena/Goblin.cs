using System.Collections.Generic;

namespace MonsterArena
{
    class Goblin : Monster
    {
        public Goblin(string name) : base(name)
        {
            AddBonusDexterity(25);
            AddBonusLuck(25);
            AddBonusStrength(25);
            AddBonusVitality(25);
        }

        public override int GetAttackIndex()
        {
            int index = ArenaMaster.GetInstance().GetMonsterList().FindIndex(m => m.level > 1);
            if (index >= 0)
            {
                return index;
            }
            else
            {
                return base.GetAttackIndex();
            }
        }
    }
}
