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

        public static ActionPlan actionPlanForm = new ActionPlan();
        /// <summary>
        /// Für das Form Action Plan wird erst alle die Sachen von dem Designer initialisiert und auch das ConnectionString mit
        /// dem DatenBank erstellt. Auch die DummyTest Patient Data wird mit dem Klasse Patient verbunden und im Labels angezeigt
        /// mit beliebigen Daten von ActionPlan abhängig von der Zeig
        /// </summary>
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
        /// <summary>
        /// hier wird das aktuelle Datum und Zeit geladen in UI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DatumUhr_Tick(object sender, EventArgs e)
        {
            labelDatum.Text = DateTime.Now.ToString("g");
        }
        /// <summary>
        /// Wenn das CheckBox gecheckt ist dann wird die Inhalte im Label verblasst vom UI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
