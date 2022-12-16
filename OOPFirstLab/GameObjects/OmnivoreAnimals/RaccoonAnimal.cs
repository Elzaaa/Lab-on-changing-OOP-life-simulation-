using OOPFirstLab.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirstLab.GameObjects
{
    class RaccoonAnimal : GameObject 
    {
        public static RaccoonAnimal Create(IGameEngine gameEngine)
        {
            bool isMutant = gameEngine.GetRandom().Next(10) < 2;
            Gender g = gameEngine.GetRandom().Next() % 2 == 0 ? Gender.Male : Gender.Female;
            return new RaccoonAnimal(gameEngine, isMutant, g);
        }

        private RaccoonAnimal(IGameEngine gameEngine, bool isMutant, Gender g) : base(gameEngine, GameObjectType.OmnivoreAnimal3, "Raccoon.xml")
        {
            IsMutant = isMutant;
            Gender = g;
        }
    }
}
