using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Officers_Criminals_Game
{
    public class Person
    {
        public string Name { get; set; }
        //public List<Person> officerTeam;
        //public List<Person> criminalTeam;
        public Person(string name)
        {
            this.Name = name;
        }

        public static List<Person> CreatePlayers()
        {
            List<Person> list = new List<Person>();
            list.Add(new Person("Charlie"));
            list.Add(new Person("Donnie"));
            list.Add(new Person("Cracker"));
            list.Add(new Person("Whak"));
            list.Add(new Person("Jimmy"));
            list.Add(new Person("Old Bastard"));
            list.Add(new Person("Lilly"));
            list.Add(new Person("Angel"));
            list.Add(new Person("Easy Bob"));
            list.Add(new Person("Jango"));
            return list;
        }

        public static List<Person> RandomizePlayers(List<Person> name)
        {
            List<Person> randomPlayers = new List<Person>();
            var rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int j = rnd.Next(name.Count);
                randomPlayers.Add(name[j]);
                name.Remove(name[j]);
            }
            return randomPlayers;
        }

        public static List<Person> CreateOfficerTeam(List<Person> name)
        {
            List<Person> criminalTeam = new List<Person>();
            for (int i = 0; i < 5; i++)
            {
                criminalTeam.Add(name[i]);
            }
            return criminalTeam;
        }

        public static List<Person> CreateCriminalTeam(List<Person> name)
        {
            List<Person> criminalTeam = new List<Person>();
            for (int i = 5; i < 10; i++)
            {
                criminalTeam.Add(name[i]);
            }
            return criminalTeam;
        }

        public static void PrintBoard()
        {
            int[] board = new int[16];
            board[0] = 1;
            board[1] = 2;
            board[2] = 3;
            board[3] = 4;
            board[4] = 5;
            board[5] = 6;
            board[6] = 7;
            board[7] = 8;
            board[8] = 9;
            board[9] = 10;
            board[10] = 11;
            board[11] = 12;
            board[12] = 13;
            board[13] = 14;
            board[14] = 15;
            board[15] = 16;

            for (int i = 0; i < 16; i++)
            {
                Console.Write(board[i] + "  ");
                if (i == 3 || i == 7 || i == 11)
                {
                    Console.WriteLine();
                }
            }
        }

    }
}
