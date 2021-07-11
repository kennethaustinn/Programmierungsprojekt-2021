namespace CareSolution
{
    partial class ActionPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActionPlan));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelMaßnahmenplan = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.labelErstellt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.pictureBoxTopMenu = new System.Windows.Forms.PictureBox();
            this.panelProfil = new System.Windows.Forms.Panel();
            this.labelFullName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelMaßnahmenplanTop = new System.Windows.Forms.Label();
            this.DatumUhr = new System.Windows.Forms.Timer(this.components);
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopMenu)).BeginInit();
            this.panelProfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.labelErstellt);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.labelDatum);
            this.panel3.Controls.Add(this.pictureBoxTopMenu);
            this.panel3.Controls.Add(this.panelProfil);
            this.panel3.Controls.Add(this.labelMaßnahmenplanTop);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(748, 544);
            this.panel3.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelMaßnahmenplan);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Location = new System.Drawing.Point(32, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 313);
            this.panel1.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 19);
            this.label3.TabIndex = 58;
            this.label3.Text = "Maßnahmenplan für heute noch :";
            // 
            // labelMaßnahmenplan
            // 
            this.labelMaßnahmenplan.AutoSize = true;
            this.labelMaßnahmenplan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            this.labelMaßnahmenplan.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaßnahmenplan.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelMaßnahmenplan.Location = new System.Drawing.Point(27, 50);
            this.labelMaßnahmenplan.Name = "labelMaßnahmenplan";
            this.labelMaßnahmenplan.Size = new System.Drawing.Size(282, 19);
            this.labelMaßnahmenplan.TabIndex = 65;
            this.labelMaßnahmenplan.Text = "was muss heute noch gemacht werden";
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox1.Location = new System.Drawing.Point(8, 287);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(65, 23);
            this.checkBox1.TabIndex = 60;
            this.checkBox1.Text = "Fertig";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // labelErstellt
            // 
            this.labelErstellt.AutoSize = true;
            this.labelErstellt.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErstellt.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelErstellt.Location = new System.Drawing.Point(138, 131);
            this.labelErstellt.Name = "labelErstellt";
            this.labelErstellt.Size = new System.Drawing.Size(16, 19);
            this.labelErstellt.TabIndex = 68;
            this.labelErstellt.Text = "x";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(36, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 19);
            this.label5.TabIndex = 67;
            this.label5.Text = "Erstellt am :";
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatum.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelDatum.Location = new System.Drawing.Point(29, 74);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(94, 30);
            this.labelDatum.TabIndex = 64;
            this.labelDatum.Text = "Datum";
            // 
            // pictureBoxTopMenu
            // 
            this.pictureBoxTopMenu.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTopMenu.Image")));
            this.pictureBoxTopMenu.Location = new System.Drawing.Point(198, 24);
            this.pictureBoxTopMenu.Name = "pictureBoxTopMenu";
            this.pictureBoxTopMenu.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxTopMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxTopMenu.TabIndex = 62;
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
            this.panelProfil.TabIndex = 61;
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // labelMaßnahmenplanTop
            // 
            this.labelMaßnahmenplanTop.AutoSize = true;
            this.labelMaßnahmenplanTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            this.labelMaßnahmenplanTop.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaßnahmenplanTop.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelMaßnahmenplanTop.Location = new System.Drawing.Point(236, 22);
            this.labelMaßnahmenplanTop.Name = "labelMaßnahmenplanTop";
            this.labelMaßnahmenplanTop.Size = new System.Drawing.Size(201, 25);
            this.labelMaßnahmenplanTop.TabIndex = 35;
            this.labelMaßnahmenplanTop.Text = "Maßnahmenplan";
            // 
            // DatumUhr
            // 
            this.DatumUhr.Enabled = true;
            this.DatumUhr.Tick += new System.EventHandler(this.DatumUhr_Tick);
            // 
            // ActionPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 544);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ActionPlan";
            this.Text = "Maßnahmenplan";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopMenu)).EndInit();
            this.panelProfil.ResumeLayout(false);
            this.panelProfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBoxTopMenu;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label labelMaßnahmenplanTop;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Timer DatumUhr;
        private System.Windows.Forms.Label labelErstellt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelMaßnahmenplan;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panelProfil;
    }
}