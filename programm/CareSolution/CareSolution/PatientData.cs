using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public PatientData()
        {
            InitializeComponent();
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

        private void textBoxSuche_Leave(object sender, EventArgs e)
        {
            if (textBoxSuche.Text == "")
                textBoxSuche.Text = "Suche";

            textBoxSuche.ForeColor = Color.Gray;
        }

        private void textBoxSuche_TextChanged(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kenne\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("select * from [dbo].[Patient] where Vorname like '%" + textBoxSuche.Text + "%' or Name like'%" + textBoxSuche.Text + "%'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewPatient.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                int n = dataGridViewPatient.Rows.Add();
                dataGridViewPatient.Rows[n].Cells["id"].Value = row["Id"].ToString();
                dataGridViewPatient.Rows[n].Cells["nachname"].Value = row["Name"].ToString();
                dataGridViewPatient.Rows[n].Cells["vorname"].Value = row["Vorname"].ToString();
                dataGridViewPatient.Rows[n].Cells["alt"].Value = row["Alter"].ToString();
                dataGridViewPatient.Rows[n].Cells["adresse"].Value = row["Adresse"].ToString();
                dataGridViewPatient.Rows[n].Cells["arzt"].Value = row["Arzt"].ToString();
            }
        }

        private void PatientData_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kenne\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("select * from  [dbo].[Patient]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewPatient.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                int n = dataGridViewPatient.Rows.Add();
                dataGridViewPatient.Rows[n].Cells["id"].Value = row["Id"].ToString();
                dataGridViewPatient.Rows[n].Cells["nachname"].Value = row["Name"].ToString();
                dataGridViewPatient.Rows[n].Cells["vorname"].Value = row["Vorname"].ToString();
                dataGridViewPatient.Rows[n].Cells["alt"].Value = row["Alter"].ToString();
                dataGridViewPatient.Rows[n].Cells["adresse"].Value = row["Adresse"].ToString();
                dataGridViewPatient.Rows[n].Cells["arzt"].Value = row["Arzt"].ToString();
            }
            //var patient = new Patient.Patient().SetTestData();
            //int n = dataGridViewPatient.Rows.Add();
            //dataGridViewPatient.Rows[n].Cells["id"].Value = patient.PersonID;
            //dataGridViewPatient.Rows[n].Cells["nachname"].Value = patient.LastName;
            //dataGridViewPatient.Rows[n].Cells["vorname"].Value = patient.FirstName; 
            //dataGridViewPatient.Rows[n].Cells["adresse"].Value = patient.Address;
            //DataTable dt = new DataTable();
            //DataRow myDataRow;
            //myDataRow = dt.NewRow();
            //myDataRow["Id"] = patient.PersonID;
            //myDataRow["Nachname"] = patient.LastName;
            //myDataRow["Vorname"] = patient.FirstName;
            //myDataRow["Adresse"] = patient.Address;

            //dt.Rows.Add(myDataRow);

        }

        private void dataGridViewPatient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            openChildForm(new Stammdaten());

            //if (e.RowIndex != -1)
            //{
            //    dataGridViewPatient.CurrentRow.Selected = true;
            //    Stammdaten1 cc = new Stammdaten1();
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
            DialogResult dialogResult = MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var patient = new Patient.Patient().SetTestData();
                int n = dataGridViewPatient.Rows.Add();
                dataGridViewPatient.Rows[n].Cells["id"].Value = patient.PersonID;
                dataGridViewPatient.Rows[n].Cells["nachname"].Value = patient.LastName;
                dataGridViewPatient.Rows[n].Cells["vorname"].Value = patient.FirstName;
                dataGridViewPatient.Rows[n].Cells["adresse"].Value = patient.Address;

                //do something
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
           

        }
    }
}
