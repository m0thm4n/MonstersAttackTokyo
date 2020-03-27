using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonstersAttackTokyo
{
    public class Monster
    {
        public string MonsterName { get; set; }

        public List<string> monsters = new List<string>();
        readonly Random _random = new Random();
        Tracker tracker = new Tracker();

        public List<string> AddMonsters(List<string> monsters)
        {
            monsters.Add("Godzilla");
            monsters.Add("Mothra");
            monsters.Add("King Kong");
            monsters.Add("Mike Wazowski");
            monsters.Add("James P. Sullivan");

            return monsters;
        }

        public string GetMonsterName(List<string> monsters)
        {
            int index = _random.Next(monsters.Count);
            string value = monsters[index];
            monsters.RemoveAt(index);
            return value;
        }

        public int AssignMonsterHealth(string monsterName)
        {
            switch (monsterName)
            {
                case "Godzilla":
                    tracker.MonsterHealth = 16;
                    break;
                case "Mothra":
                    tracker.MonsterHealth = 14;
                    break;
                case "King Kong":
                    tracker.MonsterHealth = 15;
                    break;
                case "Mike Wazowski":
                    tracker.MonsterHealth = 8;
                    break;
                case "James P. Sullivan":
                    tracker.MonsterHealth = 12;
                    break;
            }
            return tracker.MonsterHealth;
        }

        // Get item from killing the monster to help with the dragon
        // Shield, sword, mace
        
        public Monster() { }
    }
}
