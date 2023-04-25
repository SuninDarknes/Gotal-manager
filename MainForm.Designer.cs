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
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.buttonAddStorage = new System.Windows.Forms.Button();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.buttonAddDeliverer = new System.Windows.Forms.Button();
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
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonStartProducts);
            this.flowLayoutPanel1.Controls.Add(this.buttonStartSkladiste);
            this.flowLayoutPanel1.Controls.Add(this.buttonStartKupci);
            this.flowLayoutPanel1.Controls.Add(this.buttonStartDobavljaci);
            this.flowLayoutPanel1.Controls.Add(this.buttonAddProduct);
            this.flowLayoutPanel1.Controls.Add(this.buttonAddStorage);
            this.flowLayoutPanel1.Controls.Add(this.buttonAddClient);
            this.flowLayoutPanel1.Controls.Add(this.buttonAddDeliverer);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(41, 178);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(198, 116);
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
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(84, 3);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(111, 23);
            this.buttonAddProduct.TabIndex = 4;
            this.buttonAddProduct.Text = "Dodaj proizvod";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            // 
            // buttonAddStorage
            // 
            this.buttonAddStorage.Location = new System.Drawing.Point(84, 32);
            this.buttonAddStorage.Name = "buttonAddStorage";
            this.buttonAddStorage.Size = new System.Drawing.Size(111, 23);
            this.buttonAddStorage.TabIndex = 5;
            this.buttonAddStorage.Text = "Dodaj u skladište";
            this.buttonAddStorage.UseVisualStyleBackColor = true;
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.Location = new System.Drawing.Point(84, 61);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(111, 23);
            this.buttonAddClient.TabIndex = 6;
            this.buttonAddClient.Text = "Dodaj kupca";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            // 
            // buttonAddDeliverer
            // 
            this.buttonAddDeliverer.Location = new System.Drawing.Point(84, 90);
            this.buttonAddDeliverer.Name = "buttonAddDeliverer";
            this.buttonAddDeliverer.Size = new System.Drawing.Size(111, 23);
            this.buttonAddDeliverer.TabIndex = 7;
            this.buttonAddDeliverer.Text = "Dodaj dobavljača";
            this.buttonAddDeliverer.UseVisualStyleBackColor = true;
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
        private Button buttonAddProduct;
        private Button buttonAddStorage;
        private Button buttonAddClient;
        private Button buttonAddDeliverer;
    }
}