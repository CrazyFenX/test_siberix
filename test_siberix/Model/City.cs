using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_siberix.Model
{
    /// <summary>
    /// Класс города
    /// </summary>
    public class City
    {
        public City(int _id, bool _isStock)
        {
            Id = _id;
            IsStock = _isStock;
            NearbyCities = new List<CityNode>();
        }

        /// <summary>
        /// Id города
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Содержится ли в городе склад 
        /// </summary>
        public bool IsStock { get; set; }

        /// <summary>
        /// Список городов, соединенных с данным дорогой напрямую
        /// </summary>
        public List<CityNode> NearbyCities { get; set; }

        public override string ToString()
        {
            string retStr = "City " + this.Id + " is Stock: " + this.IsStock.ToString() + "\n";
            foreach (CityNode cityNode in NearbyCities) retStr += "    " + cityNode.ToString() + "\n";
            return retStr;
        }
    }
}
