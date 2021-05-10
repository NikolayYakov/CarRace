using CarsRace.Models.Cars.Contracts;
using CarsRace.Models.Drivers.Contracts;
using CarsRace.Models.Drivers.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsRace
{
    public partial class DriverForm : Form
    {
        public IDriver Driver { get;private set; }
        public ICar Car { get;private set; }
        public DriverForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Driver = new Driver(driverName.Text);
            Driver.AddCar(Car);
            Close();
        }

        private void carButton_Click(object sender, EventArgs e)
        {
            var fp = new CarInfoForm();
            if (fp.ShowDialog() == DialogResult.OK)
            {
                Car = fp.Car;
            }
            
        }
    }
}
