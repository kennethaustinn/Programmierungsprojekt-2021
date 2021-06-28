namespace CareSolution
{
    partial class Medikamente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medikamente));
            this.panelBio = new System.Windows.Forms.Panel();
            this.dataGridViewMedikamente = new System.Windows.Forms.DataGridView();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.pictureBoxTopMenu = new System.Windows.Forms.PictureBox();
            this.panelProfil = new System.Windows.Forms.Panel();
            this.labelName2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.medikament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosierung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frequenz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grund = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verwaltetvon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedikamente)).BeginInit();
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
            this.dataGridViewMedikamente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewMedikamente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewMedikamente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            this.dataGridViewMedikamente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMedikamente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(104)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMedikamente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewMedikamente.ColumnHeadersHeight = 30;
            this.dataGridViewMedikamente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewMedikamente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medikament,
            this.dosierung,
            this.frequenz,
            this.grund,
            this.verwaltetvon});
            this.dataGridViewMedikamente.EnableHeadersVisualStyles = false;
            this.dataGridViewMedikamente.GridColor = System.Drawing.Color.MediumPurple;
            this.dataGridViewMedikamente.Location = new System.Drawing.Point(28, 101);
            this.dataGridViewMedikamente.Name = "dataGridViewMedikamente";
            this.dataGridViewMedikamente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(123)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMedikamente.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewMedikamente.RowHeadersVisible = false;
            this.dataGridViewMedikamente.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(123)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewMedikamente.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewMedikamente.RowTemplate.Height = 24;
            this.dataGridViewMedikamente.Size = new System.Drawing.Size(689, 321);
            this.dataGridViewMedikamente.TabIndex = 110;
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
            this.panelProfil.Controls.Add(this.labelName2);
            this.panelProfil.Controls.Add(this.pictureBox1);
            this.panelProfil.Location = new System.Drawing.Point(548, 3);
            this.panelProfil.Name = "panelProfil";
            this.panelProfil.Size = new System.Drawing.Size(200, 28);
            this.panelProfil.TabIndex = 106;
            // 
            // labelName2
            // 
            this.labelName2.AutoSize = true;
            this.labelName2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelName2.Location = new System.Drawing.Point(33, 5);
            this.labelName2.Name = "labelName2";
            this.labelName2.Size = new System.Drawing.Size(72, 23);
            this.labelName2.TabIndex = 58;
            this.labelName2.Text = "label1";
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
            this.label4.Size = new System.Drawing.Size(206, 34);
            this.label4.TabIndex = 97;
            this.label4.Text = "Medikamente";
            // 
            // medikament
            // 
            this.medikament.HeaderText = "Medikament";
            this.medikament.MinimumWidth = 6;
            this.medikament.Name = "medikament";
            this.medikament.Width = 129;
            // 
            // dosierung
            // 
            this.dosierung.HeaderText = "Dosierung";
            this.dosierung.MinimumWidth = 6;
            this.dosierung.Name = "dosierung";
            this.dosierung.Width = 109;
            // 
            // frequenz
            // 
            this.frequenz.HeaderText = "Frequenz";
            this.frequenz.MinimumWidth = 6;
            this.frequenz.Name = "frequenz";
            this.frequenz.Width = 102;
            // 
            // grund
            // 
            this.grund.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.grund.HeaderText = "Grund";
            this.grund.MinimumWidth = 6;
            this.grund.Name = "grund";
            // 
            // verwaltetvon
            // 
            this.verwaltetvon.HeaderText = "Verwaltet von";
            this.verwaltetvon.MinimumWidth = 6;
            this.verwaltetvon.Name = "verwaltetvon";
            this.verwaltetvon.Width = 142;
            // 
            // Medikamente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 544);
            this.Controls.Add(this.panelBio);
            this.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Medikamente";
            this.Text = "Medikamente";
            this.Load += new System.EventHandler(this.Medikamente_Load);
            this.panelBio.ResumeLayout(false);
            this.panelBio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedikamente)).EndInit();
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
        private System.Windows.Forms.Panel panelProfil;
        private System.Windows.Forms.Label labelName2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewMedikamente;
        private System.Windows.Forms.DataGridViewTextBoxColumn medikament;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosierung;
        private System.Windows.Forms.DataGridViewTextBoxColumn frequenz;
        private System.Windows.Forms.DataGridViewTextBoxColumn grund;
        private System.Windows.Forms.DataGridViewTextBoxColumn verwaltetvon;
    }
}