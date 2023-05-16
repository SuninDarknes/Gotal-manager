namespace Gotal_manager.Inputs.Storage.Izdatnice
{
    partial class IzdatnicaForm
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
            this.labelKupac = new System.Windows.Forms.Label();
            this.textBoxKupac = new System.Windows.Forms.TextBox();
            this.MainFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.postavkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dopuniKupcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SmallErrorLabel = new System.Windows.Forms.Label();
            this.buttonUnesi = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelID = new System.Windows.Forms.Label();
            this.labelIznos = new System.Windows.Forms.Label();
            this.labelCijena = new System.Windows.Forms.Label();
            this.labelBroj = new System.Windows.Forms.Label();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.labelPopust = new System.Windows.Forms.Label();
            this.labelPDV = new System.Windows.Forms.Label();
            this.labelKolicna = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelKupac
            // 
            this.labelKupac.AutoSize = true;
            this.labelKupac.Location = new System.Drawing.Point(12, 29);
            this.labelKupac.Name = "labelKupac";
            this.labelKupac.Size = new System.Drawing.Size(40, 15);
            this.labelKupac.TabIndex = 0;
            this.labelKupac.Text = "Kupac";
            // 
            // textBoxKupac
            // 
            this.textBoxKupac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxKupac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxKupac.Location = new System.Drawing.Point(116, 26);
            this.textBoxKupac.Name = "textBoxKupac";
            this.textBoxKupac.Size = new System.Drawing.Size(300, 23);
            this.textBoxKupac.TabIndex = 1;
            this.textBoxKupac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKupac_KeyPress);
            // 
            // MainFlowPanel
            // 
            this.MainFlowPanel.AutoScroll = true;
            this.MainFlowPanel.Location = new System.Drawing.Point(116, 78);
            this.MainFlowPanel.Name = "MainFlowPanel";
            this.MainFlowPanel.Size = new System.Drawing.Size(730, 294);
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
            this.menuStrip1.Size = new System.Drawing.Size(859, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // postavkeToolStripMenuItem
            // 
            this.postavkeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dopuniKupcaToolStripMenuItem});
            this.postavkeToolStripMenuItem.Name = "postavkeToolStripMenuItem";
            this.postavkeToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.postavkeToolStripMenuItem.Text = "Postavke";
            // 
            // dopuniKupcaToolStripMenuItem
            // 
            this.dopuniKupcaToolStripMenuItem.Name = "dopuniKupcaToolStripMenuItem";
            this.dopuniKupcaToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.dopuniKupcaToolStripMenuItem.Text = "Dopuni Kupca";
            this.dopuniKupcaToolStripMenuItem.Click += new System.EventHandler(this.dopuniKupcaToolStripMenuItem_Click);
            // 
            // SmallErrorLabel
            // 
            this.SmallErrorLabel.AutoSize = true;
            this.SmallErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.SmallErrorLabel.Location = new System.Drawing.Point(12, 433);
            this.SmallErrorLabel.Name = "SmallErrorLabel";
            this.SmallErrorLabel.Size = new System.Drawing.Size(61, 15);
            this.SmallErrorLabel.TabIndex = 5;
            this.SmallErrorLabel.Text = "Initializnig";
            // 
            // buttonUnesi
            // 
            this.buttonUnesi.Location = new System.Drawing.Point(116, 407);
            this.buttonUnesi.Name = "buttonUnesi";
            this.buttonUnesi.Size = new System.Drawing.Size(75, 23);
            this.buttonUnesi.TabIndex = 6;
            this.buttonUnesi.Text = "Unesi";
            this.buttonUnesi.UseVisualStyleBackColor = true;
            this.buttonUnesi.Click += new System.EventHandler(this.buttonUnesi_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(116, 378);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(149, 23);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(2023, 5, 5, 0, 0, 0, 0);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(124, 60);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 15);
            this.labelID.TabIndex = 16;
            this.labelID.Text = "ID";
            // 
            // labelIznos
            // 
            this.labelIznos.AutoSize = true;
            this.labelIznos.Location = new System.Drawing.Point(733, 60);
            this.labelIznos.Name = "labelIznos";
            this.labelIznos.Size = new System.Drawing.Size(81, 15);
            this.labelIznos.TabIndex = 15;
            this.labelIznos.Text = "Prodajni Iznos";
            // 
            // labelCijena
            // 
            this.labelCijena.AutoSize = true;
            this.labelCijena.Location = new System.Drawing.Point(474, 60);
            this.labelCijena.Name = "labelCijena";
            this.labelCijena.Size = new System.Drawing.Size(90, 15);
            this.labelCijena.TabIndex = 12;
            this.labelCijena.Text = "Prodajna Cijena";
            // 
            // labelBroj
            // 
            this.labelBroj.AutoSize = true;
            this.labelBroj.Location = new System.Drawing.Point(174, 60);
            this.labelBroj.Name = "labelBroj";
            this.labelBroj.Size = new System.Drawing.Size(28, 15);
            this.labelBroj.TabIndex = 11;
            this.labelBroj.Text = "Broj";
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Location = new System.Drawing.Point(224, 60);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(36, 15);
            this.labelNaziv.TabIndex = 10;
            this.labelNaziv.Text = "Naziv";
            // 
            // labelPopust
            // 
            this.labelPopust.AutoSize = true;
            this.labelPopust.Location = new System.Drawing.Point(559, 60);
            this.labelPopust.Name = "labelPopust";
            this.labelPopust.Size = new System.Drawing.Size(62, 15);
            this.labelPopust.TabIndex = 17;
            this.labelPopust.Text = "Popust(%)";
            // 
            // labelPDV
            // 
            this.labelPDV.AutoSize = true;
            this.labelPDV.Location = new System.Drawing.Point(621, 60);
            this.labelPDV.Name = "labelPDV";
            this.labelPDV.Size = new System.Drawing.Size(47, 15);
            this.labelPDV.TabIndex = 18;
            this.labelPDV.Text = "PDV(%)";
            // 
            // labelKolicna
            // 
            this.labelKolicna.AutoSize = true;
            this.labelKolicna.Location = new System.Drawing.Point(677, 60);
            this.labelKolicna.Name = "labelKolicna";
            this.labelKolicna.Size = new System.Drawing.Size(46, 15);
            this.labelKolicna.TabIndex = 19;
            this.labelKolicna.Text = "Količna";
            // 
            // IzdatnicaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 457);
            this.Controls.Add(this.labelKolicna);
            this.Controls.Add(this.labelPDV);
            this.Controls.Add(this.labelPopust);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelIznos);
            this.Controls.Add(this.labelCijena);
            this.Controls.Add(this.labelBroj);
            this.Controls.Add(this.labelNaziv);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonUnesi);
            this.Controls.Add(this.SmallErrorLabel);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.MainFlowPanel);
            this.Controls.Add(this.textBoxKupac);
            this.Controls.Add(this.labelKupac);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "IzdatnicaForm";
            this.Text = "IzdatnicaForm";
            this.Load += new System.EventHandler(this.IzdatnicaForm_Load);
            this.SizeChanged += new System.EventHandler(this.IzdatnicaForm_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelKupac;
        private TextBox textBoxKupac;
        private FlowLayoutPanel MainFlowPanel;
        private Button buttonAddProduct;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem postavkeToolStripMenuItem;
        private ToolStripMenuItem dopuniKupcaToolStripMenuItem;
        public Label SmallErrorLabel;
        private Button buttonUnesi;
        private DateTimePicker dateTimePicker1;
        private Label labelID;
        private Label labelIznos;
        private Label labelCijena;
        private Label labelBroj;
        private Label labelNaziv;
        private Label labelPopust;
        private Label labelPDV;
        private Label labelKolicna;
    }
}
