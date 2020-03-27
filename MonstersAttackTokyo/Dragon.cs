using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonstersAttackTokyo
{
    class Dragon
    {
        public string DragonName { get; set; }

        public List<string> dragons = new List<string>();
        readonly Random _random = new Random();
        Tracker tracker = new Tracker();

        public List<string> AddDragons(List<string> dragons)
        {
            dragons.Add("Drogon");
            dragons.Add("Rhaegal");
            dragons.Add("Viserion");
            dragons.Add("Borch");

            return dragons;
        }

        public string GetDragonName(List<string> dragons)
        {
            int index = _random.Next(dragons.Count);
            string value = dragons[index];
            dragons.RemoveAt(index);
            return value;
        }

        public int AssignDragonHealth(string dragonName)
        {
            switch (dragonName)
            {
                case "Drogon":
                    tracker.DragonHealth = 18;
                    break;
                case "Rhaegal":
                    tracker.DragonHealth = 17;
                    break;
                case "Viserion":
                    tracker.DragonHealth = 17;
                    break;
                case "Borch":
                    tracker.DragonHealth = 20;
                    break;
            }
            return tracker.DragonHealth;
        }

        public Dragon() { }
    }
}
