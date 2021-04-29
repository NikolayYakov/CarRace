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
        
    }
}
