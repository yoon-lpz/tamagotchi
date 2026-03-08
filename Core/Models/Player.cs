using Tamagotchi.Core.Models;

namespace Tamagotchi
{
    public class Player
    {
        public int Language { get; set; } = 0;
        public string Name { get; set; }
        public APet Pet { get; set; }
        public Inventory PlayerInventory { get; set; }

        public Player()
        {
            PlayerInventory = new Inventory();
        }

        public void Feed(FoodType type)
        {
            if (Pet is AAnimal aux)
            {
                aux.Eat(type);
            }
        }

        public void Play()
        {
            if (Pet is AAnimal aux)
            {
                aux.Play();
            }
        }

        public void Sleep()
        {
            if (Pet is AAnimal aux)
            {
                aux.Sleep();
            }
        }
    }
}
