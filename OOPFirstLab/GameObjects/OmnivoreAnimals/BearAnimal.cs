using OOPFirstLab.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirstLab.GameObjects
{
    class BearAnimal : GameObject
    {
        public static BearAnimal Create(IGameEngine gameEngine)
        {
            bool isMutant = gameEngine.GetRandom().Next(10) < 2;
            Gender g = gameEngine.GetRandom().Next() % 2 == 0 ? Gender.Male : Gender.Female;
            return new BearAnimal(gameEngine, isMutant, g);
        }

        private BearAnimal(IGameEngine gameEngine, bool isMutant, Gender g) : base(gameEngine, GameObjectType.OmnivoreAnimal1, "Bear.xml")
        {
            IsMutant = isMutant;
            Gender = g;
        }
    }
}
