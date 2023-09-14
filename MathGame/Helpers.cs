using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class Helpers
    {
        internal static List<Game> games = new();

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

        internal static int[] GetEasyDivisionNumbers()
        {
            var random = new Random();
            var firstNumber = random.Next(1, 100);
            var secondNumber = random.Next(1, 51);

            var result = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 100);
                secondNumber = random.Next(1, 51);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }

        internal static int[] GetMediumDivisionNumbers()
        {
            var random = new Random();
            var firstNumber = random.Next(100, 1000);
            var secondNumber = random.Next(10, 51);

            var result = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(100, 1000);
                secondNumber = random.Next(10, 51);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }

        internal static int[] GetHardDivisionNumbers()
        {
            var random = new Random();
            var firstNumber = random.Next(1000, 10000);
            var secondNumber = random.Next(10, 501);

            var result = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1000, 10000);
                secondNumber = random.Next(10, 501);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }

        internal static int[] GetEasySubtractionNumbers()
        {
            var random = new Random();
            var firstNumber = random.Next(1, 100);
            var secondNumber = random.Next(1, 100);

            var result = new int[2];

            while (firstNumber - secondNumber < 0)
            {
                firstNumber = random.Next(1, 100);
                secondNumber = random.Next(1, 100);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }

        internal static int[] GetMediumSubtractionNumbers()
        {
            var random = new Random();
            var firstNumber = random.Next(100, 1000);
            var secondNumber = random.Next(100, 1000);

            var result = new int[2];

            while (firstNumber - secondNumber < 0)
            {
                firstNumber = random.Next(100, 1000);
                secondNumber = random.Next(100, 1000);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }

        internal static int[] GetHardSubtractionNumbers()
        {
            var random = new Random();
            var firstNumber = random.Next(1000, 10000);
            var secondNumber = random.Next(1000, 10000);

            var result = new int[2];

            while (firstNumber - secondNumber < 0)
            {
                firstNumber = random.Next(1000, 10000);
                secondNumber = random.Next(1000, 10000);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }

        internal static string? ValidateResult(string result)
        {
            while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
            {
                Console.Write("\nPlease enter a valid answer and try again.\nAnswer: ");
                result = Console.ReadLine();
            }

            return result;
        }

        internal static void AddToHistory(int gameScore, int maxGameScore, GameType gameType, Difficulty difficulty)
        {
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = gameScore,
                MaxScore = maxGameScore,
                Type = gameType,
                Difficulty = difficulty
            });
        }

        internal static void PrintGames()
        {
            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("====================================================================================================");

            foreach (var game in games)
            {
                Console.WriteLine($"{game.Date} - {game.Difficulty} {game.Type}, Score: {game.Score}/{game.MaxScore}");
            }

            Console.WriteLine("====================================================================================================");
            Console.WriteLine("\nPress ENTER to return to menu");
            PressEnter();
        }
    }
}
