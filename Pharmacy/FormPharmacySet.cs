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
    public partial class FormPharmacy : Form
    {
        public FormPharmacy()
        {
            InitializeComponent();
            ShowPharmacy();
        }

        void ShowPharmacy()
        {
            listViewPharmacy.Items.Clear();
            foreach (PharmacySet pharmacy in Program.pharmacy.PharmacySet)
            {
                ListViewItem item = new ListViewItem(new string[]
                { pharmacy.Id.ToString(), pharmacy.Title, 
                   pharmacy.Address, pharmacy.Email, pharmacy.Phone
                });
                item.Tag = pharmacy;
                listViewPharmacy.Items.Add(item);
            }
            listViewPharmacy.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            PharmacySet pharmacy = new PharmacySet();
            pharmacy.Title = textBoxPharmacy.Text;
            pharmacy.Address = textBoxAddress.Text;
            pharmacy.Email = textBoxEmail.Text;
            pharmacy.Phone = textBoxPhone.Text;
            Program.pharmacy.PharmacySet.Add(pharmacy);
            Program.pharmacy.SaveChanges();
            ShowPharmacy();
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (listViewPharmacy.SelectedItems.Count == 1)
            {
                PharmacySet pharmacy = listViewPharmacy.SelectedItems[0].Tag as PharmacySet;
                pharmacy.Title = textBoxPharmacy.Text;
                pharmacy.Address = textBoxAddress.Text;
                pharmacy.Email = textBoxEmail.Text;
                pharmacy.Phone = textBoxPhone.Text;
            }
            Program.pharmacy.SaveChanges();
            ShowPharmacy();
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewPharmacy.SelectedItems.Count == 1)
                {
                    PharmacySet pharmacy = listViewPharmacy.SelectedItems[0].Tag as PharmacySet;
                    Program.pharmacy.PharmacySet.Remove(pharmacy);
                    Program.pharmacy.SaveChanges();
                    ShowPharmacy();
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListViewPharmacy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPharmacy.SelectedItems.Count == 1)
            {
                PharmacySet pharmacy = listViewPharmacy.SelectedItems[0].Tag as PharmacySet;
                textBoxPharmacy.Text = pharmacy.Title;
                textBoxAddress.Text = pharmacy.Address;
                textBoxEmail.Text = pharmacy.Email;
                textBoxPhone.Text = pharmacy.Phone;
            }
            else
            {
                textBoxPharmacy.Text = "";
                textBoxAddress.Text = "";
                textBoxEmail.Text = "";
                textBoxPhone.Text = "";
            }
        }
    }
}
