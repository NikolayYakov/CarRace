using CarsRace.Models.Drivers.Contracts;
using CarsRace.Models.Races.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsRace
{
    public partial class ResultForm : Form
    {
        private List<IDriver> drivers;
        private IRace race;
        public IRace Race { get { return race; } set { race = value; } }
        public List<IDriver> Drivers 
        { 
            get
            {
                return drivers;
            }
            set
            {
                drivers = value;
                firstDriverTextBox.Text = drivers[0].ToString();
                SecondDriverTextBox.Text = drivers[1].ToString();
                thirdDriverTextBox.Text = drivers[2].ToString();
            }
        }
        public ResultForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.TableName = "Driver";
            DataColumn dc1 = new DataColumn("DriverName");
            DataColumn dc2 = new DataColumn("DriverCarModel");
            DataColumn dc3 = new DataColumn("DriverCarHP");
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);
            for (int i = 0; i < Drivers.Count; i++)
            {
                dt.Rows.Add(Drivers[i].Name, Drivers[i].Car.Model, Drivers[i].Car.HorsePower);
            }
            DataSet ds = new DataSet();
            ds.DataSetName = "Race";
            ds.Tables.Add(dt);
            ds.WriteXml("Results.xml");
            
            using (StreamWriter writer = new StreamWriter("RaceResult.txt",true))
            {
                writer.WriteLine("New Race:");
                writer.WriteLine($"RaceName: {Race.Name} Laps: {Race.Laps}");
                for (int i = 0; i < drivers.Count(); i++)
                {
                    writer.WriteLine($"{i+1}. Name: {drivers[i].Name} Car: {drivers[i].Car.Model} HorsePowers: {drivers[i].Car.HorsePower}");
                }
            }
            Application.Exit();
        }
    }
}
