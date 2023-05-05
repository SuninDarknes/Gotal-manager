namespace Gotal_manager
{
    partial class StorageForm
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
            this.MainFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SmallErrorLabel = new System.Windows.Forms.Label();
            this.buttonPrimka = new System.Windows.Forms.Button();
            this.buttonIzdatnica = new System.Windows.Forms.Button();
            this.labelPorez = new System.Windows.Forms.Label();
            this.labelPopust = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MainFlowPanel
            // 
            this.MainFlowPanel.AutoScroll = true;
            this.MainFlowPanel.Location = new System.Drawing.Point(12, 52);
            this.MainFlowPanel.Name = "MainFlowPanel";
            this.MainFlowPanel.Size = new System.Drawing.Size(1221, 369);
            this.MainFlowPanel.TabIndex = 0;
            // 
            // SmallErrorLabel
            // 
            this.SmallErrorLabel.AutoSize = true;
            this.SmallErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.SmallErrorLabel.Location = new System.Drawing.Point(15, 426);
            this.SmallErrorLabel.Name = "SmallErrorLabel";
            this.SmallErrorLabel.Size = new System.Drawing.Size(70, 15);
            this.SmallErrorLabel.TabIndex = 21;
            this.SmallErrorLabel.Text = "Initializing...";
            // 
            // buttonPrimka
            // 
            this.buttonPrimka.Location = new System.Drawing.Point(1239, 52);
            this.buttonPrimka.Name = "buttonPrimka";
            this.buttonPrimka.Size = new System.Drawing.Size(75, 23);
            this.buttonPrimka.TabIndex = 22;
            this.buttonPrimka.Text = "Primka";
            this.buttonPrimka.UseVisualStyleBackColor = true;
            this.buttonPrimka.Click += new System.EventHandler(this.buttonPrimka_Click);
            // 
            // buttonIzdatnica
            // 
            this.buttonIzdatnica.Location = new System.Drawing.Point(1239, 81);
            this.buttonIzdatnica.Name = "buttonIzdatnica";
            this.buttonIzdatnica.Size = new System.Drawing.Size(75, 23);
            this.buttonIzdatnica.TabIndex = 23;
            this.buttonIzdatnica.Text = "Izdatnica";
            this.buttonIzdatnica.UseVisualStyleBackColor = true;
            this.buttonIzdatnica.Click += new System.EventHandler(this.buttonIzdatnica_Click);
            // 
            // labelPorez
            // 
            this.labelPorez.AutoSize = true;
            this.labelPorez.Location = new System.Drawing.Point(515, 34);
            this.labelPorez.Name = "labelPorez";
            this.labelPorez.Size = new System.Drawing.Size(29, 15);
            this.labelPorez.TabIndex = 35;
            this.labelPorez.Text = "PDV";
            // 
            // labelPopust
            // 
            this.labelPopust.AutoSize = true;
            this.labelPopust.Location = new System.Drawing.Point(465, 34);
            this.labelPopust.Name = "labelPopust";
            this.labelPopust.Size = new System.Drawing.Size(44, 15);
            this.labelPopust.TabIndex = 34;
            this.labelPopust.Text = "Popust";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1065, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 33;
            this.label1.Text = "Stanje(€)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(965, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "Stanje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(865, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "Razduženo(€)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(765, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 30;
            this.label4.Text = "Razduženo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(665, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "Sveukupno(€)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(565, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "Komad(€)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(415, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "Komada";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(115, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 15);
            this.label8.TabIndex = 26;
            this.label8.Text = "Naziv";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 15);
            this.label9.TabIndex = 25;
            this.label9.Text = "Broj";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 15);
            this.label10.TabIndex = 24;
            this.label10.Text = "ID";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(115, 8);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 23);
            this.textBoxSearch.TabIndex = 36;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // StorageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 450);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelPorez);
            this.Controls.Add(this.labelPopust);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonIzdatnica);
            this.Controls.Add(this.buttonPrimka);
            this.Controls.Add(this.SmallErrorLabel);
            this.Controls.Add(this.MainFlowPanel);
            this.Name = "StorageForm";
            this.Text = "StorageForm";
            this.Load += new System.EventHandler(this.StorageForm_Load);
            this.SizeChanged += new System.EventHandler(this.StorageForm_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel MainFlowPanel;
        private Label SmallErrorLabel;
        private Button buttonPrimka;
        private Button buttonIzdatnica;
        private Label labelPorez;
        private Label labelPopust;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textBoxSearch;
    }
}