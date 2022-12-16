using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirstLab.GameObjects
{
    public class CarrotPlant : GameObject
    {
        public CarrotPlant(IGameEngine gameEngine) : base(gameEngine, Common.GameObjectType.Fruit1, "Carrot.xml")
        {

        }
    }
}
