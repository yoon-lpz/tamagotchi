using System;
using System.Drawing;

namespace Tamagotchi.Core.Models
{
    public abstract class APet
    {
        private EmotionType emotion = 0;

        public string Name { get; set; }
        public EmotionType Emotion { get; set; } = 0;
        public Stat PetStat = new Stat();
        public string[] Sprites;
        public string ActualSprite { get; set; }
        public int Language { get; set; }
        public ConsoleColor PetColor { get; set; }

        public APet(string name, int language)
        {
            Name = name;
            Language = language;
        }
    }
}
