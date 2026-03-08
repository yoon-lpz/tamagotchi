using System.Security.Cryptography.X509Certificates;

namespace Tamagotchi.Core.Models
{
    public abstract class AAnimal : APet
    {
        protected AAnimal(string name, int language) : base(name, language) { }


        public void Eat(FoodType type)
        {

            switch (type)
            {
                case FoodType.Snack:
                    PetStat.Hunger += 10;
                    PetStat.Health -= 5;
                    break;
                case FoodType.Meal:
                    PetStat.Hunger += 40;
                    break;
            }

            if (PetStat.Hunger > 100) PetStat.Hunger = 100;
            UpdateEmotion();
        }

        public void Play() {
            PetStat.Hunger = PetStat.Hunger < 10 ? 0 : PetStat.Hunger - 10;
            PetStat.Energy = PetStat.Energy < 10 ? 0 : PetStat.Energy - 10;
            Emotion = EmotionType.Happy;
            UpdateEmotion();
        }

        public void Sleep() {
            PetStat.Energy = 100;
            UpdateEmotion();
        }
    }
}
