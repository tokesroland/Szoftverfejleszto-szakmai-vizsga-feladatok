using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace NetrunnerGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DBConnect();
        }

        public void DBConnect()
        {
            string connString = "server=localhost;port=3306;database=netrunner;uid=root;pwd=;";

            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    // Kiszedtem a felugró MessageBoxot, hogy ne idegesítsen minden egyes ablakfrissítésnél

                    label1.Text = "Kapcsolódás sikeres!";
                    label1.ForeColor = Color.Green;

                    string query = "SELECT * FROM implants;";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            StringBuilder sb = new StringBuilder();

                            foreach (DataRow row in dataTable.Rows)
                            {
                                string sor = $"{row["ID"]};{row["Name"]};{row["Slot"]};{row["Ram_usage"]};{row["Danger_level"]}";
                                sb.AppendLine(sor);
                            }

                            File.WriteAllText("C:/Users/baloendr/Desktop/source.txt", sb.ToString());

                            List<Implant> lista = Implant.Beolvasas("C:/Users/baloendr/Desktop/source.txt");

                            // Elsütünk egy nullázást, hogy a DataGridView kénytelen legyen teljesen újrarajzolni magát
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = lista;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba történt: " + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    label1.Text = "Kapcsolódás sikertelen!";
                    label1.ForeColor = Color.Red;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Biztosan ki szeretnél lépni?", "Megerősítés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Biztosítjuk, hogy ne kapjunk hibát, ha a fejlécre kattint a felhasználó (-1 index)
            if (e.RowIndex >= 0)
            {
                formEdit f2 = new formEdit();

                f2.textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
                f2.textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["name"].Value.ToString();
                f2.textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["slot"].Value.ToString();
                f2.textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["ram_usage"].Value.ToString();
                f2.textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells["danger_level"].Value.ToString();

                // KRITIKUS VÁLTOZTATÁS: f2.Show() helyett ShowDialog()!
                // Ez megállítja a Form1 futását addig, amíg a formEdit ablakot be nem zárod.
                f2.ShowDialog();

                // Amint a formEdit-ben lefut a "this.Close();", a kód folytatódik itt, 
                // újraírja a TXT-t a friss adatokkal, és beolvassa a Gridbe.
                DBConnect();
            }
        }
    }
}