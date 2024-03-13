using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetMar
{
    public partial class FormBookOnLedger : Form
    {
        public FormBookOnLedger()
        {
            InitializeComponent();

            BookingType.Items.Add("0: Diverse Post");
            BookingType.Items.Add("1: Afschrijvingspost Eindejaar");
            BookingType.Items.Add("2: Beginbalans");
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            BookingType.Enabled = true;
            BookingType.SelectedIndex = -1; 
            LedgerEntries.Items.Clear();

        }
    }
}
