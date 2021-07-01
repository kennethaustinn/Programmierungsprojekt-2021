using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonInterfaces;
using OCRManager;

namespace CareSolution
{
    public partial class Bio : Form
    {
        private readonly OcrManager _ocrManager = new OcrManager();

        private Dictionary<string, List<string>> _documentDictionary = new Dictionary<string, List<string>>();

        private List<string> _documentKeys = new List<string>();
        private string _path;

        //private readonly string _projectDirectory = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.FullName;


        public Bio()
        {
            InitializeComponent();
            //SaveLabelInList();
            //var patient = new Patient.Patient().SetTestData();
            //labelName2.Text = patient.FirstName + " " + patient.LastName;
            //labelSchule.Text = patient.Bio.School;
            //labelBeruf.Text = patient.Bio.Job;
            //labelAusbildung.Text = patient.Bio.Training;
            //labelUni.Text = patient.Bio.University;
            //labelPartnerschaft.Text = patient.Bio.Partnership;
            //labelKinder.Text = patient.Bio.Children;
            //labelFreizeit.Text = patient.Bio.Leisure;
            //labelFamilieMitglieder.Text = patient.Bio.Family_Members;
            //labelSprache.Text = patient.Bio.Languages;
        }

        private void buttonScanNeueData_Click(object sender, EventArgs e)
        {
            //OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Filter = "PDF File (*.pdf)| *.pdf |Image Files (*.png;*.jpg)|*.png;*.jpg ";
            //ofd.ShowDialog();
            OpenFileDialog ofd = new OpenFileDialog
            {
                AddExtension = true,
                //DefaultExt = ".drw",
                //CheckPathExists = true,
                Filter = "PDF File(*.pdf) | *.pdf | Image Files(*.png; *.jpg)| *.png; *.jpg ",
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

            // erstmal Hardgecodet für die Datei BioTest02
            // nach dem Reiterwechsel werden die Sachen nicht gespeicjert.
            labelSchule.Text = _documentDictionary.ElementAt(0).Value[0];
            labelAusbildung.Text = _documentDictionary.ElementAt(1).Value[0];
            labelUni.Text = _documentDictionary.ElementAt(2).Value[0];
            labelBeruf.Text = _documentDictionary.ElementAt(3).Value[0];
            labelPartnerschaft.Text = _documentDictionary.ElementAt(4).Value[0];
            labelKinder.Text = _documentDictionary.ElementAt(5).Value[0];
            labelFreizeit.Text = _documentDictionary.ElementAt(6).Value[0];
            labelFamilieMitglieder.Text = _documentDictionary.ElementAt(7).Value[0];
            labelSprache.Text = _documentDictionary.ElementAt(8).Value[0];

            //SaveLabelInList();
            //FillLabels();
        }

        private void FillLabels()
        {
            for (int i = 0; i < _documentKeys.Count; i++)
            {
                var key = _documentDictionary.ElementAt(i);
                for (int j = 0; j < key.Value.Count; j++)
                {
                    var keey = _documentKeys[i];
                    keey = key.Value[j];
                }
            }
        }

        private void SaveLabelInList()
        {
            _documentKeys.Add(labelSchule.Text);
            _documentKeys.Add(labelAusbildung.Text);
            _documentKeys.Add(labelUni.Text);
            _documentKeys.Add(labelBeruf.Text);
            _documentKeys.Add(labelPartnerschaft.Text);
            _documentKeys.Add(labelKinder.Text);
            _documentKeys.Add(labelFreizeit.Text);
            _documentKeys.Add(labelFamilieMitglieder.Text);
            _documentKeys.Add(labelSprache.Text);
        }
    }
}
