using System;
using Tamagotchi.Core;
using Tamagotchi.Core.UI;

namespace Tamagotchi
{
    public class Program
    {
        public static void Main() {
            int language = 0, petSelection;
            string auxString, username;

            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Utils.ResetCMDColours();
            Console.Clear();

            //Ask language
            do
            {
                Console.WriteLine(Messages.MsgLanguageOptions);
                Console.Write(Messages.MsgLanguageSelection);

                Console.ForegroundColor = ConsoleColor.Black;
                auxString = Console.ReadLine();
                Utils.ResetCMDColours();


                if (Utils.IsNumber(auxString) && Utils.IsBetween(auxString, 0, 2))
                {
                    language = int.Parse(auxString);
                } else
                {
                    Console.Clear();
                    Utils.ErrorColours();
                    Console.WriteLine(Messages.MsgLanguageError);
                    Utils.ResetCMDColours();
                }

            } while (!Utils.IsNumber(auxString) || !Utils.IsBetween(auxString, 0, 2));

            Console.Clear();

            //Ask name
            do
            {
                Console.Write(Messages.MsgUserNameSelection[language]);
                Console.ForegroundColor = ConsoleColor.Black;
                username = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                if (String.IsNullOrEmpty(username)) {
                    Console.Clear();
                    Utils.ErrorColours();
                    Console.WriteLine(Messages.MsgUserNameSelectionError[language]);
                    Utils.ResetCMDColours();
                }
            } while (String.IsNullOrEmpty(username));

            Console.Clear();

            //Ask pet
            do
            {
                Utils.SetCMDColours(ConsoleColor.Gray, ConsoleColor.DarkGray);
                Console.WriteLine(Messages.CatProfileASCII);

                Utils.SetCMDColours(ConsoleColor.White, ConsoleColor.Black);
                Console.WriteLine(Messages.DogProfileASCII);

                Utils.SetCMDColours(ConsoleColor.Yellow, ConsoleColor.DarkYellow);
                Console.WriteLine(Messages.ChickProfileASCII);

                Utils.ResetCMDColours();
                Console.WriteLine(Messages.MsgSelectPet[language]);

                Console.ForegroundColor= ConsoleColor.Black;
                auxString = Console.ReadLine();
                Utils.ResetCMDColours();

                if (Utils.IsNumber(auxString) && Utils.IsBetween(auxString, 0, 2))
                {
                    petSelection = int.Parse(auxString);
                }
                else
                {
                    Console.Clear();
                    Utils.ErrorColours();
                    Console.WriteLine(Messages.MsgSelectPetError);
                    Utils.ResetCMDColours();
                }
            } while (Utils.IsNumber(auxString) && Utils.IsBetween(auxString, 0, 2));
        }
    }
}