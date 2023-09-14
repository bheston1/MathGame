namespace MathGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TitleScreen();
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