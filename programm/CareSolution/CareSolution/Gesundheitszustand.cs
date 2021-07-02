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
    public partial class Gesundheitszustand : Form
    {
        public Gesundheitszustand()
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
