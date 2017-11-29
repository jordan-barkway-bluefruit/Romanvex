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
            Int32.TryParse( radixNumberField.Text, out radixNumber);
            
            string romanNumeral = ArabicToRomanConverter.Convert(radixNumber);
            
        }
    }
}
