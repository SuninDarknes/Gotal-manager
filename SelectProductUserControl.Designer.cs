namespace Gotal_manager
{
    partial class SelectProductUserControl
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
            this.labelNaziv = new System.Windows.Forms.Label();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.labelCijena = new System.Windows.Forms.Label();
            this.labelBroj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Location = new System.Drawing.Point(53, 7);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(36, 15);
            this.labelNaziv.TabIndex = 0;
            this.labelNaziv.Text = "Naziv";
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(403, 3);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(75, 23);
            this.buttonAddProduct.TabIndex = 1;
            this.buttonAddProduct.Text = "Dodaj";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // labelCijena
            // 
            this.labelCijena.AutoSize = true;
            this.labelCijena.Location = new System.Drawing.Point(303, 7);
            this.labelCijena.Name = "labelCijena";
            this.labelCijena.Size = new System.Drawing.Size(40, 15);
            this.labelCijena.TabIndex = 2;
            this.labelCijena.Text = "Cijena";
            // 
            // labelBroj
            // 
            this.labelBroj.AutoSize = true;
            this.labelBroj.Location = new System.Drawing.Point(3, 7);
            this.labelBroj.Name = "labelBroj";
            this.labelBroj.Size = new System.Drawing.Size(28, 15);
            this.labelBroj.TabIndex = 3;
            this.labelBroj.Text = "Broj";
            // 
            // SelectProductUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelBroj);
            this.Controls.Add(this.labelCijena);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.labelNaziv);
            this.Name = "SelectProductUserControl";
            this.Size = new System.Drawing.Size(481, 29);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNaziv;
        private Button buttonAddProduct;
        private Label labelCijena;
        private Label labelBroj;
    }
}
