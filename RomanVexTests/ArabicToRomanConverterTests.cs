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

        [TestMethod]
        public void When_The_Arabic_Numeral_Is_90_Then_The_Roman_Numeral_Is_XC()
        {
            Assert.AreEqual("XC", ArabicToRomanConverter.Convert(90));
        }

        [TestMethod]
        public void When_The_Arabic_Numeral_Is_150_Then_The_Roman_Numeral_Is_CL()
        {
            Assert.AreEqual("CL", ArabicToRomanConverter.Convert(150));
        }

        [TestMethod]
        public void When_The_Arabic_Numeral_Is_399_Then_The_Roman_Numeral_Is_CCCXCIX()
        {
            Assert.AreEqual("CCCXCIX", ArabicToRomanConverter.Convert(399));
        }

        [TestMethod]
        public void When_The_Arabic_Numeral_Is_400_Then_The_Roman_Numeral_Is_CD()
        {
            Assert.AreEqual("CD", ArabicToRomanConverter.Convert(400));
        }

        [TestMethod]
        public void When_The_Arabic_Numeral_Is_800_Then_The_Roman_Numeral_Is_DCCC()
        {
            Assert.AreEqual("DCCC", ArabicToRomanConverter.Convert(800));
        }

        [TestMethod]
        public void When_The_Arabic_Numeral_Is_900_Then_The_Roman_Numeral_Is_CM()
        {
            Assert.AreEqual("CM", ArabicToRomanConverter.Convert(900));
        }

        [TestMethod]
        public void When_The_Arabic_Numeral_Is_3200_Then_The_Roman_Numeral_Is_MMMCC()
        {
            Assert.AreEqual("MMMCC", ArabicToRomanConverter.Convert(3200));
        }

        [TestMethod]
        public void When_The_Arabic_Numeral_Is_5000_Then_The_Roman_Numeral_Is_v()
        {
            Assert.AreEqual("v", ArabicToRomanConverter.Convert(5000));
        }

        [TestMethod]
        public void When_The_Arabic_Numeral_Is_5999_Then_The_Roman_Numeral_Is_vCMXCIX()
        {
            Assert.AreEqual("vCMXCIX", ArabicToRomanConverter.Convert(5999));
        }

        [TestMethod]
        public void When_The_Arabic_Numeral_Is_8999_Then_The_Roman_Numeral_Is_vMMMCMXCIX()
        {
            Assert.AreEqual("vMMMCMXCIX", ArabicToRomanConverter.Convert(8999));
        }

        [TestMethod]
        public void When_The_Arabic_Numeral_Is_9000_Then_The_Roman_Numeral_Is_Mx()
        {
            Assert.AreEqual("Mx", ArabicToRomanConverter.Convert(9000));
        }

        [TestMethod]
        public void When_The_Arabic_Numeral_Is_10000_Then_The_Roman_Numeral_Is_x()
        {
            Assert.AreEqual("x", ArabicToRomanConverter.Convert(10000));
        }

        [TestMethod]
        public void When_The_Arabic_Numeral_Is_40000_Then_The_Roman_Numeral_Is_xl()
        {
            Assert.AreEqual("xl", ArabicToRomanConverter.Convert(40000));
        }

        [TestMethod]
        public void When_The_Arabic_Numeral_Is_50000_Then_The_Roman_Numeral_Is_l()
        {
            Assert.AreEqual("l", ArabicToRomanConverter.Convert(50000));
        }

        [TestMethod]
        public void When_The_Arabic_Numeral_Is_89000_Then_The_Roman_Numeral_Is_lxxxMx()
        {
            Assert.AreEqual("lxxxMx", ArabicToRomanConverter.Convert(89000));
        }

        [TestMethod]
        public void When_The_Arabic_Numeral_Is_90000_Then_The_Roman_Numeral_Is_xc()
        {
            Assert.AreEqual("xc", ArabicToRomanConverter.Convert(90000));
        }

    }
}

