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
    public partial class Medikamentenplan : Form
    {
        public Medikamentenplan()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Wichtiges cc = new Wichtiges();
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
    }
}
