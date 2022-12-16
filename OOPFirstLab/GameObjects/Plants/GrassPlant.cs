using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirstLab.GameObjects
{
    public class GrassPlant : GameObject
    {
        public GrassPlant(IGameEngine gameEngine) : base(gameEngine, Common.GameObjectType.Fruit3, "Grass.xml")
        {

        }
    }
}
