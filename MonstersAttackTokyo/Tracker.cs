using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonstersAttackTokyo
{
    public class Tracker
    { 
        public bool heartsUnderSeven = false;

        //Keep track of Monster health
        public int MonsterHealth { get; set; }
        // Keep track of hearts
        public int DragonHealth { get; set;}

        public int UserHearts { get; set; }
        // Keep track of stars
        public int UserStars { get; set; }

        public int WeaponDamage { get;  set; }
        
        // Add a Method to remove a heart
        public int RemoveUserHearts()
        {
            return UserHearts--;
        }
        
        // Add a Method to add a heart
        public  int AddUserHearts()
        {
            return UserHearts++;
        }
        
        // Add a Method to remove a star
        public int RemoveUserStars()
        {
            return UserStars--;
        }
        
        // Add a Method to add a star
        public int AddThreeUserStars()
        {
            return UserStars + 3;
        }

        public int AddOneUserStar()
        {
            return UserStars++;
        }

        public int RemoveMonsterHealth()
        {
            return MonsterHealth--;
        }
        public int RemoveDragonHealth()
        {
            return DragonHealth--;
        }
        // Remove Dragon health based on weapon
        public int RemoveDragonHealthWithItem()
        {
            return DragonHealth -= WeaponDamage;
        }

        public void GameUpdater(List<string> listOfDieFaces)
        {
            foreach (string die in listOfDieFaces)
            {
                switch (die)
                {
                    case "claw":
                        // If dice roll equals claw remove heart
                        RemoveUserHearts();
                        break;

                    // If dice roll equals star add one star
                    case "star":
                        AddOneUserStar();
                        break;
                        /*case "arrow":
                            RemoveMonsterHealth();
                            break;*/
                }

                if (die == "item" && MonsterHealth <= 0)
                {
                    RemoveDragonHealth();
                }
                else if (die == "arrow") 
                {
                    RemoveMonsterHealth();
                }
            }
        }

        // Beat the Golden dragon and then you try and slay the monster

        public Tracker()
        {

        }
    }
}
