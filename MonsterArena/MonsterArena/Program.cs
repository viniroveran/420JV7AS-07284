using System;
using System.Collections.Generic;

namespace MonsterArena
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Monster> monsters = new List<Monster>()
            {
                new LuckyUnicorn("Lady"),
                new Dragon("Xiangfeng"),
                new FirstDragon("sixiang"),
                new Slime("Felix"),
                new Ironman("Chenyi"),
                new Slimoblin("Jack")
            };

            foreach (var monster in monsters)
            {
                monster.Spawn();
            }

            ArenaMaster.GetInstance().SetMonsterList(monsters);

            while (!IsBattleOver(monsters))
            {
                monsters.Sort();
                foreach (var activeMonster in monsters)
                {
                    if (activeMonster.IsDead())
                        continue;

                    int attackIndex = activeMonster.GetAttackIndex();
                    if (attackIndex < 0 || attackIndex >= monsters.Count)
                        continue;

                    activeMonster.Attack(monsters[attackIndex]);
                }
            }

            Monster winner = monsters.Find(m => !m.IsDead());
            if (winner != null)
            {
                Console.WriteLine($"The winner is {winner}!");
            }
            else
            {
                Console.WriteLine("All combatants have perished...");
            }
        }

        static bool IsBattleOver(List<Monster> monsters)
        {
            return monsters.FindAll(m => !m.IsDead()).Count <= 1;
        }
    }
}
