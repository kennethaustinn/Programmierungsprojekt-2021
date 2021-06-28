using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CareSolution
{
    public partial class Anamnese : Form
    {
        public Anamnese()
        {
            InitializeComponent(); 
            var patient = new Patient.Patient().SetTestData();
            labelName2.Text = patient.FirstName + " " + patient.LastName;
            labelKrankengeschichte.Text = patient.HealthData.MedicalHistory;
            labelChronischeKrankheit.Text = patient.HealthData.ChronicDiseases;
            foreach (var item in patient.HealthData.RiskValues)
            {
                labelDekubitus.Text = item.Decubitus.ToString();
                labelSchmerz.Text = item.Pain.ToString();
                labelSturzgefahr.Text = item.Falling.ToString();
                labelDemenz.Text = item.Dementia.ToString();
            }
        }

    }
}
