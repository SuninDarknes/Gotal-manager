﻿namespace Gotal_manager
{
    partial class ProductsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DobitLock = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelRoba = new System.Windows.Forms.Label();
            this.IzlazLock = new System.Windows.Forms.RadioButton();
            this.ProfitLock = new System.Windows.Forms.RadioButton();
            this.SmallErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 395);
            this.panel1.TabIndex = 1;
            // 
            // DobitLock
            // 
            this.DobitLock.AutoSize = true;
            this.DobitLock.Location = new System.Drawing.Point(508, 6);
            this.DobitLock.Name = "DobitLock";
            this.DobitLock.Size = new System.Drawing.Size(14, 13);
            this.DobitLock.TabIndex = 2;
            this.DobitLock.UseVisualStyleBackColor = true;
            this.DobitLock.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(692, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Zarada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prodajna cijena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(457, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dobit %";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ulazna cijena";
            // 
            // LabelRoba
            // 
            this.LabelRoba.AutoSize = true;
            this.LabelRoba.Location = new System.Drawing.Point(12, 9);
            this.LabelRoba.Name = "LabelRoba";
            this.LabelRoba.Size = new System.Drawing.Size(34, 15);
            this.LabelRoba.TabIndex = 1;
            this.LabelRoba.Text = "Roba";
            // 
            // IzlazLock
            // 
            this.IzlazLock.AutoSize = true;
            this.IzlazLock.Checked = true;
            this.IzlazLock.Location = new System.Drawing.Point(633, 7);
            this.IzlazLock.Name = "IzlazLock";
            this.IzlazLock.Size = new System.Drawing.Size(14, 13);
            this.IzlazLock.TabIndex = 3;
            this.IzlazLock.TabStop = true;
            this.IzlazLock.UseVisualStyleBackColor = true;
            this.IzlazLock.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // ProfitLock
            // 
            this.ProfitLock.AutoSize = true;
            this.ProfitLock.Location = new System.Drawing.Point(737, 7);
            this.ProfitLock.Name = "ProfitLock";
            this.ProfitLock.Size = new System.Drawing.Size(14, 13);
            this.ProfitLock.TabIndex = 6;
            this.ProfitLock.UseVisualStyleBackColor = true;
            this.ProfitLock.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // SmallErrorLabel
            // 
            this.SmallErrorLabel.AutoSize = true;
            this.SmallErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.SmallErrorLabel.Location = new System.Drawing.Point(12, 430);
            this.SmallErrorLabel.Name = "SmallErrorLabel";
            this.SmallErrorLabel.Size = new System.Drawing.Size(61, 15);
            this.SmallErrorLabel.TabIndex = 7;
            this.SmallErrorLabel.Text = "Initializing";
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 450);
            this.Controls.Add(this.SmallErrorLabel);
            this.Controls.Add(this.ProfitLock);
            this.Controls.Add(this.DobitLock);
            this.Controls.Add(this.IzlazLock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabelRoba);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProductsForm";
            this.Text = "ProductsForm";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel1;
        private Label LabelRoba;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private RadioButton DobitLock;
        private RadioButton IzlazLock;
        private RadioButton ProfitLock;
        private Label SmallErrorLabel;
    }
}