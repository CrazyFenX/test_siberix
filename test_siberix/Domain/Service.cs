using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test_siberix.Model;

namespace test_siberix.Domain
{
    /// <summary>
    /// Service class that describes basic City Class processing algorithms
    /// </summary>
    class Service
    {
        Repository repository;
        List<ReturnStruct> returnStructList = new List<ReturnStruct>();

        public Service(Repository _repository)
        {
            repository = _repository;
        }

        public ReturnStruct GetOptimalRoute(int _id)
        {
            List<int> RouteCitiesIds = new List<int>();

            City inputCity = repository.GetCityById(_id);
            returnStructList = new List<ReturnStruct>();

            RecursiveTraversal(inputCity, 0, RouteCitiesIds);

            string retStr = "";
            uint OptimalRoutLength = returnStructList[0].RouteLength;
            ReturnStruct OptimalRetStruct = new ReturnStruct();

            foreach (ReturnStruct tempRetStruct in returnStructList)
            {
                retStr += "Id: " + tempRetStruct.StockCityId.ToString() + "; RL: " + tempRetStruct.RouteLength + "; Is Stock: " + tempRetStruct.IsStock.ToString() + "\n";
                if (tempRetStruct.IsStock && tempRetStruct.RouteLength <= OptimalRoutLength)
                {
                    //OptimalRoutLength = tempRetStruct.RouteLength;
                    OptimalRetStruct = tempRetStruct;
                }
            }
            retStr += "\n\n";
            retStr += "Id: " + OptimalRetStruct.StockCityId.ToString() + "; RL: " + OptimalRetStruct.RouteLength + "; Is Stock: " + OptimalRetStruct.IsStock.ToString();

            MessageBox.Show(retStr);

            return OptimalRetStruct;
        }

        ReturnStruct RecursiveTraversal(City _currentCity, uint _routeLength, List<int> _citiesIds)
        {
            if (_currentCity.NearbyCities.Count == 0 || _currentCity.IsStock) return new ReturnStruct(_currentCity.Id, _routeLength, _citiesIds.ToArray(), _currentCity.IsStock);
            
            if (!_citiesIds.Contains(_currentCity.Id)) _citiesIds.Add(_currentCity.Id);
            
            foreach (CityNode cityNode in _currentCity.NearbyCities)
            //for (int i = 0; i < _currentCity.NearbyCities.Count; i++)
            {
                if (!_citiesIds.Contains(cityNode.City.Id))
                {
                    uint tempRouteLength = _routeLength + cityNode.Distance;
                    List<int> tempListIds = new List<int>();
                    tempListIds.AddRange(_citiesIds);
                    //tempListIds.Add(cityNode.City.Id);
                    returnStructList.Add(RecursiveTraversal(cityNode.City, tempRouteLength, tempListIds));
                }
            }
            
            return new ReturnStruct();
        }
    }

    struct ReturnStruct
    {
        public int StockCityId; //required
        public uint RouteLength;
        public int[] CitiesIds;
        public bool IsStock;

        public ReturnStruct(int _stockCityId, uint _routeLength, int[] _citiesIds, bool _isStock)
        {
            StockCityId = _stockCityId;
            RouteLength = _routeLength;
            CitiesIds = _citiesIds;
            IsStock = _isStock;
            //MessageBox.Show(StockCityId.ToString() + "; RL: " + RouteLength + "; Is Stock: " + IsStock.ToString());
        }
    }
}
