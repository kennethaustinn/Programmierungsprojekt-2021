using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataManager;

namespace CareSolution
{
    public partial class PatientFiles : Form
    {
        public PatientFiles()
        {
            InitializeComponent();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login cc = new Login();
            cc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stammdaten cc = new Stammdaten();
            cc.Show();
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kenne\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("select * from [dbo].[Patient] where Vorname like '%" + textBox1.Text + "%' or Name like'%" + textBox1.Text + "%'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }
        

        private void PatientFiles_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kenne\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("select * from  [dbo].[Patient]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

            System.Diagnostics.Debug.WriteLine(sda);

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.DeepSkyBlue;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkBlue;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DeepSkyBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main cc = new Main();
            cc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bio cc = new Bio();
            cc.Show();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stammdaten cc = new Stammdaten();
            cc.Show();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
