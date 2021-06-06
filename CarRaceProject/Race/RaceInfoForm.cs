using CarsRace.Models.Drivers.Contracts;
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
    public partial class RaceInfoForm : Form
    {
        private IRace race;
        private IDriver driver;
        public RaceInfoForm()
        {
            InitializeComponent();
            
        }
        public IRace Race
        {
            get
            {
                return race;
            }
            set
            {
                race = value;
                RaceName.Text = Race.Name;
                raceLaps.Text = Race.Laps.ToString();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var fp = new DriverForm();
            fp.Race = Race;
            if (fp.ShowDialog() == DialogResult.OK)
            {   
                driver = fp.Driver;
                driversList.Items.Add(fp.Driver);
                race.AddDriver(fp.Driver);   
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (driversList.SelectedItem == null)
                {
                    throw new ArgumentException("You need to select a driver to remove it.");

                }
                IDriver driver = (IDriver)driversList.SelectedItem;
                driversList.Items.Remove(driver);
                race.RemoveDriver(driver);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


            
        }

        private void startRaceButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (race.Drivers.Count < 3)
                {
                    throw new ArgumentException("Drivers Should be at least 3 to start a race");
                }

 
                var fp = new ResultForm();
                fp.Race = Race;
                List<IDriver> drivers = race.Drivers.ToList();
                drivers = drivers.OrderBy(d => d.Car.CalculateRacePoints(race.Laps)).ThenBy(d=>d.Car.HorsePower).ThenBy(d=>d.Car.Model).ToList();
                fp.Drivers = drivers;
                Hide();
                fp.ShowDialog();
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
