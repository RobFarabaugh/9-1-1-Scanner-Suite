using System.Windows.Forms;

namespace ScannerSuite
{
    public partial class ByStateOrCountryDialog : Form
    {
        public ByStateOrCountryDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The state or country currently selected in the dialog. Always one of the
        /// listed entries, because the combo box has no empty state.
        /// </summary>
        public string SelectedStateOrCountry
        {
            get { return this.comboBox.SelectedItem as string; }
        }

        /// <summary>
        /// Shows the dialog and returns the chosen state or country, or null if the
        /// user cancelled or closed it. The caller checks one value instead of
        /// remembering to compare DialogResult, and the dialog is disposed for them.
        /// </summary>
        public static string ShowSelection(IWin32Window owner)
        {
            using (ByStateOrCountryDialog dialog = new ByStateOrCountryDialog())
            {
                if (dialog.ShowDialog(owner) != DialogResult.OK)
                {
                    return null;
                }

                return dialog.SelectedStateOrCountry;
            }
        }
    }
}
