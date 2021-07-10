using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OCRManager;

namespace CareSolution
{
    public partial class CareReport : Form
    {
        public static CareReport careReportForm = new CareReport();

        private readonly OcrManager _ocrManager = new OcrManager();
        private Dictionary<string, List<string>> _documentDictionary = new Dictionary<string, List<string>>();
        private List<string> _documentKeys = new List<string>();
        private string _path;

        /// <summary>
        /// Für das Form CareReport wird erst alle die Sachen von dem Designer initialisiert und auch das ConnectionString mit
        /// dem DatenBank erstellt. Auch die DummyTest Patient Data wird mit dem Klasse Patient verbunden und im Labels angezeigt
        /// </summary>
        public CareReport()
        {
            InitializeComponent();
            //var patient = new Patient.Patient().SetTestData();
            //labelName2.Text = patient.FirstName + " " + patient.LastName;
            //foreach (var item in patient.CareReport)
            //{
            //    labelDatum.Text = item.CreatedOn.ToShortDateString();
            //    checkBoxErfüllungMaßnahmenplan.Checked = item.ActionPlanFulfilled;
            //    labelAbweichungen.Text = item.Deviations;
            //    labelErstelltvon.Text = item.CaregiverPersonID.ToString();
            //}
        }
        /// <summary>
        /// Event wenn man Button Scan New Data anklicken dann komm zur new open file dialog um neue Daten holen vom
        /// unserer Explorer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonScanNeueData_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                AddExtension = true,
                //DefaultExt = ".drw",
                //CheckPathExists = true,
                Filter = "  Image Files(*.png; *.jpg)| *.png; *.jpg | PDF File(*.pdf) | *.pdf  ",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Title = "Welche Datei soll geladen werden.",

            };
            ofd.InitialDirectory = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.FullName + @"\Resources";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _path = ofd.FileName;
                //MessageBox.Show(fileName);
                //pictureBox1.Image = Image.FromFile(_path);
                //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            _documentDictionary = _ocrManager.ExecuteOcr(_path);

            // erstmal Hardgecodet für die Datei Pflegebericht
            // nach dem Reiterwechsel werden die Sachen nicht gespeicjert.
            labelDatum.Text = _documentDictionary.ElementAt(0).Value[0];
            labelErfüllung.Text = _documentDictionary.ElementAt(1).Value[0];
            labelAbweichungen.Text = _documentDictionary.ElementAt(2).Value[0];
            labelErstelltvon.Text = _documentDictionary.ElementAt(3).Value[0];


        }
    }
}
