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
            AddBonusDexterity(0);
            AddBonusLuck(0);
            AddBonusStrength(0);
            AddBonusVitality(100);
        }

        public override int GetAttackIndex()
        {
            //int index = ArenaMaster.GetInstance().GetMonsterList().FindIndex
            //    ( m => m.name != "Jack" && m.hp == MinHp());
            int index = AutoAim();
            if (index >= 0)
            {
                return index;
            }
            else
            {
                return base.GetAttackIndex();
            }
        }

        //public int MinHp()
        //{
        //    int[] input = new int[ArenaMaster.GetInstance().GetMonsterList().Count];
        //    for (int i = 0; i < ArenaMaster.GetInstance().GetMonsterList().Count; i++)
        //    {
        //        input[i] = ArenaMaster.GetInstance().GetMonsterList()[i].hp;
        //    }
        //    int minNum = input[0];
        //    foreach (int item in input)
        //    {
        //        if (minNum <= 0)
        //        {
        //            minNum = item;
        //        }
        //        else if (item < minNum && item > 0)
        //        {
        //            minNum = item;
        //        }
        //    }
        //    Console.WriteLine($"=={minNum}==");
        //    return minNum;
        //}

        public int AutoAim()
        {
            int selfNum = ArenaMaster.GetInstance().GetMonsterList().FindIndex(m => m.name == "Jack");

            int[] input = new int[ArenaMaster.GetInstance().GetMonsterList().Count];
            for (int i = 0; i < ArenaMaster.GetInstance().GetMonsterList().Count; i++)
            {
                input[i] = ArenaMaster.GetInstance().GetMonsterList()[i].hp;
            }

            int k = 0;
            int minHpNum = input[0];
            for (int i = 0; i < ArenaMaster.GetInstance().GetMonsterList().Count; i++)
            {
                if (i != selfNum)
                {
                    if (minHpNum <= 0)
                    {
                        minHpNum = input[i];
                        k = i;
                    }
                    if (input[i] < minHpNum && input[i] > 0)
                    {
                        minHpNum = input[i];
                        k = i;
                    }
                }
            }
            //Console.WriteLine($"=={minHpNum}==");

            return k;
        }

    }
}
