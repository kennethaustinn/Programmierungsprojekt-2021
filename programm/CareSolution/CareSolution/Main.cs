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

namespace CareSolution
{
    public partial class Main : Form
    {
        private Button currentButton;
        private Panel leftBorderBtn;
        SqlConnection connection;
        private string connectionString;
        public Main()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["CareSolution.Properties.Settings.AmbulantCareDBConnectionString"].ConnectionString;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 38);
            panelMenu.Controls.Add(leftBorderBtn);
            var patient = new Patient.Patient().SetTestData();
            foreach (var item in patient.Doctor)
            {
                checkedListBox1.Items.Add(item.ToDoList);
            }

        }
        //speichern das Form von Anfang
        private Form activeForm = null;

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

        private void buttonBiography_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new Bio());
        }

        private void buttonPatientData_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new Stammdaten());
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            Reset();
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
        }

        private void buttonMaßnahmenplan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new ActionPlan());
        }

        private void buttonAnamnese_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new CaseHistory());
        }

        private void buttonGesundheitszustand_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new HealthData());
        }

        private void buttonPflegebericht_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new CareReport());
        }

        private void buttonMedikamente_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new Medication());

        }

        private void buttonZuhause_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new Home());
        }

        private void buttonSonstiges_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new Others());
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login cc = new Login();
            cc.Show();
        }

        private void DatumUhr_Tick(object sender, EventArgs e)
        {
            labelDatum.Text = DateTime.Now.ToString("f");
        }

        private void buttonWeiterPatientsübersicht_Click(object sender, EventArgs e)
        {
            openChildForm(new PatientData());
        }
        
        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "ambulantCareDBDataSet.PersonSet". Sie können sie bei Bedarf verschieben oder entfernen.
            this.personSetTableAdapter.Fill(this.ambulantCareDBDataSet.PersonSet);
        }

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
