using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanVex
{
    public class ArabicToRomanConverter
    {
        public static string Convert(int arabicNumeral)
        {
            string romanNumeral = "";

            for ( int i = 0; i < arabicNumeral; i++)
            {
                romanNumeral += "I";
            }
            return romanNumeral;
        }
    }
}
