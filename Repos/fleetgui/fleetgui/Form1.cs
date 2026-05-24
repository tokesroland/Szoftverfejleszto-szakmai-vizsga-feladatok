using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fleetgui
{
    public partial class Form1 : Form
    {
        List<Vehicles> vehicles;
        List<Vehicles> FilteredVehicles = new List<Vehicles>();
        List<string> Markak = new List<string> { "Összes" };
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Biztosan ki akar lépni?","Kilépés", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void LoadBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                vehicles = Vehicles.Beolvasas(ofd.FileName);
                dataGridView1 = null;
                dataGridView1.DataSource = vehicles;
                dataGridView1.Columns["ID"].Visible = false;

                foreach (var car in vehicles)
                {
                    if (!Markak.Contains(car.Marka))
                    {
                        Markak.Add(car.Marka);
                    }
                }
                comboBox1.DataSource = Markak;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text != "Összes")
            {
                foreach(var car in vehicles)
                {
                    if(car.Marka == comboBox1.Text)
                    {
                        FilteredVehicles.Add(car);
                    }
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = FilteredVehicles;

            } else
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = vehicles;
            }
        }
    }
}
