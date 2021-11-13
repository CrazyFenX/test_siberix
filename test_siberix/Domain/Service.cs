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

        public Service(Repository _repository)
        {
            repository = _repository;
        }

        public void GetOptimalRoute(int _id)
        {
            uint OptimalRoutLength = 0;
            List<int> RouteCitiesIds = new List<int>();

            City inputCity = repository.GetCityById(_id);

            //recursive traversal
            //foreach (CityNode cityNode in inputCity.NearbyCities)
            //{
            List<int>[] resultMass = new List<int>[inputCity.NearbyCities.Count];
            int[] lengthsMass = new int[inputCity.NearbyCities.Count];
            for (int i = 0; i < inputCity.NearbyCities.Count; i++)
            {
                resultMass[i] = new List<int>();
                RecursiveTraversal(inputCity.NearbyCities[i].City, 0, resultMass[i]);
            }
        }

        ReturnStruct RecursiveTraversal(City _currentCity, uint _routeLength, List<int> _citiesIds)
        {
            if (_currentCity.NearbyCities.Count == 0 || _currentCity.IsStock) return new ReturnStruct(_currentCity.Id, _routeLength, _citiesIds.ToArray(), _currentCity.IsStock);
            
            foreach (CityNode cityNode in _currentCity.NearbyCities)
            //for (int i = 0; i < _currentCity.NearbyCities.Count; i++)
            {
                RecursiveTraversal(cityNode.City, _routeLength, _citiesIds);
            }
            
            return new ReturnStruct();
        }
    }

    struct ReturnStruct
    {
        int StockCityId; //required
        uint RouteLength;
        int[] CitiesIds;
        bool IsStock;

        public ReturnStruct(int _stockCityId, uint _routeLength, int[] _citiesIds, bool _isStock)
        {
            StockCityId = _stockCityId;
            RouteLength = _routeLength;
            CitiesIds = _citiesIds;
            IsStock = _isStock;
            MessageBox.Show("Id: " + StockCityId.ToString() + "; RL: " + RouteLength + "; Is Stock: " + IsStock.ToString());
        }
    }
}
