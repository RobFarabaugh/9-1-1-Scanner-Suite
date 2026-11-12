using System;
using System.Windows.Forms;

namespace ScannerSuite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void byStateOrCountryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selection = ByStateOrCountryDialog.ShowSelection(this);

            if (selection == null)
            {
                // Cancelled or closed: nothing was chosen, so stay quiet.
                return;
            }

            // A message box takes focus, so the selection is announced by the
            // screen reader instead of changing silently behind the dialog.
            MessageBox.Show(
                this,
                $"You selected {selection}.",
                "Feed selection",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
