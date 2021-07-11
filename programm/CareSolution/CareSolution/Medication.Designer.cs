﻿namespace CareSolution
{
    partial class Medication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medication));
            this.panelBio = new System.Windows.Forms.Panel();
            this.dataGridViewMedikamente = new System.Windows.Forms.DataGridView();
            this.drugDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frequencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.administeredByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicationSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ambulantCareDBDataSet = new CareSolution.AmbulantCareDBDataSet();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.pictureBoxTopMenu = new System.Windows.Forms.PictureBox();
            this.panelProfil = new System.Windows.Forms.Panel();
            this.labelFullName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.medicationSetTableAdapter = new CareSolution.AmbulantCareDBDataSetTableAdapters.MedicationSetTableAdapter();
            this.panelBio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedikamente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicationSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambulantCareDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopMenu)).BeginInit();
            this.panelProfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBio
            // 
            this.panelBio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            this.panelBio.Controls.Add(this.dataGridViewMedikamente);
            this.panelBio.Controls.Add(this.buttonEdit);
            this.panelBio.Controls.Add(this.pictureBoxTopMenu);
            this.panelBio.Controls.Add(this.panelProfil);
            this.panelBio.Controls.Add(this.label4);
            this.panelBio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBio.Location = new System.Drawing.Point(0, 0);
            this.panelBio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelBio.Name = "panelBio";
            this.panelBio.Size = new System.Drawing.Size(748, 544);
            this.panelBio.TabIndex = 25;
            // 
            // dataGridViewMedikamente
            // 
            this.dataGridViewMedikamente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMedikamente.AutoGenerateColumns = false;
            this.dataGridViewMedikamente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewMedikamente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewMedikamente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            this.dataGridViewMedikamente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMedikamente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(104)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMedikamente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMedikamente.ColumnHeadersHeight = 30;
            this.dataGridViewMedikamente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewMedikamente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.drugDataGridViewTextBoxColumn,
            this.dosageDataGridViewTextBoxColumn,
            this.frequencyDataGridViewTextBoxColumn,
            this.administeredByDataGridViewTextBoxColumn});
            this.dataGridViewMedikamente.DataSource = this.medicationSetBindingSource;
            this.dataGridViewMedikamente.EnableHeadersVisualStyles = false;
            this.dataGridViewMedikamente.GridColor = System.Drawing.Color.MediumPurple;
            this.dataGridViewMedikamente.Location = new System.Drawing.Point(28, 101);
            this.dataGridViewMedikamente.Name = "dataGridViewMedikamente";
            this.dataGridViewMedikamente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(123)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMedikamente.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMedikamente.RowHeadersVisible = false;
            this.dataGridViewMedikamente.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(123)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewMedikamente.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewMedikamente.RowTemplate.Height = 24;
            this.dataGridViewMedikamente.Size = new System.Drawing.Size(689, 321);
            this.dataGridViewMedikamente.TabIndex = 110;
            // 
            // drugDataGridViewTextBoxColumn
            // 
            this.drugDataGridViewTextBoxColumn.DataPropertyName = "Drug";
            this.drugDataGridViewTextBoxColumn.HeaderText = "Drug";
            this.drugDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.drugDataGridViewTextBoxColumn.Name = "drugDataGridViewTextBoxColumn";
            this.drugDataGridViewTextBoxColumn.Width = 59;
            // 
            // dosageDataGridViewTextBoxColumn
            // 
            this.dosageDataGridViewTextBoxColumn.DataPropertyName = "Dosage";
            this.dosageDataGridViewTextBoxColumn.HeaderText = "Dosage";
            this.dosageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dosageDataGridViewTextBoxColumn.Name = "dosageDataGridViewTextBoxColumn";
            this.dosageDataGridViewTextBoxColumn.Width = 77;
            // 
            // frequencyDataGridViewTextBoxColumn
            // 
            this.frequencyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.frequencyDataGridViewTextBoxColumn.DataPropertyName = "Frequency";
            this.frequencyDataGridViewTextBoxColumn.HeaderText = "Frequency";
            this.frequencyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.frequencyDataGridViewTextBoxColumn.Name = "frequencyDataGridViewTextBoxColumn";
            // 
            // administeredByDataGridViewTextBoxColumn
            // 
            this.administeredByDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.administeredByDataGridViewTextBoxColumn.DataPropertyName = "AdministeredBy";
            this.administeredByDataGridViewTextBoxColumn.HeaderText = "AdministeredBy";
            this.administeredByDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.administeredByDataGridViewTextBoxColumn.Name = "administeredByDataGridViewTextBoxColumn";
            // 
            // medicationSetBindingSource
            // 
            this.medicationSetBindingSource.DataMember = "MedicationSet";
            this.medicationSetBindingSource.DataSource = this.ambulantCareDBDataSet;
            // 
            // ambulantCareDBDataSet
            // 
            this.ambulantCareDBDataSet.DataSetName = "AmbulantCareDBDataSet";
            this.ambulantCareDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(104)))), ((int)(((byte)(177)))));
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEdit.Location = new System.Drawing.Point(278, 481);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(166, 51);
            this.buttonEdit.TabIndex = 109;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            // 
            // pictureBoxTopMenu
            // 
            this.pictureBoxTopMenu.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTopMenu.Image")));
            this.pictureBoxTopMenu.Location = new System.Drawing.Point(220, 26);
            this.pictureBoxTopMenu.Name = "pictureBoxTopMenu";
            this.pictureBoxTopMenu.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxTopMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxTopMenu.TabIndex = 107;
            this.pictureBoxTopMenu.TabStop = false;
            // 
            // panelProfil
            // 
            this.panelProfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProfil.Controls.Add(this.labelFullName);
            this.panelProfil.Controls.Add(this.pictureBox1);
            this.panelProfil.Location = new System.Drawing.Point(548, 3);
            this.panelProfil.Name = "panelProfil";
            this.panelProfil.Size = new System.Drawing.Size(200, 28);
            this.panelProfil.TabIndex = 106;
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelFullName.Location = new System.Drawing.Point(33, 5);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(0, 21);
            this.labelFullName.TabIndex = 58;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 28);
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(258, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 25);
            this.label4.TabIndex = 97;
            this.label4.Text = "Medikamente";
            // 
            // medicationSetTableAdapter
            // 
            this.medicationSetTableAdapter.ClearBeforeFill = true;
            // 
            // Medication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 544);
            this.Controls.Add(this.panelBio);
            this.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Medication";
            this.Text = "Medikamente";
            this.Load += new System.EventHandler(this.Medikamente_Load);
            this.panelBio.ResumeLayout(false);
            this.panelBio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedikamente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicationSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambulantCareDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopMenu)).EndInit();
            this.panelProfil.ResumeLayout(false);
            this.panelProfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBio;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.PictureBox pictureBoxTopMenu;
        public System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewMedikamente;
        private AmbulantCareDBDataSet ambulantCareDBDataSet;
        private System.Windows.Forms.BindingSource medicationSetBindingSource;
        private AmbulantCareDBDataSetTableAdapters.MedicationSetTableAdapter medicationSetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn frequencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn administeredByDataGridViewTextBoxColumn;
        public System.Windows.Forms.Panel panelProfil;
    }
}