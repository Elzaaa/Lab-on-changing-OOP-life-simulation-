using OOPFirstLab.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirstLab.GameObjects
{
    public class ElkAnimal : GameObject
    {
        public static ElkAnimal Create(IGameEngine gameEngine)
        {
            bool isMutant = gameEngine.GetRandom().Next(10) < 2;
            Gender g = gameEngine.GetRandom().Next() % 2 == 0 ? Gender.Male : Gender.Female;            
            return new ElkAnimal(gameEngine, isMutant, g);
        }

        private ElkAnimal(IGameEngine gameEngine, bool isMutant, Gender g) : base(gameEngine, GameObjectType.HerbivoreAnimal1, "Elk.xml")
        {
            IsMutant = isMutant;
            Gender = g;
        }
    }
}
