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
    public partial class Zuhause : Form
    {
        public Zuhause()
        {
            InitializeComponent();
            var patient = new Patient.Patient().SetTestData();
            labelName2.Text = patient.FirstName + " " + patient.LastName;
            labelHilfsmittel.Text = patient.Home.Tools;
            checkBox1.Checked = patient.Home.Barrier_Free_Kitchen;
            checkBox2.Checked = patient.Home.Barrier_Free_Bath;
            checkBox3.Checked = patient.Home.Barrier_Free_Living_Area;
            checkBox4.Checked = patient.Home.Barrier_Free_Elevator;
            checkBox5.Checked = patient.Home.Barrier_Free_Stairlift;
        }
    }
}
