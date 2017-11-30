namespace RomanVex
{
    partial class Romanvex
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
            this.guidanceLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userNameField = new System.Windows.Forms.TextBox();
            this.radixNumeralLabel = new System.Windows.Forms.Label();
            this.base10NumberField = new System.Windows.Forms.TextBox();
            this.romanNumeralOutputTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // guidanceLabel
            // 
            this.guidanceLabel.AutoSize = true;
            this.guidanceLabel.Location = new System.Drawing.Point(13, 13);
            this.guidanceLabel.Name = "guidanceLabel";
            this.guidanceLabel.Size = new System.Drawing.Size(231, 13);
            this.guidanceLabel.TabIndex = 0;
            this.guidanceLabel.Text = "Convert Base 10 Numbers To Roman Numerals";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(13, 49);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(60, 13);
            this.userNameLabel.TabIndex = 3;
            this.userNameLabel.Text = "User Name";
            this.userNameLabel.Click += new System.EventHandler(this.userNameLabel_Click);
            // 
            // userNameField
            // 
            this.userNameField.Location = new System.Drawing.Point(126, 49);
            this.userNameField.Name = "userNameField";
            this.userNameField.Size = new System.Drawing.Size(100, 20);
            this.userNameField.TabIndex = 2;
            // 
            // radixNumeralLabel
            // 
            this.radixNumeralLabel.AutoSize = true;
            this.radixNumeralLabel.Location = new System.Drawing.Point(13, 83);
            this.radixNumeralLabel.Name = "radixNumeralLabel";
            this.radixNumeralLabel.Size = new System.Drawing.Size(86, 13);
            this.radixNumeralLabel.TabIndex = 3;
            this.radixNumeralLabel.Text = "Base 10 Number";
            this.radixNumeralLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // radixNumberField
            // 
            this.base10NumberField.Location = new System.Drawing.Point(126, 80);
            this.base10NumberField.Name = "radixNumberField";
            this.base10NumberField.Size = new System.Drawing.Size(100, 20);
            this.base10NumberField.TabIndex = 4;
            this.base10NumberField.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // romanNumeralOutputTextBox
            // 
            this.romanNumeralOutputTextBox.Location = new System.Drawing.Point(126, 113);
            this.romanNumeralOutputTextBox.Name = "romanNumeralOutputTextBox";
            this.romanNumeralOutputTextBox.ReadOnly = true;
            this.romanNumeralOutputTextBox.Size = new System.Drawing.Size(100, 20);
            this.romanNumeralOutputTextBox.TabIndex = 6;
            this.romanNumeralOutputTextBox.TextChanged += new System.EventHandler(this.romanNumeralOutputTextBox_TextChanged);
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(16, 113);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 8;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // Romanvex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 211);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.romanNumeralOutputTextBox);
            this.Controls.Add(this.base10NumberField);
            this.Controls.Add(this.radixNumeralLabel);
            this.Controls.Add(this.userNameField);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.guidanceLabel);
            this.Name = "Romanvex";
            this.Text = "RomanVex";
            this.Load += new System.EventHandler(this.Romanvex_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label guidanceLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox userNameField;
        private System.Windows.Forms.Label radixNumeralLabel;
        private System.Windows.Forms.TextBox base10NumberField;
        private System.Windows.Forms.TextBox romanNumeralOutputTextBox;
        private System.Windows.Forms.Button convertButton;
    }
}

