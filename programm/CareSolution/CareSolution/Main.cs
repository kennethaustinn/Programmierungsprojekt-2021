using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataManager;

namespace CareSolution
{
    public partial class Main : Form
    {
        private Button currentButton;
        private Panel leftBorderBtn;
        SqlConnection connection;
        private string connectionString;

        private DataManager<Person> dm = new DataManager<Person>();
        /// <summary>
        /// Für das Form Main wird erst alle die Sachen von dem Designer initialisiert und auch das ConnectionString mit
        /// dem DatenBank erstellt. Sowie das Button Border für das Panel Menu wird hier initialisiert.
        /// Auch SetTest Data für die ListBox wird initialisiert
        /// </summary>
        public Main()
        {
            InitializeComponent();
            //connectionString = ConfigurationManager.ConnectionStrings["CareSolution.Properties.Settings.AmbulantCareDBConnectionString"].ConnectionString;
            connectionString = dm.ConnectionString;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 38);
            panelMenu.Controls.Add(leftBorderBtn);
            var patient = new Patient.Patient().SetTestData();
            foreach (var item in patient.Doctor)
            {
                checkedListBox1.Items.Add(item.ToDoList);
            }
        }
        // speichern das activeForm für OpenChildForm das genau am Anfang ist genau am Main. Das heißt keine
        // anderen OpenChildForm geöffnet oder gedrückt wird 
        private Form activeForm = null;
        /// <summary>
        /// wird das Form im PanelChilForm hier neue abgerufen und angezeigt. Mit dem Parameter Form
        /// die man gerade gedrückt von dem beliebigen Button
        /// </summary>
        /// <param name="childForm"> aktuelles Form, das wir angeklickt haben </param>
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildform.Controls.Add(childForm);
            panelChildform.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        /// <summary>
        /// initialisiert das Button, das gerade gedrückt wird wo auf dem MenuForm aktiv ist,
        /// hier ändert sich die Farbe das aktuelle Button und das Bild Format ändert sich auch nach rechte Seite
        /// nach dem Text im Button 
        /// </summary>
        /// <param name="senderBtn"> als Parameter hier ist das gerade gedrückte Button wird im object
        /// als sender Button geliefert</param>
        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentButton = (Button) senderBtn;
                currentButton.BackColor = Color.FromArgb(37, 36, 81);
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;
                leftBorderBtn.BackColor = Color.FromArgb(150, 123, 163);
                leftBorderBtn.Location = new Point(0, currentButton.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }
        /// <summary>
        /// Diese Methode wird verwendet, um die gerade aktive Button zu deaktivieren,
        /// damit sie in das normale Format zurückkehrt.
        /// </summary>
        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(40, 45, 62);
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        /// <summary>
        /// Ein Eventhandler wenn das Button Bio angeklickt dann wird das Bio Form geladen,
        /// sowie das Bio Button im PanelMenu wird aktualisiert
        /// </summary>
        private void buttonBiography_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new Bio());
        }
        /// <summary>
        /// Ein Eventhandler wenn das Button PatientData angeklickt dann wird das PatientData Form geladen,
        /// sowie das PatientData Button im PanelMenu wird aktualisiert
        /// </summary>
        private void buttonPatientData_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new Stammdaten());
        }
        /// <summary>
        /// Ein Eventhandler wenn das Button Home angeklickt dann wird das Home Form geladen,
        /// sowie das Home Button im PanelMenu wird aktualisiert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHome_Click(object sender, EventArgs e)
        {
            Reset();
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }
        /// <summary>
        /// setzt die aktuell aktive Button durch Aufruf einer DisableButton Methode
        /// </summary>
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
        }
        /// <summary>
        /// Ein Eventhandler wenn das Button Maßnahmenplan angeklickt dann wird das Maßnahmenplan Form geladen,
        /// sowie das Maßnahmenplan Button im PanelMenu wird aktualisiert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMaßnahmenplan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new ActionPlan());
        }
        /// <summary>
        /// Ein Eventhandler wenn das Button Anamnese angeklickt dann wird das Anamnese Form geladen,
        /// sowie das Anamnese Button im PanelMenu wird aktualisiert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAnamnese_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new CaseHistory());
        }
        /// <summary>
        /// Ein Eventhandler wenn das Button Gesundheitszustand angeklickt dann wird das Gesundheitszustand Form geladen,
        /// sowie das Gesundheitszustand Button im PanelMenu wird aktualisiert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGesundheitszustand_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new HealthData());
        }
        /// <summary>
        /// Ein Eventhandler wenn das Button Pflegebericht angeklickt dann wird das Pflegebericht Form geladen,
        /// sowie das Pflegebericht Button im PanelMenu wird aktualisiert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPflegebericht_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new CareReport());
        }
        /// <summary>
        /// Ein Eventhandler wenn das Button Medikamente angeklickt dann wird das Medikamente Form geladen,
        /// sowie das Medikamente Button im PanelMenu wird aktualisiert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMedikamente_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new Medication());

        }
        /// <summary>
        /// Ein Eventhandler wenn das Button Zuhause angeklickt dann wird das Zuhause Form geladen,
        /// sowie das Zuhause Button im PanelMenu wird aktualisiert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonZuhause_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new Home());
        }
        /// <summary>
        /// Ein Eventhandler wenn das Button Sonstiges angeklickt dann wird das Sonstiges Form geladen,
        /// sowie das Sonstiges Button im PanelMenu wird aktualisiert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSonstiges_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new Others());
        }
        /// <summary>
        /// Ein Eventhandler wenn das Button Patientsübersicht angeklickt dann wird das Patientsübersicht Form geladen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWeiterPatientsübersicht_Click(object sender, EventArgs e)
        {
            openChildForm(new PatientData());
        }
        /// <summary>
        /// Ein Eventhandler wenn das Button Logout angeklickt dann wird das Login Form geladen
        /// und das aktuelle Form geschlossen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login cc = new Login();
            cc.Show();
        }
        /// <summary>
        /// hier wird das aktuelle Datum und Zeit geladen in UI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DatumUhr_Tick(object sender, EventArgs e)
        {
            labelDatum.Text = DateTime.Now.ToString("f");
        }
        // Es wird eine Verbindung mit dem Datenbank automatisch erstellt. Da man die Datenquelle im DataGridView verknüpft hatte
        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "ambulantCareDBDataSet.PersonSet". Sie können sie bei Bedarf verschieben oder entfernen.
            this.personSetTableAdapter.Fill(this.ambulantCareDBDataSet.PersonSet);
        }
        /// <summary>
        /// ist ein Event so wenn man das Text in TextboxSuche geändert, wird eine Verbindung zur Datenbank erstellt
        /// danach wird die Datei in der Tabelle abgerufen und man vergleicht die mit dem Text in TextboxSuche.
        /// Dann letzendlich in DataGridView beliebig angezeigt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxSuche_TextChanged(object sender, EventArgs e)
        {
            var query = "SELECT * FROM PersonSet a WHERE a.LastName   Like '" + textBoxSuche.Text + "%' or a.FirstName like'%" + textBoxSuche.Text + "%'";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adatpe = new SqlDataAdapter(command))
            {
                DataTable Persondt = new DataTable();
                adatpe.Fill(Persondt);
                dataGridViewPatient.DataSource = Persondt;
            }
        }

    }

}
