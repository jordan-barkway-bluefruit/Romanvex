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

            if (arabicNumeral >= 5000)
            {
                romanNumeral += "v";
                arabicNumeral -= 5000;
            }

            while(arabicNumeral >= 1000)
            {
                romanNumeral += "M";
                arabicNumeral -= 1000;
            }

            if (arabicNumeral >= 900)
            {
                romanNumeral += "CM";
                arabicNumeral -= 900;
            }

            if (arabicNumeral >= 500)
            {
                romanNumeral += "D";
                arabicNumeral -= 500;
            }

            if (arabicNumeral >= 400)
            {
                romanNumeral += "CD";
                arabicNumeral -= 400;
            }

            while (arabicNumeral >= 100)
            {
                romanNumeral += "C";
                arabicNumeral -= 100;
            }

            if (arabicNumeral >= 90)
            {
                romanNumeral += "XC";
                arabicNumeral -= 90;
            }

            if (arabicNumeral >= 50)
            {
                romanNumeral += "L";
                arabicNumeral -= 50;
            }

            if (arabicNumeral >= 40)
            {
                romanNumeral += "XL";
                arabicNumeral -= 40;
            }

            while (arabicNumeral >= 10)
            {
                romanNumeral += "X";
                arabicNumeral -= 10;
            }

            if (arabicNumeral == 9)
            {
                romanNumeral += "IX";
                arabicNumeral -= 9;
            }

            if (arabicNumeral > 4)
            {
                romanNumeral += "V";
                arabicNumeral -= 5;
            }
            
            if (arabicNumeral == 4)
            {
                romanNumeral += "IV";
                arabicNumeral -= 4;
            }
            
            while (arabicNumeral >= 1)
            {
                romanNumeral += "I";
                arabicNumeral -= 1;
            }            
            return romanNumeral;
        }
    }
}
