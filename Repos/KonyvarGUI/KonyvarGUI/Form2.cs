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
    public partial class Form2 : Form
    {

        List<Konyv> mentendoLista = new List<Konyv>();
        public Form2()
        {
            InitializeComponent();
        }

        private void BekuldBTN_Click(object sender, EventArgs e)
        {
            if (TitleTextbox.Text != "" || AuthorTextBox.Text != "" || ReleaseTextBox.Text != "" || PriceTextBox.Text != "" || GenreTextBox.Text != "")
            {
                string SorAdat = $"{TitleTextbox.Text};{AuthorTextBox.Text};{ReleaseTextBox.Text};{PriceTextBox.Text};{GenreTextBox.Text}";
                Konyv ujKonyv = new Konyv(SorAdat);
                mentendoLista.Add(ujKonyv);

                TitleTextbox.Clear();
                AuthorTextBox.Clear();
                ReleaseTextBox.Clear();
                PriceTextBox.Clear();
                GenreTextBox.Clear();

                mentesText.BackColor = Color.Green;
                mentesText.Text = "Sikeresen beszúrva!";
            }
            else
            {
                mentesText.BackColor = Color.Red;
                mentesText.Text = "Minden mezőt töltsön ki!";
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = mentendoLista;
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {

        }
    }
}
