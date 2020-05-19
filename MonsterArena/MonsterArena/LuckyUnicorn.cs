using System;
using System.Linq;

namespace MonsterArena
{
    class LuckyUnicorn : Monster
    {
        public LuckyUnicorn(string name) : base(name)
        {
            // AddBonusDexterity(100); // Dexterity doesn't affect combat. Bug?
            // AddBonusLuck(75);
            AddBonusStrength(25);
            AddBonusVitality(75);
        }
        public override int GetAttackIndex()
        {
            // Fetches monster list
            var monsterList = ArenaMaster.GetInstance().GetMonsterList();
            // Initializes lowestHp with a high value
            var lowestHp = 999;
            
            // Strategy: avoid suicide and always target low health enemies. (Win rate: +-80%)
            // Attack lowest HP monster to farm some levels
            foreach (var t in monsterList.Where(t => lowestHp > t.hp && t.hp > 0 && t.type != "LuckyUnicorn"))
            {
                lowestHp = t.hp;
                // Console.WriteLine("Weakest enemy: " + lowestHp);
            }

            return monsterList.FindIndex(data => data.hp == lowestHp);
        }
    }
}
