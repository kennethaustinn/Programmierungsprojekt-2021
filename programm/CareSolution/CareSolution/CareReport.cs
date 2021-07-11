using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DataManager;
using OCRManager;

namespace CareSolution
{
    public partial class CareReport : Form
    {

        /// <summary>
        /// Instanz vom OcrManger, damit auf den Suchalgorithmus zugegriffen werden kann.
        /// </summary>
        private readonly OcrManager _ocrManager = new OcrManager();

        /// <summary>
        /// Instanz von DataManger, damit Datensätze in die Datenbank speichern kann.
        /// </summary>
        private readonly DataManager<Person> _dataManager = new DataManager<Person>();

        /// <summary>
        /// Dictionary mit den Keys und Values des aktuellen Dokuments. Wird an die GUI/Datenbank übergeben.
        /// </summary>
        private Dictionary<string, List<string>> _documentDictionary = new Dictionary<string, List<string>>();

        /// <summary>
        /// Dateipfad der einzulesenden Datei.
        /// </summary>
        private string _path;

        /// <summary>
        /// List aus Labels der BioForm.
        /// </summary>
        private readonly List<Label> _documentKeys = new List<Label>();

        /// <summary>
        /// Form der CareReport
        /// </summary>
        public static CareReport CareReportForm = new CareReport();
        
        /// <summary>
        /// Für das Form CareReport wird erst alle die Sachen von dem Designer initialisiert und auch das ConnectionString mit
        /// dem DatenBank erstellt. Auch die DummyTest Patient Data wird mit dem Klasse Patient verbunden und im Labels angezeigt
        /// </summary>
        public CareReport()
        {
            InitializeComponent();
            SaveLabelInList();
        }

        /// <summary>
        /// Event wenn man Button Scan New Data anklicken dann komm zur new open file dialog um neue Daten holen vom
        /// unserer Explorer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonScanNeueData_Click(object sender, EventArgs e)
        {
            try
            {
                openFile();
                _documentDictionary = _ocrManager.ExecuteOcr(_path);
                FillLabels();
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Es wurde schon ein Pflegebericht eingefügt");
            }

        }

        /// <summary>
        /// Öffnet den Dateiordner.
        /// </summary>
        private void openFile()
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                AddExtension = true,
                //DefaultExt = ".drw",
                //CheckPathExists = true,
                Filter = @"  Image Files(*.png; *.jpg)| *.png; *.jpg | PDF File(*.pdf) | *.pdf  ",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Title = @"Welche Datei soll geladen werden.",
            };
            ofd.InitialDirectory = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.FullName + @"\Resources";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _path = ofd.FileName;
            }
        }

        /// <summary>
        /// Die Labels der BioFrom werden mit den eingescannten Werten befüllt.
        /// </summary>
        private void FillLabels()
        {
            for (int i = 0; i < _documentDictionary.Count; i++)
            {
                _documentKeys[i].Text = "";
                var key = _documentDictionary.ElementAt(i);

                for (int j = 0; j < key.Value.Count; j++)
                {
                    _documentKeys[i].Text += key.Value[j] + Environment.NewLine;
                }
            }

            giveDatabaseDataset();
        }

        /// <summary>
        /// Der Datenbank werden die eingescannten Werte zur Speicherung übergeben.
        /// </summary>
        private void giveDatabaseDataset()
        {
            _dataManager.addCareReportToDb("id", _documentKeys[0].Text,
                checkBoxErfüllungMaßnahmenplan.Checked,
                _documentKeys[1].Text +_documentKeys[2].Text
            );
        }

        /// <summary>
        /// Speicherung der Labels der BioForm in eine List.
        /// </summary>
        private void SaveLabelInList()
        {
            _documentKeys.Add(labelDatum);
            _documentKeys.Add(labelErfüllung);
            _documentKeys.Add(labelAbweichungen);
            _documentKeys.Add(labelErstelltvon);
        }

        /// <summary>
        /// Es wird eine Verbindung mit dem Datenbank automatisch erstellt.
        /// Da man die Datenquelle im DataGridView verknüpft hatte.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CareReport_Load(object sender, EventArgs e)
        {
            //SaveLabelInList();
        }
    }
}
