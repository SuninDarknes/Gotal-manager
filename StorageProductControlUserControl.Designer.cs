namespace Gotal_manager
{
    partial class StorageProductControlUserControl
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
            this.textBoxPopust = new System.Windows.Forms.TextBox();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.labelBroj = new System.Windows.Forms.Label();
            this.labelCijena = new System.Windows.Forms.Label();
            this.textBoxPDV = new System.Windows.Forms.TextBox();
            this.textBoxKolicina = new System.Windows.Forms.TextBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.labelIznos = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPopust
            // 
            this.textBoxPopust.Location = new System.Drawing.Point(444, 3);
            this.textBoxPopust.Name = "textBoxPopust";
            this.textBoxPopust.Size = new System.Drawing.Size(50, 23);
            this.textBoxPopust.TabIndex = 0;
            this.textBoxPopust.Text = "0";
            this.textBoxPopust.TextChanged += new System.EventHandler(this.textBoxPopust_TextChanged);
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Location = new System.Drawing.Point(103, 7);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(36, 15);
            this.labelNaziv.TabIndex = 1;
            this.labelNaziv.Text = "Naziv";
            // 
            // labelBroj
            // 
            this.labelBroj.AutoSize = true;
            this.labelBroj.Location = new System.Drawing.Point(53, 7);
            this.labelBroj.Name = "labelBroj";
            this.labelBroj.Size = new System.Drawing.Size(28, 15);
            this.labelBroj.TabIndex = 2;
            this.labelBroj.Text = "Broj";
            // 
            // labelCijena
            // 
            this.labelCijena.AutoSize = true;
            this.labelCijena.Location = new System.Drawing.Point(353, 7);
            this.labelCijena.Name = "labelCijena";
            this.labelCijena.Size = new System.Drawing.Size(40, 15);
            this.labelCijena.TabIndex = 3;
            this.labelCijena.Text = "Cijena";
            // 
            // textBoxPDV
            // 
            this.textBoxPDV.Location = new System.Drawing.Point(500, 3);
            this.textBoxPDV.Name = "textBoxPDV";
            this.textBoxPDV.Size = new System.Drawing.Size(50, 23);
            this.textBoxPDV.TabIndex = 4;
            this.textBoxPDV.Text = "0";
            this.textBoxPDV.TextChanged += new System.EventHandler(this.textBoxPDV_TextChanged);
            // 
            // textBoxKolicina
            // 
            this.textBoxKolicina.Location = new System.Drawing.Point(556, 3);
            this.textBoxKolicina.Name = "textBoxKolicina";
            this.textBoxKolicina.Size = new System.Drawing.Size(50, 23);
            this.textBoxKolicina.TabIndex = 5;
            this.textBoxKolicina.Text = "1";
            this.textBoxKolicina.TextChanged += new System.EventHandler(this.textBoxKolicina_TextChanged);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Image = global::Gotal_manager.Properties.Resources.cross;
            this.RemoveButton.Location = new System.Drawing.Point(678, 3);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(23, 23);
            this.RemoveButton.TabIndex = 6;
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // labelIznos
            // 
            this.labelIznos.AutoSize = true;
            this.labelIznos.Location = new System.Drawing.Point(612, 7);
            this.labelIznos.Name = "labelIznos";
            this.labelIznos.Size = new System.Drawing.Size(34, 15);
            this.labelIznos.TabIndex = 7;
            this.labelIznos.Text = "Iznos";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(3, 7);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 15);
            this.labelID.TabIndex = 8;
            this.labelID.Text = "ID";
            // 
            // StorageProductControlUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelIznos);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.textBoxKolicina);
            this.Controls.Add(this.textBoxPDV);
            this.Controls.Add(this.labelCijena);
            this.Controls.Add(this.labelBroj);
            this.Controls.Add(this.labelNaziv);
            this.Controls.Add(this.textBoxPopust);
            this.Name = "StorageProductControlUserControl";
            this.Size = new System.Drawing.Size(705, 29);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxPopust;
        private Label labelNaziv;
        private Label labelBroj;
        private Label labelCijena;
        private TextBox textBoxPDV;
        private TextBox textBoxKolicina;
        private Button RemoveButton;
        private Label labelIznos;
        private Label labelID;
    }
}
