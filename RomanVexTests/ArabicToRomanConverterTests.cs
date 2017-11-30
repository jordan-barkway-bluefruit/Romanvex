using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanVex;

namespace RomanVexTests
{
    [TestClass]
    public class ArabicToRomanConverterTests
    {
        [TestMethod]
        public void When_The_Arabic_Numeral_Is_1_Then_The_Roman_Numeral_Is_I()
        {
            Assert.AreEqual("I", ArabicToRomanConverter.Convert(1));
        }

        [TestMethod]
        public void When_The_Arabic_Numeral_Is_4_Then_The_Roman_Numeral_Is_IV()
        {
            Assert.AreEqual("IV", ArabicToRomanConverter.Convert(4));
        }
     
        [TestMethod]
        public void When_The_Arabic_Numeral_Is_5_Then_The_Roman_Numeral_Is_V()
        {
            Assert.AreEqual("V", ArabicToRomanConverter.Convert(5));
        }

        [TestMethod]
        public void When_The_Arabic_Numeral_Is_10_Then_The_Roman_Numeral_Is_X()
        {
            Assert.AreEqual("X", ArabicToRomanConverter.Convert(10));
        }

        [TestMethod]
        public void When_The_Arabic_Numeral_Is_10_Then_The_Roman_Numeral_Is_IX()
        {
            Assert.AreEqual("IX", ArabicToRomanConverter.Convert(9));
        }

        [TestMethod]
        public void When_The_Arabic_Numeral_Is_33_Then_The_Roman_Numeral_Is_XXXIII()
        {
            Assert.AreEqual("XXXIII", ArabicToRomanConverter.Convert(33));
        }

        [TestMethod]
        public void When_The_Arabic_Numeral_Is_40_Then_The_Roman_Numeral_Is_XL()
        {
            Assert.AreEqual("XL", ArabicToRomanConverter.Convert(40));
        }

        [TestMethod]
        public void When_The_Arabic_Numeral_Is_45_Then_The_Roman_Numeral_Is_XLV()
        {
            Assert.AreEqual("XLV", ArabicToRomanConverter.Convert(45));
        }

        [TestMethod]
        public void When_The_Arabic_Numeral_Is_89_Then_The_Roman_Numeral_Is_LXXXIX()
        {
            Assert.AreEqual("LXXXIX", ArabicToRomanConverter.Convert(89));
        }
    }
}
