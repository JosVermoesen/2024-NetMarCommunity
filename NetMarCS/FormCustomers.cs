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
    public partial class FormCustomers : Form
    {
        public FormCustomers()
        {
            InitializeComponent();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {            
            // set global variables
            Globals.SetInt(12345);
            Globals.SetMimTitle("Hello Bedrijfje!");

            MessageBox.Show(Globals.Int.ToString());
            MessageBox.Show(Globals.MimTitle);
            Close();
        }
    }
}
