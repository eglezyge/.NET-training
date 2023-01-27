using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Battleship
{
    class Program
    {
        static String[] p2Board = new String[100];
        static String[] p1Board = new String[100];

        static String[] p2Hit = new String[100];
        static String[] p1Hit = new String[100];

        //p2Board = Where the ships are located, same for p1.
        //p2 hit / p1Hit = where the player is aiming respectively to hit the opposite board.

        static int hitCounterP1 = 0;
        static int hitCounterP2 = 0;


        static Boolean hasWon = false;


        static void initializeVariables()
        {
            for (int i = 0; i < 100; i++)
            {
                p1Board[i] = " ";
                p2Board[i] = " ";
                p1Hit[i] = " ";
                p2Hit[i] = " ";
            }
        }

        static void Main(string[] args)
        {

            initializeVariables();
            introduction();
            askData();
            goodBye();

        }

        static void goodBye()
        {
            Console.Clear();
            Console.WriteLine("Thank you for playing Battleship!");
            Console.WriteLine("The winner is: ");
            if (hitCounterP1 == 26)
                Console.WriteLine("Player 1!");
            else
                Console.WriteLine("Player 2!");
            Console.WriteLine("\nThank you for playing.");
            Console.ReadLine();

        }

        static void inputShipLocation()
        {
            //N
            //W S
            //S

            Console.Clear();
            Console.WriteLine("This is the turn for Player 1! Player 2: LEAVE!");
            Console.ReadLine();
            Console.Clear();
            //if (selection.equals("N"))
            //  p1Board[i] && p1Board[i +- 10]
            Console.WriteLine("Please select the location of your ship (patrol) based on the box #");
            drawBoard("P1");
            int selection = Convert.ToInt32(Console.ReadLine());
            //09 -> 10
            //19 -> 20 ERROR!
            //29 -> 30 ERROR!

            //0 | 1 | 2 | 3
            //  S| S | S | S |
            p1Board[selection] = "S";
            p1Board[selection + 1] = "S";

            //---------
            Console.WriteLine("Please select the location of your ship (Destroyer) based on the box #");
            drawBoard("P1");
            selection = Convert.ToInt32(Console.ReadLine());
            //09 -> 10
            //19 -> 20 ERROR!
            //29 -> 30 ERROR!

            p1Board[selection] = "S";
            p1Board[selection + 1] = "S";
            p1Board[selection + 2] = "S";

            //---------
            Console.WriteLine("Please select the location of your ship (Submarine) based on the box #");
            drawBoard("P1");
            selection = Convert.ToInt32(Console.ReadLine());
            //09 -> 10
            //19 -> 20 ERROR!
            //29 -> 30 ERROR!

            p1Board[selection] = "S";
            p1Board[selection + 1] = "S";
            p1Board[selection + 2] = "S";

            //---------
            Console.WriteLine("Please select the location of your ship (Destroyer) based on the box #");
            drawBoard("P1");
            selection = Convert.ToInt32(Console.ReadLine());
            //09 -> 10
            //19 -> 20 ERROR!
            //29 -> 30 ERROR!

            p1Board[selection] = "S";
            p1Board[selection + 1] = "S";
            p1Board[selection + 2] = "S";
            p1Board[selection + 3] = "S";

            //---------
            Console.WriteLine("Please select the location of your ship (battleship) based on the box #");
            drawBoard("P1");
            selection = Convert.ToInt32(Console.ReadLine());
            //09 -> 10
            //19 -> 20 ERROR!
            //29 -> 30 ERROR!

            p1Board[selection] = "B";
            p1Board[selection + 1] = "B";
            p1Board[selection + 2] = "B";
            p1Board[selection + 3] = "B";

            //---------
            Console.WriteLine("Please select the location of your ship (Carrier) based on the box #");
            drawBoard("P1");
            selection = Convert.ToInt32(Console.ReadLine());
            //09 -> 10
            //19 -> 20 ERROR!
            //29 -> 30 ERROR!

            p1Board[selection] = "S";
            p1Board[selection + 1] = "S";
            p1Board[selection + 2] = "S";
            p1Board[selection + 3] = "S";
            p1Board[selection + 4] = "S";

            //----------------------------

            Console.Clear();
            Console.WriteLine("Player 2! Your turn right now! Press any key to continue.");
            Console.ReadLine();

            Console.WriteLine("Please select the location of your ship (patrol) based on the box #");
            drawBoard("P1");
            selection = Convert.ToInt32(Console.ReadLine());
            //09 -> 10
            //19 -> 20 ERROR!
            //29 -> 30 ERROR!

            p2Board[selection] = "S";
            p2Board[selection + 1] = "S";

            //---------
            Console.WriteLine("Please select the location of your ship (Destroyer) based on the box #");
            drawBoard("P1");
            selection = Convert.ToInt32(Console.ReadLine());
            //09 -> 10
            //19 -> 20 ERROR!
            //29 -> 30 ERROR!

            p2Board[selection] = "S";
            p2Board[selection + 1] = "S";
            p2Board[selection + 2] = "S";

            //---------
            Console.WriteLine("Please select the location of your ship (Submarine) based on the box #");
            drawBoard("P1");
            selection = Convert.ToInt32(Console.ReadLine());
            //09 -> 10
            //19 -> 20 ERROR!
            //29 -> 30 ERROR!

            p2Board[selection] = "S";
            p2Board[selection + 1] = "S";
            p2Board[selection + 2] = "S";

            //---------
            Console.WriteLine("Please select the location of your ship (Destroyer) based on the box #");
            drawBoard("P1");
            selection = Convert.ToInt32(Console.ReadLine());
            //09 -> 10
            //19 -> 20 ERROR!
            //29 -> 30 ERROR!

            p2Board[selection] = "S";
            p2Board[selection + 1] = "S";
            p2Board[selection + 2] = "S";
            p2Board[selection + 3] = "S";

            //---------
            Console.WriteLine("Please select the location of your ship (battleship) based on the box #");
            drawBoard("P1");
            selection = Convert.ToInt32(Console.ReadLine());
            //09 -> 10
            //19 -> 20 ERROR!
            //29 -> 30 ERROR!

            p2Board[selection] = "B";
            p2Board[selection + 1] = "B";
            p2Board[selection + 2] = "B";
            p2Board[selection + 3] = "B";

            //---------
            Console.WriteLine("Please select the location of your ship (Carrier) based on the box #");
            drawBoard("P1");
            selection = Convert.ToInt32(Console.ReadLine());
            //09 -> 10
            //19 -> 20 ERROR!
            //29 -> 30 ERROR!

            p2Board[selection] = "S";
            p2Board[selection + 1] = "S";
            p2Board[selection + 2] = "S";
            p2Board[selection + 3] = "S";
            p2Board[selection + 4] = "S";
            //----------------------------
        }

        static void promptHit()
        {
            Console.Clear();
            Console.WriteLine("Player 1: Please enter your selection based on the previous hit field.");
            drawBoard("P1Hit");
            int selection = Convert.ToInt32(Console.ReadLine());
            if (p2Board[selection] != " ")
            {
                Console.WriteLine("HIT!");
                p1Hit[selection] = "H";
                hitCounterP1++;
                if (hitCounterP1 == 21)
                    hasWon = true;
            }
            else
            {
                Console.WriteLine("MISS!");
                p1Hit[selection] = "M";
            }
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Player 12 Please enter your selection based on the previous hit field.");
            drawBoard("P2Hit");
            selection = Convert.ToInt32(Console.ReadLine());
            if (p1Board[selection] != " ")
            {
                Console.WriteLine("HIT!");
                p2Hit[selection] = "H";
                hitCounterP2++;
                if (hitCounterP2 == 21)
                    hasWon = true;

            }
            else
            {
                Console.WriteLine("MISS!");
                p2Hit[selection] = "M";
            }
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadLine();
        }

        static void askData()
        {
            inputShipLocation();
            while (hasWon)
            {
                promptHit();

            }


        }

        static void drawBoard(String selection)
        {
            if (selection.Equals("P1"))
            {
                for (int x = 0; x < 10; x++)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write(p1Board[i + x] + "|");
                    }
                    Console.WriteLine();
                }
            }
            else if (selection.Equals("P2"))
            {
                for (int x = 0; x < 10; x++)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write(p2Board[i + x] + "|");
                    }
                    Console.WriteLine();
                }
            }
            else if (selection.Equals("P1Hit"))
            {
                for (int x = 0; x < 10; x++)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write(p1Hit[i + x] + "|");
                    }
                    Console.WriteLine();
                }
            }
            else
            {

                for (int x = 0; x < 10; x++)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write(p2Hit[i + x] + "|");
                    }
                    Console.WriteLine();
                }

            }

        }

        static void introduction()
        {
            Console.Title = "Battleship";

            Console.WriteLine("Welcome to Battleship.\n\nPress any key to continue.");
            Console.ReadLine();
        }
    }
}