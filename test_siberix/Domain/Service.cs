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
    /// Сервис, организующий основную логшику работы с классом City
    /// </summary>
    class Service
    {
        /// <summary>
        /// Репозиторий для временного хранения и обработки данных
        /// </summary>
        Repository repository;
        
        /// <summary>
        /// Список, который заполняется экземплярами ReturnStruct в процессе рекурсивного обхода графа
        /// </summary>
        List<ReturnStruct> returnStructList = new List<ReturnStruct>();
        
        /// <summary>
        /// Хранит в себе текущее значение минимальной длинны маршрута (изначально равно 0)
        /// </summary>
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
            /*
            Алгоритм представляет собой рекурсивный обход графа.
            Мы выбираем определенный узел и двигаемся по всем дорогам,
            исходящим из этого узла.
            Перейдя в новый узел, снова вызываем метод, но уже для вновь
            открывшихся дорог. Если таких нет или мы оказались в городе
            со складом, рекурсия прерывается.
            */
        }

        /// <summary>
        /// Рекурсивный метод для Brute Force метода
        /// </summary>
        /// <param name="_currentCity"></param>
        /// <param name="_routeLength"></param>
        /// <param name="_citiesIds"></param>
        /// <returns></returns>
        ReturnStruct RecursiveTraversalBruteForce(City _currentCity, uint _routeLength, List<int> _citiesIds)
        {
            if (!_citiesIds.Contains(_currentCity.Id)) _citiesIds.Add(_currentCity.Id);
            if (_currentCity.NearbyCities.Count == 0 || _currentCity.IsStock) return new ReturnStruct(_currentCity.Id, _routeLength, _citiesIds.ToArray(), _currentCity.IsStock);
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
            /*
            Повышение оптимальности достигается тем, что рекурсивный метод вызывается только в том случае,
            если длинна текущего маршрута не привышает минимальную длинну среди уже найденных маршрутов.
            В случае, если маршрут всё ещё претендует на роль оптимального, алгоритм продолжит выполняться,
            Иначе - в итоговый список будет записан незавершенный маршрут (в облике структуры ReturnStruct)
            */
        }

        /// <summary>
        /// Рекурсивный метод для более оптимального метода
        /// </summary>
        /// <param name="_currentCity"></param>
        /// <param name="_routeLength"></param>
        /// <param name="_citiesIds"></param>
        void RecursiveTraversal(City _currentCity, uint _routeLength, List<int> _citiesIds)
        {
            if (!_citiesIds.Contains(_currentCity.Id)) _citiesIds.Add(_currentCity.Id);
            if (_currentCity.IsStock)
            {
                if (_routeLength < dynamicMinimalRouteLength || dynamicMinimalRouteLength == 0) dynamicMinimalRouteLength = _routeLength;
                returnStructList.Add(new ReturnStruct(_currentCity.Id, _routeLength, _citiesIds.ToArray(), _currentCity.IsStock));
                return;
            }
            foreach (CityNode cityNode in _currentCity.NearbyCities)
            {
                if (!_citiesIds.Contains(cityNode.City.Id))
                {
                    uint tempRouteLength = _routeLength + cityNode.Distance;
                    if (tempRouteLength <= dynamicMinimalRouteLength || dynamicMinimalRouteLength == 0)
                    {
                        List<int> tempListIds = new List<int>();
                        tempListIds.AddRange(_citiesIds);
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
            {
                retStr += "Id: " + tempRetStruct.FinalCityId.ToString() + "; Route length: " + tempRetStruct.RouteLength + "; Is stock: " + tempRetStruct.IsStock.ToString() + "; ";
                retStr += "In route cities Ids: ";
                for (int i = 0; i < tempRetStruct.CitiesIds.Length; i++)
                    retStr += tempRetStruct.CitiesIds[i].ToString() + " ";
                retStr += "\n";
            }
            retStr += "\n\n" + "Id: " + optimalRetStruct.FinalCityId.ToString() + "; RL: " + optimalRetStruct.RouteLength + "; Is Stock: " + optimalRetStruct.IsStock.ToString() + "; ";
            return retStr;
        }
    }

    struct ReturnStruct
    {
        /// <summary>
        /// Id финального города маршрута 
        /// </summary>
        public int FinalCityId;

        /// <summary>
        /// Длинна маршрута
        /// </summary>
        public uint RouteLength;

        /// <summary>
        /// Массив городов, которые содержит маршрут
        /// </summary>
        public int[] CitiesIds;

        /// <summary>
        /// Есть ли в финальном городе склад
        /// </summary>
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
