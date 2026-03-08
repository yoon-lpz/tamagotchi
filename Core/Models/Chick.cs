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

        public override void Eat()
        {
            PetStat.Hunger = PetStat.Hunger > 90 ? 100 : PetStat.Hunger += 10;
        }
        public override void Sleep()
        {
            PetStat.Energy = PetStat.Energy > 60 ? 100 : PetStat.Energy += 40;
        }

        public override void Play()
        {
            if (PetStat.Energy >= 20 && PetStat.Hunger >= 20)
            {
                PetStat.Energy -= 20;
                PetStat.Hunger -= 20;

                Emotion = (EmotionType)(PetStat.Energy > 10 && PetStat.Hunger > 10 ? 0 : 4);
            }
            else
            {
                Utils.ErrorColours();
                if (PetStat.Energy < 20 && PetStat.Hunger < 20)
                {
                    Console.WriteLine(Messages.MsgPlayErrorNoEnergyHunger[Language], Name);
                }
                else if (PetStat.Energy < 20)
                {
                    Console.WriteLine(Messages.MsgPlayErrorNoEnergy[Language], Name);
                }
                else
                {
                    Console.WriteLine(Messages.MsgPlayErrorNoEnergy[Language], Name);
                }
                Utils.ResetCMDColours();
            }
        }
    }
}
