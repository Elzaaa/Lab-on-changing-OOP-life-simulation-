using OOPFirstLab.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirstLab.GameObjects
{
    class TigerAnimal : GameObject
    {
        public static TigerAnimal Create(IGameEngine gameEngine)
        {
            bool isMutant = gameEngine.GetRandom().Next(10) < 2;
            Gender g = gameEngine.GetRandom().Next() % 2 == 0 ? Gender.Male : Gender.Female;
            return new TigerAnimal(gameEngine, isMutant, g);
        }

        private TigerAnimal(IGameEngine gameEngine, bool isMutant, Gender g) : base(gameEngine, GameObjectType.PredatoryAnimal1, "Tiger.xml")
        {
            IsMutant = isMutant;
            Gender = g;
        }
    }
}
