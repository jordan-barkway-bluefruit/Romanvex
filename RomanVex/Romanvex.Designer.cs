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
            this.label1 = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userNameField = new System.Windows.Forms.TextBox();
            this.radixNumeralLabel = new System.Windows.Forms.Label();
            this.radixNumberField = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.convertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Convert Base 10 Numbers To Roman Numerals";
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
            this.radixNumberField.Location = new System.Drawing.Point(126, 80);
            this.radixNumberField.Name = "radixNumberField";
            this.radixNumberField.Size = new System.Drawing.Size(100, 20);
            this.radixNumberField.TabIndex = 4;
            this.radixNumberField.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(126, 113);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(16, 155);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.radixNumberField);
            this.Controls.Add(this.radixNumeralLabel);
            this.Controls.Add(this.userNameField);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.label1);
            this.Name = "Romanvex";
            this.Text = "RomanVex";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox userNameField;
        private System.Windows.Forms.Label radixNumeralLabel;
        private System.Windows.Forms.TextBox radixNumberField;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button convertButton;
    }
}

