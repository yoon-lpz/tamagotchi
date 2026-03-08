using Tamagotchi.Core.Models;

namespace Tamagotchi
{
    public class Player
    {
        public string Name { get; set; }
        public int Language { get; set; } = 0;
        public APet Pet { get; set; }

        // missing inventory
    }
}
