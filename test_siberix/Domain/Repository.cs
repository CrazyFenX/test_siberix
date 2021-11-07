using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_siberix.Model;

namespace test_siberix.Domain
{
    /// <summary>
    /// The service class that orginizing data access
    /// </summary>
    public class Repository
    {
        public Repository()
        {
            Cities = new List<City>();
        }
        /// <summary>
        /// List of Cities
        /// </summary>
        List<City> Cities { get; set; }

        /// <summary>
        /// Add City in the List of Cities
        /// </summary>
        /// <param name="_city"></param>
        public void AddCity(City _city)
        {
            Cities.Add(_city);
        }

        /// <summary>
        /// Remove City from the List of Cities
        /// </summary>
        /// <param name="_city"></param>
        public void RemoveCity(City _city)
        {
            Cities.Remove(_city);
        }

        /// <summary>
        /// Find and return City by id.
        /// Algorithm complexity: O(n)
        /// </summary>
        /// <param name="_id"></param>
        /// <returns></returns>
        public City GetCityById(int _id)
        {
            foreach (City currentCity in Cities)
                if (currentCity.Id == _id) return currentCity;
            return new City(-1, false);
        }

        /// <summary>
        /// Adds a road from the city with id equal to _citySendingId to the city with id equal to _cityArrivalId with distance equal to _distance.
        /// </summary>
        /// <param name="_citySendingId"></param>
        /// <param name="_cityArrivalId"></param>
        /// <param name="_distance"></param>
        public void AddRoad(int _citySendingId, int _cityArrivalId, ushort _distance)
        {
            City citySend = GetCityById(_citySendingId);
            City cityArrival = GetCityById(_cityArrivalId);
            if (citySend.Id == -1) throw new Exception("City with id: " + _citySendingId.ToString() + " was not found!");
            if (cityArrival.Id == -1) throw new Exception("City with id: " + _cityArrivalId.ToString() + " was not found!");

            citySend.NearbyCities.Add(new CityNode(cityArrival, _distance));
        }

        public void RemoveRoad(int _citySendingId, int _cityArrivalId)
        {
            //pass
        }

        public void InitialCities()
        {
            AddCity(new City(1, true));
            AddCity(new City(2, false));
            AddCity(new City(3, true));
        }

        public void InitialRoads()
        {
            
        }
    }
}
