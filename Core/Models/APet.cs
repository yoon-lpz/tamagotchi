using System;

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

        protected APet(string name, int language)
        {
            Name = name;
            Language = language;
        }

        public void Injection()
        {
            PetStat.Health += 50;
            UpdateEmotion();
        }

        protected void UpdateEmotion() {

            if (PetStat.Hunger <= 50)
            {
                PetStat.Health -= 5;
                Emotion = EmotionType.Angry;
                ActualSprite = Sprites[2];
            }

            if (PetStat.Energy <= 30)
            {
                PetStat.Health -= 5;
                Emotion = EmotionType.Tired;
                ActualSprite = Sprites[3];
            }

            if (PetStat.Health <= 20)
            {
                Emotion = EmotionType.Sick;
                ActualSprite = Sprites[4];
            }

            if (PetStat.Health < 0) PetStat = null;
        }
    }
}
