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
        public PatientData()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["CareSolution.Properties.Settings.AmbulantCareDBConnectionString"].ConnectionString;
        }
        //speichern das Form von Anfang
        private Form activeForm = null;

        //hab schon mit erben versucht aber hat nicht geklappt
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
        private void textBoxSuche_Enter(object sender, EventArgs e)
        {
            if (textBoxSuche.Text == "Suche") 
                textBoxSuche.Text = "";
            textBoxSuche.ForeColor = Color.WhiteSmoke;
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

        private void PatientData_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "ambulantCareDBDataSet.PersonSet". Sie können sie bei Bedarf verschieben oder entfernen.
            this.personSetTableAdapter.Fill(this.ambulantCareDBDataSet.PersonSet);
            dataGridViewPatient.Update();
            dataGridViewPatient.Refresh();
        }

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
        private void buttonNeueData_Click(object sender, EventArgs e)
        {
            openChildForm(new AddPatient());
        }
    }
}
