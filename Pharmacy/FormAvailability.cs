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
    public partial class FormAvailability : Form
    {
        public FormAvailability()
        {
            InitializeComponent();
            ShowPharmacy();
            ShowMedication();
            ShowAvailability();
        }
        void ShowPharmacy()
        {
            comboBoxPharmacy.Items.Clear();
            foreach (PharmacySet pharmacy in Program.pharmacy.PharmacySet)
            {
                string[] item = { pharmacy.Id.ToString() + ".", pharmacy.Title };
                comboBoxPharmacy.Items.Add(string.Join(" ", item));
            }
        }
        void ShowMedication()
        {
            comboBoxMedication.Items.Clear();
            foreach (MedicationSet medication in Program.pharmacy.MedicationSet)
            {
                string[] item = { medication.Id.ToString() + ".", medication.Medication };
                comboBoxMedication.Items.Add(string.Join(" ", item));
            }
        }

        void ShowAvailability()
        {
            listViewAvailability.Items.Clear();
            foreach (Availability availability in Program.pharmacy.Availability)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    availability.Id.ToString(), availability.PharmacySet.Title,
                    availability.MedicationSet.Medication, availability.Quantity.ToString(),
                    availability.Price.ToString()
                }); 
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Availability availability = new Availability();
            availability.IdPharmacy = Convert.ToInt32(comboBoxPharmacy.SelectedItem.ToString().Split('.')[0]);
            availability.IdMedication = Convert.ToInt32(comboBoxMedication.SelectedItem.ToString().Split('.')[0]);
            availability.Quantity = Convert.ToInt32(textBoxKol.Text);
            availability.Price = Convert.ToInt32(textBoxPrice.Text);
            Program.pharmacy.Availability.Add(availability);
            Program.pharmacy.SaveChanges();
            ShowAvailability();
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (listViewAvailability.SelectedItems.Count == 1)
            {
                Availability availability = listViewAvailability.SelectedItems[0].Tag as Availability;
                availability.IdPharmacy = Convert.ToInt32(comboBoxPharmacy.SelectedItem.ToString().Split('.')[0]);
                availability.IdMedication = Convert.ToInt32(comboBoxMedication.SelectedItem.ToString().Split('.')[0]);
                availability.Quantity = Convert.ToInt32(textBoxKol.Text);
                availability.Price = Convert.ToInt32(textBoxPrice.Text);
                
                Program.pharmacy.SaveChanges();
                ShowAvailability();
            }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewAvailability.SelectedItems.Count == 1)
                {
                    Availability availability = listViewAvailability.SelectedItems[0].Tag as Availability;
                    Program.pharmacy.Availability.Remove(availability);
                    Program.pharmacy.SaveChanges();
                    ShowAvailability();
                }

                comboBoxPharmacy.SelectedItem = null;
                comboBoxMedication.SelectedItem = null;
                textBoxKol.Text = "";
                textBoxPrice.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBoxKol_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44 && number != 45)
            {
                e.Handled = true;
            }
        }

        private void TextBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44 && number != 45)
            {
                e.Handled = true;
            }
        }
    }
}
