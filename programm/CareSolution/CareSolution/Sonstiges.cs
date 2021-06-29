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
    public partial class Sonstiges : Form
    {
        public Sonstiges()
        {
            InitializeComponent();
            var patient = new Patient.Patient().SetTestData();
            labelName2.Text = patient.FirstName + " " + patient.LastName;
            foreach (var item in patient.CaringRelatives)
            {
                labelName.Text = item.Name;
                labelBeruf.Text = item.Activity;
                labelBesuch.Text = item.VisitFrequency;
                if (item.LivesInHousehold)
                {
                    checkBox1.Checked = true;
                }
                else
                {
                    checkBox2.Checked = false;
                }
            }

        }
    }
}
