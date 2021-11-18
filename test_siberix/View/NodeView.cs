using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_siberix.View
{
    class NodeView
    {
        public NodeView(int _id, bool _isStock, int _x, int _y)
        {
            Id = _id;
            IsSrock = _isStock;
            X = _x;
            Y = _y;
        }
        public int Id { get; set; }
        public bool IsSrock { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
