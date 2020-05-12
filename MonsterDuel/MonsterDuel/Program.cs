using System;

namespace MonsterDuel
{
    class Program
    {
        static void Main(string[] args)
        {
            Battle(new Goblin("Alice"), new Goblin("Bob"));
            Battle(new Goblin("Charlie"), new Orc("David"));
            Battle(new BossGoblin("Edgar"), new Orc("Felix"));
        }

        static void Battle(Monster monster1, Monster monster2)
        {
            Console.WriteLine($"__________{monster1.name} V.S. {monster2.name}__________");
            monster1.target = monster2;
            monster2.target = monster1;

            Monster currentMonster = monster2;

            while (!currentMonster.target.IsDead())
            {
                currentMonster = (currentMonster == monster1) ? monster2 : monster1;
                currentMonster.Attack();
            }

            Console.WriteLine($"{currentMonster.name} is victorious!\n");
        }
    }
}
