﻿namespace MegaDesk
{
    partial class AddQuote
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
            this.cancelQuoteButton = new System.Windows.Forms.Button();
            this.getQuoteButton = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.shippingNumDaysSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deskWidthLabel = new System.Windows.Forms.Label();
            this.numDrawersLabel = new System.Windows.Forms.Label();
            this.deskDepthLabel = new System.Windows.Forms.Label();
            this.shippingSpeedLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.surfaceMaterialSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.shippingPriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelQuoteButton
            // 
            this.cancelQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelQuoteButton.Location = new System.Drawing.Point(16, 294);
            this.cancelQuoteButton.Name = "cancelQuoteButton";
            this.cancelQuoteButton.Size = new System.Drawing.Size(115, 40);
            this.cancelQuoteButton.TabIndex = 8;
            this.cancelQuoteButton.Text = "Cancel";
            this.cancelQuoteButton.UseVisualStyleBackColor = true;
            this.cancelQuoteButton.Click += new System.EventHandler(this.cancelQuoteButton_Click);
            // 
            // getQuoteButton
            // 
            this.getQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getQuoteButton.Location = new System.Drawing.Point(172, 294);
            this.getQuoteButton.Name = "getQuoteButton";
            this.getQuoteButton.Size = new System.Drawing.Size(115, 40);
            this.getQuoteButton.TabIndex = 7;
            this.getQuoteButton.Text = "Get Quote";
            this.getQuoteButton.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(174, 51);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(113, 26);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(69, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 26);
            this.textBox1.TabIndex = 1;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(174, 83);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(113, 26);
            this.numericUpDown2.TabIndex = 3;
            this.numericUpDown2.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown3.Location = new System.Drawing.Point(174, 115);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(113, 26);
            this.numericUpDown3.TabIndex = 4;
            // 
            // shippingNumDaysSelectionComboBox
            // 
            this.shippingNumDaysSelectionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shippingNumDaysSelectionComboBox.FormattingEnabled = true;
            this.shippingNumDaysSelectionComboBox.Items.AddRange(new object[] {
            "3 days",
            "5 days",
            "7 days",
            "14 days"});
            this.shippingNumDaysSelectionComboBox.Location = new System.Drawing.Point(174, 181);
            this.shippingNumDaysSelectionComboBox.Name = "shippingNumDaysSelectionComboBox";
            this.shippingNumDaysSelectionComboBox.Size = new System.Drawing.Size(113, 28);
            this.shippingNumDaysSelectionComboBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // deskWidthLabel
            // 
            this.deskWidthLabel.AutoSize = true;
            this.deskWidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskWidthLabel.Location = new System.Drawing.Point(12, 53);
            this.deskWidthLabel.Name = "deskWidthLabel";
            this.deskWidthLabel.Size = new System.Drawing.Size(110, 20);
            this.deskWidthLabel.TabIndex = 12;
            this.deskWidthLabel.Text = "Width (inches)";
            // 
            // numDrawersLabel
            // 
            this.numDrawersLabel.AutoSize = true;
            this.numDrawersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDrawersLabel.Location = new System.Drawing.Point(12, 117);
            this.numDrawersLabel.Name = "numDrawersLabel";
            this.numDrawersLabel.Size = new System.Drawing.Size(146, 20);
            this.numDrawersLabel.TabIndex = 14;
            this.numDrawersLabel.Text = "Number of Drawers";
            // 
            // deskDepthLabel
            // 
            this.deskDepthLabel.AutoSize = true;
            this.deskDepthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskDepthLabel.Location = new System.Drawing.Point(12, 85);
            this.deskDepthLabel.Name = "deskDepthLabel";
            this.deskDepthLabel.Size = new System.Drawing.Size(113, 20);
            this.deskDepthLabel.TabIndex = 13;
            this.deskDepthLabel.Text = "Depth (inches)";
            // 
            // shippingSpeedLabel
            // 
            this.shippingSpeedLabel.AutoSize = true;
            this.shippingSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shippingSpeedLabel.Location = new System.Drawing.Point(12, 184);
            this.shippingSpeedLabel.Name = "shippingSpeedLabel";
            this.shippingSpeedLabel.Size = new System.Drawing.Size(122, 20);
            this.shippingSpeedLabel.TabIndex = 18;
            this.shippingSpeedLabel.Text = "Shipping Speed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Surface Material";
            // 
            // surfaceMaterialSelectionComboBox
            // 
            this.surfaceMaterialSelectionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfaceMaterialSelectionComboBox.FormattingEnabled = true;
            this.surfaceMaterialSelectionComboBox.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.surfaceMaterialSelectionComboBox.Location = new System.Drawing.Point(174, 147);
            this.surfaceMaterialSelectionComboBox.Name = "surfaceMaterialSelectionComboBox";
            this.surfaceMaterialSelectionComboBox.Size = new System.Drawing.Size(113, 28);
            this.surfaceMaterialSelectionComboBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 26);
            this.label2.TabIndex = 21;
            this.label2.Text = "Total Price";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.Location = new System.Drawing.Point(197, 252);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(90, 26);
            this.totalPriceLabel.TabIndex = 22;
            this.totalPriceLabel.Text = "$200.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Shipping Price";
            // 
            // shippingPriceLabel
            // 
            this.shippingPriceLabel.AutoSize = true;
            this.shippingPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shippingPriceLabel.Location = new System.Drawing.Point(238, 212);
            this.shippingPriceLabel.Name = "shippingPriceLabel";
            this.shippingPriceLabel.Size = new System.Drawing.Size(49, 20);
            this.shippingPriceLabel.TabIndex = 24;
            this.shippingPriceLabel.Text = "$0.00";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 346);
            this.Controls.Add(this.shippingPriceLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.surfaceMaterialSelectionComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.shippingSpeedLabel);
            this.Controls.Add(this.numDrawersLabel);
            this.Controls.Add(this.deskDepthLabel);
            this.Controls.Add(this.deskWidthLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shippingNumDaysSelectionComboBox);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.getQuoteButton);
            this.Controls.Add(this.cancelQuoteButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(315, 385);
            this.MinimumSize = new System.Drawing.Size(315, 385);
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Quote";
            this.Deactivate += new System.EventHandler(this.cancelQuoteButton_Click);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelQuoteButton;
        private System.Windows.Forms.Button getQuoteButton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.ComboBox shippingNumDaysSelectionComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label deskWidthLabel;
        private System.Windows.Forms.Label numDrawersLabel;
        private System.Windows.Forms.Label deskDepthLabel;
        private System.Windows.Forms.Label shippingSpeedLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox surfaceMaterialSelectionComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label shippingPriceLabel;
    }
}