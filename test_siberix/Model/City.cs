using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_siberix.Model
{
    public class City
    {
        public City()
        {
            NearbyCities = new List<CityNode>();
        }

        public City(int _id, bool _isStock)
        {
            Id = _id;
            IsStock = _isStock;
            NearbyCities = new List<CityNode>();
        }
        public int Id { get; set; }
        public bool IsStock { get; set; }
        public List<CityNode> NearbyCities { get; set; }

        public override string ToString()
        {
            string retStr = "City " + this.Id + " is Stock: " + this.IsStock.ToString() + "\n";
            foreach (CityNode cityNode in NearbyCities) retStr += "    " + cityNode.ToString() + "\n";
            return retStr;
        }
    }
}
