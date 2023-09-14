using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class Engine
    {
        internal static bool additionSelected;
        internal static bool subtractionSelected;
        internal static bool multiplicationSelected;
        internal static bool divisionSelected;

        internal static void DifficultySelect()
        {
            Console.Clear();
            Console.WriteLine($@"Select difficulty:
1 - Easy
2 - Medium
3 - Hard");
            Console.WriteLine("==================================================");

            var difficultyMode = Console.ReadLine();

            switch (difficultyMode)
            {
                case "1":
                    if (additionSelected == true)
                    {
                        EasyAddition("Easy Addition\n==================================================");
                    }
                    else if (subtractionSelected == true)
                    {
                        EasySubtraction("Easy Subtraction\n==================================================");
                    }
                    else if (multiplicationSelected == true)
                    {
                        EasyMultiplication("Easy Multiplication\n==================================================");
                    }
                    else if (divisionSelected == true)
                    {
                        EasyDivision("Easy Division\n==================================================");
                    }
                    break;

                case "2":
                    if (additionSelected == true)
                    {
                        MediumAddition("Medium Addition\n==================================================");
                    }
                    else if (subtractionSelected == true)
                    {
                        MediumSubtraction("Medium Subtraction\n==================================================");
                    }
                    else if (multiplicationSelected == true)
                    {
                        MediumMultiplication("Medium Multiplication\n==================================================");
                    }
                    else if (divisionSelected == true)
                    {
                        MediumDivision("Medium Division\n==================================================");
                    }
                    break;

                case "3":
                    if (additionSelected == true)
                    {
                        HardAddition("Hard Addition\n==================================================");
                    }
                    else if (subtractionSelected == true)
                    {
                        HardSubtraction("Hard Subtraction\n==================================================");
                    }
                    else if (multiplicationSelected == true)
                    {
                        HardMultiplication("Hard Multiplication\n==================================================");
                    }
                    else if (divisionSelected == true)
                    {
                        HardDivision("Hard Division\n==================================================");
                    }
                    break;

                default:
                    Console.WriteLine("\nInvalid input. Press ENTER");
                    Helpers.PressEnter();
                    Console.Clear();
                    DifficultySelect();
                    break;
            }
        }

        private static void HardDivision(string message)
        {
            var score = 0;
            var maxScore = 10;

            for (int roundCount = 0; roundCount < 10; roundCount++)
            {
                Console.Clear();
                Console.WriteLine(message);

                var divisionNumbers = Helpers.GetHardDivisionNumbers();
                var firstNumber = divisionNumbers[0];
                var secondNumber = divisionNumbers[1];

                Console.Write($"{firstNumber} ÷ {secondNumber}\nAnswer: ");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("\nCorrect! Press ENTER to continue...");
                    Helpers.PressEnter();
                    score++;
                }
                else
                {
                    Console.WriteLine("\nIncorrect. Press ENTER to continue...");
                    Helpers.PressEnter();
                }

                if (roundCount == 9)
                {
                    Console.Clear();
                    Console.WriteLine($"Game over. Your final score is {score}\n\nPress ENTER");
                    Helpers.PressEnter();
                }
            }

            divisionSelected = false;
            Helpers.AddToHistory(score, maxScore, GameType.Division, Difficulty.Hard);
        }

        private static void MediumDivision(string message)
        {
            var score = 0;
            var maxScore = 10;

            for (int roundCount = 0; roundCount < 10; roundCount++)
            {
                Console.Clear();
                Console.WriteLine(message);

                var divisionNumbers = Helpers.GetMediumDivisionNumbers();
                var firstNumber = divisionNumbers[0];
                var secondNumber = divisionNumbers[1];

                Console.Write($"{firstNumber} ÷ {secondNumber}\nAnswer: ");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("\nCorrect! Press ENTER to continue...");
                    Helpers.PressEnter();
                    score++;
                }
                else
                {
                    Console.WriteLine("\nIncorrect. Press ENTER to continue...");
                    Helpers.PressEnter();
                }

                if (roundCount == 9)
                {
                    Console.Clear();
                    Console.WriteLine($"Game over. Your final score is {score}\n\nPress ENTER");
                    Helpers.PressEnter();
                }
            }

            divisionSelected = false;
            Helpers.AddToHistory(score, maxScore, GameType.Division, Difficulty.Medium);
        }

        private static void EasyDivision(string message)
        {
            var score = 0;
            var maxScore = 10;

            for (int roundCount = 0; roundCount < 10; roundCount++)
            {
                Console.Clear();
                Console.WriteLine(message);

                var divisionNumbers = Helpers.GetEasyDivisionNumbers();
                var firstNumber = divisionNumbers[0];
                var secondNumber = divisionNumbers[1];

                Console.Write($"{firstNumber} ÷ {secondNumber}\nAnswer: ");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("\nCorrect! Press ENTER to continue...");
                    Helpers.PressEnter();
                    score++;
                }
                else
                {
                    Console.WriteLine("\nIncorrect. Press ENTER to continue...");
                    Helpers.PressEnter();
                }

                if (roundCount == 9)
                {
                    Console.Clear();
                    Console.WriteLine($"Game over. Your final score is {score}\n\nPress ENTER");
                    Helpers.PressEnter();
                }
            }

            divisionSelected = false;
            Helpers.AddToHistory(score, maxScore, GameType.Division, Difficulty.Easy);
        }

        private static void HardMultiplication(string message)
        {
            var random = new Random();
            var score = 0;
            var maxScore = 10;
            int firstNumber;
            int secondNumber;

            for (int roundCount = 0; roundCount < 10; roundCount++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1000, 10000);
                secondNumber = random.Next(1000, 10000);

                Console.Write($"{firstNumber} x {secondNumber}\nAnswer: ");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("\nCorrect! Press ENTER to continue...");
                    Helpers.PressEnter();
                    score++;
                }
                else
                {
                    Console.WriteLine("\nIncorrect. Press ENTER to continue...");
                    Helpers.PressEnter();
                }

                if (roundCount == 9)
                {
                    Console.Clear();
                    Console.WriteLine($"Game over. Your final score is {score}\n\nPress ENTER");
                    Helpers.PressEnter();
                }
            }

            multiplicationSelected = false;
            Helpers.AddToHistory(score, maxScore, GameType.Multiplication, Difficulty.Hard);
        }

        private static void MediumMultiplication(string message)
        {
            var random = new Random();
            var score = 0;
            var maxScore = 10;
            int firstNumber;
            int secondNumber;

            for (int roundCount = 0; roundCount < 10; roundCount++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(100, 1000);
                secondNumber = random.Next(100, 1000);

                Console.Write($"{firstNumber} x {secondNumber}\nAnswer: ");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("\nCorrect! Press ENTER to continue...");
                    Helpers.PressEnter();
                    score++;
                }
                else
                {
                    Console.WriteLine("\nIncorrect. Press ENTER to continue...");
                    Helpers.PressEnter();
                }

                if (roundCount == 9)
                {
                    Console.Clear();
                    Console.WriteLine($"Game over. Your final score is {score}\n\nPress ENTER");
                    Helpers.PressEnter();
                }
            }

            multiplicationSelected = false;
            Helpers.AddToHistory(score, maxScore, GameType.Multiplication, Difficulty.Medium);
        }

        private static void EasyMultiplication(string message)
        {
            var random = new Random();
            var score = 0;
            var maxScore = 10;
            int firstNumber;
            int secondNumber;

            for (int roundCount = 0; roundCount < 10; roundCount++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, 100);
                secondNumber = random.Next(1, 100);

                Console.Write($"{firstNumber} x {secondNumber}\nAnswer: ");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("\nCorrect! Press ENTER to continue...");
                    Helpers.PressEnter();
                    score++;
                }
                else
                {
                    Console.WriteLine("\nIncorrect. Press ENTER to continue...");
                    Helpers.PressEnter();
                }

                if (roundCount == 9)
                {
                    Console.Clear();
                    Console.WriteLine($"Game over. Your final score is {score}\n\nPress ENTER");
                    Helpers.PressEnter();
                }
            }

            multiplicationSelected = false;
            Helpers.AddToHistory(score, maxScore, GameType.Multiplication, Difficulty.Easy);
        }

        private static void HardSubtraction(string message)
        {
            var random = new Random();
            var score = 0;
            var maxScore = 10;

            for (int roundCount = 0; roundCount < 10; roundCount++)
            {
                Console.Clear();
                Console.WriteLine(message);

                var subtractionNumbers = Helpers.GetHardSubtractionNumbers();
                var firstNumber = subtractionNumbers[0];
                var secondNumber = subtractionNumbers[1];

                Console.Write($"{firstNumber} - {secondNumber}\nAnswer: ");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("\nCorrect! Press ENTER to continue...");
                    Helpers.PressEnter();
                    score++;
                }
                else
                {
                    Console.WriteLine("\nIncorrect. Press ENTER to continue...");
                    Helpers.PressEnter();
                }

                if (roundCount == 9)
                {
                    Console.Clear();
                    Console.WriteLine($"Game over. Your final score is {score}\n\nPress ENTER");
                    Helpers.PressEnter();
                }
            }

            subtractionSelected = false;
            Helpers.AddToHistory(score, maxScore, GameType.Subtraction, Difficulty.Hard);
        }

        private static void MediumSubtraction(string message)
        {
            var random = new Random();
            var score = 0;
            var maxScore = 10;

            for (int roundCount = 0; roundCount < 10; roundCount++)
            {
                Console.Clear();
                Console.WriteLine(message);

                var subtractionNumbers = Helpers.GetMediumSubtractionNumbers();
                var firstNumber = subtractionNumbers[0];
                var secondNumber = subtractionNumbers[1];

                Console.Write($"{firstNumber} - {secondNumber}\nAnswer: ");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("\nCorrect! Press ENTER to continue...");
                    Helpers.PressEnter();
                    score++;
                }
                else
                {
                    Console.WriteLine("\nIncorrect. Press ENTER to continue...");
                    Helpers.PressEnter();
                }

                if (roundCount == 9)
                {
                    Console.Clear();
                    Console.WriteLine($"Game over. Your final score is {score}\n\nPress ENTER");
                    Helpers.PressEnter();
                }
            }

            subtractionSelected = false;
            Helpers.AddToHistory(score, maxScore, GameType.Subtraction, Difficulty.Medium);
        }

        private static void EasySubtraction(string message)
        {
            var random = new Random();
            var score = 0;
            var maxScore = 10;

            for (int roundCount = 0; roundCount < 10; roundCount++)
            {
                Console.Clear();
                Console.WriteLine(message);

                var subtractionNumbers = Helpers.GetEasySubtractionNumbers();
                var firstNumber = subtractionNumbers[0];
                var secondNumber = subtractionNumbers[1];

                Console.Write($"{firstNumber} - {secondNumber}\nAnswer: ");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("\nCorrect! Press ENTER to continue...");
                    Helpers.PressEnter();
                    score++;
                }
                else
                {
                    Console.WriteLine("\nIncorrect. Press ENTER to continue...");
                    Helpers.PressEnter();
                }

                if (roundCount == 9)
                {
                    Console.Clear();
                    Console.WriteLine($"Game over. Your final score is {score}\n\nPress ENTER");
                    Helpers.PressEnter();
                }
            }

            subtractionSelected = false;
            Helpers.AddToHistory(score, maxScore, GameType.Subtraction, Difficulty.Easy);
        }

        private static void HardAddition(string message)
        {
            var random = new Random();
            var score = 0;
            var maxScore = 10;
            int firstNumber;
            int secondNumber;

            for (int roundCount = 0; roundCount < 10; roundCount++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1000, 10000);
                secondNumber = random.Next(1000, 10000);

                Console.Write($"{firstNumber} + {secondNumber}\nAnswer: ");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("\nCorrect! Press ENTER to continue...");
                    Helpers.PressEnter();
                    score++;
                }
                else
                {
                    Console.WriteLine("\nIncorrect. Press ENTER to continue...");
                    Helpers.PressEnter();
                }

                if (roundCount == 9)
                {
                    Console.Clear();
                    Console.WriteLine($"Game over. Your final score is {score}\n\nPress ENTER");
                    Helpers.PressEnter();
                }
            }

            additionSelected = false;
            Helpers.AddToHistory(score, maxScore, GameType.Addition, Difficulty.Hard);
        }

        private static void MediumAddition(string message)
        {
            var random = new Random();
            var score = 0;
            var maxScore = 10;
            int firstNumber;
            int secondNumber;

            for (int roundCount = 0; roundCount < 10; roundCount++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(100, 1000);
                secondNumber = random.Next(100, 1000);

                Console.Write($"{firstNumber} + {secondNumber}\nAnswer: ");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("\nCorrect! Press ENTER to continue...");
                    Helpers.PressEnter();
                    score++;
                }
                else
                {
                    Console.WriteLine("\nIncorrect. Press ENTER to continue...");
                    Helpers.PressEnter();
                }

                if (roundCount == 9)
                {
                    Console.Clear();
                    Console.WriteLine($"Game over. Your final score is {score}\n\nPress ENTER");
                    Helpers.PressEnter();
                }
            }

            additionSelected = false;
            Helpers.AddToHistory(score, maxScore, GameType.Addition, Difficulty.Medium);
        }

        private static void EasyAddition(string message)
        {
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;
            var maxScore = 10;
            int firstNumber;
            int secondNumber;

            for (int roundCount = 0; roundCount < 10; roundCount++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, 100);
                secondNumber = random.Next(1, 100);

                Console.Write($"{firstNumber} + {secondNumber}\nAnswer: ");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("\nCorrect! Press ENTER to continue...");
                    Helpers.PressEnter();
                    score++;
                }
                else
                {
                    Console.WriteLine("\nIncorrect. Press ENTER to continue...");
                    Helpers.PressEnter();
                }

                if (roundCount == 9)
                {
                    Console.Clear();
                    Console.WriteLine($"Game over. Your final score is {score}\n\nPress ENTER");
                    Helpers.PressEnter();
                }
            }

            additionSelected = false;
            Helpers.AddToHistory(score, maxScore, GameType.Addition, Difficulty.Easy);
        }

        internal static void AdditionGame()
        {
            additionSelected = true;
            DifficultySelect();
        }

        internal static void SubtractionGame()
        {
            subtractionSelected = true;
            DifficultySelect();
        }

        internal static void MultiplicationGame()
        {
            multiplicationSelected = true;
            DifficultySelect();
        }

        internal static void DivisionGame()
        {
            divisionSelected = true;
            DifficultySelect();
        }

        internal static void RandomGame()
        {
            Console.Clear();
            Console.WriteLine($@"Select difficulty:
1 - Easy
2 - Medium
3 - Hard");
            Console.WriteLine("==================================================");

            var randomDifficultySelect = Console.ReadLine();

            switch (randomDifficultySelect)
            {
                case "1":
                    RandomEasy();
                    break;

                case "2":
                    RandomMedium();
                    break;

                case "3":
                    RandomHard();
                    break;
            }
        }

        private static void RandomHard()
        {
            var random = new Random();
            int selection = random.Next(1, 5);

            switch (selection)
            {
                case 1:
                    HardAddition("Hard Addition\n==================================================");
                    break;

                case 2:
                    HardSubtraction("Hard Subtraction\n==================================================");
                    break;

                case 3:
                    HardMultiplication("Hard Multiplication\n==================================================");
                    break;

                case 4:
                    HardDivision("Hard Division\n==================================================");
                    break;
            }
        }

        private static void RandomMedium()
        {
            var random = new Random();
            int selection = random.Next(1, 5);

            switch (selection)
            {
                case 1:
                    MediumAddition("Medium Addition\n==================================================");
                    break;

                case 2:
                    MediumSubtraction("Medium Subtraction\n==================================================");
                    break;

                case 3:
                    MediumMultiplication("Medium Multiplication\n==================================================");
                    break;

                case 4:
                    MediumDivision("Medium Division\n==================================================");
                    break;
            }
        }

        private static void RandomEasy()
        {
            var random = new Random();
            int selection = random.Next(1, 5);

            switch (selection)
            {
                case 1:
                    EasyAddition("Easy Addition\n==================================================");
                    break;

                case 2:
                    EasySubtraction("Easy Subtraction\n==================================================");
                    break;

                case 3:
                    EasyMultiplication("Easy Multiplication\n==================================================");
                    break;

                case 4:
                    EasyDivision("Easy Division\n==================================================");
                    break;
            }
        }
    }
}
