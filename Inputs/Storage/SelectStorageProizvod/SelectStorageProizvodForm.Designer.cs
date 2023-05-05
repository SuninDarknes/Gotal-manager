namespace Gotal_manager.Inputs.Storage.SelectStorageProizvod
{
    partial class SelectStorageProizvodForm
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
            this.labelBroj = new System.Windows.Forms.Label();
            this.labelCijena = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 35);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(541, 501);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // labelBroj
            // 
            this.labelBroj.AutoSize = true;
            this.labelBroj.Location = new System.Drawing.Point(15, 9);
            this.labelBroj.Name = "labelBroj";
            this.labelBroj.Size = new System.Drawing.Size(28, 15);
            this.labelBroj.TabIndex = 6;
            this.labelBroj.Text = "Broj";
            // 
            // labelCijena
            // 
            this.labelCijena.AutoSize = true;
            this.labelCijena.Location = new System.Drawing.Point(315, 9);
            this.labelCijena.Name = "labelCijena";
            this.labelCijena.Size = new System.Drawing.Size(40, 15);
            this.labelCijena.TabIndex = 5;
            this.labelCijena.Text = "Cijena";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(71, 6);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(226, 23);
            this.textBoxSearch.TabIndex = 7;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // SelectStorageProizvodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 548);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelBroj);
            this.Controls.Add(this.labelCijena);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "SelectStorageProizvodForm";
            this.Text = "SelectProductForm";
            this.Load += new System.EventHandler(this.SelectStorageProizvodForm_Load);
            this.SizeChanged += new System.EventHandler(this.SelectStorageProizvodForm_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label labelBroj;
        private Label labelCijena;
        private TextBox textBoxSearch;
    }
}