
namespace CareSolution
{
    partial class AddPatient
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
            this.panelPatient = new System.Windows.Forms.Panel();
            this.buttonNeueData = new System.Windows.Forms.Button();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelPatient = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.AddPhone = new System.Windows.Forms.TextBox();
            this.AddLFirstName = new System.Windows.Forms.TextBox();
            this.AddLastName = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.panelPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPatient
            // 
            this.panelPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            this.panelPatient.Controls.Add(this.buttonNeueData);
            this.panelPatient.Controls.Add(this.labelGender);
            this.panelPatient.Controls.Add(this.labelFirstName);
            this.panelPatient.Controls.Add(this.labelPatient);
            this.panelPatient.Controls.Add(this.comboBoxGender);
            this.panelPatient.Controls.Add(this.AddPhone);
            this.panelPatient.Controls.Add(this.AddLFirstName);
            this.panelPatient.Controls.Add(this.AddLastName);
            this.panelPatient.Controls.Add(this.labelPhone);
            this.panelPatient.Controls.Add(this.labelLastName);
            this.panelPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPatient.Location = new System.Drawing.Point(0, 0);
            this.panelPatient.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panelPatient.Name = "panelPatient";
            this.panelPatient.Size = new System.Drawing.Size(748, 544);
            this.panelPatient.TabIndex = 26;
            // 
            // buttonNeueData
            // 
            this.buttonNeueData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonNeueData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(104)))), ((int)(((byte)(177)))));
            this.buttonNeueData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNeueData.FlatAppearance.BorderSize = 0;
            this.buttonNeueData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNeueData.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNeueData.Location = new System.Drawing.Point(275, 467);
            this.buttonNeueData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonNeueData.Name = "buttonNeueData";
            this.buttonNeueData.Size = new System.Drawing.Size(187, 64);
            this.buttonNeueData.TabIndex = 69;
            this.buttonNeueData.Text = "Neue hinzufügen";
            this.buttonNeueData.UseVisualStyleBackColor = false;
            this.buttonNeueData.Click += new System.EventHandler(this.buttonNeueData_Click);
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelGender.Location = new System.Drawing.Point(27, 287);
            this.labelGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(126, 22);
            this.labelGender.TabIndex = 68;
            this.labelGender.Text = "Geschlecht :";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelFirstName.Location = new System.Drawing.Point(27, 202);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(107, 22);
            this.labelFirstName.TabIndex = 67;
            this.labelFirstName.Text = "Vorname :";
            // 
            // labelPatient
            // 
            this.labelPatient.AutoSize = true;
            this.labelPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            this.labelPatient.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatient.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelPatient.Location = new System.Drawing.Point(197, 21);
            this.labelPatient.Name = "labelPatient";
            this.labelPatient.Size = new System.Drawing.Size(331, 25);
            this.labelPatient.TabIndex = 66;
            this.labelPatient.Text = "Einfügen des Neuen Patienten";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGender.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Location = new System.Drawing.Point(248, 286);
            this.comboBoxGender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(76, 29);
            this.comboBoxGender.TabIndex = 65;
            // 
            // AddPhone
            // 
            this.AddPhone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPhone.Location = new System.Drawing.Point(248, 365);
            this.AddPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddPhone.Name = "AddPhone";
            this.AddPhone.Size = new System.Drawing.Size(228, 27);
            this.AddPhone.TabIndex = 63;
            // 
            // AddLFirstName
            // 
            this.AddLFirstName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLFirstName.Location = new System.Drawing.Point(248, 200);
            this.AddLFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddLFirstName.Name = "AddLFirstName";
            this.AddLFirstName.Size = new System.Drawing.Size(228, 27);
            this.AddLFirstName.TabIndex = 62;
            // 
            // AddLastName
            // 
            this.AddLastName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLastName.Location = new System.Drawing.Point(248, 114);
            this.AddLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddLastName.Name = "AddLastName";
            this.AddLastName.Size = new System.Drawing.Size(228, 27);
            this.AddLastName.TabIndex = 61;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.labelPhone.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelPhone.Location = new System.Drawing.Point(27, 367);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(85, 22);
            this.labelPhone.TabIndex = 60;
            this.labelPhone.Text = "Telefon :";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelLastName.Location = new System.Drawing.Point(25, 116);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(125, 22);
            this.labelLastName.TabIndex = 57;
            this.labelLastName.Text = "Nachname :";
            // 
            // AddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 544);
            this.Controls.Add(this.panelPatient);
            this.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddPatient";
            this.Text = "AddPatient";
            this.Load += new System.EventHandler(this.AddPatient_Load);
            this.panelPatient.ResumeLayout(false);
            this.panelPatient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPatient;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox AddPhone;
        private System.Windows.Forms.TextBox AddLFirstName;
        private System.Windows.Forms.TextBox AddLastName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelPatient;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Button buttonNeueData;
    }
}