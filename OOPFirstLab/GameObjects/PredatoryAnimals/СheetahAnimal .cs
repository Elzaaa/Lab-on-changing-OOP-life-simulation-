using OOPFirstLab.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirstLab.GameObjects
{
    class CheetahAnimal : GameObject
    {
        public static CheetahAnimal Create(IGameEngine gameEngine)
        {
            bool isMutant = gameEngine.GetRandom().Next(10) < 2;
            Gender g = gameEngine.GetRandom().Next() % 2 == 0 ? Gender.Male : Gender.Female;
            return new CheetahAnimal(gameEngine, isMutant, g);
        }

        private CheetahAnimal(IGameEngine gameEngine, bool isMutant, Gender g) : base(gameEngine, GameObjectType.HerbivoreAnimal1, "PredatoryAnimal3.xml")
        {
            IsMutant = isMutant;
            Gender = g;
        }
    }
}
