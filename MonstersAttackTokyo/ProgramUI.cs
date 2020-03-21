using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MonstersAttackTokyo
{
    public class ProgramUI
    {
        public static void Run()
        {
            RunMenu();
            Console.Clear();
        }

        public static void RunMenu()
        {
            // Have user enter name for game
            Dice dice = new Dice();
            UserInfo userInfo = new UserInfo();
            Tracker tracker = new Tracker();

            tracker.UserHearts = 12;
            List<string> listOfDieFaces = new List<string>();

            // Create a private bool verify hearts aren't <= 10
            bool heartUnderSeven = false;
         

            Console.WriteLine("Tell me your first name: ");
            userInfo.UserName = Console.ReadLine();

            // While heart not equal 0 and stars not equal 20
            while (tracker.UserHearts >= 0 || tracker.UserStars < 20)
            {
                dice.Die1 = dice.AssignDie(dice.Die1);
                dice.Die2 = dice.AssignDie(dice.Die2);
                dice.Die3 = dice.AssignDie(dice.Die3);
                dice.Die4 = dice.AssignDie(dice.Die4);
                dice.Die5 = dice.AssignDie(dice.Die5);
                dice.Die6 = dice.AssignDie(dice.Die6);

                // Get how many rolls of the dice the user wants to roll
                Console.WriteLine("How many dice do you want to use for your first roll? ");
                int diceToBeRolled = Convert.ToInt32(Console.ReadLine());

                // Roll the Dice
                
                // Type variable equals
                listOfDieFaces = dice.DiceToBeRolled(diceToBeRolled);
                foreach (string die in listOfDieFaces)
                {
                    Console.WriteLine(die);
                }

                // If UserHearts <= 10 turn heartUnderTen to True
                if (tracker.UserHearts <= 7)
                {
                    heartUnderSeven = true;
                }

                // If dice roll lands heart add heart
                if ((listOfDieFaces.Contains("heart")) && (tracker.UserHearts >= 12) && !heartUnderSeven)
                {
                    tracker.AddUserHearts(tracker.UserHearts);
                }

                // If dice roll equals claw remove heart
                if (listOfDieFaces.Contains("claw"))
                {
                    tracker.RemoveUserHearts(tracker.UserHearts);
                }

                // If dice roll equals 3 add three stars
                if (listOfDieFaces.Contains("3"))
                {
                    tracker.AddThreeUserStars(tracker.UserStars);
                }

                // If dice roll equals star add one star
                if (listOfDieFaces.Contains("star"))
                {
                    tracker.AddOneUserStar(tracker.UserStars);
                }

                // Print to Console what the results of the dice roll were with Console.Color (red indicating bad result, green indicating good result of dice roll)
                // Console.WriteLine($"{ bird, -30 } - { score, -10 } - {lives, -8}");
                Console.WriteLine($"{tracker.UserStars} - { tracker.UserHearts}");

                // Clear the Console
            }
        }
    }
}
