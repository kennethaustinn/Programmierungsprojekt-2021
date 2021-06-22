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
            labelName2.Text = patient.LastName;
            labelVorname.Text = patient.FirstName;

            DateTime dob = patient.BirthDate;
            int alter = CalculateAge(dob);
            labelAlter.Text = alter.ToString();

            labelGeschlecht.Text = patient.Gender;
            labelAdresse.Text = patient.Address;
            labelGeburtsdatum.Text = patient.BirthDate.ToString();
            labelHöhe.Text = patient.Height.ToString();
            labelGewicht.Text = patient.Weight.ToString();
            //labelArzt.Text = patient.Doctor.ToString();
            labelPflegegrad.Text = patient.DegreeOfCare.ToString();
            labelVerischerung.Text = patient.HealthInsurance;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                labelReport.Visible=false;
            }
            else
            {
                labelReport.Visible = true;
            }
        }
        public static int CalculateAge(DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;

            return age;
        }
    }
}
