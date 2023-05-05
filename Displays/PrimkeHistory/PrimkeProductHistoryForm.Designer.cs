namespace Gotal_manager.Displays
{
    partial class PrimkeProductHistoryForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelDobavljac = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.labelUkupnaCijena = new System.Windows.Forms.Label();
            this.labelCijena = new System.Windows.Forms.Label();
            this.labelKolicina = new System.Windows.Forms.Label();
            this.labelPorez = new System.Windows.Forms.Label();
            this.labelPopust = new System.Windows.Forms.Label();
            this.labelPrimkaID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(675, 395);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // labelDobavljac
            // 
            this.labelDobavljac.AutoSize = true;
            this.labelDobavljac.Location = new System.Drawing.Point(62, 9);
            this.labelDobavljac.Name = "labelDobavljac";
            this.labelDobavljac.Size = new System.Drawing.Size(59, 15);
            this.labelDobavljac.TabIndex = 15;
            this.labelDobavljac.Text = "Dobavljac";
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Location = new System.Drawing.Point(562, 9);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(43, 15);
            this.labelDatum.TabIndex = 14;
            this.labelDatum.Text = "Datum";
            // 
            // labelUkupnaCijena
            // 
            this.labelUkupnaCijena.AutoSize = true;
            this.labelUkupnaCijena.Location = new System.Drawing.Point(462, 9);
            this.labelUkupnaCijena.Name = "labelUkupnaCijena";
            this.labelUkupnaCijena.Size = new System.Drawing.Size(84, 15);
            this.labelUkupnaCijena.TabIndex = 13;
            this.labelUkupnaCijena.Text = "Ukupna Cijena";
            // 
            // labelCijena
            // 
            this.labelCijena.AutoSize = true;
            this.labelCijena.Location = new System.Drawing.Point(362, 9);
            this.labelCijena.Name = "labelCijena";
            this.labelCijena.Size = new System.Drawing.Size(86, 15);
            this.labelCijena.TabIndex = 12;
            this.labelCijena.Text = "Cijena komada";
            // 
            // labelKolicina
            // 
            this.labelKolicina.AutoSize = true;
            this.labelKolicina.Location = new System.Drawing.Point(312, 9);
            this.labelKolicina.Name = "labelKolicina";
            this.labelKolicina.Size = new System.Drawing.Size(49, 15);
            this.labelKolicina.TabIndex = 11;
            this.labelKolicina.Text = "Kolicina";
            // 
            // labelPorez
            // 
            this.labelPorez.AutoSize = true;
            this.labelPorez.Location = new System.Drawing.Point(262, 9);
            this.labelPorez.Name = "labelPorez";
            this.labelPorez.Size = new System.Drawing.Size(36, 15);
            this.labelPorez.TabIndex = 10;
            this.labelPorez.Text = "Porez";
            // 
            // labelPopust
            // 
            this.labelPopust.AutoSize = true;
            this.labelPopust.Location = new System.Drawing.Point(212, 9);
            this.labelPopust.Name = "labelPopust";
            this.labelPopust.Size = new System.Drawing.Size(44, 15);
            this.labelPopust.TabIndex = 9;
            this.labelPopust.Text = "Popust";
            // 
            // labelPrimkaID
            // 
            this.labelPrimkaID.AutoSize = true;
            this.labelPrimkaID.Location = new System.Drawing.Point(12, 9);
            this.labelPrimkaID.Name = "labelPrimkaID";
            this.labelPrimkaID.Size = new System.Drawing.Size(55, 15);
            this.labelPrimkaID.TabIndex = 8;
            this.labelPrimkaID.Text = "PrimkaID";
            // 
            // PrimkeProductHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 435);
            this.Controls.Add(this.labelDobavljac);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.labelUkupnaCijena);
            this.Controls.Add(this.labelCijena);
            this.Controls.Add(this.labelKolicina);
            this.Controls.Add(this.labelPorez);
            this.Controls.Add(this.labelPopust);
            this.Controls.Add(this.labelPrimkaID);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "PrimkeProductHistoryForm";
            this.Text = "PrimkeProductHistoryForm";
            this.Load += new System.EventHandler(this.PrimkeProductHistoryForm_Load);
            this.SizeChanged += new System.EventHandler(this.PrimkeProductHistoryForm_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label labelDobavljac;
        private Label labelDatum;
        private Label labelUkupnaCijena;
        private Label labelCijena;
        private Label labelKolicina;
        private Label labelPorez;
        private Label labelPopust;
        private Label labelPrimkaID;
    }
}