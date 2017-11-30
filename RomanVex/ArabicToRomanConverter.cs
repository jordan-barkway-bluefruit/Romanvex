using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanVex
{
    public class ArabicToRomanConverter
    {
        private struct Numerals
        {
            public Numerals(int arabic, string roman)
            {
                Arabic = arabic;
                Roman = roman;
            }
            int Arabic;
            string Roman;
        }

        private static readonly Numerals[] NumeralsArray = {
            new Numerals( 1, "I" ),
            new Numerals(4, "IV")
        };
        private static readonly int[] arabicNumeralList = { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000, 4000, 5000, 9000, 10000, 40000, 50000, 90000 };
        private static readonly string[] romanNumeralList = { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M", "Mv", "v", "Mx", "x", "xl", "l", "xc" };

        public static string Convert(int arabicNumeral)
        {
            int arabicNumeralOriginal = arabicNumeral;
            string romanNumeral = "";

            foreach (var numeral in NumeralsArray.Reverse())
            {

            }

            for (int i = 1; i <= arabicNumeralList.Length; i++)
            {
                while (arabicNumeral >= arabicNumeralList[arabicNumeralList.Length - i])
                {
                    romanNumeral += romanNumeralList[romanNumeralList.Length - i];
                    arabicNumeral -= arabicNumeralList[arabicNumeralList.Length - i];
                }
            }
            return romanNumeral;
        }
    }
}
