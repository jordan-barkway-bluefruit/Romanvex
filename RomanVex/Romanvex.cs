using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RomanVex
{
    public partial class Romanvex : Form
    {
        private object userName;
        private int radixNumber;
        
        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("dd/MM/yyyy HH:mm:ss");
        }

        public Romanvex()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void userNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            userName = userNameField.Text;
            Int32.TryParse( base10NumberField.Text, out radixNumber);
            
            string romanNumeral = ArabicToRomanConverter.Convert(radixNumber);
            romanNumeralOutputTextBox.Text = romanNumeral;
            string timeStamp = GetTimestamp(DateTime.UtcNow);

            var saveResult = MessageBox.Show("Would you like to save your result?", "Save", MessageBoxButtons.YesNo);
            if (saveResult == DialogResult.Yes)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = "RomanConversion";
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                saveFileDialog.OverwritePrompt = false;
                saveFileDialog.ShowDialog();
                string fullFilePath = saveFileDialog.FileName;

                string resultInformation = $"Username:{userNameField.Text}, Base 10 Number:{base10NumberField.Text}, Roman Numeral:{romanNumeral}, Timestamp:{timeStamp}{Environment.NewLine}";
                System.IO.File.AppendAllText(fullFilePath, resultInformation);

            }
        }

        private void romanNumeralOutputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
        }

        private void Romanvex_Load(object sender, EventArgs e)
        {

        }
    }
}
