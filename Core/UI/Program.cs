using System;
using Tamagotchi.Core;
using Tamagotchi.Core.Models;
using Tamagotchi.Core.UI;

namespace Tamagotchi
{
    public class Program
    {
        public static void Main() {
            int auxInt = 0, random = 0, maxLanguage = 2, menuOption = -1, eatOption = -1, shopOption = -1, maxOption = 4, maxEatOption = 2, maxShopOption = 2;
            bool action = true;
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
                Utils.ResetCMDColours();
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
                Console.Clear();
                Console.WriteLine(Messages.MsgShowStats[user.Language], user.Pet.PetStat.Energy, user.Pet.PetStat.Energy, user.Pet.PetStat.Health);
                Console.WriteLine();
                Console.ForegroundColor = user.Pet.PetColor;
                Console.WriteLine("\t\t" + user.Pet.ActualSprite);
                Utils.ResetCMDColours();
                Console.WriteLine();
                Console.Write(Messages.MsgMenuOptions[user.Language]);
                Console.ForegroundColor = ConsoleColor.Black;
                auxString = Console.ReadLine();
                Utils.ResetCMDColours();
                Console.Clear();

                menuOption = Utils.IsNumber(auxString)? int.Parse(auxString) : -1;

                switch (menuOption) {
                    case < 0:
                        Utils.ErrorColours();
                        Console.WriteLine(Messages.MsgMenuOptionsError[user.Language], maxOption);
                        Utils.ResetCMDColours();
                        break;
                    case 1:

                        random = user.Pet.Emotion == EmotionType.Angry ? new Random().Next(0, 3) : 0;

                        if (random < 2 || !(user.Pet.Emotion is EmotionType.Angry))
                        {
                            do
                            {
                                Console.Write(Messages.MsgMenuEat[user.Language], user.PlayerInventory.SnackList.Length, user.PlayerInventory.MealList.Length);
                                Console.ForegroundColor = ConsoleColor.Black;
                                auxString = Console.ReadLine();
                                Utils.ResetCMDColours();

                                if (Utils.IsNumber(auxString) && Utils.IsBetween(auxString, 0, maxEatOption))
                                {
                                    eatOption = int.Parse(auxString);

                                    switch (eatOption)
                                    {
                                        case 1:
                                            if (user.PlayerInventory.SnackList.Length > 0)
                                            {
                                                user.Feed(FoodType.Snack);
                                                user.PlayerInventory.RemoveSnack();
                                            } else
                                            {
                                                Utils.ErrorColours();
                                                Console.WriteLine(Messages.MsgSnackError[user.Language]);
                                                Utils.ResetCMDColours();
                                            }
                                                break;
                                        case 2:
                                            if (user.PlayerInventory.MealList.Length > 0)
                                            {
                                                user.Feed(FoodType.Meal);
                                                user.PlayerInventory.RemoveMeal();
                                            }
                                            else
                                            {
                                                Utils.ErrorColours();
                                                Console.WriteLine(Messages.MsgMealError[user.Language]);
                                                Utils.ResetCMDColours();
                                            }
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                    Utils.ErrorColours();
                                    Console.WriteLine(Messages.MsgErrorNumber[user.Language], maxEatOption);
                                    Utils.ResetCMDColours();
                                }
                            } while (eatOption < 0 || eatOption > maxEatOption);
                        } else
                        {
                            Utils.ErrorColours();
                            Console.WriteLine(Messages.MsgAngry[user.Language]);
                            Utils.ResetCMDColours();
                        }
                            break; // Eat
                    case 2:

                        action = user.Pet.PetStat.Energy < 100;
                        
                        if (action) user.Sleep();
                            break; // Sleep
                    case 3:
                        if (user.Pet.Emotion is EmotionType.Happy)
                        {
                            action = true;
                        }
                        else if (user.Pet.Emotion is EmotionType.Angry || user.Pet.Emotion is EmotionType.Sad)
                        {
                            random = new Random().Next(0, 3);

                            action = random < 2;
                        }
                        else
                        {
                            action = false;
                        }

                        if (action) user.Play();
                        break; // Play
                    case 4:
                        do
                        {
                            Console.Write(Messages.MsgShopOptions[user.Language]);
                            Console.ForegroundColor = ConsoleColor.Black;
                            auxString = Console.ReadLine();
                            Utils.ResetCMDColours();
                            if (Utils.IsNumber(auxString) && Utils.IsBetween(auxString, 0, maxShopOption))
                            {
                                shopOption = int.Parse(auxString);

                                switch (shopOption)
                                {
                                    case 1:
                                        user.PlayerInventory.AddSnack();
                                        break;
                                    case 2:
                                        user.PlayerInventory.AddMeal();
                                        break;
                                }
                            }
                            else
                            {
                                Utils.ErrorColours();
                                Console.WriteLine(Messages.MsgErrorNumber[user.Language]);
                                Utils.ResetCMDColours();
                                Console.Clear();
                            }
                        } while (shopOption < 0 ||  shopOption > maxShopOption);
                        
                            break; // Shop
                    case 5:
                        action = user.Pet.Emotion is EmotionType.Sick;

                        if (action)
                        {
                            user.Pet.Injection();
                        }
                        break; // Injection
                    case 6:
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
                            break; // Language change
                }

                Console.WriteLine(Messages.MsgPressEnter[user.Language]);
                Utils.SetCMDColours(ConsoleColor.Cyan, ConsoleColor.Cyan);
                Console.ReadLine();
                Utils.ResetCMDColours();
                Console.Clear();

            } while (menuOption != 0);
        }
    }
}