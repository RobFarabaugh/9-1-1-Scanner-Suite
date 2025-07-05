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

        private void SetupMenuBar()
        {
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.feedToolStripMenuItem,
                this.favoritesToolStripMenuItem,
                this.settingsToolStripMenuItem,
                this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
        }
        
        private void StateOrCountry_Click(object sender, EventArgs e)
        {
            var dialog = new ByStateOrCountryDialog();
            dialog.ShowDialog();
        }

        private void SetupFeedMenu()
        {
            this.feedToolStripMenuItem.Name = "feedToolStripMenuItem";
            this.feedToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.feedToolStripMenuItem.Text = "Feed";
            var browseSubMenu = new ToolStripMenuItem("Browse By");
            this.feedToolStripMenuItem.DropDownItems.Add(browseSubMenu);
            browseSubMenu.DropDownItems.Add(new ToolStripMenuItem("State or country", null, StateOrCountry_Click));
        }

        private void SetupFavoritesMenu()
        {
            this.favoritesToolStripMenuItem.Name = "favoritesToolStripMenuItem";
            this.favoritesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.favoritesToolStripMenuItem.Text = "Favorites";
        }

        private void SetupSettingsMenu()
        {
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
        }

        private void SetupHelpMenu()
        {
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
        }
    }
}
