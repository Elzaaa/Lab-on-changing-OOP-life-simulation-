using OOPFirstLab.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace OOPFirstLab.GameObjectDescriptors
{
    /// <summary>
    /// Описание класса игрового объекта
    /// </summary>
    public class GameObjectDescriptor
    {
        public GameObjectDescriptor(GameObjectType type, string xmlDescriptor)
        {
            Type = type;

            string fileName = Path.Combine("GameObjectDescriptors", "XML", xmlDescriptor);

            // реализовать логику загрузки из переданного xml файла
            XDocument doc = XDocument.Load(fileName);
            XElement root = doc?.Element("ObjectDescriptor");
            CanBeMutant = ParseCanBeMutant(root?.Element("Type"));
            HasGender = ParseHasGender(root?.Element("HasGender"));
            CanMove = ParseCanMove(root?.Element("CanMove"));
            MaxHealth = ParseMaxHealth(root?.Element("MaxHealth"));
            CanBreed = ParseCanBreed(root?.Element("CanBreed"));
            MaxBreedTimer = ParseMaxBreedTimer(root?.Element("MaxBreedTimer"));
            Food = ParseFood(root?.Element("Food"));
            NewObjectPlacement = ParseNewObjectPlacement(root?.Element("NewObjectPlacement"));
            CanJump = ParseCanJump(root?.Element("CanJump"));
        }

        /// <summary>
        /// Тип этого объекта
        /// </summary>
        public GameObjectType Type { get; private set; } = GameObjectType.Undefined;

        /// <summary>
        /// Может ли объект мутировать при рождении (пока что это влияет только на количество максимального здоровья)
        /// </summary>
        public bool CanBeMutant { get; private set; } = false;

        /// <summary>
        /// Есть ли пол и соответственно нужен ли партнёр для размножения
        /// </summary>
        public bool HasGender { get; private set; } = false;

        /// <summary>
        /// Может ли объект данного типа двигаться
        /// </summary>
        public bool CanMove { get; private set; } = false;

        /// <summary>
        /// Есть ли здоровье у объекта и его максимальное значение. Соответственно 
        /// если максимальное здоровье больше 0 то объект может умереть от голода
        /// </summary>
        public int MaxHealth { get; private set; } = 0;

        /// <summary>
        /// Может ли объект размножаться
        /// </summary>
        public bool CanBreed { get; private set; } = false;

        /// <summary>
        /// Сколько времени должно пройти между размножениями
        /// </summary>
        public int MaxBreedTimer { get; private set; } = 0;

        /// <summary>
        /// Список объектов, которые данный объект может съесть
        /// </summary>
        public List<GameObjectType> Food { get; private set; } = new List<GameObjectType>();

        /// <summary>
        /// Позиция, в которую будет размещен новый объект при размножении
        /// </summary>
        public NewObjectPlacement NewObjectPlacement { get; private set; } = NewObjectPlacement.NeighborFreeCell;

        public bool CanJump { get; private set; } = false;

        private GameObjectType ParseType(XElement element)
        {
            GameObjectType result;
            try
            {
                result = (GameObjectType)Enum.Parse(typeof(GameObjectType), element?.Value);
            }
            catch (Exception)
            {
                result = GameObjectType.Undefined;
            }

            return result;
        }

        private bool ParseCanBeMutant(XElement element)
        {
            bool result;
            try
            {
                result = bool.Parse(element?.Value);
            }
            catch (Exception)
            {
                result = false;
            }

            return result;
        }

        private List<GameObjectType> ParseFood(XElement element)
        {
            List<GameObjectType> result = new List<GameObjectType>();
            var foodTypeElems = element?.Elements("Type");
            if (foodTypeElems != null)
            {
                foreach (XElement foodTypeElem in foodTypeElems)
                {
                    GameObjectType food = ParseType(foodTypeElem);
                    if (food != GameObjectType.Undefined)
                        result.Add(food);
                }
            }

            return result;
        }

        private bool ParseHasGender(XElement element)
        {
            bool result;
            try
            {
                result = bool.Parse(element?.Value);
            }
            catch (Exception)
            {
                result = false;
            }

            return result;
        }

        private bool ParseCanMove(XElement element)
        {
            bool result;
            try
            {
                result = bool.Parse(element?.Value);
            }
            catch (Exception)
            {
                result = false;
            }

            return result;
        }

        private int ParseMaxHealth(XElement element)
        {
            int result;
            try
            {
                result = int.Parse(element?.Value);
            }
            catch (Exception)
            {
                result = 0;
            }

            return result;
        }

        private bool ParseCanBreed(XElement element)
        {
            bool result;
            try
            {
                result = bool.Parse(element?.Value);
            }
            catch (Exception)
            {
                result = false;
            }

            return result;
        }

        private int ParseMaxBreedTimer(XElement element)
        {
            int result;
            try
            {
                result = int.Parse(element?.Value);
            }
            catch (Exception)
            {
                result = 0;
            }

            return result;
        }

        private NewObjectPlacement ParseNewObjectPlacement(XElement element)
        {
            NewObjectPlacement result;
            try
            {
                result = (NewObjectPlacement)Enum.Parse(typeof(NewObjectPlacement), element?.Value);
            }
            catch (Exception)
            {
                throw new NotImplementedException();;
            }

            return result;
        }

        private bool ParseCanJump(XElement element)
        {
            bool result;
            try
            {
                result = bool.Parse(element?.Value);
            }
            catch (Exception)
            {
                result = false;
            }

            return result;
        }
    }
}