using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CareSolution
{
    public partial class PatientData : Form
    {
        SqlConnection connection;
        private string connectionString;
        /// <summary>
        /// Für das Form PatientData wird erst alle die Sachen von dem Designer initialisiert und auch das
        /// ConnectionString mit dem DatenBank erstellt.
        /// </summary>
        public PatientData()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["CareSolution.Properties.Settings.AmbulantCareDBConnectionString"].ConnectionString;
        }
        /// speichern das activeForm für OpenChildForm das genau am Anfang ist genau null.
        /// Das heißt anderen OpenChildForm geöffnet oder gedrückt wird 
        private Form activeForm = null;

        // wird das Form im PanelChilForm hier neue abgerufen und angezeigt. Mit dem Parameter Form
        // die man gerade gedrückt von dem beliebigen Button
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
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adatpe = new SqlDataAdapter(command))
            {
                DataTable Persondt = new DataTable();
                adatpe.Fill(Persondt);
                dataGridViewPatient.DataSource = Persondt;
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
            openChildForm(new Stammdaten());

            //if (e.RowIndex != -1)
            //{
            //    dataGridViewPatient.CurrentRow.Selected = true;
            //    cc.labelId.Text = dataGridViewPatient.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
            //    cc.labelName.Text = dataGridViewPatient.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
            //    cc.labelName2.Text = dataGridViewPatient.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
            //    cc.labelVorname.Text = dataGridViewPatient.Rows[e.RowIndex].Cells["vorname"].FormattedValue.ToString();
            //    cc.labelAlter.Text = dataGridViewPatient.Rows[e.RowIndex].Cells["alt"].FormattedValue.ToString();
            //    cc.labelAdresse.Text = dataGridViewPatient.Rows[e.RowIndex].Cells["adresse"].FormattedValue.ToString();
            //    cc.labelArzt.Text = dataGridViewPatient.Rows[e.RowIndex].Cells["arzt"].FormattedValue.ToString();
            //}

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
