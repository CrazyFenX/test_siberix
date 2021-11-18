using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_siberix.Model
{
    /// <summary>
    /// Класс представляющий дорогу (название не очень подходит)
    /// </summary>
    public class CityNode
    {
        public CityNode(City _city, ushort _distance)
        {
            City = _city;
            Distance = _distance;
        }

        /// <summary>
        /// Город, в который ведет дорога
        /// </summary>
        public City City { get; set; }
        
        /// <summary>
        /// Протяженность дороги
        /// </summary>
        public ushort Distance { get; set; } //ushort так как максимальное значение ushort превышает длинну экватора => достаточно
        
        public override string ToString()
        {
            return City.Id.ToString() + " " + Distance.ToString();
        }
    }
}
