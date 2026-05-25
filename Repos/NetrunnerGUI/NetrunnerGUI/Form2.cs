using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NetrunnerGUI
{
    public partial class formEdit : Form
    {
        public formEdit()
        {
            InitializeComponent();
        }

        private void formEdit_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "server=localhost;port=3306;database=netrunner;uid=root;pwd=;";

            // 1. Biztonságos, paraméterezett UPDATE lekérdezés
            string query = "UPDATE implants SET Name = @name, Slot = @slot, Ram_usage = @ram, Danger_level = @danger WHERE ID = @id;";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    // 2. Paraméterek biztonságos feltöltése a TextBoxokból
                    command.Parameters.AddWithValue("@id", textBox1.Text);
                    command.Parameters.AddWithValue("@name", textBox2.Text);
                    command.Parameters.AddWithValue("@slot", textBox3.Text);
                    command.Parameters.AddWithValue("@ram", textBox4.Text);
                    command.Parameters.AddWithValue("@danger", textBox5.Text);

                    try
                    {
                        conn.Open();

                        // 3. Adatmódosítás végrehajtása
                        int erintettSorok = command.ExecuteNonQuery();

                        if (erintettSorok > 0)
                        {
                            MessageBox.Show("Implantátum sikeresen frissítve az adatbázisban!", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // 4. CSAK BEZÁRJUK ezt az ablakot. Nem nyitunk új Form1-et!
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Nem található implantátum ezzel az ID-val, semmi sem változott.", "Figyelem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hiba történt a mentés során: " + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}