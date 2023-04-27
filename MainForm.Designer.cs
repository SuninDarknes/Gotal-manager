namespace Gotal_manager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonStartSkladiste = new System.Windows.Forms.Button();
            this.buttonStartProducts = new System.Windows.Forms.Button();
            this.buttonStartKupci = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonStartDobavljaci = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStartSkladiste
            // 
            this.buttonStartSkladiste.Location = new System.Drawing.Point(3, 32);
            this.buttonStartSkladiste.Name = "buttonStartSkladiste";
            this.buttonStartSkladiste.Size = new System.Drawing.Size(75, 23);
            this.buttonStartSkladiste.TabIndex = 0;
            this.buttonStartSkladiste.Text = "Skladište";
            this.buttonStartSkladiste.UseVisualStyleBackColor = true;
            this.buttonStartSkladiste.Click += new System.EventHandler(this.buttonStartSkladiste_Click);
            // 
            // buttonStartProducts
            // 
            this.buttonStartProducts.Location = new System.Drawing.Point(3, 3);
            this.buttonStartProducts.Name = "buttonStartProducts";
            this.buttonStartProducts.Size = new System.Drawing.Size(75, 23);
            this.buttonStartProducts.TabIndex = 1;
            this.buttonStartProducts.Text = "Cijenik";
            this.buttonStartProducts.UseVisualStyleBackColor = true;
            this.buttonStartProducts.Click += new System.EventHandler(this.buttonStartCijenik_Click);
            // 
            // buttonStartKupci
            // 
            this.buttonStartKupci.Location = new System.Drawing.Point(3, 61);
            this.buttonStartKupci.Name = "buttonStartKupci";
            this.buttonStartKupci.Size = new System.Drawing.Size(75, 23);
            this.buttonStartKupci.TabIndex = 2;
            this.buttonStartKupci.Text = "Kupci";
            this.buttonStartKupci.UseVisualStyleBackColor = true;
            this.buttonStartKupci.Click += new System.EventHandler(this.buttonStartKupci_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonStartProducts);
            this.flowLayoutPanel1.Controls.Add(this.buttonStartSkladiste);
            this.flowLayoutPanel1.Controls.Add(this.buttonStartKupci);
            this.flowLayoutPanel1.Controls.Add(this.buttonStartDobavljaci);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 210);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(84, 116);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // buttonStartDobavljaci
            // 
            this.buttonStartDobavljaci.Location = new System.Drawing.Point(3, 90);
            this.buttonStartDobavljaci.Name = "buttonStartDobavljaci";
            this.buttonStartDobavljaci.Size = new System.Drawing.Size(75, 23);
            this.buttonStartDobavljaci.TabIndex = 3;
            this.buttonStartDobavljaci.Text = "Dobavljači";
            this.buttonStartDobavljaci.UseVisualStyleBackColor = true;
            this.buttonStartDobavljaci.Click += new System.EventHandler(this.buttonStartDobavljaci_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonStartSkladiste;
        private Button buttonStartProducts;
        private Button buttonStartKupci;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonStartDobavljaci;
    }
}