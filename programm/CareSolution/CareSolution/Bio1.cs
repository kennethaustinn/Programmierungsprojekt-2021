using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CareSolution
{
    public partial class Bio1 : Form
    {
        public Bio1()
        {
            InitializeComponent();
        }

        private void buttonScanNeueData_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PDF File | *.pdf";
            ofd.ShowDialog();
        }
    }
}
