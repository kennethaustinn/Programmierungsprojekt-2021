
using System.Globalization;
using System.Windows.Forms;

namespace CareSolution
{
    public partial class HealthData : Form
    {
        /// <summary>
        /// Form der HealthDat
        /// </summary>
        public static HealthData HealthDataForm = new HealthData();

        /// <summary>
        /// Für das Form HealthData wird erst alle die Sachen von dem Designer initialisiert und auch das ConnectionString mit
        /// dem DatenBank erstellt. Auch die DummyTest Patient Data wird mit dem Klasse Patient verbunden und im Labels angezeigt
        /// </summary>
        public HealthData()
        {
            InitializeComponent();
            var patient = new Patient.Patient().SetTestData();
            foreach (var item in patient.HealthData.VitalParameters)
            {
                labelDatum.Text = item.DateTime.ToShortDateString();
                labelWert.Text = item.Value.ToString(CultureInfo.CurrentCulture);
            }
        }
    }
}
