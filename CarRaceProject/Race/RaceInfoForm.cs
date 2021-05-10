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
            if (fp.ShowDialog() == DialogResult.OK)
            {
                if (fp.Driver.CanParticipate == true)
                {
                    driver = fp.Driver;
                    driversList.Items.Add(fp.Driver);
                }
                
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (driversList.SelectedItem == null)
            {
                return;
            }
            driversList.Items.Remove(driversList.SelectedItem);
        }
    }
}
