namespace Gotal_manager
{
    partial class ProductUserControl
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
            this.TextBoxUlazna = new System.Windows.Forms.TextBox();
            this.TextBoxDobit = new System.Windows.Forms.TextBox();
            this.TextBoxIzlazna = new System.Windows.Forms.TextBox();
            this.TextBoxProfit = new System.Windows.Forms.TextBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.TextBoxProductNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextBoxNaziv
            // 
            this.TextBoxNaziv.Location = new System.Drawing.Point(62, 4);
            this.TextBoxNaziv.Name = "TextBoxNaziv";
            this.TextBoxNaziv.Size = new System.Drawing.Size(300, 23);
            this.TextBoxNaziv.TabIndex = 0;
            this.TextBoxNaziv.TextChanged += new System.EventHandler(this.TextBoxNaziv_TextChanged);
            this.TextBoxNaziv.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // TextBoxUlazna
            // 
            this.TextBoxUlazna.Location = new System.Drawing.Point(368, 4);
            this.TextBoxUlazna.Name = "TextBoxUlazna";
            this.TextBoxUlazna.Size = new System.Drawing.Size(125, 23);
            this.TextBoxUlazna.TabIndex = 1;
            this.TextBoxUlazna.TextChanged += new System.EventHandler(this.TextBoxUlazna_TextChanged);
            // 
            // TextBoxDobit
            // 
            this.TextBoxDobit.Location = new System.Drawing.Point(499, 4);
            this.TextBoxDobit.Name = "TextBoxDobit";
            this.TextBoxDobit.Size = new System.Drawing.Size(75, 23);
            this.TextBoxDobit.TabIndex = 2;
            this.TextBoxDobit.TextChanged += new System.EventHandler(this.TextBoxDobit_TextChanged);
            // 
            // TextBoxIzlazna
            // 
            this.TextBoxIzlazna.Location = new System.Drawing.Point(580, 4);
            this.TextBoxIzlazna.Name = "TextBoxIzlazna";
            this.TextBoxIzlazna.Size = new System.Drawing.Size(125, 23);
            this.TextBoxIzlazna.TabIndex = 3;
            this.TextBoxIzlazna.TextChanged += new System.EventHandler(this.TextBoxIzlazna_TextChanged);
            // 
            // TextBoxProfit
            // 
            this.TextBoxProfit.Location = new System.Drawing.Point(711, 4);
            this.TextBoxProfit.Name = "TextBoxProfit";
            this.TextBoxProfit.Size = new System.Drawing.Size(125, 23);
            this.TextBoxProfit.TabIndex = 4;
            this.TextBoxProfit.TextChanged += new System.EventHandler(this.TextBoxProfit_TextChanged);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Image = global::Gotal_manager.Properties.Resources.cross;
            this.RemoveButton.Location = new System.Drawing.Point(842, 3);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(23, 23);
            this.RemoveButton.TabIndex = 5;
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // TextBoxProductNumber
            // 
            this.TextBoxProductNumber.Location = new System.Drawing.Point(3, 4);
            this.TextBoxProductNumber.Name = "TextBoxProductNumber";
            this.TextBoxProductNumber.Size = new System.Drawing.Size(53, 23);
            this.TextBoxProductNumber.TabIndex = 6;
            this.TextBoxProductNumber.TextChanged += new System.EventHandler(this.TextBoxProductNumber_TextChanged);
            // 
            // ProductUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.TextBoxProductNumber);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.TextBoxProfit);
            this.Controls.Add(this.TextBoxIzlazna);
            this.Controls.Add(this.TextBoxDobit);
            this.Controls.Add(this.TextBoxUlazna);
            this.Controls.Add(this.TextBoxNaziv);
            this.Name = "ProductUserControl";
            this.Size = new System.Drawing.Size(868, 29);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TextBoxNaziv;
        private TextBox TextBoxUlazna;
        private TextBox TextBoxDobit;
        private TextBox TextBoxIzlazna;
        private TextBox TextBoxProfit;
        private Button RemoveButton;
        private TextBox TextBoxProductNumber;
    }
}
