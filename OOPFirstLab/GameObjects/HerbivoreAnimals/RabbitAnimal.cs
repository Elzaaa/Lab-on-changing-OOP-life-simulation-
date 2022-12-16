using OOPFirstLab.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirstLab.GameObjects
{
    class RabbitAnimal : GameObject
    {
        public static RabbitAnimal Create(IGameEngine gameEngine)
        {
            bool isMutant = gameEngine.GetRandom().Next(10) < 2;
            Gender g = gameEngine.GetRandom().Next() % 2 == 0 ? Gender.Male : Gender.Female;
            return new RabbitAnimal(gameEngine, isMutant, g);
        }

        private RabbitAnimal(IGameEngine gameEngine, bool isMutant, Gender g) : base(gameEngine, GameObjectType.HerbivoreAnimal3, "Rabbit.xml")
        {
            IsMutant = isMutant;
            Gender = g;
        }
    }
}
