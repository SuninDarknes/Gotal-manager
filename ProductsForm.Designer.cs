namespace Gotal_manager
{
    partial class ProductsForm
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
            this.DobitLock = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelRoba = new System.Windows.Forms.Label();
            this.IzlazLock = new System.Windows.Forms.RadioButton();
            this.ProfitLock = new System.Windows.Forms.RadioButton();
            this.SmallErrorLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automatskoRačunanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikazujUpozorenjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spremiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddRowButton = new System.Windows.Forms.Button();
            this.MainFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.NazivSearchTextBox = new System.Windows.Forms.TextBox();
            this.BrojLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DobitLock
            // 
            this.DobitLock.AutoSize = true;
            this.DobitLock.Location = new System.Drawing.Point(564, 21);
            this.DobitLock.Name = "DobitLock";
            this.DobitLock.Size = new System.Drawing.Size(14, 13);
            this.DobitLock.TabIndex = 2;
            this.DobitLock.UseVisualStyleBackColor = true;
            this.DobitLock.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(735, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Zarada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(599, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prodajna cijena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(513, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dobit %";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ulazna cijena";
            // 
            // LabelRoba
            // 
            this.LabelRoba.AutoSize = true;
            this.LabelRoba.Location = new System.Drawing.Point(79, 24);
            this.LabelRoba.Name = "LabelRoba";
            this.LabelRoba.Size = new System.Drawing.Size(34, 15);
            this.LabelRoba.TabIndex = 1;
            this.LabelRoba.Text = "Roba";
            // 
            // IzlazLock
            // 
            this.IzlazLock.AutoSize = true;
            this.IzlazLock.Checked = true;
            this.IzlazLock.Location = new System.Drawing.Point(689, 22);
            this.IzlazLock.Name = "IzlazLock";
            this.IzlazLock.Size = new System.Drawing.Size(14, 13);
            this.IzlazLock.TabIndex = 3;
            this.IzlazLock.TabStop = true;
            this.IzlazLock.UseVisualStyleBackColor = true;
            this.IzlazLock.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // ProfitLock
            // 
            this.ProfitLock.AutoSize = true;
            this.ProfitLock.Location = new System.Drawing.Point(780, 22);
            this.ProfitLock.Name = "ProfitLock";
            this.ProfitLock.Size = new System.Drawing.Size(14, 13);
            this.ProfitLock.TabIndex = 6;
            this.ProfitLock.UseVisualStyleBackColor = true;
            this.ProfitLock.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // SmallErrorLabel
            // 
            this.SmallErrorLabel.AutoSize = true;
            this.SmallErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.SmallErrorLabel.Location = new System.Drawing.Point(12, 430);
            this.SmallErrorLabel.Name = "SmallErrorLabel";
            this.SmallErrorLabel.Size = new System.Drawing.Size(61, 15);
            this.SmallErrorLabel.TabIndex = 7;
            this.SmallErrorLabel.Text = "Initializing";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.spremiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1168, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.automatskoRačunanjeToolStripMenuItem,
            this.prikazujUpozorenjaToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.editToolStripMenuItem.Text = "Postavke";
            // 
            // automatskoRačunanjeToolStripMenuItem
            // 
            this.automatskoRačunanjeToolStripMenuItem.Checked = true;
            this.automatskoRačunanjeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.automatskoRačunanjeToolStripMenuItem.Name = "automatskoRačunanjeToolStripMenuItem";
            this.automatskoRačunanjeToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.automatskoRačunanjeToolStripMenuItem.Text = "automatsko računanje";
            this.automatskoRačunanjeToolStripMenuItem.Click += new System.EventHandler(this.automatskoRačunanjeToolStripMenuItem_Click);
            // 
            // prikazujUpozorenjaToolStripMenuItem
            // 
            this.prikazujUpozorenjaToolStripMenuItem.Name = "prikazujUpozorenjaToolStripMenuItem";
            this.prikazujUpozorenjaToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.prikazujUpozorenjaToolStripMenuItem.Text = "Prikazuj Upozorenja";
            this.prikazujUpozorenjaToolStripMenuItem.Click += new System.EventHandler(this.prikazujUpozorenjaToolStripMenuItem_Click);
            // 
            // spremiToolStripMenuItem
            // 
            this.spremiToolStripMenuItem.Name = "spremiToolStripMenuItem";
            this.spremiToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.spremiToolStripMenuItem.Text = "Spremi";
            this.spremiToolStripMenuItem.Click += new System.EventHandler(this.spremiToolStripMenuItem_Click);
            // 
            // AddRowButton
            // 
            this.AddRowButton.Image = global::Gotal_manager.Properties.Resources.add;
            this.AddRowButton.Location = new System.Drawing.Point(326, 42);
            this.AddRowButton.Name = "AddRowButton";
            this.AddRowButton.Size = new System.Drawing.Size(23, 23);
            this.AddRowButton.TabIndex = 0;
            this.AddRowButton.UseVisualStyleBackColor = false;
            this.AddRowButton.Click += new System.EventHandler(this.AddRowButton_Click);
            // 
            // MainFlowPanel
            // 
            this.MainFlowPanel.AutoScroll = true;
            this.MainFlowPanel.Location = new System.Drawing.Point(12, 71);
            this.MainFlowPanel.Name = "MainFlowPanel";
            this.MainFlowPanel.Size = new System.Drawing.Size(893, 356);
            this.MainFlowPanel.TabIndex = 9;
            // 
            // NazivSearchTextBox
            // 
            this.NazivSearchTextBox.Location = new System.Drawing.Point(12, 42);
            this.NazivSearchTextBox.Name = "NazivSearchTextBox";
            this.NazivSearchTextBox.Size = new System.Drawing.Size(301, 23);
            this.NazivSearchTextBox.TabIndex = 1;
            this.NazivSearchTextBox.TextChanged += new System.EventHandler(this.NazivSearchTextBox_TextChanged);
            // 
            // BrojLabel
            // 
            this.BrojLabel.AutoSize = true;
            this.BrojLabel.Location = new System.Drawing.Point(18, 24);
            this.BrojLabel.Name = "BrojLabel";
            this.BrojLabel.Size = new System.Drawing.Size(28, 15);
            this.BrojLabel.TabIndex = 10;
            this.BrojLabel.Text = "Broj";
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 450);
            this.Controls.Add(this.BrojLabel);
            this.Controls.Add(this.AddRowButton);
            this.Controls.Add(this.NazivSearchTextBox);
            this.Controls.Add(this.MainFlowPanel);
            this.Controls.Add(this.SmallErrorLabel);
            this.Controls.Add(this.ProfitLock);
            this.Controls.Add(this.DobitLock);
            this.Controls.Add(this.IzlazLock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabelRoba);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProductsForm";
            this.Text = "ProductsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductsForm_FormClosing);
            this.SizeChanged += new System.EventHandler(this.ProductsForm_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label LabelRoba;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private RadioButton DobitLock;
        private RadioButton IzlazLock;
        private RadioButton ProfitLock;
        private Label SmallErrorLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem spremiToolStripMenuItem;
        private ToolStripMenuItem automatskoRačunanjeToolStripMenuItem;
        private ToolStripMenuItem prikazujUpozorenjaToolStripMenuItem;
        private Button AddRowButton;
        private FlowLayoutPanel MainFlowPanel;
        private TextBox NazivSearchTextBox;
        private Label BrojLabel;
    }
}