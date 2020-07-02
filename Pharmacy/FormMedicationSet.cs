using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class FormMedicationSet : Form
    {
        public FormMedicationSet()
        {
            InitializeComponent();
            ShowMedication();
        }

        void ShowMedication()
        {
            listViewMedication.Items.Clear();
            foreach (MedicationSet medication in Program.pharmacy.MedicationSet)
            {
                if (medication.FormRelease == 0)
                {
                    ListViewItem item = new ListViewItem(new string[]
                  {
                    medication.Id.ToString(), medication.Medication,
                    medication.FormRelease.ToString(),medication.Dosage,
                    medication.Maker, medication.ProductionDate.ToString()
                  });
                    item.Tag = medication;
                    listViewMedication.Items.Add(item);
                }
                if (medication.FormRelease == 1)
                {
                    ListViewItem item = new ListViewItem(new string[]
                  {
                    medication.Id.ToString(), medication.Medication,
                    medication.FormRelease.ToString(),medication.Dosage,
                    medication.Maker, medication.ProductionDate.ToString()
                  });
                    item.Tag = medication;
                    listViewMedication.Items.Add(item);
                }
                if (medication.FormRelease == 2)
                {
                    ListViewItem item = new ListViewItem(new string[]
                  {
                    medication.Id.ToString(), medication.Medication,
                    medication.FormRelease.ToString(),medication.Dosage,
                    medication.Maker, medication.ProductionDate.ToString()
                  });
                    item.Tag = medication;
                    listViewMedication.Items.Add(item);
                }
                if (medication.FormRelease == 3)
                {
                    ListViewItem item = new ListViewItem(new string[]
                  {
                    medication.Id.ToString(), medication.Medication,
                    medication.FormRelease.ToString(),medication.Dosage,
                    medication.Maker, medication.ProductionDate.ToString()
                  });
                    item.Tag = medication;
                    listViewMedication.Items.Add(item);
                }
                if (medication.FormRelease == 4)
                {
                    ListViewItem item = new ListViewItem(new string[]
                  {
                    medication.Id.ToString(), medication.Medication,
                    medication.FormRelease.ToString(),medication.Dosage,
                    medication.Maker, medication.ProductionDate.ToString()
                  });
                    item.Tag = medication;
                    listViewMedication.Items.Add(item);
                }
            }
            listViewMedication.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void ListViewMedication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewMedication.SelectedItems.Count == 1)
            {
                MedicationSet medication = listViewMedication.SelectedItems[0].Tag as MedicationSet;
                textBoxMedication.Text = medication.Medication;
                comboBoxFormRelease.SelectedIndex = comboBoxFormRelease.FindString(medication.FormRelease.ToString());
                textBoxDosage.Text = medication.Dosage;
                textBoxMaker.Text = medication.Maker;
                dateTimePickerDate.Value = medication.ProductionDate.GetValueOrDefault();
            }
            else
            {
                textBoxMedication.Text = "";
                comboBoxFormRelease.SelectedItem = null;
                textBoxDosage.Text = "";
                textBoxMaker.Text = "";
                dateTimePickerDate.Value = DateTime.Now;
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            MedicationSet medication = new MedicationSet();
            medication.Medication = textBoxMedication.Text;
            medication.Dosage = textBoxDosage.Text;
            medication.Maker = textBoxMaker.Text;
            medication.ProductionDate = dateTimePickerDate.Value;

            if (comboBoxFormRelease.SelectedIndex == 0)
            {
                medication.FormRelease = 0;
            }
            if (comboBoxFormRelease.SelectedIndex == 1)
            {
                medication.FormRelease = 1;
            }
            if (comboBoxFormRelease.SelectedIndex == 2)
            {
                medication.FormRelease = 2;
            }
            if (comboBoxFormRelease.SelectedIndex == 3)
            {
                medication.FormRelease = 3;
            }
            if (comboBoxFormRelease.SelectedIndex == 4)
            {
                medication.FormRelease = 4;
            }
            Program.pharmacy.MedicationSet.Add(medication);
            Program.pharmacy.SaveChanges();
            ShowMedication();
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxFormRelease.SelectedIndex == 0)
            {
                if (listViewMedication.SelectedItems.Count == 1)
                {
                    MedicationSet medication = listViewMedication.SelectedItems[0].Tag as MedicationSet;
                    medication.Medication = textBoxMedication.Text;
                    medication.Dosage = textBoxDosage.Text;
                    medication.Maker = textBoxMaker.Text;
                    medication.ProductionDate = dateTimePickerDate.Value;
                    
                    Program.pharmacy.SaveChanges();
                    ShowMedication();
                }
            }
            else if (comboBoxFormRelease.SelectedIndex == 1)
            {
                if (listViewMedication.SelectedItems.Count == 1)
                {
                    MedicationSet medication = listViewMedication.SelectedItems[0].Tag as MedicationSet;
                    medication.Medication = textBoxMedication.Text;
                    medication.Dosage = textBoxDosage.Text;
                    medication.Maker = textBoxMaker.Text;
                    medication.ProductionDate = dateTimePickerDate.Value;

                    Program.pharmacy.SaveChanges();
                    ShowMedication();
                }
            }
            else if (comboBoxFormRelease.SelectedIndex == 2)
            {
                if (listViewMedication.SelectedItems.Count == 1)
                {
                    MedicationSet medication = listViewMedication.SelectedItems[0].Tag as MedicationSet;
                    medication.Medication = textBoxMedication.Text;
                    medication.Dosage = textBoxDosage.Text;
                    medication.Maker = textBoxMaker.Text;
                    medication.ProductionDate = dateTimePickerDate.Value;

                    Program.pharmacy.SaveChanges();
                    ShowMedication();
                }
            }
            else if (comboBoxFormRelease.SelectedIndex == 3)
            {
                if (listViewMedication.SelectedItems.Count == 1)
                {
                    MedicationSet medication = listViewMedication.SelectedItems[0].Tag as MedicationSet;
                    medication.Medication = textBoxMedication.Text;
                    medication.Dosage = textBoxDosage.Text;
                    medication.Maker = textBoxMaker.Text;
                    medication.ProductionDate = dateTimePickerDate.Value;

                    Program.pharmacy.SaveChanges();
                    ShowMedication();
                }
            }
           
            else
            {
                if (listViewMedication.SelectedItems.Count == 1)
                {
                    MedicationSet medication = listViewMedication.SelectedItems[0].Tag as MedicationSet;
                    medication.Medication = textBoxMedication.Text;
                    medication.Dosage = textBoxDosage.Text;
                    medication.Maker = textBoxMaker.Text;
                    medication.ProductionDate = dateTimePickerDate.Value;

                    Program.pharmacy.SaveChanges();
                    ShowMedication();
                }
            }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxFormRelease.SelectedIndex == 0)
                {
                    if (listViewMedication.SelectedItems.Count == 1)
                    {
                        MedicationSet medication = listViewMedication.SelectedItems[0].Tag as MedicationSet;
                        Program.pharmacy.MedicationSet.Remove(medication);
                        Program.pharmacy.SaveChanges();
                        ShowMedication();
                    }
                    textBoxMedication.Text = "";
                    textBoxDosage.Text = "";
                    textBoxMaker.Text = "";
                    dateTimePickerDate.Value = DateTime.Now;
                }
                else if(comboBoxFormRelease.SelectedIndex == 1)
                {
                    if (listViewMedication.SelectedItems.Count == 1)
                    {
                        MedicationSet medication = listViewMedication.SelectedItems[0].Tag as MedicationSet;
                        Program.pharmacy.MedicationSet.Remove(medication);
                        Program.pharmacy.SaveChanges();
                        ShowMedication();
                    }
                    textBoxMedication.Text = "";
                    textBoxDosage.Text = "";
                    textBoxMaker.Text = "";
                    dateTimePickerDate.Value = DateTime.Now;
                }
                else if(comboBoxFormRelease.SelectedIndex == 2)
                {
                    if (listViewMedication.SelectedItems.Count == 1)
                    {
                        MedicationSet medication = listViewMedication.SelectedItems[0].Tag as MedicationSet;
                        Program.pharmacy.MedicationSet.Remove(medication);
                        Program.pharmacy.SaveChanges();
                        ShowMedication();
                    }
                    textBoxMedication.Text = "";
                    textBoxDosage.Text = "";
                    textBoxMaker.Text = "";
                    dateTimePickerDate.Value = DateTime.Now;
                }
                else if(comboBoxFormRelease.SelectedIndex == 3)
                {
                    if (listViewMedication.SelectedItems.Count == 1)
                    {
                        MedicationSet medication = listViewMedication.SelectedItems[0].Tag as MedicationSet;
                        Program.pharmacy.MedicationSet.Remove(medication);
                        Program.pharmacy.SaveChanges();
                        ShowMedication();
                    }
                    textBoxMedication.Text = "";
                    textBoxDosage.Text = "";
                    textBoxMaker.Text = "";
                    dateTimePickerDate.Value = DateTime.Now;
                }
                else
                {
                    if (listViewMedication.SelectedItems.Count == 1)
                    {
                        MedicationSet medication = listViewMedication.SelectedItems[0].Tag as MedicationSet;
                        Program.pharmacy.MedicationSet.Remove(medication);
                        Program.pharmacy.SaveChanges();
                        ShowMedication();
                    }
                    textBoxMedication.Text = "";
                    textBoxDosage.Text = "";
                    textBoxMaker.Text = "";
                    dateTimePickerDate.Value = DateTime.Now;
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
