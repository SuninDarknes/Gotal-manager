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
            this.SuspendLayout();
            // 
            // TextBoxNaziv
            // 
            this.TextBoxNaziv.Location = new System.Drawing.Point(3, 3);
            this.TextBoxNaziv.Name = "TextBoxNaziv";
            this.TextBoxNaziv.Size = new System.Drawing.Size(300, 23);
            this.TextBoxNaziv.TabIndex = 0;
            // 
            // TextBoxUlazna
            // 
            this.TextBoxUlazna.Location = new System.Drawing.Point(309, 3);
            this.TextBoxUlazna.Name = "TextBoxUlazna";
            this.TextBoxUlazna.Size = new System.Drawing.Size(125, 23);
            this.TextBoxUlazna.TabIndex = 1;
            this.TextBoxUlazna.TextChanged += new System.EventHandler(this.TextBoxUlazna_TextChanged);
            // 
            // TextBoxDobit
            // 
            this.TextBoxDobit.Location = new System.Drawing.Point(440, 3);
            this.TextBoxDobit.Name = "TextBoxDobit";
            this.TextBoxDobit.Size = new System.Drawing.Size(75, 23);
            this.TextBoxDobit.TabIndex = 2;
            this.TextBoxDobit.TextChanged += new System.EventHandler(this.TextBoxDobit_TextChanged);
            // 
            // TextBoxIzlazna
            // 
            this.TextBoxIzlazna.Location = new System.Drawing.Point(521, 3);
            this.TextBoxIzlazna.Name = "TextBoxIzlazna";
            this.TextBoxIzlazna.Size = new System.Drawing.Size(125, 23);
            this.TextBoxIzlazna.TabIndex = 3;
            this.TextBoxIzlazna.TextChanged += new System.EventHandler(this.TextBoxIzlazna_TextChanged);
            // 
            // TextBoxProfit
            // 
            this.TextBoxProfit.Location = new System.Drawing.Point(652, 3);
            this.TextBoxProfit.Name = "TextBoxProfit";
            this.TextBoxProfit.Size = new System.Drawing.Size(125, 23);
            this.TextBoxProfit.TabIndex = 4;
            this.TextBoxProfit.TextChanged += new System.EventHandler(this.TextBoxProfit_TextChanged);
            // 
            // ProductUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextBoxProfit);
            this.Controls.Add(this.TextBoxIzlazna);
            this.Controls.Add(this.TextBoxDobit);
            this.Controls.Add(this.TextBoxUlazna);
            this.Controls.Add(this.TextBoxNaziv);
            this.Name = "ProductUserControl";
            this.Size = new System.Drawing.Size(780, 29);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TextBoxNaziv;
        private TextBox TextBoxUlazna;
        private TextBox TextBoxDobit;
        private TextBox TextBoxIzlazna;
        private TextBox TextBoxProfit;
    }
}
