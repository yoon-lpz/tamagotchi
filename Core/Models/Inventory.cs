using System;

namespace Tamagotchi.Core.Models
{
    public class Inventory
    {

        public Food[] MealList { get; set; } = [];
        public Food[] auxMeal;
        public Food[] SnackList { get; set; } = [];
        public Food[] auxSnack;

        public Inventory() { }

        public void AddMeal()
        {
            auxMeal = new Food[MealList.Length + 1];
            for (int i = 0; i < MealList.Length; i++)
            {
                auxMeal[i] = MealList[i];
            }
            auxMeal[MealList.Length] = new Food(FoodType.Meal);
            MealList = auxMeal;
            auxMeal = [];
        }
        public void RemoveMeal() {
            auxMeal = new Food[MealList.Length - 1];

            for (int i = 0; i < MealList.Length - 1; i++)
            {
                auxMeal[i] = MealList[i + 1];
            }
            MealList = auxMeal;
            auxMeal = [];
        }

        public void AddSnack()
        {
            auxSnack = new Food[SnackList.Length + 1];
            for (int i = 0; i < SnackList.Length; i++)
            {
                auxSnack[i] = SnackList[i];
            }
            auxSnack[SnackList.Length] = new Food(FoodType.Snack);
            SnackList = auxSnack;
            auxSnack = [];
        }
        public void RemoveSnack()
        {
            auxSnack = new Food[SnackList.Length - 1];

            for (int i = 0; i < MealList.Length - 1; i++)
            {
                auxSnack[i] = SnackList[i + 1];
            }
            SnackList = auxSnack;
            auxSnack = [];
        }
    }
}
