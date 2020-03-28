using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonstersAttackTokyo
{
    class GameOutput
    {
        public void GameWriteToConsole(List<string> listOfDieFaces, Tracker tracker, Monster monster, Dragon dragon, Item item)
        {
            // TODO: Move code into function
            foreach (string die in listOfDieFaces)
            {
                switch (die)
                {
                    case "claw":
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case "heart":
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case "arrow":
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        break;
                    case "item":
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    case "star":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }

                // If (claw, heart, excalibur, or star) print correct response
                if (die == "claw")
                {
                    Console.WriteLine($"{die} - You lost a heart! you are now at {tracker.UserHearts}");
                }
                else if (die == "heart" && tracker.UserHearts >= 12)
                {
                    Console.WriteLine($"{die} - You gained a heart! you are now at {tracker.UserHearts}");
                }
                else if (die == "star")
                {
                    Console.WriteLine($"{die} - You gained a star! you are now at {tracker.UserStars}");
                }
                if (die == "arrow" && tracker.MonsterHealth >= 0)
                {
                    Console.WriteLine($"{die} - You injured {monster.MonsterName}! {monster.MonsterName} is at {tracker.MonsterHealth}");
                }
                else if (die == "item" && tracker.MonsterHealth <= 0)
                {
                    Console.WriteLine($"{item.WeaponName} - You injured {dragon.DragonName}! {dragon.DragonName} is at {tracker.DragonHealth}");
                }
            }
        }
    }
}
