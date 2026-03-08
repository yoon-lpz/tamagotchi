using Tamagotchi.Core.UI;
using System;

namespace Tamagotchi.Core.Models
{
    public class Dog : AAnimal
    {

        //Constructor
        public Dog(string name, int language) : base(name, language) {
            Sprites = [
                "૮₍ • ᴥ • ₎ა",
                "૮₍ ╥ ᴥ ╥ ₎ა",
                "૮₍ ◺ ᴥ ◿ ₎ა",
                "૮₍ ´ ᴥ ｀ ₎ა",
                "૮₍ x ᴥ x ₎ა"
                ];
            ActualSprite = Sprites[0];
            PetColor = ConsoleColor.DarkGray;
        }
    }
}
