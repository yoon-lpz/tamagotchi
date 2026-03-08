using Tamagotchi.Core.Interfaces;

namespace Tamagotchi.Core.Models
{
    public abstract class AAnimal : APet, IEat, ISleep, IPlay
    {
        public AAnimal(string name, int language) : base(name, language) { }

        public abstract void Eat();
        public abstract void Sleep();
        public abstract void Play();
    }
}
