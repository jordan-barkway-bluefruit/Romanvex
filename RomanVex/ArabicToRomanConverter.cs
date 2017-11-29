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
            int arabicNumeralOriginal = arabicNumeral;
            string romanNumeral = "";

            if (arabicNumeral > 4)
            {
                romanNumeral += "V";
                arabicNumeral -= 5;
            }

            if (arabicNumeral == 4)
            {
                romanNumeral += "IV";
            }
            else
            {
                for (int i = 0; i < arabicNumeral; i++)
                {
                    romanNumeral += "I";
                }
            }
            return romanNumeral;
        }
    }
}
