using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mockbuster
{
    internal class MainLibrary
    {
        //=============================Program Methods=====================================
        public static void WelcomeMessage()
        {
            string welcomeLine1 = "╔════════════════════════════════╗	";
            string welcomeLine2 = "║	 Welcome to MockBuster!    ║	";
            string welcomeLine3 = "╚════════════════════════════════╝	";
            Console.SetCursorPosition((Console.WindowWidth - welcomeLine1.Length) / 2, Console.CursorTop);
            Console.WriteLine(welcomeLine1);
            Console.SetCursorPosition((Console.WindowWidth - welcomeLine1.Length) / 2, Console.CursorTop);
            Console.WriteLine(welcomeLine2);
            Console.SetCursorPosition((Console.WindowWidth - welcomeLine1.Length) / 2, Console.CursorTop);
            Console.WriteLine(welcomeLine3);
        }

        public static string YesNo(string input)
        {
            string yesNo;
            while (true)
            {

                if (input == "y" || input == "yes")
                {
                    yesNo = "yes";
                    break;
                }
                else if (input == "n" || input == "no")
                {
                    yesNo = "no";
                    break;
                }
                else
                {
                    Console.Write("Please enter \"yes\" or \"no\": ");
                    input = Console.ReadLine().ToLower().Trim();
                }

            }

            return yesNo;
        }

        //Only pass in input validated first with YesNo() method above. 
        public static bool GoAgain(string input)
        {
            if (input == "yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
