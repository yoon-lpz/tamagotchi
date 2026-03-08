using Tamagotchi.Core.UI;
using System;

namespace Tamagotchi.Core.Models
{
    public class Cat : AAnimal
    {

        public Cat(string name, int language) : base(name, language) {
            Sprites = [
                "≽^•⩊•^≼",
                "≽^╥⩊╥^≼",
                "≽^◺⩊◿^≼",
                "≽^´⩊｀^≼",
                "≽^x⩊x^≼" 
                ];
            ActualSprite = Sprites[0];
            PetColor = ConsoleColor.White;
        }
    }
}
