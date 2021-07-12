using System;
using System.Windows.Forms;

namespace CareSolution
{
    public partial class BaseData : Form
    {

        /// <summary>
        /// Form der BaseData
        /// </summary>
        public static BaseData BaseDataForm = new BaseData();
        public BaseData()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// Hier kreuzt der Pflegende, ob er seiner zu machende Liste es erledigt ist.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                labelReport.Enabled=false;
            }
            else
            {
                labelReport.Enabled = true;
            }
        }

        /// <summary>
        /// Lädt die Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Stammdaten_Load(object sender, EventArgs e)
        {
            //labelName.Text = labelList[0];
        }
    }
}
