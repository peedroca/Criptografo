﻿namespace Criptografo.Desktop.UI
{
    partial class MainForm
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
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CryptTextBox = new System.Windows.Forms.TextBox();
            this.DescryotTextBox = new System.Windows.Forms.TextBox();
            this.CryptButton = new System.Windows.Forms.Button();
            this.DescryptButton = new System.Windows.Forms.Button();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.QuantityCryptLabel = new System.Windows.Forms.Label();
            this.QuantityDescryptLabel = new System.Windows.Forms.Label();
            this.GenerateRSAKeyButton = new System.Windows.Forms.Button();
            this.GenerateAESKeyButton = new System.Windows.Forms.Button();
            this.QuantityKeyLabel = new System.Windows.Forms.Label();
            this.GenerateDESKeyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Location = new System.Drawing.Point(199, 30);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(433, 26);
            this.KeyTextBox.TabIndex = 3;
            this.KeyTextBox.TextChanged += new System.EventHandler(this.KeyTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chave de Criptografia";
            // 
            // CryptTextBox
            // 
            this.CryptTextBox.Location = new System.Drawing.Point(12, 126);
            this.CryptTextBox.MaxLength = 10000;
            this.CryptTextBox.Multiline = true;
            this.CryptTextBox.Name = "CryptTextBox";
            this.CryptTextBox.Size = new System.Drawing.Size(292, 275);
            this.CryptTextBox.TabIndex = 9;
            this.CryptTextBox.TextChanged += new System.EventHandler(this.CryptTextBox_TextChanged);
            // 
            // DescryotTextBox
            // 
            this.DescryotTextBox.Location = new System.Drawing.Point(340, 126);
            this.DescryotTextBox.MaxLength = 30000;
            this.DescryotTextBox.Multiline = true;
            this.DescryotTextBox.Name = "DescryotTextBox";
            this.DescryotTextBox.Size = new System.Drawing.Size(292, 275);
            this.DescryotTextBox.TabIndex = 12;
            this.DescryotTextBox.TextChanged += new System.EventHandler(this.DescryotTextBox_TextChanged);
            // 
            // CryptButton
            // 
            this.CryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CryptButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CryptButton.Location = new System.Drawing.Point(310, 227);
            this.CryptButton.Name = "CryptButton";
            this.CryptButton.Size = new System.Drawing.Size(24, 27);
            this.CryptButton.TabIndex = 10;
            this.CryptButton.Text = ">";
            this.CryptButton.UseVisualStyleBackColor = true;
            this.CryptButton.Click += new System.EventHandler(this.CryptButton_Click);
            // 
            // DescryptButton
            // 
            this.DescryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DescryptButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescryptButton.Location = new System.Drawing.Point(310, 260);
            this.DescryptButton.Name = "DescryptButton";
            this.DescryptButton.Size = new System.Drawing.Size(24, 27);
            this.DescryptButton.TabIndex = 13;
            this.DescryptButton.Text = "<";
            this.DescryptButton.UseVisualStyleBackColor = true;
            this.DescryptButton.Click += new System.EventHandler(this.DescryptButton_Click);
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(12, 30);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(181, 26);
            this.TypeComboBox.TabIndex = 1;
            this.TypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipo de Criptografia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Criptografar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Descriptografar";
            // 
            // QuantityCryptLabel
            // 
            this.QuantityCryptLabel.AutoSize = true;
            this.QuantityCryptLabel.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityCryptLabel.Location = new System.Drawing.Point(9, 404);
            this.QuantityCryptLabel.Name = "QuantityCryptLabel";
            this.QuantityCryptLabel.Size = new System.Drawing.Size(66, 15);
            this.QuantityCryptLabel.TabIndex = 14;
            this.QuantityCryptLabel.Text = "Caractéres: 0";
            // 
            // QuantityDescryptLabel
            // 
            this.QuantityDescryptLabel.AutoSize = true;
            this.QuantityDescryptLabel.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityDescryptLabel.Location = new System.Drawing.Point(337, 404);
            this.QuantityDescryptLabel.Name = "QuantityDescryptLabel";
            this.QuantityDescryptLabel.Size = new System.Drawing.Size(66, 15);
            this.QuantityDescryptLabel.TabIndex = 15;
            this.QuantityDescryptLabel.Text = "Caractéres: 0";
            // 
            // GenerateRSAKeyButton
            // 
            this.GenerateRSAKeyButton.Location = new System.Drawing.Point(12, 62);
            this.GenerateRSAKeyButton.Name = "GenerateRSAKeyButton";
            this.GenerateRSAKeyButton.Size = new System.Drawing.Size(181, 35);
            this.GenerateRSAKeyButton.TabIndex = 5;
            this.GenerateRSAKeyButton.Text = "Gerar Chaves RSA";
            this.GenerateRSAKeyButton.UseVisualStyleBackColor = true;
            this.GenerateRSAKeyButton.Click += new System.EventHandler(this.GenerateRSAKeyButton_Click);
            // 
            // GenerateAESKeyButton
            // 
            this.GenerateAESKeyButton.Location = new System.Drawing.Point(199, 62);
            this.GenerateAESKeyButton.Name = "GenerateAESKeyButton";
            this.GenerateAESKeyButton.Size = new System.Drawing.Size(168, 35);
            this.GenerateAESKeyButton.TabIndex = 6;
            this.GenerateAESKeyButton.Text = "Gerar Chave AES";
            this.GenerateAESKeyButton.UseVisualStyleBackColor = true;
            this.GenerateAESKeyButton.Click += new System.EventHandler(this.GenerateAESKeyButton_Click);
            // 
            // QuantityKeyLabel
            // 
            this.QuantityKeyLabel.AutoSize = true;
            this.QuantityKeyLabel.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityKeyLabel.Location = new System.Drawing.Point(566, 12);
            this.QuantityKeyLabel.Name = "QuantityKeyLabel";
            this.QuantityKeyLabel.Size = new System.Drawing.Size(66, 15);
            this.QuantityKeyLabel.TabIndex = 4;
            this.QuantityKeyLabel.Text = "Caractéres: 0";
            // 
            // GenerateDESKeyButton
            // 
            this.GenerateDESKeyButton.Location = new System.Drawing.Point(373, 62);
            this.GenerateDESKeyButton.Name = "GenerateDESKeyButton";
            this.GenerateDESKeyButton.Size = new System.Drawing.Size(174, 35);
            this.GenerateDESKeyButton.TabIndex = 7;
            this.GenerateDESKeyButton.Text = "Gerar Chave DES";
            this.GenerateDESKeyButton.UseVisualStyleBackColor = true;
            this.GenerateDESKeyButton.Click += new System.EventHandler(this.GenerateDESKeyButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 427);
            this.Controls.Add(this.GenerateDESKeyButton);
            this.Controls.Add(this.QuantityKeyLabel);
            this.Controls.Add(this.GenerateAESKeyButton);
            this.Controls.Add(this.GenerateRSAKeyButton);
            this.Controls.Add(this.QuantityDescryptLabel);
            this.Controls.Add(this.QuantityCryptLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.DescryptButton);
            this.Controls.Add(this.CryptButton);
            this.Controls.Add(this.DescryotTextBox);
            this.Controls.Add(this.CryptTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KeyTextBox);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criptografo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CryptTextBox;
        private System.Windows.Forms.TextBox DescryotTextBox;
        private System.Windows.Forms.Button CryptButton;
        private System.Windows.Forms.Button DescryptButton;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label QuantityCryptLabel;
        private System.Windows.Forms.Label QuantityDescryptLabel;
        private System.Windows.Forms.Button GenerateRSAKeyButton;
        private System.Windows.Forms.Button GenerateAESKeyButton;
        private System.Windows.Forms.Label QuantityKeyLabel;
        private System.Windows.Forms.Button GenerateDESKeyButton;
    }
}