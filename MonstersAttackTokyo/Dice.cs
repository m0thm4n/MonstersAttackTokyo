using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MonstersAttackTokyo
{
    public class Dice
    {
        private readonly Random _random = new Random();

        // Six die can roll up to three times
        // Make user select how many die they want to roll

        public Dictionary<int, string> Die1 { get; set; }
        public Dictionary<int, string> Die2 { get; set; }
        public Dictionary<int, string> Die3 { get; set; }
        public Dictionary<int, string> Die4 { get; set; }
        public Dictionary<int, string> Die5 { get; set; }
        public Dictionary<int, string> Die6 { get; set; }

        // Add Method for assigning each die
        public Dictionary<int, string> AssignDie(Dictionary<int,string> die)
        {
            die = new Dictionary<int, string>
            {
                { 1, "claw" },
                { 2, "star" },
                { 3, "arrow" },
                { 4, "item" },
                { 5, "item" },
                { 6, "heart" },
            };

            return die;
        }

        // Add Method to roll the Dice
        public string RollDie(Dictionary<int, string> dice)
        {
            List<string> values = Enumerable.ToList(dice.Values);
            int index = _random.Next(values.Count);
            string value = values[index];
            values.RemoveAt(index);
            return value;
        }

        // This figures out how many dice to roll from 1 to 6
        public List<string> DiceToBeRolled(int diceToBeRolled)
        {
            List<string> rolledDice = new List<string>();
            switch (diceToBeRolled)
            {
                case 1:
                    rolledDice.Add(RollDie(Die1));
                    break;
                case 2:
                    rolledDice.Add(RollDie(Die1));
                    rolledDice.Add(RollDie(Die2));
                    break;
                case 3:
                    rolledDice.Add(RollDie(Die1));
                    rolledDice.Add(RollDie(Die2));
                    rolledDice.Add(RollDie(Die3));
                    break;
                case 4:
                    rolledDice.Add(RollDie(Die1));
                    rolledDice.Add(RollDie(Die2));
                    rolledDice.Add(RollDie(Die3));
                    rolledDice.Add(RollDie(Die4));
                    break;
                case 5:
                    rolledDice.Add(RollDie(Die1));
                    rolledDice.Add(RollDie(Die2));
                    rolledDice.Add(RollDie(Die3));
                    rolledDice.Add(RollDie(Die4));
                    rolledDice.Add(RollDie(Die5));
                    break;
                case 6:
                    rolledDice.Add(RollDie(Die1));
                    rolledDice.Add(RollDie(Die2));
                    rolledDice.Add(RollDie(Die3));
                    rolledDice.Add(RollDie(Die4));
                    rolledDice.Add(RollDie(Die5));
                    rolledDice.Add(RollDie(Die6));
                    break;
                default:
                    Console.WriteLine("You did not select 1, 2, 3, 4, 5, or 6. Please select one of the options");
                    break;
            }
            return rolledDice;
        }

        public Dice()
        {
            

        }
    }
}
