using System;

namespace MonsterDuel
{
    abstract class Monster
    {
        public string name;
        public Monster target;
        protected int hp = 100;

        protected int bonusDamage;
        int baseDamage = 10;

        public Monster(string firstName)
        {
            name = $"{firstName} the {GetType().Name}";
        }

        public void Attack()
        {
            int totalDamage = baseDamage + bonusDamage;
            Console.WriteLine($"{name} attacks {target.name} for {totalDamage} damage!");
            target.hp -= totalDamage;

            if (target.IsDead())
            {
                target.OnDeath();
            }
        }

        public bool IsDead()
        {
            return hp <= 0;
        }

        protected virtual void OnDeath()
        {
            Console.WriteLine($"{name}: I'm...dead...");
        }
    }
}
