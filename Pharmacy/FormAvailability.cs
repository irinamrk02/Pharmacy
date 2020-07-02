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
        }
        void ShowPharmacy()
        {
            comboBoxPharmacy.Items.Clear();
            foreach (PharmacySet pharmacy in Program.pharmacy.PharmacySet)
            {
                string[] item = { pharmacy.Id.ToString() + ".", pharmacy.Title };
            }

        }

    }
}
