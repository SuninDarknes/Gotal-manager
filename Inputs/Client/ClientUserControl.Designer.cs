namespace Gotal_manager
{
    partial class ClientUserControl
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
            this.TextBoxNaziv = new System.Windows.Forms.TextBox();
            this.TextBoxAdresa = new System.Windows.Forms.TextBox();
            this.TextBoxTelefon = new System.Windows.Forms.TextBox();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.TextBoxVAT = new System.Windows.Forms.TextBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.labelAdresa = new System.Windows.Forms.Label();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelVAT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBoxNaziv
            // 
            this.TextBoxNaziv.Location = new System.Drawing.Point(62, 6);
            this.TextBoxNaziv.Name = "TextBoxNaziv";
            this.TextBoxNaziv.Size = new System.Drawing.Size(300, 23);
            this.TextBoxNaziv.TabIndex = 0;
            this.TextBoxNaziv.TextChanged += new System.EventHandler(this.TextBoxNaziv_TextChanged);
            // 
            // TextBoxAdresa
            // 
            this.TextBoxAdresa.Location = new System.Drawing.Point(62, 35);
            this.TextBoxAdresa.Name = "TextBoxAdresa";
            this.TextBoxAdresa.Size = new System.Drawing.Size(300, 23);
            this.TextBoxAdresa.TabIndex = 1;
            this.TextBoxAdresa.TextChanged += new System.EventHandler(this.TextBoxAdresa_TextChanged);
            // 
            // TextBoxTelefon
            // 
            this.TextBoxTelefon.Location = new System.Drawing.Point(62, 64);
            this.TextBoxTelefon.Name = "TextBoxTelefon";
            this.TextBoxTelefon.Size = new System.Drawing.Size(300, 23);
            this.TextBoxTelefon.TabIndex = 2;
            this.TextBoxTelefon.TextChanged += new System.EventHandler(this.TextBoxTelefon_TextChanged);
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Location = new System.Drawing.Point(450, 7);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(200, 23);
            this.TextBoxEmail.TabIndex = 3;
            this.TextBoxEmail.TextChanged += new System.EventHandler(this.TextBoxEmail_TextChanged);
            // 
            // TextBoxVAT
            // 
            this.TextBoxVAT.Location = new System.Drawing.Point(450, 36);
            this.TextBoxVAT.Name = "TextBoxVAT";
            this.TextBoxVAT.Size = new System.Drawing.Size(200, 23);
            this.TextBoxVAT.TabIndex = 4;
            this.TextBoxVAT.TextChanged += new System.EventHandler(this.TextBoxVAT_TextChanged);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Image = global::Gotal_manager.Properties.Resources.cross;
            this.RemoveButton.Location = new System.Drawing.Point(679, 5);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(23, 23);
            this.RemoveButton.TabIndex = 5;
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Location = new System.Drawing.Point(3, 7);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(36, 15);
            this.labelNaziv.TabIndex = 8;
            this.labelNaziv.Text = "Naziv";
            // 
            // labelAdresa
            // 
            this.labelAdresa.AutoSize = true;
            this.labelAdresa.Location = new System.Drawing.Point(3, 38);
            this.labelAdresa.Name = "labelAdresa";
            this.labelAdresa.Size = new System.Drawing.Size(43, 15);
            this.labelAdresa.TabIndex = 9;
            this.labelAdresa.Text = "Adresa";
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Location = new System.Drawing.Point(3, 67);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(45, 15);
            this.labelTelefon.TabIndex = 10;
            this.labelTelefon.Text = "Telefon";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(403, 11);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(41, 15);
            this.labelEmail.TabIndex = 11;
            this.labelEmail.Text = "E-mail";
            // 
            // labelVAT
            // 
            this.labelVAT.AutoSize = true;
            this.labelVAT.Location = new System.Drawing.Point(403, 39);
            this.labelVAT.Name = "labelVAT";
            this.labelVAT.Size = new System.Drawing.Size(26, 15);
            this.labelVAT.TabIndex = 12;
            this.labelVAT.Text = "VAT";
            // 
            // DobavljacUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelVAT);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.labelAdresa);
            this.Controls.Add(this.labelNaziv);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.TextBoxVAT);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.TextBoxTelefon);
            this.Controls.Add(this.TextBoxAdresa);
            this.Controls.Add(this.TextBoxNaziv);
            this.Name = "DobavljacUserControl";
            this.Size = new System.Drawing.Size(707, 93);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TextBoxNaziv;
        private TextBox TextBoxAdresa;
        private TextBox TextBoxTelefon;
        private TextBox TextBoxEmail;
        private TextBox TextBoxVAT;
        private Button RemoveButton;
        private Label labelNaziv;
        private Label labelAdresa;
        private Label labelTelefon;
        private Label labelEmail;
        private Label labelVAT;
    }
}
