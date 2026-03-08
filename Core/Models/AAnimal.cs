using Tamagotchi.Core.Interfaces;

namespace Tamagotchi.Core.Models
{
    public abstract class AAnimal : APet, IEat, ISleep, IPlay
    {
        protected AAnimal(string name, int language) : base(name, language) { }

        public abstract void Eat(int type);
        public abstract void Sleep();
        public abstract void Play();
    }
}
