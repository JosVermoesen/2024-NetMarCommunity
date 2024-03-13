using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// using IDEALSoftware.VpeStandard;
using IDEALSoftware.VpeCommunity;

using static System.Windows.Forms.DataFormats;

namespace NetMar
{
    public partial class FormMim : Form
    {
        public Form FormMimBYPERDAT { get; private set; }

        [LibraryImport("shell32.dll", EntryPoint = "ShellExecuteW", StringMarshalling = StringMarshalling.Utf16)]
        public static partial int ShellExecute(IntPtr hwnd, string operation, string file, string parameters, string directory, int ShowCmd);

        public static void ExportDocument(string FileName, VpeControl VpeDoc)
        {
            if (MessageBox.Show("Create PDF file?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FileName = Path.GetTempPath() + FileName;
                if (VpeDoc.WriteDoc(FileName))
                {
                    MessageBox.Show("PDF file \"" + FileName + "\" created successfully.");
                    ShellExecute((IntPtr)null, "Open", FileName, "", "", 3);
                }
                else
                {
                    MessageBox.Show("Error creating PDF file \"" + FileName + "\"\n" +
                        "Possible reasons:\n" +
                        " - the file is open in Acrobat Reader\n" +
                        " - hard disk full\n" +
                        " - no access rights to the folder\n" +
                        " - out of memory\n" +
                        " - export module missing");
                }
            }
        }

        public FormMim()
        {            
            InitializeComponent();
            FormMimBYPERDAT = new FormBYPERDAT
            {
                MdiParent = this
            };
            FormMimBYPERDAT.Show();
            FormMimBYPERDAT.Visible = false;

            FormMim_Load(this, EventArgs.Empty);            
        }

        private void FormMim_Load(object sender, EventArgs e)
        {
            // Set the title of the form
            Text = "Mim - " + Globals.MimTitle;
            // OpenBusinessToolStripMenuItem_Click(this, EventArgs.Empty);
        }

        private void CloseAppToolStripMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CommandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShellExecute((IntPtr)null, "CMD", "", "", "", 3);
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);

        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void AccessTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var form = new AccessTestForm();
            //form.MdiParent = this;
            //form.Show();
        }

        private void VsoftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ = ShellExecute((IntPtr)null, "Open", "https://www.vsoft.be", "", "", 3);
        }

        private void HostingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ = ShellExecute((IntPtr)null, "Open", "https://web20.foxxl.com:8443", "", "", 3);
        }

        private void PleskMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ = ShellExecute((IntPtr)null, "Open", "https://webmail.rv.be", "", "", 3);
        }

        private void LicenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO");
            MessageBox.Show(Globals.Int.ToString());
            MessageBox.Show(Globals.MimTitle);
        }

        private void CustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FormCustomers"] == null)
            {
                var CustomersForm = new FormCustomers
                {
                    MdiParent = this
                };

                CustomersForm.Show();
            }
        }

        private void BookOnLedgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FormBookOnLedger"] == null)
            {
                var BookOnLedgerForm = new FormBookOnLedger
                {
                    MdiParent = this
                };
                BookOnLedgerForm.Show();
            }            
        }

        // =====================================================================
        //                             Auto Page Break
        // =====================================================================
        private void VpeAutoPageMenuItem_Click(object sender, EventArgs e)
        {
            using OpenFileDialog SPPathFileDialog = new();
            SPPathFileDialog.InitialDirectory = "c:\\";
            SPPathFileDialog.Filter = "c# txt files (*.cs)|*.cs|All files (*.txt)|*.txt";
            SPPathFileDialog.Multiselect = true;
            SPPathFileDialog.FilterIndex = 1;
            SPPathFileDialog.RestoreDirectory = true;

            if (SPPathFileDialog.ShowDialog() == DialogResult.OK)
            {
                // string fileContent = string.Empty;
                string firstFullPath; // = string.Empty;

                //Get the path of specified file
                firstFullPath = SPPathFileDialog.FileName;
                // var arrayFileNames = SPPathFileDialog.FileNames;

                string sLine, block = "";
                StreamReader stream;

                FileInfo fi = new(firstFullPath);
                if (!fi.Exists)
                {
                    MessageBox.Show("File \"" + firstFullPath + "\" not found.");
                    return;
                }

                stream = new StreamReader(firstFullPath);
                VpeAutoPageMenuItem.Enabled = false;
                while (stream.Peek() > -1)    // not EOF
                {
                    sLine = stream.ReadLine()!;

                    // Replace all TAB characters with blanks, since the plain text object created with
                    // VPE.Print[Box]() or VPE.Write[Box]() does not handle TAB's
                    // NOTE: The RTF (Rich Text Format) object of the VPE Professional Edition DOES handle
                    //       tabs and also hanging indents, but this demo is intended for the
                    //       VPE Standard Edition.
                    sLine = sLine.Replace("\t", "   ");
                    block = block + "\n" + sLine;
                }
                stream.Close();

                MessageBox.Show("We loaded the file\n \"" + firstFullPath + "\"\n\n" +
                    "into memory using the slow \"ReadLine\" method.\n" +
                    "We also replaced all tab-characters with blanks.\n" +
                    "NOW we call VPE and create a document from the data.\n" +
                    "VPE will create the page breaks itself. This will work very fast!");

                AutoPageBreak.OpenDoc();
                AutoPageBreak.SelectFont("Courier New", 8);

                // Set the bottom margin, so the report will fit
                // onto A4 as well as onto US-Letter paper:
                // =============================================
                AutoPageBreak.SetOutRect(2, 2, 19, 26.5);

                // Header will be placed outside default output rectangle:
                AutoPageBreak.NoPen();
                AutoPageBreak.TextUnderline = true;
                AutoPageBreak.DefineHeader(1, 1, -7, -0.5, "Auto Text Break Demo - Page @PAGE");

                // On every intial page:
                // VLEFT   = VLEFTMARGIN
                // VTOP    = VTOPMARGIN
                // VRIGHT  = VRIGHTMARGIN
                // VBOTTOM = VTOPMARGIN !!!!!!!!!!
                AutoPageBreak.TextUnderline = false;
                AutoPageBreak.SetPen(0.03, PenStyle.Solid, Color.Black);
                AutoPageBreak.WriteBox(AutoPageBreak.nLeft, AutoPageBreak.nBottom, AutoPageBreak.nRight, AutoPageBreak.nFree, "[N TO BC LtGray CE S 12 B]Start of Listing");
                AutoPageBreak.WriteBox(AutoPageBreak.nLeft, AutoPageBreak.nBottom, AutoPageBreak.nRight, AutoPageBreak.nFree, block);
                AutoPageBreak.WriteBox(AutoPageBreak.nLeft, AutoPageBreak.nBottom, AutoPageBreak.nRight, AutoPageBreak.nFree, "[N TO BC LtGray CE S 12 B]End of Listing");

                AutoPageBreak.Preview();

                ExportDocument("Auto Break.pdf", AutoPageBreak);
                VpeAutoPageMenuItem.Enabled = true;
            }
        }

        private void OpenBusinessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormMimBYPERDAT.Visible)
            {
                // Determine if the Yes button was clicked on the dialog box.
                if (MessageBox.Show("Close active company?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    FormMimBYPERDAT.Visible = false;                                 
                }
                else { return; }
            }

            Form form = new FormOpenAdministration();
            form.ShowDialog();
            // Determine if the OK button was clicked on the dialog box.
            if (form.DialogResult == DialogResult.OK)
            {
                // Display a message box indicating that the OK button was clicked.
                // MessageBox.Show("The OK button on the form was clicked.");
                // Optional: Call the Dispose method when you are finished with the dialog box.
                form.Dispose();
                SysteemToolStripMenuItem.Enabled = true;
                SheetsToolStripMenuItem.Enabled = true;
                AccountingToolStripMenuItem.Enabled = true;

                FormMimBYPERDAT.Visible = true;
            }
            else
            {
                // Eventually display a message box indicating that the Cancel button was clicked.
                MessageBox.Show("The Cancel button on the form was clicked.");
                // Optional: Call the Dispose method when you are finished with the dialog box.
                form.Dispose();
                SysteemToolStripMenuItem.Enabled = false;
                SheetsToolStripMenuItem.Enabled = false;
                AccountingToolStripMenuItem.Enabled = false;
            }
        }        
    }
}
