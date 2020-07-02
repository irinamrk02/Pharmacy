namespace Pharmacy
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.buttonPharmacy = new System.Windows.Forms.Button();
            this.buttonMedication = new System.Windows.Forms.Button();
            this.buttonAvailability = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPharmacy
            // 
            this.buttonPharmacy.BackColor = System.Drawing.Color.Green;
            this.buttonPharmacy.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPharmacy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPharmacy.Location = new System.Drawing.Point(7, 172);
            this.buttonPharmacy.Name = "buttonPharmacy";
            this.buttonPharmacy.Size = new System.Drawing.Size(300, 60);
            this.buttonPharmacy.TabIndex = 11;
            this.buttonPharmacy.Text = "Аптеки";
            this.buttonPharmacy.UseVisualStyleBackColor = false;
            this.buttonPharmacy.Click += new System.EventHandler(this.ButtonPharmacy_Click);
            // 
            // buttonMedication
            // 
            this.buttonMedication.BackColor = System.Drawing.Color.Green;
            this.buttonMedication.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMedication.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonMedication.Location = new System.Drawing.Point(7, 237);
            this.buttonMedication.Name = "buttonMedication";
            this.buttonMedication.Size = new System.Drawing.Size(300, 60);
            this.buttonMedication.TabIndex = 12;
            this.buttonMedication.Text = "Лекарства";
            this.buttonMedication.UseVisualStyleBackColor = false;
            this.buttonMedication.Click += new System.EventHandler(this.ButtonMedication_Click);
            // 
            // buttonAvailability
            // 
            this.buttonAvailability.BackColor = System.Drawing.Color.Green;
            this.buttonAvailability.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAvailability.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAvailability.Location = new System.Drawing.Point(7, 301);
            this.buttonAvailability.Name = "buttonAvailability";
            this.buttonAvailability.Size = new System.Drawing.Size(300, 60);
            this.buttonAvailability.TabIndex = 13;
            this.buttonAvailability.Text = "Наличие";
            this.buttonAvailability.UseVisualStyleBackColor = false;
            this.buttonAvailability.Click += new System.EventHandler(this.ButtonAvailability_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Pharmacy.Properties.Resources._119_1192900_pharmacy_icon_svg_png_icon_free_download_healthcare_innovation_icon;
            this.pictureBoxLogo.Location = new System.Drawing.Point(-2, -2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(328, 168);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(315, 367);
            this.Controls.Add(this.buttonAvailability);
            this.Controls.Add(this.buttonMedication);
            this.Controls.Add(this.buttonPharmacy);
            this.Controls.Add(this.pictureBoxLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonPharmacy;
        private System.Windows.Forms.Button buttonMedication;
        private System.Windows.Forms.Button buttonAvailability;
    }
}