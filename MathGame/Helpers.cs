using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class Helpers
    {
        internal static string GetName()
        {
            Console.Clear();
            Console.Write("Please enter your name: ");
            var nameInput = Console.ReadLine();
            while (string.IsNullOrEmpty(nameInput))
            {
                Console.Write("\nName cannot be empty.\nEnter your name: ");
                nameInput = Console.ReadLine();
            }
            return nameInput;
        }

        internal static void TitleScreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("███╗   ███╗ █████╗ ████████╗██╗  ██╗     ██████╗  █████╗ ███╗   ███╗███████╗\r\n████╗ ████║██╔══██╗╚══██╔══╝██║  ██║    ██╔════╝ ██╔══██╗████╗ ████║██╔════╝\r\n██╔████╔██║███████║   ██║   ███████║    ██║  ███╗███████║██╔████╔██║█████╗  \r\n██║╚██╔╝██║██╔══██║   ██║   ██╔══██║    ██║   ██║██╔══██║██║╚██╔╝██║██╔══╝  \r\n██║ ╚═╝ ██║██║  ██║   ██║   ██║  ██║    ╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗\r\n╚═╝     ╚═╝╚═╝  ╚═╝   ╚═╝   ╚═╝  ╚═╝     ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝\r\n");
            Console.ResetColor();
            Console.Write("Press ENTER to play");
            PressEnter();
        }

        internal static void PressEnter()
        {
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);
            } while (key.Key != ConsoleKey.Enter);
        }
    }
}
