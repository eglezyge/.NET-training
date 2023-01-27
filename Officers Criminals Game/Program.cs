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
            Console.WriteLine("Player1, this is your game board: ");
            Person.PrintBoard();
            Console.WriteLine();

            var officersHiddenBoard = HiddenBoard.MakeHiddenBoard(officers);
            //Print board with placed players (for testing).
            for (int i = 0; i < 16; i++)
            {
                Console.Write(officersHiddenBoard[i] + "  ");

            }
            Console.WriteLine();

            var criminalsHiddenBoard = HiddenBoard.MakeHiddenBoard(criminals);
            //Print board with placed players (for testing).
            for (int i = 0; i < 16; i++)
            {
                Console.Write(criminalsHiddenBoard[i] + "  ");

            }
            Console.WriteLine();

        //Create public boards for both players (create public board method).

        TakeShotOfficers:
            //Clear console.
            Console.WriteLine("Shoot!");
            //Draw public board with shots taken by passing public board variable (print public board method).
            int shotOfficers = int.Parse(Console.ReadLine());
            if (criminalsHiddenBoard[shotOfficers - 1] == "x")
            {
                Console.WriteLine("Sorry, you missed!");
                //Add "-" for missed shot in the public board (modify public board method)
                //Draw public board with shots taken by passing public board variable (print public board method).
                goto TakeShotCriminals;
            }
            else
            {
                Console.WriteLine("You shot " + criminalsHiddenBoard[shotOfficers - 1]);
                //Add "+" for good shot in the public board (modify public board method)
                //Add counter and check if won.
                //Draw public board with shots taken by passing public board variable (print public board method).
                goto TakeShotOfficers;
            }

        TakeShotCriminals:
            //Clear console.
            Console.WriteLine("Shoot!");
            //Draw public board with shots taken by passing public board variable (print public board method).
            int shotCriminals = int.Parse(Console.ReadLine());
            if (officersHiddenBoard[shotCriminals - 1] == "x")
            {
                Console.WriteLine("Sorry, you missed!");
                //Add "-" for missed shot in the public board (modify public board method)
                //Draw public board with shots taken by passing public board variable (print public board method).
                goto TakeShotOfficers;
            }
            else
            {
                Console.WriteLine("You shot " + officersHiddenBoard[shotCriminals - 1]);
                //Add "+" for good shot in the public board (modify public board method)
                //Add counter and check if won.
                //Draw public board with shots taken by passing public board variable (print public board method).
                goto TakeShotCriminals;
            }
        }
    }
}