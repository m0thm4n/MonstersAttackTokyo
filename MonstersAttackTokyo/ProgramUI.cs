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
            Console.WriteLine(



"MMMMMMMM               MMMMMMMM                                                             tttt                                                                                       AAA                tttt               tttt                                               kkkkkkkk                TTTTTTTTTTTTTTTTTTTTTTT                                    kkkkkkkk\n" +
"M:::::::M             M:::::::M                                                          ttt:::t                                                                                      A:::A            ttt:::t            ttt:::t                                               k::::::k                T:::::::::::::::::::::T                                    k::::::k\n" +
"M::::::::M           M::::::::M                                                          t:::::t                                                                                     A:::::A           t:::::t            t:::::t                                               k::::::k                T:::::::::::::::::::::T                                    k::::::k\n" +
"M:::::::::M         M:::::::::M                                                          t:::::t                                                                                    A:::::::A          t:::::t            t:::::t                                               k::::::k                T:::::TT:::::::TT:::::T                                    k::::::k\n" +
"M::::::::::M       M::::::::::M   ooooooooooo   nnnn  nnnnnnnn        ssssssssss   ttttttt:::::ttttttt        eeeeeeeeeeee    rrrrr   rrrrrrrrr       ssssssssss                   A:::::::::A   ttttttt:::::tttttttttttttt:::::ttttttt      aaaaaaaaaaaaa      cccccccccccccccc k:::::k    kkkkkkk     TTTTTT  T:::::T  TTTTTTooooooooooo yyyyyyy           yyyyyyyk:::::k    kkkkkkk ooooooooooo\n" +
"M:::::::::::M     M:::::::::::M oo:::::::::::oo n:::nn::::::::nn    ss::::::::::s  t:::::::::::::::::t      ee::::::::::::ee  r::::rrr:::::::::r    ss::::::::::s                 A:::::A:::::A  t:::::::::::::::::tt:::::::::::::::::t      a::::::::::::a   cc:::::::::::::::c k:::::k   k:::::k              T:::::T      oo:::::::::::ooy:::::y         y:::::y k:::::k   k:::::koo:::::::::::oo\n" +
"M:::::::M::::M   M::::M:::::::Mo:::::::::::::::on::::::::::::::nn ss:::::::::::::s t:::::::::::::::::t     e::::::eeeee:::::eer:::::::::::::::::r ss:::::::::::::s               A:::::A A:::::A t:::::::::::::::::tt:::::::::::::::::t      aaaaaaaaa:::::a c:::::::::::::::::c k:::::k  k:::::k               T:::::T     o:::::::::::::::oy:::::y       y:::::y  k:::::k  k:::::ko:::::::::::::::o\n" +
"M::::::M M::::M M::::M M::::::Mo:::::ooooo:::::onn:::::::::::::::ns::::::ssss:::::stttttt:::::::tttttt    e::::::e     e:::::err::::::rrrrr::::::rs::::::ssss:::::s             A:::::A   A:::::Atttttt:::::::tttttttttttt:::::::tttttt               a::::ac:::::::cccccc:::::c k:::::k k:::::k                T:::::T     o:::::ooooo:::::o y:::::y     y:::::y   k:::::k k:::::k o:::::ooooo:::::o\n" +
"M::::::M  M::::M::::M  M::::::Mo::::o     o::::o  n:::::nnnn:::::n s:::::s  ssssss       t:::::t          e:::::::eeeee::::::e r:::::r     r:::::r s:::::s  ssssss             A:::::A     A:::::A     t:::::t            t:::::t              aaaaaaa:::::ac::::::c     ccccccc k::::::k:::::k                 T:::::T     o::::o     o::::o  y:::::y   y:::::y    k::::::k:::::k  o::::o     o::::o\n" +
"M::::::M   M:::::::M   M::::::Mo::::o     o::::o  n::::n    n::::n   s::::::s            t:::::t          e:::::::::::::::::e  r:::::r     rrrrrrr   s::::::s                 A:::::AAAAAAAAA:::::A    t:::::t            t:::::t            aa::::::::::::ac:::::c              k:::::::::::k                  T:::::T     o::::o     o::::o   y:::::y y:::::y     k:::::::::::k   o::::o     o::::o\n" +
"M::::::M    M:::::M    M::::::Mo::::o     o::::o  n::::n    n::::n      s::::::s         t:::::t          e::::::eeeeeeeeeee   r:::::r                  s::::::s             A:::::::::::::::::::::A   t:::::t            t:::::t           a::::aaaa::::::ac:::::c              k:::::::::::k                  T:::::T     o::::o     o::::o    y:::::y:::::y      k:::::::::::k   o::::o     o::::o\n" +
"M::::::M     MMMMM     M::::::Mo::::o     o::::o  n::::n    n::::nssssss   s:::::s       t:::::t    tttttte:::::::e            r:::::r            ssssss   s:::::s          A:::::AAAAAAAAAAAAA:::::A  t:::::t    tttttt  t:::::t    tttttta::::a    a:::::ac::::::c     ccccccc k::::::k:::::k                 T:::::T     o::::o     o::::o     y:::::::::y       k::::::k:::::k  o::::o     o::::o\n" +
"M::::::M               M::::::Mo:::::ooooo:::::o  n::::n    n::::ns:::::ssss::::::s      t::::::tttt:::::te::::::::e           r:::::r            s:::::ssss::::::s        A:::::A             A:::::A t::::::tttt:::::t  t::::::tttt:::::ta::::a    a:::::ac:::::::cccccc:::::ck::::::k k:::::k              TT:::::::TT   o:::::ooooo:::::o      y:::::::y       k::::::k k:::::k o:::::ooooo:::::o\n" +
"M::::::M               M::::::Mo:::::::::::::::o  n::::n    n::::ns::::::::::::::s       tt::::::::::::::t e::::::::eeeeeeee   r:::::r            s::::::::::::::s        A:::::A               A:::::Att::::::::::::::t  tt::::::::::::::ta:::::aaaa::::::a c:::::::::::::::::ck::::::k  k:::::k             T:::::::::T   o:::::::::::::::o       y:::::y        k::::::k  k:::::ko:::::::::::::::o\n" +
"M::::::M               M::::::M oo:::::::::::oo   n::::n    n::::n s:::::::::::ss          tt:::::::::::tt  ee:::::::::::::e   r:::::r             s:::::::::::ss        A:::::A                 A:::::A tt:::::::::::tt    tt:::::::::::tt a::::::::::aa:::a cc:::::::::::::::ck::::::k   k:::::k            T:::::::::T    oo:::::::::::oo       y:::::y         k::::::k   k:::::koo:::::::::::oo\n" +
"MMMMMMMM               MMMMMMMM   ooooooooooo     nnnnnn    nnnnnn  sssssssssss              ttttttttttt      eeeeeeeeeeeeee   rrrrrrr              sssssssssss         AAAAAAA                   AAAAAAA  ttttttttttt        ttttttttttt    aaaaaaaaaa  aaaa   cccccccccccccccckkkkkkkk    kkkkkkk           TTTTTTTTTTT      ooooooooooo        y:::::y          kkkkkkkk    kkkkkkk ooooooooooo\n" +
                                                                                                                                                                                                                                                                                                                                                 "y:::::y" +
                                                                                                                                                                                                                                                                                                                                                "y:::::y" +
                                                                                                                                                                                                                                                                                                                                               "y:::::y" +
                                                                                                                                                                                                                                                                                                                                              "y:::::y" +
                                                                                                                                                                                                                                                                                                                                             "yyyyyyy" 



);

            // Have user enter name for game
            Dice dice = new Dice();
            UserInfo userInfo = new UserInfo();
            Tracker tracker = new Tracker();

            tracker.UserHearts = 12;
            List<string> listOfDieFaces = new List<string>();

            // Create a private bool verify hearts aren't <= 10
            bool heartUnderSeven = false;
            bool heartsEqualZero = false;
            bool starsEqualTwenty = false;
         

            Console.WriteLine("Tell me your first name: ");
            userInfo.UserName = Console.ReadLine();

            // While heart not equal 0 and stars not equal 20
            while (!heartsEqualZero && !starsEqualTwenty)
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

                // Add columns for the different die faces
                
                string dieFaceColums = String.Format("{0} {1} {2} {3} {4} {5}", listOfDieFaces[0], listOfDieFaces[1], listOfDieFaces[2], listOfDieFaces[3], listOfDieFaces[4], listOfDieFaces[5]);
                Console.WriteLine(dieFaceColums);

                /*foreach (string die in listOfDieFaces)
                {
                    Console.WriteLine(die);
                }*/

                // If UserHearts <= 10 turn heartUnderTen to True
                /*if (tracker.UserHearts <= 7)
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
                }*/


                if ((tracker.UserHearts >= 12) && !heartUnderSeven)
                {
                    tracker.AddUserHearts(tracker.UserHearts);
                }

                tracker.GameUpdater(listOfDieFaces);

                if (tracker.UserHearts <= 0)
                {
                    heartsEqualZero = true;
                }

                if (tracker.UserStars >= 20)
                {
                    starsEqualTwenty = true;
                }

                if (tracker.UserHearts <= 7)
                {
                    heartUnderSeven = true;
                }

                // Print to Console what the results of the dice roll were with Console.Color (red indicating bad result, green indicating good result of dice roll)
                // Console.WriteLine($"{ bird, -30 } - { score, -10 } - {lives, -8}");
                Console.WriteLine($"{tracker.UserStars} - { tracker.UserHearts}");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
