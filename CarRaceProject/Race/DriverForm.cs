using CarsRace.Models.Cars.Contracts;
using CarsRace.Models.Drivers.Contracts;
using CarsRace.Models.Drivers.Entities;
using CarsRace.Models.Races.Contracts;
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
        public IRace Race { get; set; }
        public DriverForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                 
                Driver = new Driver(driverName.Text);
                Driver.AddCar(Car);
                var existingDriver = Race.Drivers.FirstOrDefault(d => d.Name == driverName.Text);
                if (existingDriver != null)
                {
                    throw new Exception($"Driver {driverName.Text} is already added in {Race.Name} race.");
                }
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
            
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
