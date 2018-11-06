namespace WindowsFormsApp1
{
    partial class Form1
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
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.Country = new System.Windows.Forms.Label();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.Marka = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.Label();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.carinfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbCountry
            // 
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(66, 39);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(235, 21);
            this.cmbCountry.TabIndex = 0;
            this.cmbCountry.SelectedIndexChanged += new System.EventHandler(this.cmbCountry_SelectedIndexChanged);
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.Location = new System.Drawing.Point(63, 9);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(43, 13);
            this.Country.TabIndex = 1;
            this.Country.Text = "Country";
            // 
            // cmbMarka
            // 
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(66, 143);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(235, 21);
            this.cmbMarka.TabIndex = 2;
            this.cmbMarka.SelectedIndexChanged += new System.EventHandler(this.cmbMarka_SelectedIndexChanged);
            // 
            // Marka
            // 
            this.Marka.AutoSize = true;
            this.Marka.Location = new System.Drawing.Point(63, 114);
            this.Marka.Name = "Marka";
            this.Marka.Size = new System.Drawing.Size(37, 13);
            this.Marka.TabIndex = 3;
            this.Marka.Text = "Marka";
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Location = new System.Drawing.Point(66, 211);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(36, 13);
            this.Model.TabIndex = 4;
            this.Model.Text = "Model";
            // 
            // cmbModel
            // 
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(69, 247);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(232, 21);
            this.cmbModel.TabIndex = 5;
            this.cmbModel.SelectedIndexChanged += new System.EventHandler(this.cmbModel_SelectedIndexChanged);
            // 
            // carinfo
            // 
            this.carinfo.AutoSize = true;
            this.carinfo.Location = new System.Drawing.Point(69, 303);
            this.carinfo.Name = "carinfo";
            this.carinfo.Size = new System.Drawing.Size(35, 13);
            this.carinfo.TabIndex = 6;
            this.carinfo.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 428);
            this.Controls.Add(this.carinfo);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.Marka);
            this.Controls.Add(this.cmbMarka);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.cmbCountry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Label Country;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.Label Marka;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.Label carinfo;
    }
}

