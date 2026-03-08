using System;

namespace Tamagotchi.Core.Models
{
    public class Stat
    {
        public int Hunger { get; set; } = 100;
        public int Energy { get; set; } = 100;
        public int Health { get; set; } = 100;

        public Stat() { }
    }
}
