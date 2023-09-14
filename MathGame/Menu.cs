﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class Menu
    {
        internal static void ShowMenu(string name)
        {
            var closeApp = false;
            while (closeApp == false)
            {
                Console.Clear();
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
                        Helpers.PressEnter();
                        ShowMenu(name);
                        break;
                }
            }
        }
    }
}