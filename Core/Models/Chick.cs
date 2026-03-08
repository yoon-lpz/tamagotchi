using Tamagotchi.Core.UI;
using System;

namespace Tamagotchi.Core.Models
{
    public class Chick : AAnimal
    {

        //Constructor
        public Chick(string name, int language) : base(name, language) {
            Sprites = [
                "꒰ঌ(•⌔•)໒꒱",
                "꒰ঌ(╥⌔╥)໒꒱",
                "꒰ঌ(◺⌔◿)໒꒱",
                "꒰ঌ(´⌔｀)໒꒱",
                "꒰ঌ(x⌔x)໒꒱"
                ];
            ActualSprite = Sprites[0];
            PetColor = ConsoleColor.Yellow;
        }
    }
}
