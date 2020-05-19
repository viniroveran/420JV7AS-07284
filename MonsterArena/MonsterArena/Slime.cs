namespace MonsterArena
{
    class Slime : Monster
    {
        public Slime(string name) : base(name)
        {
            AddBonusDexterity(100);
        }
    }
}
