using System;

namespace MonsterDuel
{
    class BossGoblin : Goblin
    {
        public BossGoblin(string firstName) : base(firstName)
        {
            bonusDamage = 20;
        }

        protected override void OnDeath()
        {
            base.OnDeath();
            Console.WriteLine($"{name}: There will be... another boss...");
        }
    }
}
