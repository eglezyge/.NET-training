using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Officers_Criminals_Game
{
    public class HiddenBoard
    {
        public static string[] MakeHiddenBoard(List<Person> team)
        {
            string[] HiddenBoard = new string[16];
            for (int i = 0; i < 16; i++)
            {
                HiddenBoard[i] = "x";
            }
            foreach (var item in team)
            {
            PlacePlayer:
                try
                {
                    Console.WriteLine("Type a number where do you want to place " + item.Name + " ?");
                    int square = int.Parse(Console.ReadLine());
                    if (HiddenBoard[square - 1] == "x")
                    {
                        HiddenBoard[square - 1] = item.Name;
                    }
                    else
                    {
                        Console.WriteLine("This square is taken. Try again.");
                        goto PlacePlayer;
                    }
                }
                catch
                {
                    Console.WriteLine("There is no such square. Try again.");
                    goto PlacePlayer;
                }
            }
            return HiddenBoard;
        }
 
    }
}
