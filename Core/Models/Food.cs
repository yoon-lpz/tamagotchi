
namespace Tamagotchi.Core.Models
{
    public class Food : AItem
    {
        FoodType Type {  get; set; }

        public Food(FoodType type) : base() {
            Type = type;
        }
    }
}
