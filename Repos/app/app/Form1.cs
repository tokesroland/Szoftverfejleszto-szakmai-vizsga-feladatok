using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class Form1 : Form
    {
        List<Users> userList;
        List<string> authorizations = new List<string>{"Összes"};
        List<Users> filteredUserList = new List<Users>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                userList = Users.DataReader(ofd.FileName);
                dataGridView1.DataSource = userList;
                dataGridView1.Columns["ID"].Visible = false;

                foreach (Users user in userList)
                {
                    if (!authorizations.Contains(user.Authorization))
                    {
                        authorizations.Add(user.Authorization);

                    }
                }
                comboBox1.DataSource = authorizations;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Kilép az alkalmazásból?","Kilépés",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            if (comboBox1.Text == "Összes")
            {
                dataGridView1.DataSource = userList;
                dataGridView1.Columns["ID"].Visible = false;
            }
            else
            {
                filteredUserList.Clear();
                foreach(Users user in userList)
                {
                    if(user.Authorization == comboBox1.Text)
                    {
                        filteredUserList.Add(user);
                    }
                }
                dataGridView1.DataSource = filteredUserList;
                dataGridView1.Columns["ID"].Visible = false;

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            int selectedIndex = e.RowIndex;
            if(dataGridView1.DataSource == userList)
            {
                label3.Text = 
                    $"- Username: {userList[selectedIndex].Username}" +
                    $"\n- Email: {userList[selectedIndex].Email}" +
                    $"\n- ID: {userList[selectedIndex].ID}" +
                    $"\n- Auth: {userList[selectedIndex].Authorization}"
                    ;

                //pictureBox1.ImageLocation = 
            }
            else if(dataGridView1.DataSource == filteredUserList)
            {
                label3.Text =
                    $"- Username: {filteredUserList[selectedIndex].Username}" +
                    $"\n- Email: {filteredUserList[selectedIndex].Email}" +
                    $"\n- ID: {filteredUserList[selectedIndex].ID}" +
                    $"\n- Auth: {filteredUserList[selectedIndex].Authorization}"
                    ;
            } else
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = userList;
                textBox1.Text = "";
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string keresettSzo = textBox1.Text.ToLower().Trim();

            if (string.IsNullOrEmpty(keresettSzo))
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = userList;
            }
            else
            {
                var szurtLista = userList.Where(user => user.Username.ToLower().Contains(keresettSzo) || user.Email.ToLower().Contains(keresettSzo)).ToList();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = szurtLista;
            }

            if (dataGridView1.Columns["ID"] != null)
            {
                dataGridView1.Columns["ID"].Visible = false;
            }
        }
    }
}
