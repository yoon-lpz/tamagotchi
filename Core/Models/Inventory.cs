using System;

namespace Tamagotchi.Core.Models
{
    public class Inventory
    {
        public Meal[] MealList { get; set; } = [];
        public Meal[] auxMeal;
        public Snack[] SnackList { get; set; } = [];
        public Snack[] auxSnack;

        public Inventory() { }

        public void AddMeal()
        {
            auxMeal = new Meal[MealList.Length + 1];
            for (int i = 0; i < MealList.Length; i++)
            {
                auxMeal[i] = MealList[i];
            }
            auxMeal[MealList.Length] = new Meal();
            MealList = auxMeal;
            auxMeal = [];
        }
        public void RemoveMeal() {
            auxMeal = new Meal[MealList.Length - 1];

            for (int i = 0; i < MealList.Length - 1; i++)
            {
                auxMeal[i] = MealList[i + 1];
            }
            auxMeal[MealList.Length] = new Meal();
            MealList = auxMeal;
            auxMeal = [];
        }

        public void AddSnack()
        {
            auxSnack = new Snack[SnackList.Length + 1];
            for (int i = 0; i < SnackList.Length; i++)
            {
                auxSnack[i] = SnackList[i];
            }
            auxSnack[SnackList.Length] = new Snack();
            SnackList = auxSnack;
            auxSnack = [];
        }
        public void RemoveSnack()
        {
            auxSnack = new Snack[SnackList.Length - 1];

            for (int i = 0; i < MealList.Length - 1; i++)
            {
                auxSnack[i] = SnackList[i + 1];
            }
            auxSnack[SnackList.Length] = new Snack();
            SnackList = auxSnack;
            auxSnack = [];
        }
    }
}
