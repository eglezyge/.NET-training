using System.Diagnostics.Metrics;

namespace Officers_Criminals_Game
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("         \x1b[93m---------------------------------------------\u001b[0m");
            Console.WriteLine("         \x1b[93m||\x1B[0m \x1b[96mWelcome to OFFICERS VS. CRIMINALS game!\x1B[0m \x1b[93m||\x1B[0m");
            Console.WriteLine("         \x1b[93m---------------------------------------------\u001b[0m");
            Console.WriteLine();
            Console.WriteLine("\x1b[91m>>>\x1B[0m \x1b[93mBe the first to shoot all 5 of your opponent’s players!\x1B[0m \u001b[91m<<<\u001b[0m");
            Console.WriteLine();

            Console.Write("Officers start first. Who will play as \u001b[96mOfficers\x1B[0m? Type the name: ");
            string player1Name = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Who will play as \u001b[93mCriminals\x1B[0m? Type the name: ");
            string player2Name = Console.ReadLine();
            Console.WriteLine();
            Console.Clear();

            var allPlayers = Person.CreatePlayers();
            var randomPlayers = Person.RandomizePlayers(allPlayers);
            var officers = Person.CreateOfficerTeam(randomPlayers);
            var criminals = Person.CreateCriminalTeam(randomPlayers);

            Console.WriteLine($"{player1Name}, this will be your team of Officers:\n");
            foreach (var item in officers)
            {
                Console.WriteLine("\x1b[96m - " + item.Name + "\x1B[0m");
            }
            Console.WriteLine();

            Console.WriteLine($"{player2Name}, this will be your team of Criminals:\n");
            foreach (var item in criminals)
            {
                Console.WriteLine("\x1b[93m - " + item.Name + "\x1B[0m");
            }
            Console.WriteLine();
            Console.Write("Press ENTER to continue.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"{player1Name}, this is your board:\n");
            string[] officersBoard = PublicBoard.CreatePublicBoard();
            PublicBoard.PrintPublicBoard(officersBoard);
            Console.WriteLine("\n");

            //Player 1 places his players on the board:
            var officersHiddenBoard = HiddenBoard.MakeHiddenBoard(officers);
            Console.Clear();

            Console.WriteLine($"{player2Name}, this is your board:\n");
            string[] criminalsBoard = PublicBoard.CreatePublicBoard();
            PublicBoard.PrintPublicBoard(criminalsBoard);
            Console.WriteLine("\n");

            //Player 2 places his players on the board:
            var criminalsHiddenBoard = HiddenBoard.MakeHiddenBoard(criminals);
            Console.Clear();

            int counterOfficers = 0;
            int counterCriminals = 0;

        TakeShotOfficers:
            Console.Clear();
            Console.WriteLine($"{player1Name}, where do you want to shoot?\n");
            PublicBoard.PrintPublicBoard(criminalsBoard);
            Console.WriteLine();
            Console.Write("\nType a square number: ");

            bool tryAgain = true;
            while(tryAgain)
            {
                try
                {
                    int shotOfficers = int.Parse(Console.ReadLine());
                    if (criminalsHiddenBoard[shotOfficers - 1] == "x")
                    {
                        Console.Clear();
                        Console.WriteLine($"\x1B[31mSorry {player1Name}, you missed!\x1B[0m"); // red text
                        Console.WriteLine();
                        criminalsBoard[shotOfficers - 1] = "\x1B[31m -\x1B[0m"; // red text
                        PublicBoard.PrintPublicBoard(criminalsBoard);
                        Console.WriteLine();
                        Console.Write("\nPress ENTER to continue. ");
                        Console.ReadLine();

                        goto TakeShotCriminals;
                    }

                    else if (criminalsHiddenBoard[shotOfficers - 1] == "y")
                    {
                        Console.Write("You can't shoot here. Try again: ");
                        tryAgain = true;
                        
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine($"{player1Name}, you shot Criminal " + criminalsHiddenBoard[shotOfficers - 1] + "!\n");
                        criminalsHiddenBoard[shotOfficers - 1] = "y";
                        criminalsBoard[shotOfficers - 1] = "\x1B[32m X\x1B[0m"; // green text
                        PublicBoard.PrintPublicBoard(criminalsBoard);
                        counterOfficers++;
                        if (counterOfficers == 5)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"\u001b[91m>>>\u001b[0m \u001b[93mCongratultions {player1Name}, you shot all Criminals! You win!\u001b[0m \u001b[91m<<<\u001b[0m");
                            goto TheEnd;
                        }
                        Console.WriteLine();
                        Console.Write("\nShoot again: ");
                        tryAgain = true;
                        
                    }
                }
                catch
                {
                    Console.Write("There is no such square. Try again: ");
                    tryAgain = true;
                    
                }
            }

        TakeShotCriminals:
            Console.Clear();
            Console.WriteLine($"{player2Name}, where do you want to shoot?\n");
            PublicBoard.PrintPublicBoard(officersBoard);
            Console.WriteLine();
            Console.Write("\nType a square number: ");

            bool tryAgainCrim = true;
            while (tryAgainCrim)
            {
                try
                {
                    int shotCriminals = int.Parse(Console.ReadLine());
                    if (officersHiddenBoard[shotCriminals - 1] == "x")
                    {
                        Console.Clear();
                        Console.WriteLine($"\u001b[31mSorry {player2Name}, you missed!\u001b[0m");
                        Console.WriteLine();
                        officersBoard[shotCriminals - 1] = "\u001b[31m -\u001b[0m";
                        PublicBoard.PrintPublicBoard(officersBoard);
                        Console.WriteLine();
                        Console.Write("\nPress ENTER to continue. ");
                        Console.ReadLine();

                        goto TakeShotOfficers;
                    }

                    else if (officersHiddenBoard[shotCriminals - 1] == "y")
                    {
                        Console.Write("You can't shoot here. Try again:  ");
                        tryAgainCrim = true;

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine($"{player2Name}, you shot Officer " + officersHiddenBoard[shotCriminals - 1] + "!\n");
                        officersHiddenBoard[shotCriminals - 1] = "y";
                        officersBoard[shotCriminals - 1] = "\u001b[32m X\u001b[0m";
                        PublicBoard.PrintPublicBoard(officersBoard);
                        counterCriminals++;
                        if (counterCriminals == 5)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"\u001b[91m>>>\u001b[0m \u001b[93mCongratultions {player2Name}, you shot all Officers! You win!\u001b[0m \u001b[91m<<<\u001b[0m");
                            goto TheEnd;
                        }
                        Console.WriteLine();
                        Console.Write("\nShoot again: ");
                        tryAgainCrim = true;

                    }
                }
                catch
                {
                    Console.Write("There is no such square. Try again: ");
                    tryAgainCrim = true;

                }
            }

        TheEnd:

            Console.WriteLine("\n\u001b[91m>>>\u001b[0m \x1b[96mTHANK YOU FOR THE GAME!\u001b[0m \u001b[91m<<<\u001b[0m");
        }
    }
}