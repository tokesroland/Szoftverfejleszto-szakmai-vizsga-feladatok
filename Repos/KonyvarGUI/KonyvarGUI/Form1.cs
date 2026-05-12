using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonyvarGUI
{
    public partial class Form1 : Form
    {
        List<Konyv> list;
        List<Konyv> szurtLista;
        List<Konyv> szurtKeresettLista;
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if(dataGridView1.DataSource == list)
                {
                    int selectedItem = e.RowIndex;
                    label1.Text = $"Cím: {list[selectedItem].Cim} \nSzerző: {list[selectedItem].Szerzo}";
                }
                else if(dataGridView1.DataSource == szurtLista)
                {
                    int selectedItem = e.RowIndex;
                    label1.Text = $"Cím: {szurtLista[selectedItem].Cim} \nSzerző: {szurtLista[selectedItem].Szerzo}";
                }
                else
                {
                    int selectedItem = e.RowIndex;
                    label1.Text = $"Cím: {szurtKeresettLista[selectedItem].Cim} \nSzerző: {szurtKeresettLista[selectedItem].Szerzo}";
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                list = Konyv.Beolvasas(ofd.FileName);
                dataGridView1.DataSource = list;

                List<string> categories = new List<string>();
                foreach (Konyv v in list) 
                {
                    if (!categories.Contains("Összes"))
                    {
                        categories.Add("Összes");
                    }

                    if (!categories.Contains(v.Mufaj))
                    {
                        categories.Add(v.Mufaj);
                    }
                }
                comboBox1.DataSource = categories;
                //comboBox1.DataSource += "Összes";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztonsan ki akar lépni?", "Kijelentkezés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            szurtLista = new List<Konyv>();
            textBox1.Text = "";

            if(comboBox1.Text != "Összes")
            {
                foreach (Konyv v in list)
                {
                    if (v.Mufaj == comboBox1.Text)
                    {
                        szurtLista.Add(v);
                    }
                }
                dataGridView1.DataSource = szurtLista;
            }
            else
            {
                dataGridView1.DataSource = list;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string keresendo = textBox1.Text;

            if (dataGridView1.DataSource == list)
            {
                foreach (Konyv v in list)
                {
                    if (v.Cim.Contains(keresendo))
                    {
                        szurtLista.Add(v);
                    }
                }
                dataGridView1.DataSource = szurtLista;
            }
            else
            {
                szurtKeresettLista = new List<Konyv>();

                foreach (Konyv v in list)
                {
                    if (v.Cim.Contains(keresendo) && szurtLista.Contains(v))
                    {
                        szurtKeresettLista.Add(v);
                    }
                }
                //szurtLista.RemoveRange(0, torlendoIndexek);

                dataGridView1.DataSource = szurtKeresettLista;

            }
        }

        private void beszúrásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }
    }
}
