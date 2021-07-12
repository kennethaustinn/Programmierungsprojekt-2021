using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using DataManager;

namespace CareSolution
{
    public partial class PatientData : Form
    {
        
        /// <summary>
        /// Sucht die Connection bzw. ruft die ab.
        /// </summary>
        private SqlConnection _connection;
        /// <summary>
        /// Dieser string stellt die Verbindungszeichungsfolge zu der Datenbank Datei (mdf).
        /// </summary>
        private readonly string _connectionString;

        /// <summary>
        /// Instanz von DataManager
        /// </summary>
        private readonly DataManager<Person> _dataManager = new DataManager<Person>();

        /// <summary>
        /// Form der PatientData
        /// </summary>
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
            //showRestOfTable();
            
        }

        /// <summary>
        /// Ein Event wird ausgeführt wenn man beliebige Zelle doppelklicken und öffnet das Form von OpenChildForm von Stammdaten 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void dataGridViewPatient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            showDataInformationFromMainForm(this.dataGridViewPatient);
            openChildForm(BaseData.BaseDataForm);

        }

        /// <summary>
        /// Die Information vom gewählten Patient werden übernommen
        /// </summary>
        /// <param name="dataGridView"></param>
        public void showDataInformationFromMainForm(DataGridView dataGridView)
        {
            var id = dataGridView.CurrentRow?.Cells[0].Value.ToString();
            var name = dataGridView.CurrentRow?.Cells[1].Value.ToString();
            var firstName = dataGridView.CurrentRow?.Cells[2].Value.ToString();
            var gender = dataGridView.CurrentRow?.Cells[3].Value.ToString();
            var fullName = firstName + @" " + name;

            var patient = _dataManager.GetPatient(id);

            checkIfPatientIsFound(patient);
            //var patient = new Patient.Patient();

            showFullNameInAllForms(fullName);
            fillBaseDataInformation(id, name, firstName, gender, patient);
        }

        /// <summary>
        /// Überprüft ob bei der Sql Abfrage ein Patient gefunden wurde.
        /// Falls nicht wird ein neuer mitt leeren Werten erstellt(Das sind die îndemfall die Ärzte und Pfleger)
        /// </summary>
        /// <param name="patient"></param>
        private static void checkIfPatientIsFound(List<DataManager.Patient> patient)
        {
            if (patient.Count == 0)
            {
                patient.Add(new DataManager.Patient()
                {
                    Address = "Keine Angabe",
                    BirthDate = null,
                    Height = null,
                    Weight = null,
                    Contactperson = "Keine Angabe",
                    DegreeOfCare = null,
                    HealthInsurance = "Keine Angabe",
                });
            }
        }

        /// <summary>
        /// Teigt einen weiteren Auschnitt vom Patient in der Tabele.
        /// </summary>
        //public void showRestOfTable()
        //{
        //    //var id = dataGridViewPatient.Rows[0].Cells["personIDDataGridViewTextBoxColumn"].Value.ToString();
        //    //var pat = _dataManager.GetPatient(id);
        //    //dataGridView1.Rows[0].Cells["ad1"].Value = pat[0].Address;
        //    dataGridView1.RowCount = dataGridViewPatient.RowCount;
        //    for (int i = 0; i < dataGridViewPatient.RowCount-1; i++)
        //    {

        //            var id = dataGridViewPatient.Rows[i].Cells["personIDDataGridViewTextBoxColumn"].Value.ToString();
        //            var pat = _dataManager.GetPatient(id);
        //            checkIfPatientIsFound(pat);
        //            dataGridView1.Rows[i].Cells["alter"].Value = pat[0].BirthDate?.ToString(CultureInfo.CurrentCulture);
        //            dataGridView1.Rows[i].Cells["adresse"].Value = pat[0].Address;
        //            dataGridView1.Rows[i].Cells["pflegegrad"].Value = pat[0].DegreeOfCare.ToString();
        //    }
        //}

        /// <summary>
        /// Gibt die Inforamtionenn des Aktuellen Patienten an die BasaData Form.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="firstName"></param>
        /// <param name="gender"></param>
        /// <param name="testPatient"></param>
        private static void fillBaseDataInformation(string id, string name, string firstName, string gender, List<DataManager.Patient> testPatient)
        {
            BaseData.BaseDataForm.labelId.Text = id;
            BaseData.BaseDataForm.labelName.Text = name;
            BaseData.BaseDataForm.labelVorname.Text = firstName;
            //BaseData.baseDataForm.labelAlter.Text = patient.CalculateAge(testPatient[0].BirthDate).ToString();
            BaseData.BaseDataForm.labelGeschlecht.Text = gender;
            BaseData.BaseDataForm.labelAdresse.Text = testPatient[0].Address;
            BaseData.BaseDataForm.labelGeburtsdatum.Text = testPatient[0].BirthDate?.ToString(CultureInfo.CurrentCulture);
            BaseData.BaseDataForm.labelHöhe.Text = testPatient[0].Height?.ToString(CultureInfo.CurrentCulture);
            BaseData.BaseDataForm.labelGewicht.Text = testPatient[0].Weight?.ToString(CultureInfo.CurrentCulture);
            BaseData.BaseDataForm.labelKontaktperson.Text = testPatient[0].Contactperson;
            BaseData.BaseDataForm.labelKontakNummer.Text = testPatient[0].ContactpersonPhone;
            BaseData.BaseDataForm.labelPflegegrad.Text = testPatient[0].DegreeOfCare.ToString();
            BaseData.BaseDataForm.labelVerischerung.Text = testPatient[0].HealthInsurance;
        }

        /// <summary>
        /// Gibt den Namen des Aktuellen Patienten an die Forms
        /// </summary>
        /// <param name="fullName"> Ganzer Name</param>
        private static void showFullNameInAllForms(string fullName)
        {
            ActionPlan.ActionPlanForm.labelFullName.Text = fullName;
            BaseData.BaseDataForm.labelFullName.Text = fullName;
            Bio.BioForm.labelFullName.Text = fullName;
            CareReport.CareReportForm.labelFullName.Text = fullName;
            CaseHistory.CaseHistoryForm.labelFullName.Text = fullName;
            HealthData.HealthDataForm.labelFullName.Text = fullName;
            Home.HomeForm.labelFullName.Text = fullName;
            Medication.MedicationForm.labelFullName.Text = fullName;
            Others.OthersForm.labelFullName.Text = fullName;
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
