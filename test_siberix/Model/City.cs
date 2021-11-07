using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_siberix.Model
{
    public class City
    {
        public int Id { get; set; }
        public bool IsStock { get; set; }
        public List<CityNode> NearbyCities { get; set; }

        public City(int _id, bool _isStock)
        {
            Id = _id;
            IsStock = _isStock;
        }
    }
}
