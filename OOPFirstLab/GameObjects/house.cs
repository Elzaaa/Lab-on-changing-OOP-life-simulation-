using OOPFirstLab.Common;
using OOPFirstLab.GameObjectDescriptors;

namespace OOPFirstLab.GameObjects
{
    public class House : GameObject
    {
        /// <summary>
        /// Примем что в доме может быть 5 фруктов
        /// </summary>
        public static int kMaxFruitCount = 5;

        public House(IGameEngine gameEngine) : base(gameEngine, GameObjectType.House, "House.xml")
        {
        }

        public int FruitCount { get; set; }
    }
}
