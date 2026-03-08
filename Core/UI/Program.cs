using System;
using Tamagotchi.Core;
using Tamagotchi.Core.Models;
using Tamagotchi.Core.UI;

namespace Tamagotchi
{
    public class Program
    {
        public static void Main() {
            int auxInt = 0, maxLanguage = 2, menuOption = -1, maxOption = 4;
            string auxString;

            Player user = new Player();

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

                if (Utils.IsNumber(auxString) && Utils.IsBetween(auxString, 0, maxLanguage))
                {
                    user.Language = int.Parse(auxString);
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
                Console.Write(Messages.MsgUserNameSelection[user.Language]);
                Console.ForegroundColor = ConsoleColor.Black;
                auxString = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                if (String.IsNullOrEmpty(auxString)) {
                    Console.Clear();
                    Utils.ErrorColours();
                    Console.WriteLine(Messages.MsgUserNameSelectionError[user.Language]);
                    Utils.ResetCMDColours();
                }
            } while (String.IsNullOrEmpty(auxString));

            Console.Clear();

            //Ask pet
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(Messages.CatProfileASCII);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine(Messages.DogProfileASCII);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(Messages.ChickProfileASCII);

                Utils.ResetCMDColours();
                Console.Write(Messages.MsgSelectPet[user.Language]);

                Console.ForegroundColor= ConsoleColor.Black;
                auxString = Console.ReadLine();
                Utils.ResetCMDColours();

                if (Utils.IsNumber(auxString) && Utils.IsBetween(auxString, 0, 2))
                {
                    auxInt = int.Parse(auxString);
                }
                else
                {
                    Console.Clear();
                    Utils.ErrorColours();
                    Console.WriteLine(Messages.MsgSelectPetError);
                    Utils.ResetCMDColours();
                }
            } while (!Utils.IsNumber(auxString) || !Utils.IsBetween(auxString, 0, 2));

            //Ask pet name
            do
            {
                Console.Write(Messages.MsgPetNameSelection[user.Language]);
                Console.ForegroundColor = ConsoleColor.Black;
                auxString = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                if (String.IsNullOrEmpty(auxString))
                {
                    Console.Clear();
                    Utils.ErrorColours();
                    Console.WriteLine(Messages.MsgPetNameSelectionError[user.Language]);
                    Utils.ResetCMDColours();
                }
            } while (String.IsNullOrEmpty(auxString));

            switch (auxInt)
            {
                case 0:
                    user.Pet = new Cat(auxString, user.Language);
                    break;
                case 1:
                    user.Pet = new Dog(auxString, user.Language);
                    break;
                case 2:
                    user.Pet = new Chick(auxString, user.Language);
                    break;
            }

            Console.Clear();

            do
            {
                Console.WriteLine(Messages.MsgShowStats[user.Language], user.Pet.PetStat.Energy, user.Pet.PetStat.Energy, user.Pet.PetStat.Health);
                Console.WriteLine();
                Console.WriteLine("\t\t" + user.Pet.ActualSprite);
                Console.WriteLine();
                Console.Write(Messages.MsgMenuOptions[user.Language]);
                auxString = Console.ReadLine();

                menuOption = Utils.IsNumber(auxString)? int.Parse(auxString) : -1;

                switch (menuOption) {
                    case < 0:
                        Utils.ErrorColours();
                        Console.WriteLine(Messages.MsgMenuOptionsError[user.Language], maxOption);
                        Utils.ResetCMDColours();
                        break;
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine(Messages.MsgLanguageOptions);
                        Console.Write(Messages.MsgLanguageSelection);
                        auxString = Console.ReadLine();
                        if (Utils.IsNumber(auxString) && Utils.IsBetween(auxString, 0, maxLanguage)) {
                            user.Language = int.Parse(auxString);
                            user.Pet.Language = int.Parse(auxString);
                        } else
                        {
                            Utils.ErrorColours();
                            Console.WriteLine(Messages.MsgLanguageError);
                            Utils.ResetCMDColours();
                        }
                            break;
                }

                Utils.SetCMDColours(ConsoleColor.Cyan, ConsoleColor.Cyan);
                Console.WriteLine(Messages.MsgPressEnter[user.Language]);
                Console.ReadLine();
                Utils.ResetCMDColours();
                Console.Clear();
            } while (menuOption != 0);
        }
    }
}