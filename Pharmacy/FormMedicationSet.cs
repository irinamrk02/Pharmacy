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
                ListViewItem item = new ListViewItem(new string[]
                {
                    medication.Id.ToString(), medication.Medication,
                    medication.FormRelease.ToString(),medication.Dosage,
                    medication.Maker, medication.ProductionDate.ToString()
                });
                item.Tag = medication;
                listViewMedication.Items.Add(item);
            }
            listViewMedication.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

    }
}
