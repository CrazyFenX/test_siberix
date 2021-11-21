using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test_siberix.Model;
using test_siberix.View;

namespace test_siberix.Domain
{
    class DrawService
    {
        Bitmap bitmap;
        Pen blackPen;
        Pen redPen;
        Pen darkGoldPen;
        Graphics gr;
        Font fo;
        Brush br;
        PointF point;
        public int R = 20; //радиус окружности вершины

        public List<NodeView> NodeViewList;
        public List<EdgeView> EdgeViewList;

        public DrawService(int width, int height)
        {
            bitmap = new Bitmap(width, height);
            gr = Graphics.FromImage(bitmap);
            ClearSheet();
            blackPen = new Pen(Color.Black);
            blackPen.Width = 2;
            redPen = new Pen(Color.Red);
            redPen.Width = 5;
            darkGoldPen = new Pen(Color.DarkGoldenrod);
            darkGoldPen.Width = 2;
            fo = new Font("Arial", 15);
            br = Brushes.Black;
        }

        public Bitmap GetBitmap()
        {
            return bitmap;
        }

        public void ClearSheet()
        {
            gr.Clear(Color.White);
        }

        public void DrawVertex(NodeView _inputNode)
        {
            var brush = Brushes.White;
            if (_inputNode.IsSrock) brush = Brushes.Orange;
            gr.FillEllipse(brush, (_inputNode.X - R), (_inputNode.Y - R), 2 * R, 2 * R);
            gr.DrawEllipse(blackPen, (_inputNode.X - R), (_inputNode.Y - R), 2 * R, 2 * R);
            point = new PointF(_inputNode.X - R/2 + 1, _inputNode.Y - R / 2 + 1);
            gr.DrawString(_inputNode.Id.ToString(), fo, br, point);
        }

        public void DrawSelectedVertex(int x, int y)
        {
            gr.DrawEllipse(redPen, (x - R), (y - R), 2 * R, 2 * R);
        }

        public void DrawEdge(EdgeView _inputEdge, Pen _pen) //TODO: упростить вызов метода, уменьшив количество параметров
        {
            //gr.DrawLine(darkGoldPen, V1.X, V1.Y, V2.X, V2.Y);
            //point = new PointF((V1.X + V2.X) / 2, (V1.Y + V2.Y) / 2);
            //gr.DrawString(E.Distance.ToString(), fo, br, point);

            gr.DrawLine(darkGoldPen, NodeViewList[_inputEdge.NodeId1 - 1].X, NodeViewList[_inputEdge.NodeId1 - 1].Y, NodeViewList[_inputEdge.NodeId2 - 1].X, NodeViewList[_inputEdge.NodeId2 - 1].Y);
            point = new PointF((NodeViewList[_inputEdge.NodeId1 - 1].X + NodeViewList[_inputEdge.NodeId2 - 1].X) / 2, (NodeViewList[_inputEdge.NodeId1 - 1].Y + NodeViewList[_inputEdge.NodeId2 - 1].Y) / 2);
            gr.DrawString(_inputEdge.Distance.ToString(), fo, br, point);

            DrawVertex(NodeViewList[_inputEdge.NodeId1 - 1]);
            DrawVertex(NodeViewList[_inputEdge.NodeId2 - 1]);
        }

        public void DrawALLGraph()
        {
            //рисуем ребра
            //for (int i = 0; i < EdgeViewList.Count; i++)
            foreach(var edgeItem in EdgeViewList)
            {
                //gr.DrawLine(darkGoldPen, NodeViewList[EdgeViewList[i].NodeId1 - 1].X, NodeViewList[EdgeViewList[i].NodeId1 - 1].Y, NodeViewList[EdgeViewList[i].NodeId2 - 1].X, NodeViewList[EdgeViewList[i].NodeId2 - 1].Y);
                //point = new PointF((NodeViewList[EdgeViewList[i].NodeId1 - 1].X + NodeViewList[EdgeViewList[i].NodeId2 - 1].X) / 2, (NodeViewList[EdgeViewList[i].NodeId1 - 1].Y + NodeViewList[EdgeViewList[i].NodeId2 - 1].Y) / 2);
                //gr.DrawString(EdgeViewList[i].Distance.ToString(), fo, br, point);
                DrawEdge(edgeItem, darkGoldPen);
            }
            //рисуем вершины
            foreach(var nodeItem in NodeViewList)
            {
                DrawVertex(nodeItem);
            }
        }

        internal void InitialGraph(List<City> cities)
        {
            int tmpX = 0;
            NodeViewList = new List<NodeView>();
            EdgeViewList = new List<EdgeView>();
            int tmpCoordSlide = 1;
            foreach (var cityItem in cities)
            {
                NodeViewList.Add(new NodeView(cityItem.Id, cityItem.IsStock, tmpX += (bitmap.Width - 20) / cities.Count, (bitmap.Height - 20) / cities.Count * tmpCoordSlide));
                tmpCoordSlide = cityItem.NearbyCities.Count;
                foreach (var cityNodeItem in cityItem.NearbyCities)
                {
                    EdgeViewList.Add(new EdgeView(cityItem.Id, cityNodeItem.City.Id, cityNodeItem.Distance));
                }
            }
        }

        public void DrawRoute(int[] inputCityIds)
        {
            for (int i = 1; i < inputCityIds.Length; i++)
            {
                gr.DrawLine(redPen, NodeViewList[inputCityIds[i] - 1].X, NodeViewList[inputCityIds[i] - 1].Y, NodeViewList[inputCityIds[i - 1] - 1].X, NodeViewList[inputCityIds[i - 1] - 1].Y);
            }
        }
    }
}
