using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CareSolution
{
    public partial class Main1 : Form
    {
        private Button currentButton;
        private Panel leftBorderBtn;

        public Main1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 38);
            panelMenu.Controls.Add(leftBorderBtn);

        }

        //speichern das Form von Anfang
        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildform.Controls.Add(childForm);
            panelChildform.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentButton = (Button) senderBtn;
                currentButton.BackColor = Color.FromArgb(37, 36, 81);
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;
                leftBorderBtn.BackColor = Color.FromArgb(150, 123, 163);
                leftBorderBtn.Location = new Point(0, currentButton.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

            }
        }

        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(40, 45, 62);
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void buttonBiography_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new Bio1());
        }

        private void buttonPatientData_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new Stammdaten1());
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            Reset();
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
        }

        private void buttonMaßnahmenplan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonAnamnese_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonGesundheitszustand_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new Gesundheitszustand1());
        }

        private void buttonPflegebericht_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonMedikamente_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonWichtiges_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonSonstiges_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login cc = new Login();
            cc.Show();
        }

        private void DatumUhr_Tick(object sender, EventArgs e)
        {
            labelDatum.Text = DateTime.Now.ToString("D");
            labelUhr.Text = DateTime.Now.ToString("HH:mm");
        }

        private void buttonWeiterPatientsübersicht_Click(object sender, EventArgs e)
        {
            openChildForm(new PatientData());
        }
    }

}
