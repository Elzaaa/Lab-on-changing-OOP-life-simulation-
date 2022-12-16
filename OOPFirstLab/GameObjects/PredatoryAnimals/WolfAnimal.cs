using OOPFirstLab.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirstLab.GameObjects
{
    class WolfAnimal : GameObject
    {
        public static WolfAnimal Create(IGameEngine gameEngine)
        {
            bool isMutant = gameEngine.GetRandom().Next(10) < 2;
            Gender g = gameEngine.GetRandom().Next() % 2 == 0 ? Gender.Male : Gender.Female;
            return new WolfAnimal(gameEngine, isMutant, g);
        }

        private WolfAnimal(IGameEngine gameEngine, bool isMutant, Gender g) : base(gameEngine, GameObjectType.PredatoryAnimal2, "Wolf.xml")
        {
            IsMutant = isMutant;
            Gender = g;
        }
    }
}
