namespace MathGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Helpers.TitleScreen();
            string name = Helpers.GetName();
            Menu.ShowMenu(name);
        }
    }
}