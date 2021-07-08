
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
            this.labelToDoListe = new System.Windows.Forms.Label();
            this.buttonNeueData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddLastName = new System.Windows.Forms.TextBox();
            this.AddLFirstName = new System.Windows.Forms.TextBox();
            this.AddPhone = new System.Windows.Forms.TextBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.panelPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPatient
            // 
            this.panelPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(67)))));
            this.panelPatient.Controls.Add(this.comboBoxGender);
            this.panelPatient.Controls.Add(this.AddPhone);
            this.panelPatient.Controls.Add(this.AddLFirstName);
            this.panelPatient.Controls.Add(this.AddLastName);
            this.panelPatient.Controls.Add(this.label3);
            this.panelPatient.Controls.Add(this.label2);
            this.panelPatient.Controls.Add(this.label1);
            this.panelPatient.Controls.Add(this.labelToDoListe);
            this.panelPatient.Controls.Add(this.buttonNeueData);
            this.panelPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPatient.Location = new System.Drawing.Point(0, 0);
            this.panelPatient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelPatient.Name = "panelPatient";
            this.panelPatient.Size = new System.Drawing.Size(551, 476);
            this.panelPatient.TabIndex = 26;
            // 
            // labelToDoListe
            // 
            this.labelToDoListe.AutoSize = true;
            this.labelToDoListe.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToDoListe.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelToDoListe.Location = new System.Drawing.Point(38, 59);
            this.labelToDoListe.Name = "labelToDoListe";
            this.labelToDoListe.Size = new System.Drawing.Size(132, 30);
            this.labelToDoListe.TabIndex = 57;
            this.labelToDoListe.Text = "LastName";
            // 
            // buttonNeueData
            // 
            this.buttonNeueData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonNeueData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(104)))), ((int)(((byte)(177)))));
            this.buttonNeueData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNeueData.FlatAppearance.BorderSize = 0;
            this.buttonNeueData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNeueData.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNeueData.Location = new System.Drawing.Point(169, 413);
            this.buttonNeueData.Name = "buttonNeueData";
            this.buttonNeueData.Size = new System.Drawing.Size(166, 51);
            this.buttonNeueData.TabIndex = 56;
            this.buttonNeueData.Text = "Neue hinzufügen";
            this.buttonNeueData.UseVisualStyleBackColor = false;
            this.buttonNeueData.Click += new System.EventHandler(this.buttonNeueData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(38, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 30);
            this.label1.TabIndex = 58;
            this.label1.Text = "FirstName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(38, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 30);
            this.label2.TabIndex = 59;
            this.label2.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(38, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 30);
            this.label3.TabIndex = 60;
            this.label3.Text = "Phone";
            // 
            // AddLastName
            // 
            this.AddLastName.Location = new System.Drawing.Point(235, 70);
            this.AddLastName.Name = "AddLastName";
            this.AddLastName.Size = new System.Drawing.Size(153, 20);
            this.AddLastName.TabIndex = 61;
            // 
            // AddLFirstName
            // 
            this.AddLFirstName.Location = new System.Drawing.Point(235, 134);
            this.AddLFirstName.Name = "AddLFirstName";
            this.AddLFirstName.Size = new System.Drawing.Size(153, 20);
            this.AddLFirstName.TabIndex = 62;
            // 
            // AddPhone
            // 
            this.AddPhone.Location = new System.Drawing.Point(235, 296);
            this.AddPhone.Name = "AddPhone";
            this.AddPhone.Size = new System.Drawing.Size(153, 20);
            this.AddPhone.TabIndex = 63;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Location = new System.Drawing.Point(235, 218);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(52, 21);
            this.comboBoxGender.TabIndex = 65;
            // 
            // AddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 476);
            this.Controls.Add(this.panelPatient);
            this.Name = "AddPatient";
            this.Text = "AddPatient";
            this.Load += new System.EventHandler(this.AddPatient_Load);
            this.panelPatient.ResumeLayout(false);
            this.panelPatient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPatient;
        private System.Windows.Forms.Button buttonNeueData;
        private System.Windows.Forms.Label labelToDoListe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddPhone;
        private System.Windows.Forms.TextBox AddLFirstName;
        private System.Windows.Forms.TextBox AddLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxGender;
    }
}