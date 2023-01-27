using System.Diagnostics.Metrics;

namespace Officers_Criminals_Game
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var allPlayers = Person.CreatePlayers();
            var randomPlayers = Person.RandomizePlayers(allPlayers);
            var officers = Person.CreateOfficerTeam(randomPlayers);
            var criminals = Person.CreateCriminalTeam(randomPlayers);

            Console.WriteLine("Player 1, your team of officers consists of: ");
            foreach (var item in officers)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine();

            Console.WriteLine("Player 2, your team of criminals consists of: ");
            foreach (var item in criminals)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine();

            Console.WriteLine("Player 1, this is your game board: ");
            string[] officersBoard = PublicBoard.CreatePublicBoard();
            PublicBoard.PrintPublicBoard(officersBoard);
            Console.WriteLine("\n");

            //Player 1 places his players on the board:
            var officersHiddenBoard = HiddenBoard.MakeHiddenBoard(officers);
            Console.WriteLine("\n");
            //Print player 1 board with placed players for testing:
            Console.WriteLine("Your hidden board is: ");
            for (int i = 0; i < 16; i++)
            {
                Console.Write(officersHiddenBoard[i] + "  ");
            }
            Console.WriteLine("\n");

            //Clear console.
            Console.WriteLine("Player 2, this is your game board: ");
            string[] criminalsBoard = PublicBoard.CreatePublicBoard();
            PublicBoard.PrintPublicBoard(criminalsBoard);
            Console.WriteLine("\n");

            //Player 2 places his players on the board:
            var criminalsHiddenBoard = HiddenBoard.MakeHiddenBoard(criminals);
            Console.WriteLine("\n");
            //Print player 2 board with placed players for testing:
            Console.WriteLine("Your hidden board is: ");
            for (int i = 0; i < 16; i++)
            {
                Console.Write(criminalsHiddenBoard[i] + "  ");
            }
            Console.WriteLine("\n");
            //Clear console.

            int counterOfficers = 0;
            int counterCriminals = 0;

        TakeShotOfficers:
            //Clear console.
            Console.WriteLine("\nPlayer 1, type a number where do you want to shoot!");
            //Draw criminals public board with shots taken:
            PublicBoard.PrintPublicBoard(criminalsBoard);
            Console.WriteLine("\n");

            int shotOfficers = int.Parse(Console.ReadLine());
           
            if (criminalsHiddenBoard[shotOfficers - 1] == "x")
            {
                Console.WriteLine("Sorry, you missed!");
                //Add "-" for missed shot in the public board:
                criminalsBoard[shotOfficers - 1] = "-"; //PROBLEM: re-writes + into - in public board. Need to make that + cannot be changed into -.
                //Draw public board with shots taken:
                PublicBoard.PrintPublicBoard(criminalsBoard);
 
                goto TakeShotCriminals;
            }
            else
            {
                Console.WriteLine("You shot " + criminalsHiddenBoard[shotOfficers - 1]);
                criminalsHiddenBoard[shotOfficers - 1] = "x";
                //Add "+" for good shot in the public board:
                criminalsBoard[shotOfficers - 1] = "+";
                PublicBoard.PrintPublicBoard(criminalsBoard);
                //Add counter and check if won:
                counterOfficers++;
                if (counterOfficers == 5)
                {
                    Console.WriteLine("\nCongratultions Player 1, you won!");
                    goto TheEnd;
                }

                goto TakeShotOfficers;
            }

        TakeShotCriminals:
            //Clear console.
            Console.WriteLine("\nPlayer 2, type a number where do you want to shoot!");
            //Draw officers public board with shots taken:
            PublicBoard.PrintPublicBoard(officersBoard);

            int shotCriminals = int.Parse(Console.ReadLine());

            if (officersHiddenBoard[shotCriminals - 1] == "x")
            {
                Console.WriteLine("\nSorry, you missed!");
                //Add "-" for missed shot in the public board:
                officersBoard[shotCriminals - 1] = "-"; //PROBLEM: re-writes + into - in public board. Need to make that + cannot be changed into -.
                //Draw public board with shots taken:
                PublicBoard.PrintPublicBoard(officersBoard);

                goto TakeShotOfficers;
            }
            else
            {
                Console.WriteLine("You shot " + officersHiddenBoard[shotCriminals - 1]);
                officersHiddenBoard[shotCriminals - 1] = "x";
                //Add "+" for good shot in the public board:
                officersBoard[shotCriminals - 1] = "+";
                PublicBoard.PrintPublicBoard(officersBoard);
                //Add counter and check if won:
                counterCriminals++;
                if (counterCriminals == 5)
                {
                    Console.WriteLine("\nCongratultions Player 2, you won!");
                    goto TheEnd;
                }

                goto TakeShotCriminals;
            }

        TheEnd:
            Console.WriteLine("\nThank you for the game!");
        }
    }
}