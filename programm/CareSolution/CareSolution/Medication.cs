using System;
using System.Windows.Forms;

namespace CareSolution
{
    public partial class Medication : Form
    {
        /// <summary>
        /// Form der Medication
        /// </summary>
        public static Medication MedicationForm = new Medication();

        /// <summary>
        /// Für das Form Medication wird erst alle die Sachen von dem Designer initialisiert und auch das ConnectionString mit
        /// dem DatenBank erstellt.
        /// </summary>
        public Medication()
        {
            InitializeComponent();
            var patient = new Patient.Patient().SetTestData();
            labelFullName.Text = patient.FirstName + @" " + patient.LastName;
        }

        /// <summary>
        /// Es wird eine Verbindung mit dem Datenbank automatisch erstellt.
        /// Da man die Datenquelle im DataGridView verknüpft hatte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
