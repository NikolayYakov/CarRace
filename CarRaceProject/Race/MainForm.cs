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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateRaceButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var fp = new CreateRaceForm();
            fp.ShowDialog();
            this.Close();
            
            
        }
    }
}
