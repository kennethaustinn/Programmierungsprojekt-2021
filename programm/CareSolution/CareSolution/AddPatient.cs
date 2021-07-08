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
using DataManager;

namespace CareSolution
{
    public partial class AddPatient : Form
    {
        public List<string> addList = new List<string>();
        SqlConnection connection;
        private string connectionString;
        /// <summary>
        /// Für das Form AddPatiet wird erst alle die Sachen von dem Designer initialisiert und auch das ConnectionString mit
        /// dem DatenBank erstellt.
        /// </summary>
        public AddPatient()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["CareSolution.Properties.Settings.AmbulantCareDBConnectionString"].ConnectionString;
        }
        private void AddPatient_Load(object sender, EventArgs e)
        {
            FillComboBox();
        }

        public void FillComboBox()
        {
            comboBoxGender.Items.Add("M");
            comboBoxGender.Items.Add("W");
        }

        public void FillList()
        {
            addList.Add(AddLastName.Text);
            addList.Add(AddLFirstName.Text);
            addList.Add(comboBoxGender.Text);
            addList.Add(AddPhone.Text);
        }

        private void buttonNeueData_Click(object sender, EventArgs e)
        {
            
            FillList();
            
            DialogResult dialogResult = MessageBox.Show("Soll der Patient wirklich hinzugefügt werden?", "Speicherung", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var query = "INSERT INTO PersonSet VALUES ("+ $"'{addList[0]}','{addList[1]}','{addList[2]}','{addList[3]}')";
                //var t = "INSERT INTO PersonSet VALUES ('dsfsd','sdfs','sdfs','123')";
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    connection.Open();
                    command.ExecuteScalar();

                }

            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
            this.Close();

        }

    }
}
