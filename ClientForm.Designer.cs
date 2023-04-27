namespace Gotal_manager
{
    partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.spremiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxNazivSearch = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainFlowPanel
            // 
            this.MainFlowPanel.AutoScroll = true;
            this.MainFlowPanel.Location = new System.Drawing.Point(12, 56);
            this.MainFlowPanel.Name = "MainFlowPanel";
            this.MainFlowPanel.Size = new System.Drawing.Size(735, 382);
            this.MainFlowPanel.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spremiToolStripMenuItem,
            this.dodajToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(755, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // spremiToolStripMenuItem
            // 
            this.spremiToolStripMenuItem.Name = "spremiToolStripMenuItem";
            this.spremiToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.spremiToolStripMenuItem.Text = "Spremi";
            this.spremiToolStripMenuItem.Click += new System.EventHandler(this.spremiToolStripMenuItem_Click);
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            this.dodajToolStripMenuItem.Click += new System.EventHandler(this.dodajToolStripMenuItem_Click);
            // 
            // textBoxNazivSearch
            // 
            this.textBoxNazivSearch.Location = new System.Drawing.Point(12, 27);
            this.textBoxNazivSearch.Name = "textBoxNazivSearch";
            this.textBoxNazivSearch.Size = new System.Drawing.Size(300, 23);
            this.textBoxNazivSearch.TabIndex = 3;
            this.textBoxNazivSearch.TextChanged += new System.EventHandler(this.textBoxNazivSearch_TextChanged);
            // 
            // DobavljaciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 450);
            this.Controls.Add(this.textBoxNazivSearch);
            this.Controls.Add(this.MainFlowPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DobavljaciForm_FormClosing);
            this.SizeChanged += new System.EventHandler(this.DobavljaciForm_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel MainFlowPanel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem spremiToolStripMenuItem;
        private ToolStripMenuItem dodajToolStripMenuItem;
        private TextBox textBoxNazivSearch;
    }
}