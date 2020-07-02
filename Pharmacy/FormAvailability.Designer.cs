namespace Pharmacy
{
    partial class FormAvailability
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAvailability));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxFormRelease = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMaker = new System.Windows.Forms.Label();
            this.labelDosage = new System.Windows.Forms.Label();
            this.textBoxMaker = new System.Windows.Forms.TextBox();
            this.textBoxDosage = new System.Windows.Forms.TextBox();
            this.listViewMedication = new System.Windows.Forms.ListView();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderIdPharmacy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPharmacy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderIdMedication = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderKol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.columnHeaderMedication = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pharmacy.Properties.Resources._119_1192900_pharmacy_icon_svg_png_icon_free_download_healthcare_innovation_icon;
            this.pictureBox1.Location = new System.Drawing.Point(-14, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxFormRelease
            // 
            this.comboBoxFormRelease.Font = new System.Drawing.Font("Calibri", 12F);
            this.comboBoxFormRelease.FormattingEnabled = true;
            this.comboBoxFormRelease.Location = new System.Drawing.Point(249, 51);
            this.comboBoxFormRelease.Name = "comboBoxFormRelease";
            this.comboBoxFormRelease.Size = new System.Drawing.Size(269, 32);
            this.comboBoxFormRelease.TabIndex = 27;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(571, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(269, 32);
            this.comboBox1.TabIndex = 28;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(244, 19);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(84, 29);
            this.labelName.TabIndex = 29;
            this.labelName.Text = "Аптека";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(566, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 29);
            this.label1.TabIndex = 30;
            this.label1.Text = "Лекарство";
            // 
            // labelMaker
            // 
            this.labelMaker.AutoSize = true;
            this.labelMaker.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaker.Location = new System.Drawing.Point(566, 96);
            this.labelMaker.Name = "labelMaker";
            this.labelMaker.Size = new System.Drawing.Size(65, 29);
            this.labelMaker.TabIndex = 34;
            this.labelMaker.Text = "Цена";
            // 
            // labelDosage
            // 
            this.labelDosage.AutoSize = true;
            this.labelDosage.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDosage.Location = new System.Drawing.Point(244, 96);
            this.labelDosage.Name = "labelDosage";
            this.labelDosage.Size = new System.Drawing.Size(131, 29);
            this.labelDosage.TabIndex = 33;
            this.labelDosage.Text = "Количество";
            // 
            // textBoxMaker
            // 
            this.textBoxMaker.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMaker.Location = new System.Drawing.Point(571, 128);
            this.textBoxMaker.Name = "textBoxMaker";
            this.textBoxMaker.Size = new System.Drawing.Size(269, 32);
            this.textBoxMaker.TabIndex = 32;
            // 
            // textBoxDosage
            // 
            this.textBoxDosage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDosage.Location = new System.Drawing.Point(249, 128);
            this.textBoxDosage.Name = "textBoxDosage";
            this.textBoxDosage.Size = new System.Drawing.Size(269, 32);
            this.textBoxDosage.TabIndex = 31;
            // 
            // listViewMedication
            // 
            this.listViewMedication.BackColor = System.Drawing.Color.White;
            this.listViewMedication.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderIdPharmacy,
            this.columnHeaderPharmacy,
            this.columnHeaderIdMedication,
            this.columnHeaderMedication,
            this.columnHeaderKol,
            this.columnHeaderPrice});
            this.listViewMedication.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewMedication.FullRowSelect = true;
            this.listViewMedication.GridLines = true;
            this.listViewMedication.HideSelection = false;
            this.listViewMedication.Location = new System.Drawing.Point(12, 180);
            this.listViewMedication.MultiSelect = false;
            this.listViewMedication.Name = "listViewMedication";
            this.listViewMedication.Size = new System.Drawing.Size(839, 237);
            this.listViewMedication.TabIndex = 35;
            this.listViewMedication.UseCompatibleStateImageBehavior = false;
            this.listViewMedication.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "Id ";
            // 
            // columnHeaderIdPharmacy
            // 
            this.columnHeaderIdPharmacy.Text = "Id аптеки";
            this.columnHeaderIdPharmacy.Width = 106;
            // 
            // columnHeaderPharmacy
            // 
            this.columnHeaderPharmacy.Text = "Аптека";
            this.columnHeaderPharmacy.Width = 143;
            // 
            // columnHeaderIdMedication
            // 
            this.columnHeaderIdMedication.Text = "Id лекарства";
            this.columnHeaderIdMedication.Width = 136;
            // 
            // columnHeaderKol
            // 
            this.columnHeaderKol.Text = "Количество";
            this.columnHeaderKol.Width = 155;
            // 
            // columnHeaderPrice
            // 
            this.columnHeaderPrice.Text = "Цена";
            this.columnHeaderPrice.Width = 134;
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.Firebrick;
            this.buttonDel.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDel.Location = new System.Drawing.Point(540, 433);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(158, 48);
            this.buttonDel.TabIndex = 38;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Green;
            this.buttonEdit.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEdit.Location = new System.Drawing.Point(360, 433);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(158, 48);
            this.buttonEdit.TabIndex = 37;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Green;
            this.buttonAdd.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdd.Location = new System.Drawing.Point(176, 433);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(158, 48);
            this.buttonAdd.TabIndex = 36;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            // 
            // columnHeaderMedication
            // 
            this.columnHeaderMedication.Text = "Лекарство";
            this.columnHeaderMedication.Width = 105;
            // 
            // FormAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(863, 491);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewMedication);
            this.Controls.Add(this.labelMaker);
            this.Controls.Add(this.labelDosage);
            this.Controls.Add(this.textBoxMaker);
            this.Controls.Add(this.textBoxDosage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBoxFormRelease);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAvailability";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Наличие";
            this.Load += new System.EventHandler(this.FormAvailability_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxFormRelease;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMaker;
        private System.Windows.Forms.Label labelDosage;
        private System.Windows.Forms.TextBox textBoxMaker;
        private System.Windows.Forms.TextBox textBoxDosage;
        private System.Windows.Forms.ListView listViewMedication;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderIdPharmacy;
        private System.Windows.Forms.ColumnHeader columnHeaderPharmacy;
        private System.Windows.Forms.ColumnHeader columnHeaderIdMedication;
        private System.Windows.Forms.ColumnHeader columnHeaderKol;
        private System.Windows.Forms.ColumnHeader columnHeaderPrice;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ColumnHeader columnHeaderMedication;
    }
}