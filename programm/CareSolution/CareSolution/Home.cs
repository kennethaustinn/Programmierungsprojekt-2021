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
    public partial class Home : Form
    {
        public static Home homeForm =new Home();
        /// <summary>
        /// Für das Form Home wird erst alle die Sachen von dem Designer initialisiert und auch das ConnectionString mit
        /// dem DatenBank erstellt. Auch die DummyTest Patient Data wird mit dem Klasse Patient verbunden und im Labels
        /// angezeigt und die bool Daten in Checkbox gecheckt wenn die true sind.
        /// </summary>
        public Home()
        {
            InitializeComponent();
            var patient = new Patient.Patient().SetTestData();
            labelFullName.Text = patient.FirstName + " " + patient.LastName;
            labelHilfsmittel.Text = patient.Home.Tools;
            checkBox1.Checked = patient.Home.Barrier_Free_Kitchen;
            checkBox2.Checked = patient.Home.Barrier_Free_Bath;
            checkBox3.Checked = patient.Home.Barrier_Free_Living_Area;
            checkBox4.Checked = patient.Home.Barrier_Free_Elevator;
            checkBox5.Checked = patient.Home.Barrier_Free_Stairlift;
        }
    }
}
