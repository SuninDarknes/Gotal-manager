namespace Gotal_manager
{
    partial class PrimkaForm
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
            this.labelDobavljac = new System.Windows.Forms.Label();
            this.textBoxDobavljac = new System.Windows.Forms.TextBox();
            this.MainFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.postavkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dopuniDobavljačaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SmallErrorLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDobavljac
            // 
            this.labelDobavljac.AutoSize = true;
            this.labelDobavljac.Location = new System.Drawing.Point(12, 29);
            this.labelDobavljac.Name = "labelDobavljac";
            this.labelDobavljac.Size = new System.Drawing.Size(59, 15);
            this.labelDobavljac.TabIndex = 0;
            this.labelDobavljac.Text = "Dobavljač";
            // 
            // textBoxDobavljac
            // 
            this.textBoxDobavljac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxDobavljac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxDobavljac.Location = new System.Drawing.Point(116, 26);
            this.textBoxDobavljac.Name = "textBoxDobavljac";
            this.textBoxDobavljac.Size = new System.Drawing.Size(300, 23);
            this.textBoxDobavljac.TabIndex = 1;
            this.textBoxDobavljac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDobavljac_KeyPress);
            // 
            // MainFlowPanel
            // 
            this.MainFlowPanel.Location = new System.Drawing.Point(116, 56);
            this.MainFlowPanel.Name = "MainFlowPanel";
            this.MainFlowPanel.Size = new System.Drawing.Size(730, 302);
            this.MainFlowPanel.TabIndex = 2;
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(12, 56);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(98, 23);
            this.buttonAddProduct.TabIndex = 3;
            this.buttonAddProduct.Text = "Dodaj Proizvod";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.postavkeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(949, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // postavkeToolStripMenuItem
            // 
            this.postavkeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dopuniDobavljačaToolStripMenuItem});
            this.postavkeToolStripMenuItem.Name = "postavkeToolStripMenuItem";
            this.postavkeToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.postavkeToolStripMenuItem.Text = "Postavke";
            // 
            // dopuniDobavljačaToolStripMenuItem
            // 
            this.dopuniDobavljačaToolStripMenuItem.Name = "dopuniDobavljačaToolStripMenuItem";
            this.dopuniDobavljačaToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.dopuniDobavljačaToolStripMenuItem.Text = "Dopuni Dobavljača";
            this.dopuniDobavljačaToolStripMenuItem.Click += new System.EventHandler(this.dopuniDobavljačaToolStripMenuItem_Click);
            // 
            // SmallErrorLabel
            // 
            this.SmallErrorLabel.AutoSize = true;
            this.SmallErrorLabel.Location = new System.Drawing.Point(12, 433);
            this.SmallErrorLabel.Name = "SmallErrorLabel";
            this.SmallErrorLabel.Size = new System.Drawing.Size(61, 15);
            this.SmallErrorLabel.TabIndex = 5;
            this.SmallErrorLabel.Text = "Initializnig";
            // 
            // PrimkaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 457);
            this.Controls.Add(this.SmallErrorLabel);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.MainFlowPanel);
            this.Controls.Add(this.textBoxDobavljac);
            this.Controls.Add(this.labelDobavljac);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrimkaForm";
            this.Text = "PrimkaForm";
            this.Load += new System.EventHandler(this.PrimkaForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelDobavljac;
        private TextBox textBoxDobavljac;
        private FlowLayoutPanel MainFlowPanel;
        private Button buttonAddProduct;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem postavkeToolStripMenuItem;
        private ToolStripMenuItem dopuniDobavljačaToolStripMenuItem;
        public Label SmallErrorLabel;
    }
}