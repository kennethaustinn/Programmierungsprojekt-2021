using System.Windows.Forms;

namespace CareSolution
{
    public partial class Others : Form
    {
        /// <summary>
        /// Form der Others
        /// </summary>
        public static Others OthersForm = new Others();

        /// <summary>
        /// Für das Form Others wird erst alle die Sachen von dem Designer initialisiert und auch das ConnectionString mit
        /// dem DatenBank erstellt. Auch die DummyTest Patient Data wird mit dem Klasse Patient verbunden und im Labels angezeigt
        /// </summary>
        public Others()
        {
            InitializeComponent();
            var patient = new Patient.Patient().SetTestData();
            labelFullName.Text = patient.FirstName + @" " + patient.LastName;
            foreach (var item in patient.CaringRelatives)
            {
                labelName.Text = item.Name;
                labelBeruf.Text = item.Activity;
                labelBesuch.Text = item.VisitFrequency;
                if (item.LivesInHousehold)
                {
                    checkBox1.Checked = true;
                }
                else
                {
                    checkBox2.Checked = false;
                }
            }

        }
    }
}
