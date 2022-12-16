using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirstLab.GameObjects
{
    class FruitPlant : GameObject
    {
        public FruitPlant(IGameEngine gameEngine) : base(gameEngine, Common.GameObjectType.Fruit2, "Fruit.xml")
        {

        }
    }
}
