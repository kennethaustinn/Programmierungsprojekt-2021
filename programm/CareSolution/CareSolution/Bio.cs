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
    public partial class Bio : Form
    {
        public Bio()
        {
            InitializeComponent();
            var patient = new Patient.Patient().SetTestData();
            labelName2.Text = patient.LastName;
            labelSchule.Text = patient.Bio.School;
            labelBeruf.Text = patient.Bio.Job;
            labelAusbildung.Text = patient.Bio.Training;
            labelUni.Text = patient.Bio.University;
            labelPartnerschaft.Text = patient.Bio.Partnership;
            labelKinder.Text = patient.Bio.Children;
            labelFreizeit.Text = patient.Bio.Leisure;
            labelFamilieMitglieder.Text = patient.Bio.Family_Members;
            labelSprache.Text = patient.Bio.Languages;
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
