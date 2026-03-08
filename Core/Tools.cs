using System;
namespace Tamagotchi.Core
{
    public class Utils
    {
        public static void SetCMDColours(ConsoleColor background, ConsoleColor foreground)
        {
            Console.BackgroundColor = background;
            Console.ForegroundColor = foreground;
        }
        public static void ResetCMDColours()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
        }
        public static void ErrorColours()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        public static bool IsNumber(string number)
        {
            try
            {
                int.Parse(number);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool IsBetween(int number, int valueMin, int valueMax) => number >= valueMin && number <= valueMax;
        public static bool IsBetween(string number, int valueMin, int valueMax)
        {
            if (!IsNumber(number)) return false;

            return int.Parse(number) >= valueMin && int.Parse(number) <= valueMax;
        }
    }
}
