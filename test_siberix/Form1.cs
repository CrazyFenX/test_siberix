using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test_siberix.Domain;
using test_siberix.Model;

namespace test_siberix
{
    public partial class Form1 : Form
    {
        Repository repository;
        Service service;
        DrawService drawService;

        public Form1()
        {
            repository = new Repository();
            service = new Service(repository);
            InitializeComponent();
            drawService = new DrawService(graphPictureBox.Width, graphPictureBox.Height);
        }

        public void InitialCities()
        {
            repository.AddCity(new City(1, false));
            repository.AddCity(new City(2, true));
            repository.AddCity(new City(3, true));
            repository.AddCity(new City(4, false));
            repository.AddCity(new City(5, false));
            repository.AddCity(new City(6, true));
            repository.AddCity(new City(7, false));
            repository.AddCity(new City(8, false));
            repository.AddCity(new City(9, true));
        }

        public void InitialRoads()
        {
            try
            {
                repository.AddRoad(1, 2, 15);
                repository.AddRoad(2, 1, 15);

                repository.AddRoad(1, 3, 20);
                repository.AddRoad(3, 1, 20);

                repository.AddRoad(3, 4, 10);
                repository.AddRoad(4, 3, 10);

                repository.AddRoad(4, 5, 15);
                repository.AddRoad(5, 4, 15);

                repository.AddRoad(5, 6, 26);
                repository.AddRoad(6, 5, 26);

                repository.AddRoad(5, 7, 10);
                repository.AddRoad(7, 5, 10);

                repository.AddRoad(5, 8, 5);
                repository.AddRoad(8, 5, 5);

                repository.AddRoad(8, 9, 19);
                repository.AddRoad(9, 8, 19);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void newCityButton_Click(object sender, EventArgs e)
        {
            newCityButton.Enabled = false;
            isStockCheckBox.Enabled = true;
        }

        private void newRoadButton_Click(object sender, EventArgs e)
        {
            newCityButton.Enabled = true;
            isStockCheckBox.Enabled = false;
            try
            {
                if (repository.GetCityById((int)IdFirstNumericUpDown.Value).Id != -1 && repository.GetCityById((int)IdSecondNumericUpDown.Value).Id != -1 && (int)distanceNumericUpDown.Value > 0)
                {
                    repository.AddRoad((int)IdFirstNumericUpDown.Value, (int)IdSecondNumericUpDown.Value, (ushort)distanceNumericUpDown.Value);
                    repository.AddRoad((int)IdSecondNumericUpDown.Value, (int)IdFirstNumericUpDown.Value, (ushort)distanceNumericUpDown.Value);
                    drawService.EdgeViewList.Add(new View.EdgeView((int)IdFirstNumericUpDown.Value, (int)IdSecondNumericUpDown.Value, (ushort)distanceNumericUpDown.Value));
                }
                else
                {
                    MessageBox.Show("Один из городов или оба не найдены");
                }

                drawService.clearSheet();
                drawService.drawALLGraph();
                graphPictureBox.Image = drawService.GetBitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetRepositoryInfo_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(repository.ToString());
        }

        private void InitialData_Button_Click(object sender, EventArgs e)
        {
            try
            {
                InitialCities();
                InitialRoads();
                drawService.clearSheet();
                drawService.InitialGraph(repository.Cities);
                drawService.drawALLGraph();
                graphPictureBox.Image = drawService.GetBitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetOptimalRoute_button_Click(object sender, EventArgs e)
        {
            try
            {
                service.GetOptimalRouteBruteForce(Convert.ToInt32(targetCityIdNumericUpDown.Value));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetOptimalRouteOptimal_button_Click(object sender, EventArgs e)
        {
            try
            {
                service.GetOptimalRoute(Convert.ToInt32(targetCityIdNumericUpDown.Value));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void graphPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (!newCityButton.Enabled)
            {
                try
                {
                    int tmpId = repository.Cities.Count + 1;
                    repository.AddCity(new City(tmpId, isStockCheckBox.Checked));
                    drawService.NodeViewList.Add(new View.NodeView(tmpId, isStockCheckBox.Checked, e.X, e.Y));

                    drawService.clearSheet();
                    drawService.drawALLGraph();
                    graphPictureBox.Image = drawService.GetBitmap();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            newCityButton.Enabled = true;
            isStockCheckBox.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            newCityButton.Enabled = true;
            isStockCheckBox.Enabled = false;
        }
    }
}
