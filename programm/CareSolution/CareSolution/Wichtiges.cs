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
            var patient = new Patient.Patient().SetTestData();
            labelName2.Text = patient.FirstName + " " + patient.LastName;
        }
    }
}
