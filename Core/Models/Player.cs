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
    }
}
