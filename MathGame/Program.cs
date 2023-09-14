namespace MathGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = GetName();

            TitleScreen();
            GetName();
            ShowMenu(name);
        }

        private static void ShowMenu(string name)
        {
            var closeApp = false;
            while (closeApp == false)
            {
                Console.WriteLine($"Hello, {name}.");
                Console.WriteLine("==================================================");
                Console.WriteLine(@"Select option:
a - Addition
s - Subtraction
m - Multiplication
d - Division
r - Random game
v - View previous games
q - Close application");
            }

            var menuInput = Console.ReadLine();
            switch (menuInput.Trim().ToLower())
            {
                case "a":

                    break;

                case "s":

                    break;

                case "m":

                    break;

                case "d":

                    break;

                case "r":

                    break;

                case "v":

                    break;

                case "q":
                    closeApp = true;
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("\nInvalid input. Press ENTER");
                    PressEnter();
                    ShowMenu(name);
                    break;
            }
        }

        private static string GetName()
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

        private static void TitleScreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("███╗   ███╗ █████╗ ████████╗██╗  ██╗     ██████╗  █████╗ ███╗   ███╗███████╗\r\n████╗ ████║██╔══██╗╚══██╔══╝██║  ██║    ██╔════╝ ██╔══██╗████╗ ████║██╔════╝\r\n██╔████╔██║███████║   ██║   ███████║    ██║  ███╗███████║██╔████╔██║█████╗  \r\n██║╚██╔╝██║██╔══██║   ██║   ██╔══██║    ██║   ██║██╔══██║██║╚██╔╝██║██╔══╝  \r\n██║ ╚═╝ ██║██║  ██║   ██║   ██║  ██║    ╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗\r\n╚═╝     ╚═╝╚═╝  ╚═╝   ╚═╝   ╚═╝  ╚═╝     ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝\r\n");
            Console.ResetColor();
            Console.Write("Press ENTER to play");
            PressEnter();
        }

        private static void PressEnter()
        {
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);
            } while (key.Key != ConsoleKey.Enter);
        }
    }
}