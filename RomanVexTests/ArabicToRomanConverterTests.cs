using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanVex;

namespace RomanVexTests
{
    [TestClass]
    public class ArabicToRomanConverterTests
    {
        [TestMethod]
        public void WhenTheArabicNumeralIs1ThenTheRomanNumeralIsI()
        {
            Assert.AreEqual("I", ArabicToRomanConverter.Convert(1));
        }
    }
}
