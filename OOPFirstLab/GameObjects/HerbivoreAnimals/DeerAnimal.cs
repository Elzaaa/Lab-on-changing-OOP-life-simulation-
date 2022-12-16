using OOPFirstLab.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirstLab.GameObjects
{
    class DeerAnimal : GameObject
    {
        public static DeerAnimal Create(IGameEngine gameEngine)
        {
            bool isMutant = gameEngine.GetRandom().Next(10) < 2;
            Gender g = gameEngine.GetRandom().Next() % 2 == 0 ? Gender.Male : Gender.Female;
            return new DeerAnimal(gameEngine, isMutant, g);
        }

        private DeerAnimal(IGameEngine gameEngine, bool isMutant, Gender g) : base(gameEngine, GameObjectType.HerbivoreAnimal2, "Deer.xml")
        {
            IsMutant = isMutant;
            Gender = g;
        }
    }
}
