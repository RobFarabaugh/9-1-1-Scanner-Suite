using System;
using System.Windows.Forms;

namespace ScannerSuite
{
    public partial class ByStateOrCountryDialog : Form
    {
        public ByStateOrCountryDialog()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "By State Or Country";
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Width = 400;
            this.Height = 200;

            Label label = new Label();
            label.Text = "Select a state or country:";
            label.Top = 20;
            label.Left = 20;
            label.Width = 200;
            this.Controls.Add(label);

            ComboBox comboBox = new ComboBox();
            comboBox.Left = 20;
            comboBox.Top = 50;
            comboBox.Width = 300;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.Items.AddRange(new string[]
            {
                "United States",
                "Canada",
                "United Kingdom",
                "Australia",
                "Germany"
            });
            this.Controls.Add(comboBox);

            Button okButton = new Button();
            okButton.Text = "OK";
            okButton.Left = 220;
            okButton.Top = 100;
            okButton.DialogResult = DialogResult.OK;
            this.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.Text = "Cancel";
            cancelButton.Left = 300;
            cancelButton.Top = 100;
            cancelButton.DialogResult = DialogResult.Cancel;
            this.Controls.Add(cancelButton);

            this.AcceptButton = okButton;
            this.CancelButton = cancelButton;
        }
    }
}
