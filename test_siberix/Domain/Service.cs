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
            uint OptimalRoutLength = 0;
            List<int> RouteCitiesIds = new List<int>();

            City inputCity = repository.GetCityById(_id);
            returnStructList = new List<ReturnStruct>();

            if (inputCity.IsStock) return new ReturnStruct(inputCity.Id, OptimalRoutLength, RouteCitiesIds.ToArray(), inputCity.IsStock);

            List<int>[] resultMass = new List<int>[inputCity.NearbyCities.Count];
            uint[] lengthsMass = new uint[inputCity.NearbyCities.Count];
            for (int i = 0; i < inputCity.NearbyCities.Count; i++)
            {
                resultMass[i] = new List<int>();
                lengthsMass[i] = inputCity.NearbyCities[i].Distance;
                returnStructList.Add(RecursiveTraversal(inputCity.NearbyCities[i].City, lengthsMass[i], resultMass[i]));
            }

            string retStr = "";
            foreach (ReturnStruct tempRetStruct in returnStructList)
            {
                retStr += "Id: " + tempRetStruct.StockCityId.ToString() + "; RL: " + tempRetStruct.RouteLength + "; Is Stock: " + tempRetStruct.IsStock.ToString();
            }

            MessageBox.Show(retStr);

            return new ReturnStruct(inputCity.Id, OptimalRoutLength, RouteCitiesIds.ToArray(), inputCity.IsStock);
            //TODO #1: Cделать общий случай для поиска через рекурсию.
            //TODO #2: Рекурсия возвращает ReturnStruct и записывает
            //результат в статический List, из которого позже будет выбираться итоговый результат
        }

        ReturnStruct RecursiveTraversal(City _currentCity, uint _routeLength, List<int> _citiesIds)
        {
            if (_currentCity.NearbyCities.Count == 0 || _currentCity.IsStock) return new ReturnStruct(_currentCity.Id, _routeLength, _citiesIds.ToArray(), _currentCity.IsStock);
            
            foreach (CityNode cityNode in _currentCity.NearbyCities)
            //for (int i = 0; i < _currentCity.NearbyCities.Count; i++)
            {
                returnStructList.Add(RecursiveTraversal(cityNode.City, _routeLength, _citiesIds));
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
            MessageBox.Show(StockCityId.ToString() + "; RL: " + RouteLength + "; Is Stock: " + IsStock.ToString());

        }
    }
}
