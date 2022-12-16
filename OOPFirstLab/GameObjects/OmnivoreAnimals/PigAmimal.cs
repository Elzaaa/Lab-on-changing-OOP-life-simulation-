using OOPFirstLab.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirstLab.GameObjects
{
    class PigAnimal : GameObject
    {
        public static PigAnimal Create(IGameEngine gameEngine)
        {
            bool isMutant = gameEngine.GetRandom().Next(10) < 2;
            Gender g = gameEngine.GetRandom().Next() % 2 == 0 ? Gender.Male : Gender.Female;
            return new PigAnimal(gameEngine, isMutant, g);
        }

        private PigAnimal(IGameEngine gameEngine, bool isMutant, Gender g) : base(gameEngine, GameObjectType.OmnivoreAnimal2, "Pig.xml")
        {
            IsMutant = isMutant;
            Gender = g;
        }
    }
}
