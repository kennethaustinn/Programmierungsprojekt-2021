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
            var patient = new Patient.Patient().SetTestData();
            labelSchule.Text = patient.Bio.School;
            labelBeruf.Text = patient.Bio.Job;
            labelUni.Text = patient.Bio.University;
            labelPartnerschaft.Text = patient.Bio.Partnership;
            labelKinder.Text = patient.Bio.Children;
            labelFreizeit.Text = patient.Bio.Leisure;
            labelFamilieMitglieder.Text = patient.Bio.Family_Members;
        }

        private void buttonScanNeueData_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PDF File | *.pdf";
            ofd.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
