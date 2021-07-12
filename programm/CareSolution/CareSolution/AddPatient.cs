using System;
using System.Windows.Forms;
using DataManager;

namespace CareSolution
{
    public partial class AddPatient : Form
    {
        /// <summary>
        /// Instanz von DataManger
        /// </summary>
        private readonly DataManager<Person> _dataManager = new DataManager<Person>();
        
        /// <summary>
        /// Für das Form AddPatiet wird erst alle die Sachen von dem Designer initialisiert und auch das ConnectionString mit
        /// dem DatenBank erstellt.
        /// </summary>
        public AddPatient()
        {
            InitializeComponent();
        }

        /// <summary>
        /// speichern das activeForm für OpenChildForm das genau am Anfang ist genau null.
        /// Das heißt anderen OpenChildForm geöffnet oder gedrückt wird
        /// </summary>
        private Form _activeForm;

        /// <summary>
        /// wird das Form im PanelChilForm hier neue abgerufen und angezeigt. Mit dem Parameter Form
        /// die man gerade gedrückt von dem beliebigen Button
        /// </summary>
        /// <param name="childForm"></param>
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
        /// Beim Laden des Form wird die ComboBox mit den Werten befüllt.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPatient_Load(object sender, EventArgs e)
        {
            FillComboBox();
        }

        /// <summary>
        /// Die Auswahl des Geschlecht zuordnen.
        /// </summary>
        public void FillComboBox()
        {
            comboBoxGender.Items.Add("M");
            comboBoxGender.Items.Add("W");
        }

        /// <summary>
        /// Beim Klicken des Button wird ein neuer Patient in der Datenbank hinzugefügt. Dabei werden die eingegebenen Werte an dem Prozedur Prozess
        /// übergeben und der beginnt den Sql Abruf mit Insert Into.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNeueData_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show(@"Soll der Patient wirklich hinzugefügt werden?", @"Speicherung",
                MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _dataManager.CreateNew(new Person
                {
                    LastName = AddLastName.Text,
                    FirstName = AddLFirstName.Text,
                    Gender = comboBoxGender.Text,
                    Phone = AddPhone.Text
                });
                
            }
            else if (dialogResult == DialogResult.No)
            {

            }
            openChildForm(new PatientData());
        }
    }
    }
