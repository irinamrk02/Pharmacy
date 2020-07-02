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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void ButtonPharmacy_Click(object sender, EventArgs e)
        {
            FormPharmacy pharmacy = new FormPharmacy();
            pharmacy.Show();
        }

        private void ButtonMedication_Click(object sender, EventArgs e)
        {
            FormMedicationSet medication = new FormMedicationSet();
            medication.Show();
        }

        private void ButtonAvailability_Click(object sender, EventArgs e)
        {
            FormAvailability availability = new FormAvailability();
            availability.Show();
        }
    }
}
