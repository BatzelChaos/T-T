using System;


namespace ConsoleApp1
{
    internal class Program
    {
        public static void Player() { 
        }
        private static void Main(string[] args)
        {
            string username;
            string playercolor;

            Console.WriteLine("Choose PLAYER.COLOR");
            Console.Write("Black\nBlue\nCyan\nDark Blue\nDark Cyan\nDark Gray\nDark Green\nDark Magenta");
            Console.Write("\nDark Red\nDark Yellow\nGray\nGreen\nMagenta\nRed\nWhite\nYellow");
            //switch ()
            //{
            //    case;
            //    case;
            //}

            Console.Clear();
            
            
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Welcome to Tyrants and Taverns, a world of awe and fear, friendships and hatred, and much more.");
            Console.WriteLine("And... may I ask, who are you?");
            //Console.ForegroundColor = 
            Console.Write("My name is ");
            username = Console.ReadLine();
            Console.WriteLine("Oh, yes, " + username + "! Is that a boy or a girl though?");
            Console.WriteLine("");

            Console.Write("\nPress any key to exit...")
            Console.ReadKey();
        }

        private static void help()
        {
            if ("help" == Console.ReadLine())
            {
                Console.WriteLine("help system activated.");
            }
        }
    }
}