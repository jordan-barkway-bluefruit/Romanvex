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



    }
}
