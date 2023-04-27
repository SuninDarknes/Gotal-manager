namespace Gotal_manager
{
    partial class PrimkaForm
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
            this.labelDobavljac = new System.Windows.Forms.Label();
            this.textBoxDobavljac = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // labelDobavljac
            // 
            this.labelDobavljac.AutoSize = true;
            this.labelDobavljac.Location = new System.Drawing.Point(12, 15);
            this.labelDobavljac.Name = "labelDobavljac";
            this.labelDobavljac.Size = new System.Drawing.Size(59, 15);
            this.labelDobavljac.TabIndex = 0;
            this.labelDobavljac.Text = "Dobavljač";
            // 
            // textBoxDobavljac
            // 
            this.textBoxDobavljac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxDobavljac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxDobavljac.Location = new System.Drawing.Point(77, 12);
            this.textBoxDobavljac.Name = "textBoxDobavljac";
            this.textBoxDobavljac.Size = new System.Drawing.Size(300, 23);
            this.textBoxDobavljac.TabIndex = 1;
            this.textBoxDobavljac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDobavljac_KeyPress);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(77, 41);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(300, 100);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // PrimkaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.textBoxDobavljac);
            this.Controls.Add(this.labelDobavljac);
            this.Name = "PrimkaForm";
            this.Text = "PrimkaForm";
            this.Load += new System.EventHandler(this.PrimkaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelDobavljac;
        private TextBox textBoxDobavljac;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}