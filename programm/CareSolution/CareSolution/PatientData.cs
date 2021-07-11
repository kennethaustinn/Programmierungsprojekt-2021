using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using DataManager;

namespace CareSolution
{
    public partial class PatientData : Form
    {
        private SqlConnection _connection;
        private readonly string _connectionString;
        private readonly DataManager<Person> _dataManager = new DataManager<Person>();
        public static PatientData PatientDataForm = new PatientData();
        

        /// speichern das activeForm für OpenChildForm das genau am Anfang ist genau null.
        /// Das heißt anderen OpenChildForm geöffnet oder gedrückt wird 
        private Form _activeForm;

        /// <summary>
        /// Für das Form PatientData wird erst alle die Sachen von dem Designer initialisiert und auch das
        /// ConnectionString mit dem DatenBank erstellt.
        /// </summary>
        public PatientData()
        {
            InitializeComponent();
            _connectionString = _dataManager.ConnectionString;
            //connectionString = ConfigurationManager.ConnectionStrings["CareSolution.Properties.Settings.AmbulantCareDBConnectionString"].ConnectionString;
        }


        // wird das Form im PanelChilForm hier neue abgerufen und angezeigt. Mit dem Parameter Form
        // die man gerade gedrückt von dem beliebigen Button
        private void openChildForm(Form childForm)
        {
            if (_activeForm != null)
            {
                _activeForm.Hide();
            }

            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelPatient.Controls.Add(childForm);
            panelPatient.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        /// <summary>
        /// ist ein Event so wenn man das Text in TextboxSuche geändert, wird eine Verbindung zur Datenbank erstellt
        /// danach wird die Datei in der Tabelle abgerufen und man vergleicht die mit dem Text in TextboxSuche.
        /// Dann letzendlich in DataGridView beliebig angezeigt
        /// </summary>
        private void textBoxSuche_TextChanged(object sender, EventArgs e)
        {
            var query = "SELECT * FROM PersonSet a WHERE a.LastName   Like '" + textBoxSuche.Text + "%' or a.FirstName like'%" + textBoxSuche.Text + "%'";
            using (_connection = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query, _connection))
            using (SqlDataAdapter adatpe = new SqlDataAdapter(command))
            {
                DataTable persondt = new DataTable();
                adatpe.Fill(persondt);
                dataGridViewPatient.DataSource = persondt;
            }
        }
        /// <summary>
        ///  Es wird eine Verbindung mit dem Datenbank automatisch erstellt. Da man die Datenquelle im DataGridView verknüpft hatte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PatientData_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "ambulantCareDBDataSet.PersonSet". Sie können sie bei Bedarf verschieben oder entfernen.
            this.personSetTableAdapter.Fill(this.ambulantCareDBDataSet.PersonSet);
            dataGridViewPatient.Update();
            dataGridViewPatient.Refresh();
        }
        /// <summary>
        /// Ein Event wird ausgeführt wenn man beliebige Zelle doppelklicken und öffnet das Form von OpenChildForm von Stammdaten 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewPatient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            var id = this.dataGridViewPatient.CurrentRow?.Cells[0].Value.ToString();
            var name = this.dataGridViewPatient.CurrentRow?.Cells[1].Value.ToString();
            var firstName = this.dataGridViewPatient.CurrentRow?.Cells[2].Value.ToString();
            var gender = this.dataGridViewPatient.CurrentRow?.Cells[3].Value.ToString();
            var fullName = firstName + @" " + name;

            var testPatient = _dataManager.GetPatient(id);
            //var patient = new Patient.Patient();

            ActionPlan.actionPlanForm.panelProfil.Text = fullName;
            BaseData.baseDataForm.labelFullName.Text = fullName;
            Bio.BioForm.labelFullName.Text = fullName;
            CareReport.CareReportForm.panelProfil.Text = fullName;
            CaseHistory.caseHistoryForm.panelProfil.Text = fullName;
            HealthData.healthDataForm.panelProfil.Text = fullName;
            Home.homeForm.panelProfil.Text = fullName;
            Medication.medicationForm.panelProfil.Text = fullName;
            Others.othersForm.panelProfil.Text = fullName;


            BaseData.baseDataForm.labelId.Text = id;
            BaseData.baseDataForm.labelName.Text = name;
            BaseData.baseDataForm.labelVorname.Text = firstName;
            //BaseData.baseDataForm.labelAlter.Text = patient.CalculateAge(testPatient[0].BirthDate).ToString();
            BaseData.baseDataForm.labelGeschlecht.Text = gender;
            BaseData.baseDataForm.labelAdresse.Text = testPatient[0].Address;
            BaseData.baseDataForm.labelGeburtsdatum.Text = testPatient[0].BirthDate.ToString(CultureInfo.CurrentCulture);
            BaseData.baseDataForm.labelHöhe.Text = testPatient[0].Height.ToString(CultureInfo.CurrentCulture);
            BaseData.baseDataForm.labelGewicht.Text = testPatient[0].Weight.ToString(CultureInfo.CurrentCulture);
            BaseData.baseDataForm.labelKontaktperson.Text = testPatient[0].Contactperson;
            BaseData.baseDataForm.labelPflegegrad.Text = testPatient[0].DegreeOfCare.ToString();
            BaseData.baseDataForm.labelVerischerung.Text = testPatient[0].HealthInsurance;
            openChildForm(BaseData.baseDataForm);

        }
        /// <summary>
        /// Ein neue Form wird geöffnet wenn man das Button Neue hinzufügen drücken und zur Form AddPatient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNeueData_Click(object sender, EventArgs e)
        {
            openChildForm(new AddPatient());
        }

    }
}
