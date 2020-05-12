using System.Collections.Generic;
using System.Linq;

namespace MonsterArena
{
    class ArenaMaster
    {
        private static ArenaMaster instance;
        private static List<Monster> monsters = new List<Monster>();

        private ArenaMaster() { }

        public static ArenaMaster GetInstance()
        {
            if (instance == null)
            {
                instance = new ArenaMaster();
            }

            return instance;
        }

        public void SetMonsterList(List<Monster> monsters)
        {
            ArenaMaster.monsters = monsters;
        }

        public List<MonsterData> GetMonsterList()
        {
            return new List<MonsterData>(monsters.Select(m => m.GetData()));
        }
    }
}
