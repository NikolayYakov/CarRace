using CarsRace.Models.Cars.Contracts;
using CarsRace.Models.Cars.Entities;
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
    public partial class CarInfoForm : Form
    {
        public ICar Car { get; set; }
         
        public CarInfoForm()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            try
            {
                string model = modelBox.Text;
                int hp = int.Parse(hpTextBox.Text);
                if (sportsCarButton.Checked == true)
                {
                    Car = new SportsCar(model, hp);
                }
                else if (muscleCarButton.Checked == true)
                {
                    Car = new MuscleCar(model, hp);
                }
                else
                {
                    throw new ArgumentException("You need to select a car.");
                }
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
