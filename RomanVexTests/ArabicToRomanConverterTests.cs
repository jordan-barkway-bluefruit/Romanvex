using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanVex;

namespace RomanVexTests
{
    [TestClass]
    public class ArabicToRomanConverterTests
    {
        [TestMethod]
        public void When_The_Arabic_Numeral_Is_A_Key_Number_Then_The_Roman_Numeral_Is_Key_To_The_Number()
        {
            Assert.AreEqual("I", ArabicToRomanConverter.Convert(1));
            Assert.AreEqual("IV", ArabicToRomanConverter.Convert(4));
            Assert.AreEqual("V", ArabicToRomanConverter.Convert(5));
            Assert.AreEqual("IX", ArabicToRomanConverter.Convert(9));
            Assert.AreEqual("X", ArabicToRomanConverter.Convert(10));
            Assert.AreEqual("XL", ArabicToRomanConverter.Convert(40));
            Assert.AreEqual("XC", ArabicToRomanConverter.Convert(90));
            Assert.AreEqual("CD", ArabicToRomanConverter.Convert(400));
            Assert.AreEqual("CM", ArabicToRomanConverter.Convert(900));
            Assert.AreEqual("v", ArabicToRomanConverter.Convert(5000));
            Assert.AreEqual("Mx", ArabicToRomanConverter.Convert(9000));
            Assert.AreEqual("x", ArabicToRomanConverter.Convert(10000));
            Assert.AreEqual("xl", ArabicToRomanConverter.Convert(40000));
            Assert.AreEqual("l", ArabicToRomanConverter.Convert(50000));
            Assert.AreEqual("xc", ArabicToRomanConverter.Convert(90000));
            Assert.AreEqual("c", ArabicToRomanConverter.Convert(100000));
            Assert.AreEqual("cd", ArabicToRomanConverter.Convert(400000));
            Assert.AreEqual("d", ArabicToRomanConverter.Convert(500000));
            Assert.AreEqual("cm", ArabicToRomanConverter.Convert(900000)); 
        }


        [TestMethod]
        public void When_The_Arabic_Numeral_Is_Obscure_Random_Then_The_Roman_Numeral_Matches()
        {
            Assert.AreEqual("XXXIII", ArabicToRomanConverter.Convert(33));
            Assert.AreEqual("XLV", ArabicToRomanConverter.Convert(45));
            Assert.AreEqual("LXXXIX", ArabicToRomanConverter.Convert(89));
            Assert.AreEqual("CL", ArabicToRomanConverter.Convert(150));
            Assert.AreEqual("CCCXCIX", ArabicToRomanConverter.Convert(399));
            Assert.AreEqual("DCCC", ArabicToRomanConverter.Convert(800));
            Assert.AreEqual("MMXIX", ArabicToRomanConverter.Convert(2019));
            Assert.AreEqual("MMMCC", ArabicToRomanConverter.Convert(3200));
            Assert.AreEqual("vCMXCIX", ArabicToRomanConverter.Convert(5999));
            Assert.AreEqual("vMMMCMXCIX", ArabicToRomanConverter.Convert(8999));
            Assert.AreEqual("lxxxMx", ArabicToRomanConverter.Convert(89000));
            Assert.AreEqual("clxxxMx", ArabicToRomanConverter.Convert(189000));
            Assert.AreEqual("cmxcMxCMXCIX", ArabicToRomanConverter.Convert(999999));
        }
        
        

    }
}

