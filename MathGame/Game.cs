using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class Game
    {
        internal int Score { get; set; }
        internal int MaxScore { get; set; }
        internal DateTime Date { get; set; }
        internal GameType Type { get; set; }
        internal Difficulty Difficulty { get; set; }
    }

    internal enum GameType
    {
        Addition,
        Subtraction,
        Multiplication,
        Division
    }

    internal enum Difficulty
    {
        Easy,
        Medium,
        Hard
    }
}
