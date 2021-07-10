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
    public partial class HealthData : Form
    {
        public static HealthData healthDataForm = new HealthData();
        /// <summary>
        /// Für das Form HealthData wird erst alle die Sachen von dem Designer initialisiert und auch das ConnectionString mit
        /// dem DatenBank erstellt. Auch die DummyTest Patient Data wird mit dem Klasse Patient verbunden und im Labels angezeigt
        /// </summary>
        public HealthData()
        {
            InitializeComponent();
            var patient = new Patient.Patient().SetTestData();
            labelName2.Text = patient.FirstName + " " + patient.LastName;

            foreach (var item in patient.HealthData.VitalParameters)
            {
                labelDatum.Text = item.DateTime.ToShortDateString();
                labelWert.Text = item.Value.ToString();
            }
        }
    }
}
