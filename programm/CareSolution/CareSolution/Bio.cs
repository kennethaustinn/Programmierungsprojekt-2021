using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DataManager;
using IronOcr;
using OCRManager;

namespace CareSolution
{
    public partial class Bio : Form
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
        /// Speichert das Ergniss des Ocr als ein OcrResult Objekt.
        /// Wird wiederverwendet für die konvertierung der gelesenen Datei in ein PDf.
        /// </summary>
        public OcrResult _ocrResult;

        /// <summary>
        /// Dateipfad der einzulesenden Datei.
        /// </summary>
        private string _path;

        /// <summary>
        /// Form der Bio
        /// </summary>
        public static Bio BioForm = new Bio();
        
        /// <summary>
        /// List aus Labels der BioForm.
        /// </summary>
        private readonly List<Label> _documentKeys = new List<Label>();

        /// <summary>
        /// Für das Form Bio wird erst alle die Sachen von dem Designer initialisiert und auch das ConnectionString mit
        /// dem DatenBank erstellt. Auch die DummyTest Patient Data wird mit dem Klasse Patient verbunden und im Labels angezeigt
        /// </summary>
        public Bio()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Es wird eine Verbindung mit dem Datenbank automatisch erstellt.
        /// Da man die Datenquelle im DataGridView verknüpft hatte.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bio_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "ambulantCareDBDataSet.BioSet". Sie können sie bei Bedarf verschieben oder entfernen.
            this.bioSetTableAdapter.Fill(this.ambulantCareDBDataSet.BioSet);
            SaveLabelInList();
        }

        /// <summary>
        /// Wenn auf den Button "Datei einlesen" gedrückt wird, fängt der Prozess des Ocr's.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonScanNeueData_Click(object sender, EventArgs e)
        {
            try
            {
                openFile();
                _documentDictionary = _ocrManager.ExecuteOcr(_path);
                 _ocrResult = _ocrManager._ocrResult;
                FillLabels();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Es wurde schon ein Biografie eingefügt");
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
                CheckPathExists = true,
                Filter = @"  Image Files(*.png; *.jpg)| *.png; *.jpg | PDF File(*.pdf) | *.pdf  ",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Title = @"Welche Datei soll geladen werden?",
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
            _dataManager.addBioToDb(Text, _documentKeys[0].Text,
                _documentKeys[1].Text,
                _documentKeys[3].Text,
                _documentKeys[3].Text,
                _documentKeys[4].Text,
                _documentKeys[5].Text,
                _documentKeys[6].Text,
                _documentKeys[7].Text,
                _documentKeys[8].Text
            );
        }

        /// <summary>
        /// Speicherung der Labels der BioForm in eine List.
        /// </summary>
        private void SaveLabelInList()
        {
            _documentKeys.Add(labelSchule);
            _documentKeys.Add(labelAusbildung);
            _documentKeys.Add(labelUni);
            _documentKeys.Add(labelBeruf);
            _documentKeys.Add(labelPartnerschaft);
            _documentKeys.Add(labelKinder);
            _documentKeys.Add(labelFreizeit);
            _documentKeys.Add(labelFamilieMitglieder);
            _documentKeys.Add(labelSprache);
            
        }

        /// <summary>
        /// Speichert die eingelesene Datei in ein PDf, in der manche die Sachen suchen und kopiern kann.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                AddExtension = true,
                CheckPathExists = true,
                Filter = @"  Image Files(*.png; *.jpg)| *.png; *.jpg | PDF File(*.pdf) | *.pdf  ",
                InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Title = "Wo soll die Datei gespeichert werden?"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                _path = sfd.FileName;
            }
            _ocrManager.SaveAsPdfAndTextFile(_ocrResult, _path);
        }
    }
}
