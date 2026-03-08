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

        public override void Eat(int type)
        {
            int nutritionalValue = type == 1 ? 10 : 40;

            PetStat.Hunger = PetStat.Hunger > 100 - nutritionalValue ? 100 : PetStat.Hunger += nutritionalValue;

            if (type == 1) PetStat.Health -= 10;
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
            } else
            {
                Utils.ErrorColours();
                if (PetStat.Energy < 20 && PetStat.Hunger < 20)
                {
                    Console.WriteLine(Messages.MsgPlayErrorNoEnergyHunger[Language], Name);
                }
                else if (PetStat.Energy < 20)
                {
                    Console.WriteLine(Messages.MsgPlayErrorNoEnergy[Language], Name);
                } else {
                    Console.WriteLine(Messages.MsgPlayErrorNoEnergy[Language], Name);
                }
                Utils.ResetCMDColours();
            }
        }
    }
}
