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
    public partial class Medikamente : Form
    {
        public Medikamente()
        {
            InitializeComponent();
            var patient = new Patient.Patient().SetTestData();
            labelName2.Text = patient.FirstName + " " + patient.LastName;
        }

        private void Medikamente_Load(object sender, EventArgs e)
        {
            var patient = new Patient.Patient().SetTestData();
            int n = dataGridViewMedikamente.Rows.Add();
            foreach (var item in patient.HealthData.Medication)
            {
                dataGridViewMedikamente.Rows[n].Cells["medikament"].Value = item.Drug;
                dataGridViewMedikamente.Rows[n].Cells["dosierung"].Value = item.Dosage;
                dataGridViewMedikamente.Rows[n].Cells["frequenz"].Value = item.Frequency;
                dataGridViewMedikamente.Rows[n].Cells["grund"].Value = item.Reason;
                dataGridViewMedikamente.Rows[n].Cells["verwaltetvon"].Value = item.AdministeredBy;
            }
            
        }
    }
}
