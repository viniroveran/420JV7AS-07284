namespace MonsterArena
{
    class LuckyUnicorn : Monster
    {
        public LuckyUnicorn(string name) : base(name)
        {
            AddBonusStrength(25);
            AddBonusLuck(75);
        }
        public override int GetAttackIndex()
        {
            int index = ArenaMaster.GetInstance().GetMonsterList().FindIndex(m => m.type == "Orc");
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
