namespace Gotal_manager.Displays
{
    partial class PrimkeProductHistoryUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPrimkaID = new System.Windows.Forms.Label();
            this.labelPopust = new System.Windows.Forms.Label();
            this.labelPorez = new System.Windows.Forms.Label();
            this.labelKolicina = new System.Windows.Forms.Label();
            this.labelCijena = new System.Windows.Forms.Label();
            this.labelUkupnaCijena = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.labelDobavljac = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPrimkaID
            // 
            this.labelPrimkaID.AutoSize = true;
            this.labelPrimkaID.Location = new System.Drawing.Point(3, 6);
            this.labelPrimkaID.Name = "labelPrimkaID";
            this.labelPrimkaID.Size = new System.Drawing.Size(55, 15);
            this.labelPrimkaID.TabIndex = 0;
            this.labelPrimkaID.Text = "PrimkaID";
            // 
            // labelPopust
            // 
            this.labelPopust.AutoSize = true;
            this.labelPopust.Location = new System.Drawing.Point(203, 6);
            this.labelPopust.Name = "labelPopust";
            this.labelPopust.Size = new System.Drawing.Size(44, 15);
            this.labelPopust.TabIndex = 1;
            this.labelPopust.Text = "Popust";
            // 
            // labelPorez
            // 
            this.labelPorez.AutoSize = true;
            this.labelPorez.Location = new System.Drawing.Point(253, 6);
            this.labelPorez.Name = "labelPorez";
            this.labelPorez.Size = new System.Drawing.Size(36, 15);
            this.labelPorez.TabIndex = 2;
            this.labelPorez.Text = "Porez";
            // 
            // labelKolicina
            // 
            this.labelKolicina.AutoSize = true;
            this.labelKolicina.Location = new System.Drawing.Point(303, 6);
            this.labelKolicina.Name = "labelKolicina";
            this.labelKolicina.Size = new System.Drawing.Size(49, 15);
            this.labelKolicina.TabIndex = 3;
            this.labelKolicina.Text = "Kolicina";
            // 
            // labelCijena
            // 
            this.labelCijena.AutoSize = true;
            this.labelCijena.Location = new System.Drawing.Point(353, 6);
            this.labelCijena.Name = "labelCijena";
            this.labelCijena.Size = new System.Drawing.Size(40, 15);
            this.labelCijena.TabIndex = 4;
            this.labelCijena.Text = "Cijena";
            // 
            // labelUkupnaCijena
            // 
            this.labelUkupnaCijena.AutoSize = true;
            this.labelUkupnaCijena.Location = new System.Drawing.Point(453, 6);
            this.labelUkupnaCijena.Name = "labelUkupnaCijena";
            this.labelUkupnaCijena.Size = new System.Drawing.Size(81, 15);
            this.labelUkupnaCijena.TabIndex = 5;
            this.labelUkupnaCijena.Text = "UkupnaCijena";
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Location = new System.Drawing.Point(553, 6);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(68, 15);
            this.labelDatum.TabIndex = 6;
            this.labelDatum.Text = "labelDatum";
            // 
            // labelDobavljac
            // 
            this.labelDobavljac.AutoSize = true;
            this.labelDobavljac.Location = new System.Drawing.Point(53, 6);
            this.labelDobavljac.Name = "labelDobavljac";
            this.labelDobavljac.Size = new System.Drawing.Size(59, 15);
            this.labelDobavljac.TabIndex = 7;
            this.labelDobavljac.Text = "Dobavljac";
            // 
            // PrimkeProductHistoryUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelDobavljac);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.labelUkupnaCijena);
            this.Controls.Add(this.labelCijena);
            this.Controls.Add(this.labelKolicina);
            this.Controls.Add(this.labelPorez);
            this.Controls.Add(this.labelPopust);
            this.Controls.Add(this.labelPrimkaID);
            this.Name = "PrimkeProductHistoryUserControl";
            this.Size = new System.Drawing.Size(721, 29);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelPrimkaID;
        private Label labelPopust;
        private Label labelPorez;
        private Label labelKolicina;
        private Label labelCijena;
        private Label labelUkupnaCijena;
        private Label labelDatum;
        private Label labelDobavljac;
    }
}
