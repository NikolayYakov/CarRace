using CarsRace.Models.Races.Contracts;
using CarsRace.Models.Races.Entities;
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
    public partial class CreateRaceForm : Form
    {
        public CreateRaceForm()
        {
            InitializeComponent();
        }
        public IRace Race { get;private set; }
        private void CreateRaceButton_Click(object sender, EventArgs e)
        {
            try
            {
                int labs = int.Parse(RaceBoxLabs.Text);
                Race = new Race(RaceNameBox.Text, labs);
                var fp = new RaceInfoForm();
                Hide();
                fp.Race = Race;
                fp.ShowDialog();
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   

        }
    }
}
