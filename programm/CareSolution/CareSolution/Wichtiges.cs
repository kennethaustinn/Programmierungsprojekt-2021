using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CareSolution
{
    public partial class Wichtiges : Form
    {
        public Wichtiges()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main cc = new Main();
            cc.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login cc = new Login();
            cc.Show();
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stammdaten cc = new Stammdaten();
            cc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bio cc = new Bio();
            cc.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gesundheitszustand cc = new Gesundheitszustand();
            cc.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Medikamentenplan cc = new Medikamentenplan();
            cc.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (string s in checkedListBox1.CheckedItems)
            {
                listBox1.Items.Add(s);
            }
        }

        }
}
