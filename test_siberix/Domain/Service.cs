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
        uint dynamicMinimalRouteLength = 0;

        public Service(Repository _repository)
        {
            repository = _repository;
        }

        /// <summary>
        /// Brute Force method
        /// </summary>
        /// <param name="_id"></param>
        /// <returns></returns>
        public ReturnStruct GetOptimalRouteBruteForce(int _id)
        {
            List<int> RouteCitiesIds = new List<int>();
            City inputCity = repository.GetCityById(_id);
            returnStructList = new List<ReturnStruct>();

            RecursiveTraversalBruteForce(inputCity, 0, RouteCitiesIds);

            uint OptimalRoutLength = returnStructList[0].RouteLength;
            ReturnStruct OptimalRetStruct = new ReturnStruct();

            foreach (ReturnStruct tempRetStruct in returnStructList)
            {
                if (tempRetStruct.IsStock && tempRetStruct.RouteLength <= OptimalRoutLength)
                    OptimalRetStruct = tempRetStruct;
            }
            MessageBox.Show(GetReturnStructListString(returnStructList, OptimalRetStruct));
            return OptimalRetStruct;
        }

        ReturnStruct RecursiveTraversalBruteForce(City _currentCity, uint _routeLength, List<int> _citiesIds)
        {
            if (_currentCity.NearbyCities.Count == 0 || _currentCity.IsStock) return new ReturnStruct(_currentCity.Id, _routeLength, _citiesIds.ToArray(), _currentCity.IsStock);
            if (!_citiesIds.Contains(_currentCity.Id)) _citiesIds.Add(_currentCity.Id);
            foreach (CityNode cityNode in _currentCity.NearbyCities)
            {
                if (!_citiesIds.Contains(cityNode.City.Id))
                {
                    uint tempRouteLength = _routeLength + cityNode.Distance;
                    List<int> tempListIds = new List<int>();
                    tempListIds.AddRange(_citiesIds);
                    returnStructList.Add(RecursiveTraversalBruteForce(cityNode.City, tempRouteLength, tempListIds));
                }
            }
            return new ReturnStruct(_currentCity.Id, _routeLength, _citiesIds.ToArray(), _currentCity.IsStock);
        }

        /// <summary>
        /// More optimal method
        /// </summary>
        /// <param name="_id"></param>
        /// <returns></returns>
        public ReturnStruct GetOptimalRoute(int _id)
        {
            List<int> RouteCitiesIds = new List<int>();
            City inputCity = repository.GetCityById(_id);
            returnStructList = new List<ReturnStruct>();
            dynamicMinimalRouteLength = 0;

            RecursiveTraversal(inputCity, 0, RouteCitiesIds);

            uint OptimalRoutLength = returnStructList[0].RouteLength;
            ReturnStruct OptimalRetStruct = new ReturnStruct();

            foreach (ReturnStruct tempRetStruct in returnStructList)
            {
                if (tempRetStruct.IsStock && tempRetStruct.RouteLength <= OptimalRoutLength)
                    OptimalRetStruct = tempRetStruct;
            }
            MessageBox.Show(GetReturnStructListString(returnStructList, OptimalRetStruct));
            return OptimalRetStruct;
        }

        void RecursiveTraversal(City _currentCity, uint _routeLength, List<int> _citiesIds)
        {
            if (_currentCity.IsStock)
            {
                if (_routeLength < dynamicMinimalRouteLength || dynamicMinimalRouteLength == 0) dynamicMinimalRouteLength = _routeLength;
                //return new ReturnStruct(_currentCity.Id, _routeLength, _citiesIds.ToArray(), _currentCity.IsStock);
                returnStructList.Add(new ReturnStruct(_currentCity.Id, _routeLength, _citiesIds.ToArray(), _currentCity.IsStock));
                return;
            }
            if (!_citiesIds.Contains(_currentCity.Id)) _citiesIds.Add(_currentCity.Id);
            foreach (CityNode cityNode in _currentCity.NearbyCities)
            {
                if (!_citiesIds.Contains(cityNode.City.Id))
                {
                    uint tempRouteLength = _routeLength + cityNode.Distance;
                    if (tempRouteLength <= dynamicMinimalRouteLength || dynamicMinimalRouteLength == 0)
                    {
                        List<int> tempListIds = new List<int>();
                        tempListIds.AddRange(_citiesIds);
                        //returnStructList.Add(RecursiveTraversal(cityNode.City, tempRouteLength, tempListIds));
                        RecursiveTraversal(cityNode.City, tempRouteLength, tempListIds);
                    }
                }
            }
        }

        public static string GetReturnStructListString(List<ReturnStruct> returnStructList, ReturnStruct optimalRetStruct)
        {
            if (returnStructList == null) return("graph reference is null");
            string retStr = "";
            foreach (ReturnStruct tempRetStruct in returnStructList)
                retStr += "Id: " + tempRetStruct.FinalCityId.ToString() + "; Route length: " + tempRetStruct.RouteLength + "; Is stock: " + tempRetStruct.IsStock.ToString() + "\n";
            retStr += "\n\n" + "Id: " + optimalRetStruct.FinalCityId.ToString() + "; RL: " + optimalRetStruct.RouteLength + "; Is Stock: " + optimalRetStruct.IsStock.ToString(); ;
            return retStr;
        }
    }

    struct ReturnStruct
    {
        public int FinalCityId; //required
        public uint RouteLength;
        public int[] CitiesIds;
        public bool IsStock;

        public ReturnStruct(int _stockCityId, uint _routeLength, int[] _citiesIds, bool _isStock)
        {
            FinalCityId = _stockCityId;
            RouteLength = _routeLength;
            CitiesIds = _citiesIds;
            IsStock = _isStock;
        }
    }
}
