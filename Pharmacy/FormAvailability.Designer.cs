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
            this.comboBoxPharmacy = new System.Windows.Forms.ComboBox();
            this.comboBoxMedication = new System.Windows.Forms.ComboBox();
            this.labelPharmacy = new System.Windows.Forms.Label();
            this.labelMedication = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelKol = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxKol = new System.Windows.Forms.TextBox();
            this.listViewAvailability = new System.Windows.Forms.ListView();
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
            // comboBoxPharmacy
            // 
            this.comboBoxPharmacy.Font = new System.Drawing.Font("Calibri", 12F);
            this.comboBoxPharmacy.FormattingEnabled = true;
            this.comboBoxPharmacy.Location = new System.Drawing.Point(249, 51);
            this.comboBoxPharmacy.Name = "comboBoxPharmacy";
            this.comboBoxPharmacy.Size = new System.Drawing.Size(269, 32);
            this.comboBoxPharmacy.TabIndex = 27;
            // 
            // comboBoxMedication
            // 
            this.comboBoxMedication.Font = new System.Drawing.Font("Calibri", 12F);
            this.comboBoxMedication.FormattingEnabled = true;
            this.comboBoxMedication.Location = new System.Drawing.Point(571, 51);
            this.comboBoxMedication.Name = "comboBoxMedication";
            this.comboBoxMedication.Size = new System.Drawing.Size(269, 32);
            this.comboBoxMedication.TabIndex = 28;
            // 
            // labelPharmacy
            // 
            this.labelPharmacy.AutoSize = true;
            this.labelPharmacy.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPharmacy.Location = new System.Drawing.Point(244, 19);
            this.labelPharmacy.Name = "labelPharmacy";
            this.labelPharmacy.Size = new System.Drawing.Size(84, 29);
            this.labelPharmacy.TabIndex = 29;
            this.labelPharmacy.Text = "Аптека";
            // 
            // labelMedication
            // 
            this.labelMedication.AutoSize = true;
            this.labelMedication.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMedication.Location = new System.Drawing.Point(566, 19);
            this.labelMedication.Name = "labelMedication";
            this.labelMedication.Size = new System.Drawing.Size(120, 29);
            this.labelMedication.TabIndex = 30;
            this.labelMedication.Text = "Лекарство";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(566, 96);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(65, 29);
            this.labelPrice.TabIndex = 34;
            this.labelPrice.Text = "Цена";
            // 
            // labelKol
            // 
            this.labelKol.AutoSize = true;
            this.labelKol.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKol.Location = new System.Drawing.Point(244, 96);
            this.labelKol.Name = "labelKol";
            this.labelKol.Size = new System.Drawing.Size(131, 29);
            this.labelKol.TabIndex = 33;
            this.labelKol.Text = "Количество";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPrice.Location = new System.Drawing.Point(571, 128);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(269, 32);
            this.textBoxPrice.TabIndex = 32;
            // 
            // textBoxKol
            // 
            this.textBoxKol.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxKol.Location = new System.Drawing.Point(249, 128);
            this.textBoxKol.Name = "textBoxKol";
            this.textBoxKol.Size = new System.Drawing.Size(269, 32);
            this.textBoxKol.TabIndex = 31;
            // 
            // listViewAvailability
            // 
            this.listViewAvailability.BackColor = System.Drawing.Color.White;
            this.listViewAvailability.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderIdPharmacy,
            this.columnHeaderPharmacy,
            this.columnHeaderIdMedication,
            this.columnHeaderMedication,
            this.columnHeaderKol,
            this.columnHeaderPrice});
            this.listViewAvailability.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewAvailability.FullRowSelect = true;
            this.listViewAvailability.GridLines = true;
            this.listViewAvailability.HideSelection = false;
            this.listViewAvailability.Location = new System.Drawing.Point(12, 180);
            this.listViewAvailability.MultiSelect = false;
            this.listViewAvailability.Name = "listViewAvailability";
            this.listViewAvailability.Size = new System.Drawing.Size(839, 237);
            this.listViewAvailability.TabIndex = 35;
            this.listViewAvailability.UseCompatibleStateImageBehavior = false;
            this.listViewAvailability.View = System.Windows.Forms.View.Details;
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
            this.buttonDel.Click += new System.EventHandler(this.ButtonDel_Click);
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
            this.buttonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
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
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
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
            this.Controls.Add(this.listViewAvailability);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelKol);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxKol);
            this.Controls.Add(this.labelMedication);
            this.Controls.Add(this.labelPharmacy);
            this.Controls.Add(this.comboBoxMedication);
            this.Controls.Add(this.comboBoxPharmacy);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAvailability";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Наличие";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxPharmacy;
        private System.Windows.Forms.ComboBox comboBoxMedication;
        private System.Windows.Forms.Label labelPharmacy;
        private System.Windows.Forms.Label labelMedication;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelKol;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxKol;
        private System.Windows.Forms.ListView listViewAvailability;
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