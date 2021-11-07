using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_siberix.Model
{
    public class CityNode
    {
        public City City { get; set; }
        public ushort Distance { get; set; }

        public CityNode(City _city, ushort _distance)
        {
            City = _city;
            Distance = _distance;
        }
    }
}
