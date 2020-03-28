using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonstersAttackTokyo
{
    class Item
    {
        readonly Random _random = new Random();
        readonly Tracker tracker = new Tracker();
        public string Weapon { get; set; }

        public string WeaponName { get; set; }
        public List<string> AssignWeapon(List<string> weapons)
        {
            weapons.Add("ShieldBash");
            weapons.Add("Mace");
            weapons.Add("QyburnsScorpion");
            weapons.Add("Catapult");
            weapons.Add("Tim");
            weapons.Add("Mjolnir");

            return weapons;
        }

        public string GetWeapon(List<string> weapons)
        {
            int index = _random.Next(weapons.Count);
            string value = weapons[index];
            weapons.RemoveAt(index);
            WeaponName = value;
            return value;
        }

        public int WeaponDamage(string weapon)
        {
            switch (weapon)
            {
                case "ShieldBash":
                    tracker.WeaponDamage = 4;
                    break;
                case "Mace":
                    tracker.DragonHealth = 4;
                    break;
                case "QyburnsScorpion":
                    tracker.WeaponDamage = 5;
                    break;
                case "Catapult":
                    tracker.DragonHealth = 6;
                    break;
                case "Tim":
                    tracker.DragonHealth = 8;
                    break;
                case "Mjolnir":
                    tracker.WeaponDamage = 8;
                    break;
            }
            return tracker.DragonHealth;
        }

        public Item() { }
    }
}
