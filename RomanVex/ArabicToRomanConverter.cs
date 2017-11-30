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
            public int Arabic;
            public string Roman;
        }

        private static readonly Numerals[] NumeralsArray = {
            new Numerals(1, "I"),
            new Numerals(4, "IV"),
            new Numerals(5, "V"),
            new Numerals(9, "IX"),
            new Numerals(10, "X"),
            new Numerals(40, "XL"),
            new Numerals(50, "L"),
            new Numerals(90, "XC"),
            new Numerals(100, "C"),
            new Numerals(400, "CD"),
            new Numerals(500, "D"),
            new Numerals(900, "CM"),
            new Numerals(1000, "M"),
            new Numerals(4000, "Mv"),
            new Numerals(5000, "v"),
            new Numerals(9000, "Mx"),
            new Numerals(10000, "x"),
            new Numerals(40000, "xl"),
            new Numerals(50000, "l"),
            new Numerals(90000, "xc"),
            new Numerals(100000, "c"),
            new Numerals(400000, "cd"),
            new Numerals(500000, "d")
        };

        public static string Convert(int arabicNumeral)
        {
            int arabicNumeralOriginal = arabicNumeral;
            string romanNumeral = "";

            foreach (var numeral in NumeralsArray.Reverse())
            {
                while (arabicNumeral >= numeral.Arabic)
                {
                    romanNumeral += numeral.Roman;
                    arabicNumeral -= numeral.Arabic;
                }
            }
            return romanNumeral; 
        }
    }
}
