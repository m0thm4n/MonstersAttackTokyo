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
        public int UserHearts { get; set; }
        // Keep track of stars
        public int UserStars { get; set; }
        
        // Add a Method to remove a heart
        public int RemoveUserHearts(int userHearts)
        {
            return UserHearts--;
        }
        
        // Add a Method to add a heart
        public  int AddUserHearts(int userHearts)
        {
            return UserHearts++;
        }
        
        // Add a Method to remove a star
        public int RemoveUserStars(int userStars)
        {
            return UserStars--;
        }
        
        // Add a Method to add a star
        public int AddThreeUserStars(int userStars)
        {
            return UserStars + 3;
        }

        public int AddOneUserStar(int userStars)
        {
            return UserStars++;
        }

        public int RemoveMonsterHealth(int monsterHealth)
        {
            return MonsterHealth--;
        }

        public void GameUpdater(List<string> listOfDieFaces)
        {
            foreach (string die in listOfDieFaces)
            {
                switch (die)
                {
                    case "claw":
                        // If dice roll equals claw remove heart
                        RemoveUserHearts(UserHearts);
                        break;

                    // If dice roll equals 3 add three stars
                    case "3":
                        AddThreeUserStars(UserStars);
                        break;

                    // If dice roll equals star add one star
                    case "star":
                        AddOneUserStar(UserStars);
                        break;
                    case "arrow":
                        RemoveUserStars(UserStars);
                        RemoveMonsterHealth(MonsterHealth);
                        break;
                }
            }
        }

        // Add three dragons
        // Golden dragon

        public Tracker()
        {

        }
    }
}
