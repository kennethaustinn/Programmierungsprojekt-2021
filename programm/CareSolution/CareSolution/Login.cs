using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CareSolution
{
    public partial class Login : Form
    {
        SqlConnection connection;
        private string connectionString;
        public Login()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["CareSolution.Properties.Settings.AmbulantCareDBConnectionString"].ConnectionString;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            panel2.BackColor = Color.White;
            pictureBoxUsername.BackColor= Color.White;
            panel3.BackColor = SystemColors.Control;
            textBox2.BackColor = SystemColors.Control;
            pictureBoxShowpassword.BackColor= SystemColors.Control;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
            panel3.BackColor = Color.White;
            pictureBoxShowpassword.BackColor = Color.White;
            panel2.BackColor = SystemColors.Control;
            textBox1.BackColor = SystemColors.Control;
            pictureBoxUsername.BackColor = SystemColors.Control;
        }

        private void pictureBoxPassword_MouseDown(object sender, MouseEventArgs e)
        {
            
            textBox2.UseSystemPasswordChar = false;
        }
        private void pictureBoxPassword_MouseUp(object sender, MouseEventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var query = "SELECT * FROM PersonSet_Worker a WHERE a.Username  = '" + textBox1.Text + "'and a.Password='" + textBox2.Text + "'";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adatpe = new SqlDataAdapter(command))
            {
                DataSet ds = new DataSet();
                adatpe.Fill(ds);
                int count = ds.Tables[0].Rows.Count;
                if (count ==1)
                {
                    this.Hide();
                    Main ss = new Main();
                    ss.Show();
                }
                else
                {
                    MessageBox.Show("Falsche Username und oder Password");
                    textBox1.Text = "Username";
                    textBox2.Text = "Password";
                    textBox2.UseSystemPasswordChar = false;
                }
            }
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Username")
                textBox1.Text = "";

            textBox1.ForeColor = Color.Black;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                textBox1.Text = "Username";

            textBox1.ForeColor = Color.Gray;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = "";
                textBox2.UseSystemPasswordChar = true;
            }
            
            textBox2.ForeColor = Color.Black;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Password";
                textBox2.UseSystemPasswordChar = false;
            }
            textBox2.ForeColor = Color.Gray;
        }
    }
}
