using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_siberix.Model
{
    class ListOfCities : IEnumerable
    {
        CityNode root;
        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            CityNode current = root;
            while (current != null)
            {
                yield return current.Distance;
                //current = current.Next;
            }
        }
    }
}
