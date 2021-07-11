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
    public partial class CaseHistory : Form
    {

        public static CaseHistory caseHistoryForm = new CaseHistory();
        /// <summary>
        /// Für das Form CaseHistory wird erst alle die Sachen von dem Designer initialisiert und auch das ConnectionString mit
        /// dem DatenBank erstellt. Auch die DummyTest Patient Data wird mit dem Klasse Patient verbunden und im Labels angezeigt
        /// </summary>
        public CaseHistory()
        {
            InitializeComponent(); 
            var patient = new Patient.Patient().SetTestData();
            labelFullName.Text = patient.FirstName + " " + patient.LastName;
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
