namespace ScannerSuite
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem feedToolStripMenuItem;
        private ToolStripMenuItem favoritesToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            feedToolStripMenuItem = new ToolStripMenuItem();
            favoritesToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();

            menuStrip1.Items.AddRange(new ToolStripItem[] {
                feedToolStripMenuItem,
                favoritesToolStripMenuItem,
                settingsToolStripMenuItem,
                helpToolStripMenuItem
            });

            feedToolStripMenuItem.Text = "Feed";
            favoritesToolStripMenuItem.Text = "Favorites";
            settingsToolStripMenuItem.Text = "Settings";
            helpToolStripMenuItem.Text = "Help";

            // Add submenus for "Feed"
            feedToolStripMenuItem.DropDownItems.Add("News");
            feedToolStripMenuItem.DropDownItems.Add("Updates");

            // Add submenus for "Favorites"
            favoritesToolStripMenuItem.DropDownItems.Add("Add to Favorites");
            favoritesToolStripMenuItem.DropDownItems.Add("Manage Favorites");

            // Add submenus for "Settings"
            settingsToolStripMenuItem.DropDownItems.Add("Preferences");
            settingsToolStripMenuItem.DropDownItems.Add("Account");

            // Add submenus for "Help"
            helpToolStripMenuItem.DropDownItems.Add("About");
            helpToolStripMenuItem.DropDownItems.Add("Support");

            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";

            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Name = "Form1";
            Text = "ScannerSuite";
        }
    }
}
