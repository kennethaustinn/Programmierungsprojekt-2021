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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientData));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelPatient = new System.Windows.Forms.Label();
            this.panelPatient = new System.Windows.Forms.Panel();
            this.buttonNeueData = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxSuche = new System.Windows.Forms.TextBox();
            this.dataGridViewPatient = new System.Windows.Forms.DataGridView();
            this.ambulantCareDBDataSet = new CareSolution.AmbulantCareDBDataSet();
            this.personSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personSetTableAdapter = new CareSolution.AmbulantCareDBDataSetTableAdapters.PersonSetTableAdapter();
            this.personIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelPatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambulantCareDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personSetBindingSource)).BeginInit();
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
            this.panelPatient.Controls.Add(this.buttonNeueData);
            this.panelPatient.Controls.Add(this.pictureBox1);
            this.panelPatient.Controls.Add(this.textBoxSuche);
            this.panelPatient.Controls.Add(this.dataGridViewPatient);
            this.panelPatient.Controls.Add(this.labelPatient);
            this.panelPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPatient.Location = new System.Drawing.Point(0, 0);
            this.panelPatient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelPatient.Name = "panelPatient";
            this.panelPatient.Size = new System.Drawing.Size(748, 544);
            this.panelPatient.TabIndex = 25;
            // 
            // buttonNeueData
            // 
            this.buttonNeueData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonNeueData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(104)))), ((int)(((byte)(177)))));
            this.buttonNeueData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNeueData.FlatAppearance.BorderSize = 0;
            this.buttonNeueData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNeueData.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNeueData.Location = new System.Drawing.Point(279, 481);
            this.buttonNeueData.Name = "buttonNeueData";
            this.buttonNeueData.Size = new System.Drawing.Size(166, 51);
            this.buttonNeueData.TabIndex = 56;
            this.buttonNeueData.Text = "Neue hinzufügen";
            this.buttonNeueData.UseVisualStyleBackColor = false;
            this.buttonNeueData.Click += new System.EventHandler(this.buttonNeueData_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(245, 82);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxSuche
            // 
            this.textBoxSuche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            this.textBoxSuche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSuche.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSuche.ForeColor = System.Drawing.Color.Gray;
            this.textBoxSuche.Location = new System.Drawing.Point(279, 82);
            this.textBoxSuche.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSuche.Name = "textBoxSuche";
            this.textBoxSuche.Size = new System.Drawing.Size(270, 20);
            this.textBoxSuche.TabIndex = 54;
            this.textBoxSuche.Text = "Suche";
            this.textBoxSuche.TextChanged += new System.EventHandler(this.textBoxSuche_TextChanged);
            this.textBoxSuche.Enter += new System.EventHandler(this.textBoxSuche_Enter);
            this.textBoxSuche.Leave += new System.EventHandler(this.textBoxSuche_Leave);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.genderDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.dataGridViewPatient.DataSource = this.personSetBindingSource;
            this.dataGridViewPatient.EnableHeadersVisualStyles = false;
            this.dataGridViewPatient.GridColor = System.Drawing.Color.MediumPurple;
            this.dataGridViewPatient.Location = new System.Drawing.Point(43, 145);
            this.dataGridViewPatient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewPatient.Name = "dataGridViewPatient";
            this.dataGridViewPatient.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dataGridViewPatient.Size = new System.Drawing.Size(674, 135);
            this.dataGridViewPatient.TabIndex = 35;
            this.dataGridViewPatient.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPatient_CellDoubleClick);
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
            this.personIDDataGridViewTextBoxColumn.Name = "personIDDataGridViewTextBoxColumn";
            this.personIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.personIDDataGridViewTextBoxColumn.Width = 82;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 91;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 90;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 76;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 68;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambulantCareDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPatient;
        private System.Windows.Forms.Panel panelPatient;
        private System.Windows.Forms.DataGridView dataGridViewPatient;
        private System.Windows.Forms.TextBox textBoxSuche;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonNeueData;
        private AmbulantCareDBDataSet ambulantCareDBDataSet;
        private System.Windows.Forms.BindingSource personSetBindingSource;
        private AmbulantCareDBDataSetTableAdapters.PersonSetTableAdapter personSetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
    }
}