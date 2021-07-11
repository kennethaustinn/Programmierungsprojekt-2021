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
    public partial class Medication : Form
    {
        public static Medication medicationForm = new Medication();
        /// <summary>
        /// Für das Form Medication wird erst alle die Sachen von dem Designer initialisiert und auch das ConnectionString mit
        /// dem DatenBank erstellt.
        /// </summary>
        public Medication()
        {
            InitializeComponent();
            var patient = new Patient.Patient().SetTestData();
            labelFullName.Text = patient.FirstName + " " + patient.LastName;
        }
        // Es wird eine Verbindung mit dem Datenbank automatisch erstellt. Da man die Datenquelle im DataGridView verknüpft hatte
        private void Medikamente_Load(object sender, EventArgs e)
        {
            var patient = new Patient.Patient().SetTestData();
            int n = dataGridViewMedikamente.Rows.Add();
            foreach (var item in patient.HealthData.Medication)
            {
                dataGridViewMedikamente.Rows[n].Cells["medikamente"].Value = item.Drug;
                dataGridViewMedikamente.Rows[n].Cells["dosierung"].Value = item.Dosage;
                dataGridViewMedikamente.Rows[n].Cells["frequenz"].Value = item.Frequency;
                dataGridViewMedikamente.Rows[n].Cells["grund"].Value = item.Reason;
                dataGridViewMedikamente.Rows[n].Cells["verwaltetvon"].Value = item.AdministeredBy;
            }
        }
    }
}
