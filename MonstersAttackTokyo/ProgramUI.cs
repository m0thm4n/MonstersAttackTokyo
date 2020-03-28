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
            // Scroll text on top.

            ScreenText screenText = new ScreenText();
            screenText.ScollLabel();


       // Have user enter name for game
            Dice dice = new Dice();
            UserInfo userInfo = new UserInfo();
            Tracker tracker = new Tracker();
            Monster monster = new Monster();
            Dragon dragon = new Dragon();
            Item item = new Item();
            GameOutput gameOutput = new GameOutput();

            tracker.UserHearts = 12;
            List<string> listOfMonsters = new List<string>();
            List<string> listOfDragons = new List<string>();
            List<string> listOfWeapons = new List<string>();

            // Create a private bool verify hearts aren't <= 10
            bool heartUnderSeven = false;
            bool heartsEqualZero = false;
            bool starsEqualTwenty = false;
            bool monsterHealthEqualZero = false;

            Console.WriteLine("Tell me your first name: ");
            userInfo.UserName = Console.ReadLine();

            dragon.AddDragons(listOfDragons);
            dragon.DragonName = dragon.GetDragonName(listOfDragons);
            tracker.DragonHealth = dragon.AssignDragonHealth(dragon.DragonName);


            monster.AddMonsters(listOfMonsters);
            monster.MonsterName = monster.GetMonsterName(listOfMonsters);
            tracker.MonsterHealth = monster.AssignMonsterHealth(monster.MonsterName);

            listOfWeapons = item.AssignWeapon(listOfWeapons);
            string weapon = item.GetWeapon(listOfWeapons);
            item.WeaponDamage(weapon);


            Console.WriteLine($"{userInfo.UserName} attempts to slay {monster.MonsterName} and {dragon.DragonName}!");

            Console.WriteLine();

            // While heart not equal 0 and stars not equal 20
            while (!heartsEqualZero && !starsEqualTwenty && !monsterHealthEqualZero)
            {
                dice.Die1 = dice.AssignDie(dice.Die1);
                dice.Die2 = dice.AssignDie(dice.Die2);
                dice.Die3 = dice.AssignDie(dice.Die3);
                dice.Die4 = dice.AssignDie(dice.Die4);
                dice.Die5 = dice.AssignDie(dice.Die5);
                dice.Die6 = dice.AssignDie(dice.Die6);

                // Get how many rolls of the dice the user wants to roll
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("How many dice do you want to roll? ");
                int diceToBeRolled = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                // Type variable equals
                List<string> listOfDieFaces = dice.DiceToBeRolled(diceToBeRolled);

                // Add columns for the different die faces

                Console.WriteLine();

                if ((tracker.UserHearts != 12) && !heartUnderSeven)
                {
                    tracker.AddUserHearts();
                }

                tracker.GameUpdater(listOfDieFaces);


                gameOutput.GameWriteToConsole(listOfDieFaces, tracker, monster, dragon, item);

                if (tracker.UserHearts <= 0)
                {
                    heartsEqualZero = true;
                }

                if (tracker.UserStars >= 50)
                {
                    starsEqualTwenty = true;
                }

                if (tracker.MonsterHealth <= 0 && tracker.DragonHealth <= 0)
                {
                    monsterHealthEqualZero = true;
                }

                if (tracker.UserHearts <= 7)
                {
                    heartUnderSeven = true;
                }

                Console.ForegroundColor = ConsoleColor.White;

                // Print to Console what the results of the dice roll were with Console.Color (red indicating bad result, green indicating good result of dice roll)
                // Console.WriteLine($"{ bird, -30 } - { score, -10 } - {lives, -8}");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Stars - {tracker.UserStars}");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Hearts - {tracker.UserHearts}");
                Console.ForegroundColor = ConsoleColor.Green;
                if (tracker.MonsterHealth >= 0)
                {
                    Console.WriteLine($"Monsters Health - {tracker.MonsterHealth}");
                }
                else if (tracker.MonsterHealth <= 0)
                {
                    Console.WriteLine($"Dragon Health - {tracker.DragonHealth}");
                }
            }

            if (tracker.UserHearts <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{userInfo.UserName} have died!");
            } else if (tracker.UserStars >= 20)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{userInfo.UserName} got to 20 stars and beat the game!");
            } else if (tracker.MonsterHealth <= 0 && tracker.DragonHealth <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{userInfo.UserName} slayed {monster.MonsterName} and {dragon.DragonName}");
            }
            Console.ReadLine();
        }
    }
}
