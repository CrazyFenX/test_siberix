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
        Repository repository = new Repository();
        public Form1()
        {
            InitializeComponent();
        }

        public void InitialCities()
        {
            repository.AddCity(new City(1, true));
            repository.AddCity(new City(2, false));
            repository.AddCity(new City(3, true));
        }

        public void InitialRoads()
        {
            repository.AddRoad(1, 2, 15);
            repository.AddRoad(1, 3, 20);
            repository.AddRoad(2, 1, 15);
        }

    }
}
