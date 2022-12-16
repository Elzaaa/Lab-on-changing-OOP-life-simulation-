using OOPFirstLab.Common;
using OOPFirstLab.GameObjectDescriptors;

namespace OOPFirstLab.GameObjects
{
    public class GameObjectFactory
    {
        IGameEngine _gameEngine;

        public GameObjectFactory(IGameEngine gameEngine)
        {
            _gameEngine = gameEngine;
        }

        public IGameObject CreateGameObject(GameObjectType type)
        {
            IGameObject result = null;
            switch (type)
            {
                case GameObjectType.Fruit1:
                    result = new CarrotPlant(_gameEngine);
                    break;
                case GameObjectType.Fruit2:
                    result = new FruitPlant(_gameEngine);
                    break;
                case GameObjectType.Fruit3:
                    result = new GrassPlant(_gameEngine);
                    break;
                case GameObjectType.HerbivoreAnimal1:
                    result = ElkAnimal.Create(_gameEngine);
                    break;
                case GameObjectType.HerbivoreAnimal2:
                    result = DeerAnimal.Create(_gameEngine);
                    break;
                case GameObjectType.HerbivoreAnimal3:
                    result = RabbitAnimal.Create(_gameEngine);
                    break;
                case GameObjectType.OmnivoreAnimal1:
                    result = BearAnimal.Create(_gameEngine);
                    break;
                case GameObjectType.OmnivoreAnimal2:
                    result = PigAnimal.Create(_gameEngine);
                    break;
                case GameObjectType.OmnivoreAnimal3:
                    result = RaccoonAnimal.Create(_gameEngine);
                    break;
                case GameObjectType.PredatoryAnimal1:
                    result = TigerAnimal.Create(_gameEngine);
                    break;
                case GameObjectType.PredatoryAnimal2:
                    result = WolfAnimal.Create(_gameEngine);
                    break;
                case GameObjectType.PredatoryAnimal3:
                    result = CheetahAnimal.Create(_gameEngine);
                    break;
                case GameObjectType.Human:
                    result = Human.Create(_gameEngine);
                    break;
                case GameObjectType.House:
                    result = new House(_gameEngine);
                    break;
            }

            return result;
        }
    }
}
