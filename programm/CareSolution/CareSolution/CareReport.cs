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
    public partial class CareReport : Form
    {
        public CareReport()
        {
            InitializeComponent();
            var patient = new Patient.Patient().SetTestData();
            labelName2.Text = patient.FirstName + " " + patient.LastName;
            foreach (var item in patient.CareReport)
            {
                labelDatum.Text = item.CreatedOn.ToShortDateString();
                checkBoxErfüllungMaßnahmenplan.Checked = item.ActionPlanFulfilled;
                labelAbweichungen.Text = item.Deviations;
                labelErstelltvon.Text = item.CaregiverPersonID.ToString();
            }
        }
        private void buttonScanNeueData_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PDF File (*.pdf)| *.pdf |Image Files (*.png;*.jpg)|*.png;*.jpg ";
            ofd.ShowDialog();
        }
    }
}
