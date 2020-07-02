namespace Pharmacy
{
    partial class FormMedicationSet
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
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelMaker = new System.Windows.Forms.Label();
            this.labelDosage = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxMaker = new System.Windows.Forms.TextBox();
            this.listViewMedication = new System.Windows.Forms.ListView();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFormRelease = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDosage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMaker = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxDosage = new System.Windows.Forms.TextBox();
            this.textBoxMedication = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxFormRelease = new System.Windows.Forms.ComboBox();
            this.labelFormRelease = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.columnHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.Firebrick;
            this.buttonDel.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDel.Location = new System.Drawing.Point(822, 500);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(158, 48);
            this.buttonDel.TabIndex = 25;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Green;
            this.buttonEdit.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEdit.Location = new System.Drawing.Point(642, 500);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(158, 48);
            this.buttonEdit.TabIndex = 24;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Green;
            this.buttonAdd.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdd.Location = new System.Drawing.Point(458, 500);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(158, 48);
            this.buttonAdd.TabIndex = 23;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhone.Location = new System.Drawing.Point(7, 484);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(208, 29);
            this.labelPhone.TabIndex = 22;
            this.labelPhone.Text = "Дата производства";
            // 
            // labelMaker
            // 
            this.labelMaker.AutoSize = true;
            this.labelMaker.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaker.Location = new System.Drawing.Point(7, 412);
            this.labelMaker.Name = "labelMaker";
            this.labelMaker.Size = new System.Drawing.Size(171, 29);
            this.labelMaker.TabIndex = 21;
            this.labelMaker.Text = "Производитель";
            // 
            // labelDosage
            // 
            this.labelDosage.AutoSize = true;
            this.labelDosage.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDosage.Location = new System.Drawing.Point(7, 332);
            this.labelDosage.Name = "labelDosage";
            this.labelDosage.Size = new System.Drawing.Size(125, 29);
            this.labelDosage.TabIndex = 20;
            this.labelDosage.Text = "Дозировка";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(7, 179);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(112, 29);
            this.labelName.TabIndex = 19;
            this.labelName.Text = "Название";
            // 
            // textBoxMaker
            // 
            this.textBoxMaker.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMaker.Location = new System.Drawing.Point(12, 444);
            this.textBoxMaker.Name = "textBoxMaker";
            this.textBoxMaker.Size = new System.Drawing.Size(217, 32);
            this.textBoxMaker.TabIndex = 17;
            // 
            // listViewMedication
            // 
            this.listViewMedication.BackColor = System.Drawing.Color.White;
            this.listViewMedication.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderName,
            this.columnHeaderFormRelease,
            this.columnHeaderDosage,
            this.columnHeaderMaker,
            this.columnHeaderDate});
            this.listViewMedication.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewMedication.FullRowSelect = true;
            this.listViewMedication.GridLines = true;
            this.listViewMedication.HideSelection = false;
            this.listViewMedication.Location = new System.Drawing.Point(255, 29);
            this.listViewMedication.MultiSelect = false;
            this.listViewMedication.Name = "listViewMedication";
            this.listViewMedication.Size = new System.Drawing.Size(725, 451);
            this.listViewMedication.TabIndex = 16;
            this.listViewMedication.UseCompatibleStateImageBehavior = false;
            this.listViewMedication.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "Id";
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Название";
            this.columnHeaderName.Width = 106;
            // 
            // columnHeaderFormRelease
            // 
            this.columnHeaderFormRelease.Text = "Форма выпука";
            this.columnHeaderFormRelease.Width = 143;
            // 
            // columnHeaderDosage
            // 
            this.columnHeaderDosage.Text = "Дозировка";
            this.columnHeaderDosage.Width = 116;
            // 
            // columnHeaderMaker
            // 
            this.columnHeaderMaker.Text = "Производитель";
            this.columnHeaderMaker.Width = 155;
            // 
            // textBoxDosage
            // 
            this.textBoxDosage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDosage.Location = new System.Drawing.Point(12, 364);
            this.textBoxDosage.Name = "textBoxDosage";
            this.textBoxDosage.Size = new System.Drawing.Size(217, 32);
            this.textBoxDosage.TabIndex = 15;
            // 
            // textBoxMedication
            // 
            this.textBoxMedication.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMedication.Location = new System.Drawing.Point(12, 211);
            this.textBoxMedication.Name = "textBoxMedication";
            this.textBoxMedication.Size = new System.Drawing.Size(217, 32);
            this.textBoxMedication.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pharmacy.Properties.Resources._119_1192900_pharmacy_icon_svg_png_icon_free_download_healthcare_innovation_icon;
            this.pictureBox1.Location = new System.Drawing.Point(-14, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxFormRelease
            // 
            this.comboBoxFormRelease.Font = new System.Drawing.Font("Calibri", 12F);
            this.comboBoxFormRelease.FormattingEnabled = true;
            this.comboBoxFormRelease.Location = new System.Drawing.Point(12, 287);
            this.comboBoxFormRelease.Name = "comboBoxFormRelease";
            this.comboBoxFormRelease.Size = new System.Drawing.Size(217, 32);
            this.comboBoxFormRelease.TabIndex = 26;
            // 
            // labelFormRelease
            // 
            this.labelFormRelease.AutoSize = true;
            this.labelFormRelease.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFormRelease.Location = new System.Drawing.Point(7, 255);
            this.labelFormRelease.Name = "labelFormRelease";
            this.labelFormRelease.Size = new System.Drawing.Size(174, 29);
            this.labelFormRelease.TabIndex = 27;
            this.labelFormRelease.Text = "Форма выпуска";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CalendarFont = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerDate.Location = new System.Drawing.Point(12, 516);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(217, 32);
            this.dateTimePickerDate.TabIndex = 28;
            // 
            // columnHeaderDate
            // 
            this.columnHeaderDate.Text = "Дата производства";
            this.columnHeaderDate.Width = 134;
            // 
            // FormMedicationSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(992, 565);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.labelFormRelease);
            this.Controls.Add(this.comboBoxFormRelease);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelMaker);
            this.Controls.Add(this.labelDosage);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxMaker);
            this.Controls.Add(this.listViewMedication);
            this.Controls.Add(this.textBoxDosage);
            this.Controls.Add(this.textBoxMedication);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormMedicationSet";
            this.Text = "Лекарства";
            this.Load += new System.EventHandler(this.FormMedicationSet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelMaker;
        private System.Windows.Forms.Label labelDosage;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxMaker;
        private System.Windows.Forms.ListView listViewMedication;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderFormRelease;
        private System.Windows.Forms.ColumnHeader columnHeaderDosage;
        private System.Windows.Forms.ColumnHeader columnHeaderMaker;
        private System.Windows.Forms.TextBox textBoxDosage;
        private System.Windows.Forms.TextBox textBoxMedication;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxFormRelease;
        private System.Windows.Forms.Label labelFormRelease;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
    }
}