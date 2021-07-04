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
    public partial class Stammdaten : Form
    {

        public Stammdaten()
        {
            InitializeComponent();
            var patient = new Patient.Patient().SetTestData();
            labelId.Text = patient.PersonID.ToString();
            labelName.Text = patient.LastName;
            labelName2.Text = patient.FirstName + " " + patient.LastName;
            labelVorname.Text = patient.FirstName;
            labelAlter.Text = patient.CalculateAge(patient.BirthDate).ToString();

            labelGeschlecht.Text = patient.Gender;
            labelAdresse.Text = patient.Address;
            labelGeburtsdatum.Text = patient.BirthDate.ToShortDateString();
            labelHöhe.Text = patient.Height.ToString();
            labelGewicht.Text = patient.Weight.ToString();
            foreach (var item in patient.Doctor)
            {
                labelArzt.Text = item.FirstName + " " + item.LastName;
            }
            labelPflegegrad.Text = patient.DegreeOfCare.ToString();
            labelVerischerung.Text = patient.HealthInsurance;
            foreach (var item in patient.CareReport)
            {
                labelReport.Text = item.Deviations;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                labelReport.Enabled=false;
            }
            else
            {
                labelReport.Enabled = true;
            }
        }
        

    }
}
