using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Officers_Criminals_Game
{
    public class PublicBoard
    {
        //Create public board:
        public static string[] CreatePublicBoard()
        {
            string[] board = new string[16];
            board[0] = " 1";
            board[1] = " 2";
            board[2] = " 3";
            board[3] = " 4";
            board[4] = " 5";
            board[5] = " 6";
            board[6] = " 7";
            board[7] = " 8";
            board[8] = " 9";
            board[9] = "10";
            board[10] = "11";
            board[11] = "12";
            board[12] = "13";
            board[13] = "14";
            board[14] = "15";
            board[15] = "16";
            return board;
        }

        public static void PrintPublicBoard(string[] board)
        {
 
            Console.WriteLine("_________________________");
            Console.WriteLine("|     |     |     |     |");
            Console.WriteLine("| " + board[0] + "  |" + " " + board[1] + "  |" + " " + board[2] + "  |" + " " + board[3] + "  |");
            Console.WriteLine("|_____|_____|_____|_____|");
            Console.WriteLine("|     |     |     |     |");
            Console.WriteLine("| " + board[4] + "  |" + " " + board[5] + "  |" + " " + board[6] + "  |" + " " + board[7] + "  |");
            Console.WriteLine("|_____|_____|_____|_____|");
            Console.WriteLine("|     |     |     |     |");
            Console.WriteLine("| " + board[8] + "  |" + " " + board[9] + "  |" + " " + board[10] + "  |" + " " + board[11] + "  |");
            Console.WriteLine("|_____|_____|_____|_____|");
            Console.WriteLine("|     |     |     |     |");
            Console.WriteLine("| " + board[12] + "  |" + " " + board[13] + "  |" + " " + board[14] + "  |" + " " + board[15] + "  |");
            Console.WriteLine("|_____|_____|_____|_____|");
        }

       
    }
}
