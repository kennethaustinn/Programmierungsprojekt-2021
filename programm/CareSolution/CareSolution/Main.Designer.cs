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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogout = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonSonstiges = new System.Windows.Forms.Button();
            this.buttonZuhause = new System.Windows.Forms.Button();
            this.buttonMedikamente = new System.Windows.Forms.Button();
            this.buttonPflegebericht = new System.Windows.Forms.Button();
            this.buttonGesundheitszustand = new System.Windows.Forms.Button();
            this.buttonAnamnese = new System.Windows.Forms.Button();
            this.buttonMaßnahmenplan = new System.Windows.Forms.Button();
            this.buttonBiographie = new System.Windows.Forms.Button();
            this.buttonStammdaten = new System.Windows.Forms.Button();
            this.panelHome = new System.Windows.Forms.Panel();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panelChildform = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxSuche = new System.Windows.Forms.TextBox();
            this.buttonWeiterPatientsübersicht = new System.Windows.Forms.Button();
            this.dataGridViewPatient = new System.Windows.Forms.DataGridView();
            this.labelPatient = new System.Windows.Forms.Label();
            this.labelToDoListe = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.DatumUhr = new System.Windows.Forms.Timer(this.components);
            this.ambulantCareDBDataSet = new CareSolution.AmbulantCareDBDataSet();
            this.personSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personSetTableAdapter = new CareSolution.AmbulantCareDBDataSetTableAdapters.PersonSetTableAdapter();
            this.personIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogout.SuspendLayout();
            this.panelHome.SuspendLayout();
            this.panelChildform.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambulantCareDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.panelMenu.Controls.Add(this.panelLogout);
            this.panelMenu.Controls.Add(this.buttonSonstiges);
            this.panelMenu.Controls.Add(this.buttonZuhause);
            this.panelMenu.Controls.Add(this.buttonMedikamente);
            this.panelMenu.Controls.Add(this.buttonPflegebericht);
            this.panelMenu.Controls.Add(this.buttonGesundheitszustand);
            this.panelMenu.Controls.Add(this.buttonAnamnese);
            this.panelMenu.Controls.Add(this.buttonMaßnahmenplan);
            this.panelMenu.Controls.Add(this.buttonBiographie);
            this.panelMenu.Controls.Add(this.buttonStammdaten);
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
            // buttonSonstiges
            // 
            this.buttonSonstiges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSonstiges.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSonstiges.FlatAppearance.BorderSize = 0;
            this.buttonSonstiges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSonstiges.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSonstiges.Image = ((System.Drawing.Image)(resources.GetObject("buttonSonstiges.Image")));
            this.buttonSonstiges.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSonstiges.Location = new System.Drawing.Point(0, 437);
            this.buttonSonstiges.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSonstiges.Name = "buttonSonstiges";
            this.buttonSonstiges.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.buttonSonstiges.Size = new System.Drawing.Size(234, 38);
            this.buttonSonstiges.TabIndex = 9;
            this.buttonSonstiges.Text = "Sonstiges";
            this.buttonSonstiges.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSonstiges.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSonstiges.UseVisualStyleBackColor = true;
            this.buttonSonstiges.Click += new System.EventHandler(this.buttonSonstiges_Click);
            // 
            // buttonZuhause
            // 
            this.buttonZuhause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonZuhause.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonZuhause.FlatAppearance.BorderSize = 0;
            this.buttonZuhause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZuhause.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonZuhause.Image = ((System.Drawing.Image)(resources.GetObject("buttonZuhause.Image")));
            this.buttonZuhause.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonZuhause.Location = new System.Drawing.Point(0, 399);
            this.buttonZuhause.Margin = new System.Windows.Forms.Padding(2);
            this.buttonZuhause.Name = "buttonZuhause";
            this.buttonZuhause.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.buttonZuhause.Size = new System.Drawing.Size(234, 38);
            this.buttonZuhause.TabIndex = 8;
            this.buttonZuhause.Text = "Zuhause";
            this.buttonZuhause.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonZuhause.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonZuhause.UseVisualStyleBackColor = true;
            this.buttonZuhause.Click += new System.EventHandler(this.buttonZuhause_Click);
            // 
            // buttonMedikamente
            // 
            this.buttonMedikamente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMedikamente.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMedikamente.FlatAppearance.BorderSize = 0;
            this.buttonMedikamente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMedikamente.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonMedikamente.Image = ((System.Drawing.Image)(resources.GetObject("buttonMedikamente.Image")));
            this.buttonMedikamente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMedikamente.Location = new System.Drawing.Point(0, 361);
            this.buttonMedikamente.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMedikamente.Name = "buttonMedikamente";
            this.buttonMedikamente.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.buttonMedikamente.Size = new System.Drawing.Size(234, 38);
            this.buttonMedikamente.TabIndex = 7;
            this.buttonMedikamente.Text = "Medikamente";
            this.buttonMedikamente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMedikamente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMedikamente.UseVisualStyleBackColor = true;
            this.buttonMedikamente.Click += new System.EventHandler(this.buttonMedikamente_Click);
            // 
            // buttonPflegebericht
            // 
            this.buttonPflegebericht.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPflegebericht.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPflegebericht.FlatAppearance.BorderSize = 0;
            this.buttonPflegebericht.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPflegebericht.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonPflegebericht.Image = ((System.Drawing.Image)(resources.GetObject("buttonPflegebericht.Image")));
            this.buttonPflegebericht.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPflegebericht.Location = new System.Drawing.Point(0, 323);
            this.buttonPflegebericht.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPflegebericht.Name = "buttonPflegebericht";
            this.buttonPflegebericht.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.buttonPflegebericht.Size = new System.Drawing.Size(234, 38);
            this.buttonPflegebericht.TabIndex = 6;
            this.buttonPflegebericht.Text = "Pflegebericht";
            this.buttonPflegebericht.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPflegebericht.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPflegebericht.UseVisualStyleBackColor = true;
            this.buttonPflegebericht.Click += new System.EventHandler(this.buttonPflegebericht_Click);
            // 
            // buttonGesundheitszustand
            // 
            this.buttonGesundheitszustand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGesundheitszustand.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGesundheitszustand.FlatAppearance.BorderSize = 0;
            this.buttonGesundheitszustand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGesundheitszustand.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonGesundheitszustand.Image = ((System.Drawing.Image)(resources.GetObject("buttonGesundheitszustand.Image")));
            this.buttonGesundheitszustand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGesundheitszustand.Location = new System.Drawing.Point(0, 285);
            this.buttonGesundheitszustand.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGesundheitszustand.Name = "buttonGesundheitszustand";
            this.buttonGesundheitszustand.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.buttonGesundheitszustand.Size = new System.Drawing.Size(234, 38);
            this.buttonGesundheitszustand.TabIndex = 5;
            this.buttonGesundheitszustand.Text = "Gesundheitszustand";
            this.buttonGesundheitszustand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGesundheitszustand.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGesundheitszustand.UseVisualStyleBackColor = true;
            this.buttonGesundheitszustand.Click += new System.EventHandler(this.buttonGesundheitszustand_Click);
            // 
            // buttonAnamnese
            // 
            this.buttonAnamnese.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAnamnese.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAnamnese.FlatAppearance.BorderSize = 0;
            this.buttonAnamnese.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnamnese.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonAnamnese.Image = ((System.Drawing.Image)(resources.GetObject("buttonAnamnese.Image")));
            this.buttonAnamnese.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAnamnese.Location = new System.Drawing.Point(0, 247);
            this.buttonAnamnese.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAnamnese.Name = "buttonAnamnese";
            this.buttonAnamnese.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.buttonAnamnese.Size = new System.Drawing.Size(234, 38);
            this.buttonAnamnese.TabIndex = 4;
            this.buttonAnamnese.Text = "Anamnese";
            this.buttonAnamnese.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAnamnese.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAnamnese.UseVisualStyleBackColor = true;
            this.buttonAnamnese.Click += new System.EventHandler(this.buttonAnamnese_Click);
            // 
            // buttonMaßnahmenplan
            // 
            this.buttonMaßnahmenplan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMaßnahmenplan.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMaßnahmenplan.FlatAppearance.BorderSize = 0;
            this.buttonMaßnahmenplan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaßnahmenplan.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonMaßnahmenplan.Image = ((System.Drawing.Image)(resources.GetObject("buttonMaßnahmenplan.Image")));
            this.buttonMaßnahmenplan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMaßnahmenplan.Location = new System.Drawing.Point(0, 209);
            this.buttonMaßnahmenplan.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMaßnahmenplan.Name = "buttonMaßnahmenplan";
            this.buttonMaßnahmenplan.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.buttonMaßnahmenplan.Size = new System.Drawing.Size(234, 38);
            this.buttonMaßnahmenplan.TabIndex = 3;
            this.buttonMaßnahmenplan.Text = "Maßnahmenplan";
            this.buttonMaßnahmenplan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMaßnahmenplan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMaßnahmenplan.UseVisualStyleBackColor = true;
            this.buttonMaßnahmenplan.Click += new System.EventHandler(this.buttonMaßnahmenplan_Click);
            // 
            // buttonBiographie
            // 
            this.buttonBiographie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBiographie.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBiographie.FlatAppearance.BorderSize = 0;
            this.buttonBiographie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBiographie.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonBiographie.Image = ((System.Drawing.Image)(resources.GetObject("buttonBiographie.Image")));
            this.buttonBiographie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBiographie.Location = new System.Drawing.Point(0, 171);
            this.buttonBiographie.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBiographie.Name = "buttonBiographie";
            this.buttonBiographie.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.buttonBiographie.Size = new System.Drawing.Size(234, 38);
            this.buttonBiographie.TabIndex = 2;
            this.buttonBiographie.Text = "Biografie";
            this.buttonBiographie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBiographie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBiographie.UseVisualStyleBackColor = true;
            this.buttonBiographie.Click += new System.EventHandler(this.buttonBiography_Click);
            // 
            // buttonStammdaten
            // 
            this.buttonStammdaten.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStammdaten.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStammdaten.FlatAppearance.BorderSize = 0;
            this.buttonStammdaten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStammdaten.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonStammdaten.Image = ((System.Drawing.Image)(resources.GetObject("buttonStammdaten.Image")));
            this.buttonStammdaten.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStammdaten.Location = new System.Drawing.Point(0, 133);
            this.buttonStammdaten.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStammdaten.Name = "buttonStammdaten";
            this.buttonStammdaten.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.buttonStammdaten.Size = new System.Drawing.Size(234, 38);
            this.buttonStammdaten.TabIndex = 1;
            this.buttonStammdaten.Text = "Stammdaten";
            this.buttonStammdaten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStammdaten.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonStammdaten.UseVisualStyleBackColor = true;
            this.buttonStammdaten.Click += new System.EventHandler(this.buttonPatientData_Click);
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.buttonHome);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Margin = new System.Windows.Forms.Padding(2);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(234, 133);
            this.panelHome.TabIndex = 0;
            // 
            // buttonHome
            // 
            this.buttonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.buttonHome.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.Location = new System.Drawing.Point(0, 0);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(234, 133);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // panelChildform
            // 
            this.panelChildform.AutoScroll = true;
            this.panelChildform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            this.panelChildform.Controls.Add(this.label2);
            this.panelChildform.Controls.Add(this.label1);
            this.panelChildform.Controls.Add(this.checkedListBox1);
            this.panelChildform.Controls.Add(this.pictureBox1);
            this.panelChildform.Controls.Add(this.textBoxSuche);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 37);
            this.label1.TabIndex = 59;
            this.label1.Text = "Wilkommen !";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(33, 187);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(293, 81);
            this.checkedListBox1.TabIndex = 58;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(343, 187);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxSuche
            // 
            this.textBoxSuche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            this.textBoxSuche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSuche.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSuche.ForeColor = System.Drawing.Color.Gray;
            this.textBoxSuche.Location = new System.Drawing.Point(447, 189);
            this.textBoxSuche.Name = "textBoxSuche";
            this.textBoxSuche.Size = new System.Drawing.Size(240, 25);
            this.textBoxSuche.TabIndex = 56;
            this.textBoxSuche.TextChanged += new System.EventHandler(this.textBoxSuche_TextChanged);
            this.textBoxSuche.Enter += new System.EventHandler(this.textBoxSuche_Enter);
            this.textBoxSuche.Leave += new System.EventHandler(this.textBoxSuche_Leave);
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(104)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPatient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewPatient.ColumnHeadersHeight = 30;
            this.dataGridViewPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewPatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personIDDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn});
            this.dataGridViewPatient.DataSource = this.personSetBindingSource;
            this.dataGridViewPatient.EnableHeadersVisualStyles = false;
            this.dataGridViewPatient.GridColor = System.Drawing.Color.MediumPurple;
            this.dataGridViewPatient.Location = new System.Drawing.Point(343, 233);
            this.dataGridViewPatient.Name = "dataGridViewPatient";
            this.dataGridViewPatient.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(123)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPatient.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewPatient.RowHeadersVisible = false;
            this.dataGridViewPatient.RowHeadersWidth = 51;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(123)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewPatient.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewPatient.RowTemplate.Height = 24;
            this.dataGridViewPatient.Size = new System.Drawing.Size(411, 251);
            this.dataGridViewPatient.TabIndex = 4;
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
            this.labelDatum.Location = new System.Drawing.Point(211, 22);
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
            // ambulantCareDBDataSet
            // 
            this.ambulantCareDBDataSet.DataSetName = "AmbulantCareDBDataSet";
            this.ambulantCareDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personSetBindingSource
            // 
            this.personSetBindingSource.DataMember = "PersonSet";
            this.personSetBindingSource.DataSource = this.ambulantCareDBDataSet;
            // 
            // personSetTableAdapter
            // 
            this.personSetTableAdapter.ClearBeforeFill = true;
            // 
            // personIDDataGridViewTextBoxColumn
            // 
            this.personIDDataGridViewTextBoxColumn.DataPropertyName = "PersonID";
            this.personIDDataGridViewTextBoxColumn.HeaderText = "PersonID";
            this.personIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personIDDataGridViewTextBoxColumn.Name = "personIDDataGridViewTextBoxColumn";
            this.personIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.personIDDataGridViewTextBoxColumn.Width = 101;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 93;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(373, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 60;
            this.label2.Text = "Suche :";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 591);
            this.Controls.Add(this.panelChildform);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambulantCareDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonSonstiges;
        private System.Windows.Forms.Button buttonZuhause;
        private System.Windows.Forms.Button buttonMedikamente;
        private System.Windows.Forms.Button buttonPflegebericht;
        private System.Windows.Forms.Button buttonGesundheitszustand;
        private System.Windows.Forms.Button buttonAnamnese;
        private System.Windows.Forms.Button buttonMaßnahmenplan;
        private System.Windows.Forms.Button buttonBiographie;
        private System.Windows.Forms.Button buttonStammdaten;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Panel panelChildform;
        private System.Windows.Forms.Panel panelLogout;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Timer DatumUhr;
        private System.Windows.Forms.Label labelToDoListe;
        private System.Windows.Forms.DataGridView dataGridViewPatient;
        private System.Windows.Forms.Label labelPatient;
        private System.Windows.Forms.Button buttonWeiterPatientsübersicht;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxSuche;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private AmbulantCareDBDataSet ambulantCareDBDataSet;
        private System.Windows.Forms.BindingSource personSetBindingSource;
        private AmbulantCareDBDataSetTableAdapters.PersonSetTableAdapter personSetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
    }
}