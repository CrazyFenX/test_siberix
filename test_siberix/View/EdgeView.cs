using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_siberix.View
{
    class EdgeView
    {
        public int NodeId1 { get; set; }
        public int NodeId2 { get; set; }
        public ushort Distance { get; set; }

        public EdgeView(int _nodeId1, int _nodeId2, ushort _distance)
        {
            NodeId1 = _nodeId1;
            NodeId2 = _nodeId2;
            Distance = _distance;
        }
    }
}
