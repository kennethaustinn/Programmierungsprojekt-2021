namespace CareSolution
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogout = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonOthers = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonMedication = new System.Windows.Forms.Button();
            this.buttonCareReport = new System.Windows.Forms.Button();
            this.buttonHealthData = new System.Windows.Forms.Button();
            this.buttonCaseHistory = new System.Windows.Forms.Button();
            this.buttonActionPlan = new System.Windows.Forms.Button();
            this.buttonBiography = new System.Windows.Forms.Button();
            this.buttonBaseData = new System.Windows.Forms.Button();
            this.panelHome = new System.Windows.Forms.Panel();
            this.buttonMain = new System.Windows.Forms.Button();
            this.panelChildform = new System.Windows.Forms.Panel();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.labelSearch = new System.Windows.Forms.Label();
            this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.buttonWeiterPatientsübersicht = new System.Windows.Forms.Button();
            this.dataGridViewPatient = new System.Windows.Forms.DataGridView();
            this.personSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ambulantCareDBDataSet = new DataManager.AmbulantCareDBDataSet();
            this.labelPatient = new System.Windows.Forms.Label();
            this.labelToDoListe = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.DatumUhr = new System.Windows.Forms.Timer(this.components);
            this.personSetTableAdapter = new DataManager.AmbulantCareDBDataSetTableAdapters.PersonSetTableAdapter();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.personIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMenu.SuspendLayout();
            this.panelLogout.SuspendLayout();
            this.panelHome.SuspendLayout();
            this.panelChildform.SuspendLayout();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambulantCareDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.panelMenu.Controls.Add(this.panelLogout);
            this.panelMenu.Controls.Add(this.buttonOthers);
            this.panelMenu.Controls.Add(this.buttonHome);
            this.panelMenu.Controls.Add(this.buttonMedication);
            this.panelMenu.Controls.Add(this.buttonCareReport);
            this.panelMenu.Controls.Add(this.buttonHealthData);
            this.panelMenu.Controls.Add(this.buttonCaseHistory);
            this.panelMenu.Controls.Add(this.buttonActionPlan);
            this.panelMenu.Controls.Add(this.buttonBiography);
            this.panelMenu.Controls.Add(this.buttonBaseData);
            this.panelMenu.Controls.Add(this.panelHome);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(234, 591);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogout
            // 
            this.panelLogout.Controls.Add(this.buttonLogout);
            this.panelLogout.Location = new System.Drawing.Point(3, 528);
            this.panelLogout.Name = "panelLogout";
            this.panelLogout.Size = new System.Drawing.Size(228, 60);
            this.panelLogout.TabIndex = 10;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.buttonLogout.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonLogout.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogout.Image")));
            this.buttonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.Location = new System.Drawing.Point(0, 3);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(228, 57);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonOthers
            // 
            this.buttonOthers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOthers.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonOthers.FlatAppearance.BorderSize = 0;
            this.buttonOthers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOthers.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonOthers.Image = ((System.Drawing.Image)(resources.GetObject("buttonOthers.Image")));
            this.buttonOthers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOthers.Location = new System.Drawing.Point(0, 437);
            this.buttonOthers.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOthers.Name = "buttonOthers";
            this.buttonOthers.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.buttonOthers.Size = new System.Drawing.Size(234, 38);
            this.buttonOthers.TabIndex = 9;
            this.buttonOthers.Text = "Sonstiges";
            this.buttonOthers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOthers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOthers.UseVisualStyleBackColor = true;
            this.buttonOthers.Click += new System.EventHandler(this.buttonOthers_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.Location = new System.Drawing.Point(0, 399);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.buttonHome.Size = new System.Drawing.Size(234, 38);
            this.buttonHome.TabIndex = 8;
            this.buttonHome.Text = "Zuhause";
            this.buttonHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonMedication
            // 
            this.buttonMedication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMedication.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMedication.FlatAppearance.BorderSize = 0;
            this.buttonMedication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMedication.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonMedication.Image = ((System.Drawing.Image)(resources.GetObject("buttonMedication.Image")));
            this.buttonMedication.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMedication.Location = new System.Drawing.Point(0, 361);
            this.buttonMedication.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMedication.Name = "buttonMedication";
            this.buttonMedication.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.buttonMedication.Size = new System.Drawing.Size(234, 38);
            this.buttonMedication.TabIndex = 7;
            this.buttonMedication.Text = "Medikamente";
            this.buttonMedication.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMedication.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMedication.UseVisualStyleBackColor = true;
            this.buttonMedication.Click += new System.EventHandler(this.buttonMedication_Click);
            // 
            // buttonCareReport
            // 
            this.buttonCareReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCareReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCareReport.FlatAppearance.BorderSize = 0;
            this.buttonCareReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCareReport.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonCareReport.Image = ((System.Drawing.Image)(resources.GetObject("buttonCareReport.Image")));
            this.buttonCareReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCareReport.Location = new System.Drawing.Point(0, 323);
            this.buttonCareReport.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCareReport.Name = "buttonCareReport";
            this.buttonCareReport.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.buttonCareReport.Size = new System.Drawing.Size(234, 38);
            this.buttonCareReport.TabIndex = 6;
            this.buttonCareReport.Text = "Pflegebericht";
            this.buttonCareReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCareReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCareReport.UseVisualStyleBackColor = true;
            this.buttonCareReport.Click += new System.EventHandler(this.buttonCareReport_Click);
            // 
            // buttonHealthData
            // 
            this.buttonHealthData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHealthData.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHealthData.FlatAppearance.BorderSize = 0;
            this.buttonHealthData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHealthData.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonHealthData.Image = ((System.Drawing.Image)(resources.GetObject("buttonHealthData.Image")));
            this.buttonHealthData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHealthData.Location = new System.Drawing.Point(0, 285);
            this.buttonHealthData.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHealthData.Name = "buttonHealthData";
            this.buttonHealthData.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.buttonHealthData.Size = new System.Drawing.Size(234, 38);
            this.buttonHealthData.TabIndex = 5;
            this.buttonHealthData.Text = "Gesundheitszustand";
            this.buttonHealthData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHealthData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHealthData.UseVisualStyleBackColor = true;
            this.buttonHealthData.Click += new System.EventHandler(this.buttonHealthData_Click);
            // 
            // buttonCaseHistory
            // 
            this.buttonCaseHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCaseHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCaseHistory.FlatAppearance.BorderSize = 0;
            this.buttonCaseHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCaseHistory.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonCaseHistory.Image = ((System.Drawing.Image)(resources.GetObject("buttonCaseHistory.Image")));
            this.buttonCaseHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCaseHistory.Location = new System.Drawing.Point(0, 247);
            this.buttonCaseHistory.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCaseHistory.Name = "buttonCaseHistory";
            this.buttonCaseHistory.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.buttonCaseHistory.Size = new System.Drawing.Size(234, 38);
            this.buttonCaseHistory.TabIndex = 4;
            this.buttonCaseHistory.Text = "Anamnese";
            this.buttonCaseHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCaseHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCaseHistory.UseVisualStyleBackColor = true;
            this.buttonCaseHistory.Click += new System.EventHandler(this.buttonCaseHistory_Click);
            // 
            // buttonActionPlan
            // 
            this.buttonActionPlan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonActionPlan.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonActionPlan.FlatAppearance.BorderSize = 0;
            this.buttonActionPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActionPlan.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonActionPlan.Image = ((System.Drawing.Image)(resources.GetObject("buttonActionPlan.Image")));
            this.buttonActionPlan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonActionPlan.Location = new System.Drawing.Point(0, 209);
            this.buttonActionPlan.Margin = new System.Windows.Forms.Padding(2);
            this.buttonActionPlan.Name = "buttonActionPlan";
            this.buttonActionPlan.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.buttonActionPlan.Size = new System.Drawing.Size(234, 38);
            this.buttonActionPlan.TabIndex = 3;
            this.buttonActionPlan.Text = "Maßnahmenplan";
            this.buttonActionPlan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonActionPlan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonActionPlan.UseVisualStyleBackColor = true;
            this.buttonActionPlan.Click += new System.EventHandler(this.buttonActionPlan_Click);
            // 
            // buttonBiography
            // 
            this.buttonBiography.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBiography.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBiography.FlatAppearance.BorderSize = 0;
            this.buttonBiography.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBiography.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonBiography.Image = ((System.Drawing.Image)(resources.GetObject("buttonBiography.Image")));
            this.buttonBiography.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBiography.Location = new System.Drawing.Point(0, 171);
            this.buttonBiography.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBiography.Name = "buttonBiography";
            this.buttonBiography.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.buttonBiography.Size = new System.Drawing.Size(234, 38);
            this.buttonBiography.TabIndex = 2;
            this.buttonBiography.Text = "Biografie";
            this.buttonBiography.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBiography.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBiography.UseVisualStyleBackColor = true;
            this.buttonBiography.Click += new System.EventHandler(this.buttonBiography_Click);
            // 
            // buttonBaseData
            // 
            this.buttonBaseData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBaseData.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBaseData.FlatAppearance.BorderSize = 0;
            this.buttonBaseData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBaseData.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonBaseData.Image = ((System.Drawing.Image)(resources.GetObject("buttonBaseData.Image")));
            this.buttonBaseData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBaseData.Location = new System.Drawing.Point(0, 133);
            this.buttonBaseData.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBaseData.Name = "buttonBaseData";
            this.buttonBaseData.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.buttonBaseData.Size = new System.Drawing.Size(234, 38);
            this.buttonBaseData.TabIndex = 1;
            this.buttonBaseData.Text = "Stammdaten";
            this.buttonBaseData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBaseData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBaseData.UseVisualStyleBackColor = true;
            this.buttonBaseData.Click += new System.EventHandler(this.buttonBaseData_Click);
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.buttonMain);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Margin = new System.Windows.Forms.Padding(2);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(234, 133);
            this.panelHome.TabIndex = 0;
            // 
            // buttonMain
            // 
            this.buttonMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMain.FlatAppearance.BorderSize = 0;
            this.buttonMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMain.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.buttonMain.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonMain.Image = ((System.Drawing.Image)(resources.GetObject("buttonMain.Image")));
            this.buttonMain.Location = new System.Drawing.Point(0, 0);
            this.buttonMain.Name = "buttonMain";
            this.buttonMain.Size = new System.Drawing.Size(234, 133);
            this.buttonMain.TabIndex = 1;
            this.buttonMain.UseVisualStyleBackColor = true;
            this.buttonMain.Click += new System.EventHandler(this.buttonMain_Click);
            // 
            // panelChildform
            // 
            this.panelChildform.AutoScroll = true;
            this.panelChildform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            this.panelChildform.Controls.Add(this.panelSearch);
            this.panelChildform.Controls.Add(this.label1);
            this.panelChildform.Controls.Add(this.checkedListBox);
            this.panelChildform.Controls.Add(this.buttonWeiterPatientsübersicht);
            this.panelChildform.Controls.Add(this.dataGridViewPatient);
            this.panelChildform.Controls.Add(this.labelPatient);
            this.panelChildform.Controls.Add(this.labelToDoListe);
            this.panelChildform.Controls.Add(this.labelDatum);
            this.panelChildform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildform.Location = new System.Drawing.Point(234, 0);
            this.panelChildform.Name = "panelChildform";
            this.panelChildform.Size = new System.Drawing.Size(766, 591);
            this.panelChildform.TabIndex = 1;
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            this.panelSearch.Controls.Add(this.labelSearch);
            this.panelSearch.Controls.Add(this.pictureBoxSearch);
            this.panelSearch.Controls.Add(this.textBoxSearch);
            this.panelSearch.Location = new System.Drawing.Point(345, 171);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(409, 38);
            this.panelSearch.TabIndex = 61;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            this.labelSearch.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.labelSearch.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelSearch.Location = new System.Drawing.Point(42, 6);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(81, 23);
            this.labelSearch.TabIndex = 60;
            this.labelSearch.Text = "Suche :";
            // 
            // pictureBoxSearch
            // 
            this.pictureBoxSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxSearch.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSearch.Image")));
            this.pictureBoxSearch.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxSearch.Name = "pictureBoxSearch";
            this.pictureBoxSearch.Size = new System.Drawing.Size(36, 38);
            this.pictureBoxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSearch.TabIndex = 57;
            this.pictureBoxSearch.TabStop = false;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxSearch.Location = new System.Drawing.Point(109, 6);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(275, 25);
            this.textBoxSearch.TabIndex = 56;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSuche_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 37);
            this.label1.TabIndex = 59;
            this.label1.Text = "Welcome !";
            // 
            // checkedListBox
            // 
            this.checkedListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            this.checkedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox.CheckOnClick = true;
            this.checkedListBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(33, 187);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(293, 54);
            this.checkedListBox.TabIndex = 58;
            // 
            // buttonWeiterPatientsübersicht
            // 
            this.buttonWeiterPatientsübersicht.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonWeiterPatientsübersicht.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(104)))), ((int)(((byte)(177)))));
            this.buttonWeiterPatientsübersicht.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWeiterPatientsübersicht.FlatAppearance.BorderSize = 0;
            this.buttonWeiterPatientsübersicht.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWeiterPatientsübersicht.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonWeiterPatientsübersicht.Location = new System.Drawing.Point(345, 506);
            this.buttonWeiterPatientsübersicht.Name = "buttonWeiterPatientsübersicht";
            this.buttonWeiterPatientsübersicht.Size = new System.Drawing.Size(255, 51);
            this.buttonWeiterPatientsübersicht.TabIndex = 5;
            this.buttonWeiterPatientsübersicht.Text = "Weiter zur Patientsübersicht";
            this.buttonWeiterPatientsübersicht.UseVisualStyleBackColor = false;
            this.buttonWeiterPatientsübersicht.Click += new System.EventHandler(this.buttonWeiterPatientsübersicht_Click);
            // 
            // dataGridViewPatient
            // 
            this.dataGridViewPatient.AutoGenerateColumns = false;
            this.dataGridViewPatient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPatient.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPatient.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            this.dataGridViewPatient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPatient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(104)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPatient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPatient.ColumnHeadersHeight = 30;
            this.dataGridViewPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewPatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personIDDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.dataGridViewPatient.DataSource = this.personSetBindingSource;
            this.dataGridViewPatient.EnableHeadersVisualStyles = false;
            this.dataGridViewPatient.GridColor = System.Drawing.Color.MediumPurple;
            this.dataGridViewPatient.Location = new System.Drawing.Point(343, 233);
            this.dataGridViewPatient.Name = "dataGridViewPatient";
            this.dataGridViewPatient.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(123)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPatient.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPatient.RowHeadersVisible = false;
            this.dataGridViewPatient.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(123)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewPatient.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPatient.RowTemplate.Height = 24;
            this.dataGridViewPatient.Size = new System.Drawing.Size(411, 251);
            this.dataGridViewPatient.TabIndex = 4;
            // 
            // personSetBindingSource
            // 
            this.personSetBindingSource.DataMember = "PersonSet";
            this.personSetBindingSource.DataSource = this.ambulantCareDBDataSet;
            // 
            // ambulantCareDBDataSet
            // 
            this.ambulantCareDBDataSet.DataSetName = "AmbulantCareDBDataSet";
            this.ambulantCareDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelPatient
            // 
            this.labelPatient.AutoSize = true;
            this.labelPatient.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatient.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelPatient.Location = new System.Drawing.Point(336, 128);
            this.labelPatient.Name = "labelPatient";
            this.labelPatient.Size = new System.Drawing.Size(156, 37);
            this.labelPatient.TabIndex = 3;
            this.labelPatient.Text = "Patienten";
            // 
            // labelToDoListe
            // 
            this.labelToDoListe.AutoSize = true;
            this.labelToDoListe.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToDoListe.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelToDoListe.Location = new System.Drawing.Point(19, 128);
            this.labelToDoListe.Name = "labelToDoListe";
            this.labelToDoListe.Size = new System.Drawing.Size(169, 37);
            this.labelToDoListe.TabIndex = 2;
            this.labelToDoListe.Text = "To do Liste";
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatum.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelDatum.Location = new System.Drawing.Point(183, 22);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(115, 37);
            this.labelDatum.TabIndex = 1;
            this.labelDatum.Text = "Datum";
            // 
            // DatumUhr
            // 
            this.DatumUhr.Enabled = true;
            this.DatumUhr.Tick += new System.EventHandler(this.DatumUhr_Tick);
            // 
            // personSetTableAdapter
            // 
            this.personSetTableAdapter.ClearBeforeFill = true;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // personIDDataGridViewTextBoxColumn
            // 
            this.personIDDataGridViewTextBoxColumn.DataPropertyName = "PersonID";
            this.personIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.personIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personIDDataGridViewTextBoxColumn.Name = "personIDDataGridViewTextBoxColumn";
            this.personIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.personIDDataGridViewTextBoxColumn.Width = 52;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Nachname";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 591);
            this.Controls.Add(this.panelChildform);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(920, 600);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Care Solution";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogout.ResumeLayout(false);
            this.panelHome.ResumeLayout(false);
            this.panelChildform.ResumeLayout(false);
            this.panelChildform.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambulantCareDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonOthers;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonMedication;
        private System.Windows.Forms.Button buttonCareReport;
        private System.Windows.Forms.Button buttonHealthData;
        private System.Windows.Forms.Button buttonCaseHistory;
        private System.Windows.Forms.Button buttonActionPlan;
        private System.Windows.Forms.Button buttonBiography;
        private System.Windows.Forms.Button buttonBaseData;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Panel panelChildform;
        private System.Windows.Forms.Panel panelLogout;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonMain;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Timer DatumUhr;
        private System.Windows.Forms.Label labelToDoListe;
        private System.Windows.Forms.DataGridView dataGridViewPatient;
        private System.Windows.Forms.Label labelPatient;
        private System.Windows.Forms.Button buttonWeiterPatientsübersicht;
        private System.Windows.Forms.PictureBox pictureBoxSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.Label label1;
        private DataManager.AmbulantCareDBDataSet ambulantCareDBDataSet;
        private System.Windows.Forms.BindingSource personSetBindingSource;
        private DataManager.AmbulantCareDBDataSetTableAdapters.PersonSetTableAdapter personSetTableAdapter;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Panel panelSearch;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.DataGridViewTextBoxColumn personIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
    }
}