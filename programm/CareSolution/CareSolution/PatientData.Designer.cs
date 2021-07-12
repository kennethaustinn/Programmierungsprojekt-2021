namespace CareSolution
{
    partial class PatientData
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientData));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelPatient = new System.Windows.Forms.Label();
            this.panelPatient = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pflegegrad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonNeueData = new System.Windows.Forms.Button();
            this.panelSuche = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxSuche = new System.Windows.Forms.TextBox();
            this.dataGridViewPatient = new System.Windows.Forms.DataGridView();
            this.personIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ambulantCareDBDataSet = new DataManager.AmbulantCareDBDataSet();
            this.fKPatientinheritsPersonBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personSetTableAdapter = new DataManager.AmbulantCareDBDataSetTableAdapters.PersonSetTableAdapter();
            this.ambulantCareDBDataSet1 = new CareSolution.AmbulantCareDBDataSet();
            this.ambulantCareDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKPatientinheritsPersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelPatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelSuche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambulantCareDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPatientinheritsPersonBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambulantCareDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambulantCareDBDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPatientinheritsPersonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPatient
            // 
            this.labelPatient.AutoSize = true;
            this.labelPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            this.labelPatient.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatient.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelPatient.Location = new System.Drawing.Point(248, 24);
            this.labelPatient.Name = "labelPatient";
            this.labelPatient.Size = new System.Drawing.Size(174, 25);
            this.labelPatient.TabIndex = 34;
            this.labelPatient.Text = "Patienten Data";
            // 
            // panelPatient
            // 
            this.panelPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            this.panelPatient.Controls.Add(this.dataGridView1);
            this.panelPatient.Controls.Add(this.buttonNeueData);
            this.panelPatient.Controls.Add(this.panelSuche);
            this.panelPatient.Controls.Add(this.dataGridViewPatient);
            this.panelPatient.Controls.Add(this.labelPatient);
            this.panelPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPatient.Location = new System.Drawing.Point(0, 0);
            this.panelPatient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelPatient.Name = "panelPatient";
            this.panelPatient.Size = new System.Drawing.Size(748, 544);
            this.panelPatient.TabIndex = 25;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(104)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Adresse,
            this.Alter,
            this.Pflegegrad});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.MediumPurple;
            this.dataGridView1.Location = new System.Drawing.Point(471, 428);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(123)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(123)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(348, 235);
            this.dataGridView1.TabIndex = 71;
            this.dataGridView1.Visible = false;
            // 
            // Adresse
            // 
            this.Adresse.HeaderText = "Adresse";
            this.Adresse.Name = "Adresse";
            this.Adresse.Width = 78;
            // 
            // Alter
            // 
            this.Alter.HeaderText = "Alter";
            this.Alter.Name = "Alter";
            this.Alter.Width = 60;
            // 
            // Pflegegrad
            // 
            this.Pflegegrad.HeaderText = "Pflegegrad";
            this.Pflegegrad.Name = "Pflegegrad";
            this.Pflegegrad.Width = 97;
            // 
            // buttonNeueData
            // 
            this.buttonNeueData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonNeueData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(104)))), ((int)(((byte)(177)))));
            this.buttonNeueData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNeueData.FlatAppearance.BorderSize = 0;
            this.buttonNeueData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNeueData.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNeueData.Location = new System.Drawing.Point(278, 428);
            this.buttonNeueData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonNeueData.Name = "buttonNeueData";
            this.buttonNeueData.Size = new System.Drawing.Size(187, 64);
            this.buttonNeueData.TabIndex = 70;
            this.buttonNeueData.Text = "Patient hinzufügen";
            this.buttonNeueData.UseVisualStyleBackColor = false;
            this.buttonNeueData.Click += new System.EventHandler(this.buttonNeueData_Click);
            // 
            // panelSuche
            // 
            this.panelSuche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            this.panelSuche.Controls.Add(this.label2);
            this.panelSuche.Controls.Add(this.pictureBox2);
            this.panelSuche.Controls.Add(this.textBoxSuche);
            this.panelSuche.Location = new System.Drawing.Point(169, 73);
            this.panelSuche.Name = "panelSuche";
            this.panelSuche.Size = new System.Drawing.Size(409, 38);
            this.panelSuche.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(42, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 60;
            this.label2.Text = "Suche :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            // 
            // textBoxSuche
            // 
            this.textBoxSuche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            this.textBoxSuche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSuche.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSuche.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxSuche.Location = new System.Drawing.Point(109, 6);
            this.textBoxSuche.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSuche.Name = "textBoxSuche";
            this.textBoxSuche.Size = new System.Drawing.Size(300, 20);
            this.textBoxSuche.TabIndex = 54;
            this.textBoxSuche.TextChanged += new System.EventHandler(this.textBoxSuche_TextChanged);
            // 
            // dataGridViewPatient
            // 
            this.dataGridViewPatient.AutoGenerateColumns = false;
            this.dataGridViewPatient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPatient.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPatient.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            this.dataGridViewPatient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPatient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(104)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPatient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewPatient.ColumnHeadersHeight = 30;
            this.dataGridViewPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewPatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personIDDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.dataGridViewPatient.DataSource = this.personSetBindingSource;
            this.dataGridViewPatient.EnableHeadersVisualStyles = false;
            this.dataGridViewPatient.GridColor = System.Drawing.Color.MediumPurple;
            this.dataGridViewPatient.Location = new System.Drawing.Point(140, 134);
            this.dataGridViewPatient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewPatient.Name = "dataGridViewPatient";
            this.dataGridViewPatient.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(123)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPatient.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewPatient.RowHeadersVisible = false;
            this.dataGridViewPatient.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(123)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewPatient.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewPatient.RowTemplate.Height = 24;
            this.dataGridViewPatient.Size = new System.Drawing.Size(467, 286);
            this.dataGridViewPatient.TabIndex = 35;
            this.dataGridViewPatient.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPatient_CellDoubleClick);
            // 
            // personIDDataGridViewTextBoxColumn
            // 
            this.personIDDataGridViewTextBoxColumn.DataPropertyName = "PersonID";
            this.personIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.personIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personIDDataGridViewTextBoxColumn.Name = "personIDDataGridViewTextBoxColumn";
            this.personIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.personIDDataGridViewTextBoxColumn.Width = 43;
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
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "Vorname";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Geschlecht";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
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
            // fKPatientinheritsPersonBindingSource1
            // 
            this.fKPatientinheritsPersonBindingSource1.DataMember = "FK_Patient_inherits_Person";
            this.fKPatientinheritsPersonBindingSource1.DataSource = this.personSetBindingSource;
            // 
            // personSetTableAdapter
            // 
            this.personSetTableAdapter.ClearBeforeFill = true;
            // 
            // ambulantCareDBDataSet1
            // 
            this.ambulantCareDBDataSet1.DataSetName = "AmbulantCareDBDataSet";
            this.ambulantCareDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ambulantCareDBDataSet1BindingSource
            // 
            this.ambulantCareDBDataSet1BindingSource.DataSource = this.ambulantCareDBDataSet1;
            this.ambulantCareDBDataSet1BindingSource.Position = 0;
            // 
            // fKPatientinheritsPersonBindingSource
            // 
            this.fKPatientinheritsPersonBindingSource.DataMember = "FK_Patient_inherits_Person";
            this.fKPatientinheritsPersonBindingSource.DataSource = this.personSetBindingSource;
            // 
            // PatientData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 544);
            this.Controls.Add(this.panelPatient);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PatientData";
            this.Text = "PatientData";
            this.Load += new System.EventHandler(this.PatientData_Load);
            this.panelPatient.ResumeLayout(false);
            this.panelPatient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelSuche.ResumeLayout(false);
            this.panelSuche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambulantCareDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPatientinheritsPersonBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambulantCareDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambulantCareDBDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPatientinheritsPersonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPatient;
        private System.Windows.Forms.Panel panelPatient;
        private System.Windows.Forms.DataGridView dataGridViewPatient;
        private DataManager.AmbulantCareDBDataSet ambulantCareDBDataSet;
        private DataManager.AmbulantCareDBDataSetTableAdapters.PersonSetTableAdapter personSetTableAdapter;
        private System.Windows.Forms.BindingSource personSetBindingSource;
        private System.Windows.Forms.Panel panelSuche;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxSuche;
        private System.Windows.Forms.Button buttonNeueData;
        private AmbulantCareDBDataSet ambulantCareDBDataSet1;
        private System.Windows.Forms.BindingSource ambulantCareDBDataSet1BindingSource;
        private System.Windows.Forms.BindingSource fKPatientinheritsPersonBindingSource1;
        private System.Windows.Forms.BindingSource fKPatientinheritsPersonBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pflegegrad;
        private System.Windows.Forms.DataGridViewTextBoxColumn personIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
    }
}