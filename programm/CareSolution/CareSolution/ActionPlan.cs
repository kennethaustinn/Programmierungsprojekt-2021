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
    public partial class ActionPlan : Form
    {
        public ActionPlan()
        {
            InitializeComponent();

            var patient = new Patient.Patient().SetTestData();
            labelName2.Text = patient.FirstName + " " + patient.LastName;
            foreach (var item in patient.ActionPlan)
            {
                labelErstellt.Text = item.CreatedOn.ToShortDateString();
                if (DateTime.Now.Hour >= 18 )
                {
                    labelMaßnahmenplan.Text = "Abend : " + item.Actions_Eve;
                }
                else if (DateTime.Now.Hour >= 12)
                {
                    labelMaßnahmenplan.Text = "Nachmittag : " + item.Actions_Afternoon + "\n" + "Abend : " + item.Actions_Eve;
                }
                else if (DateTime.Now.Hour  >= 9)
                {
                    labelMaßnahmenplan.Text = "Vormittag : " + item.Actions_Noon + "\n"+"Nachmittag : " + item.Actions_Afternoon + "\n" + "Abend : " + item.Actions_Eve;

                }
                else if(DateTime.Now.Hour >= 0)
                {
                    labelMaßnahmenplan.Text = "Morgen : " + item.Actions_Morning + "\n"+ "Vormittag : " + item.Actions_Noon + "\n" + "Nachmittag : " + item.Actions_Afternoon + "\n" + "Abend : " + item.Actions_Eve;
                }

            }

        }
        private void DatumUhr_Tick(object sender, EventArgs e)
        {
            labelDatum.Text = DateTime.Now.ToString("g");
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                labelMaßnahmenplan.Enabled = false;
            }
            else
            {
                labelMaßnahmenplan.Enabled = true;
            }
        }
    }
}
