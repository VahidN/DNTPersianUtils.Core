using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DNTPersianUtils.Core.Tests
{
    [TestClass]
    public class NationalLegalCodeUtilsTests
    {
        [TestMethod]
        public void TestIsNumber1()
        {
            Assert.AreEqual(true, "00103508290".IsNumber());
        }

        [TestMethod]
        public void TestIsNumber2()
        {
            Assert.AreEqual(false, "001a0350829".IsNumber());
        }

        [TestMethod]
        public void NationalLegalCodeValidationTest()
        {
            Assert.AreEqual(true, "00103508290".IsValidIranianNationalLegalCode());
        }

        [TestMethod]
        public void NationalLegalCodeValidationTestCorrectCode1()
        {
            Assert.AreEqual(true, "10101780644".IsValidIranianNationalLegalCode());
        }

        [TestMethod]
        public void NationalLegalCodeValidationTestCorrectCode2()
        {
            Assert.AreEqual(true, "10860953980".IsValidIranianNationalLegalCode());
        }

        [TestMethod]
        public void NationalLegalCodeValidationTestCorrectCode3()
        {
            Assert.AreEqual(true, "10340046788".IsValidIranianNationalLegalCode());
        }

        [TestMethod]
        public void NationalLegalCodeValidationTestCorrectCode4()
        {
            Assert.AreEqual(true, "10480020857".IsValidIranianNationalLegalCode());
        }
        
        [TestMethod]
        public void NationalLegalCodeValidationTestCorrectCodeWithSpace()
        {
            Assert.AreEqual(false, " 10480020857  ".IsValidIranianNationalLegalCode());
        }

        [TestMethod]
        public void NationalLegalCodeValidationTestEmptyString()
        {
            Assert.AreEqual(false, "".IsValidIranianNationalLegalCode());
        }

        [TestMethod]
        public void NationalLegalCodeValidationTestShortString()
        {
            Assert.AreEqual(false, "0254".IsValidIranianNationalLegalCode());
        }

        [DataTestMethod]
        [DataRow("14005893875")]
        [DataRow("14006278162")]
        [DataRow("10530125945")]
        [DataRow("10740068759")]
        [DataRow("10320881604")]
        [DataRow("10480059810")]
        [DataRow("10780071570")]
        [DataRow("10780071570")]
        [DataRow("14003552272")]
        [DataRow("10720172838")]
        public void ValidIranianNationalLegalCodesTest(string code)
        {
            Assert.IsTrue(code.IsValidIranianNationalLegalCode());
        }

        [DataTestMethod]
        [DataRow("14006876134")]
        [DataRow("c25da28w45fa")]
        [DataRow("10740086430")]
        [DataRow("11111111211")]
        [DataRow("10320876496")]
        public void InvalidIranianNationalLegalCodesTest(string code)
        {
            Assert.IsFalse(code.IsValidIranianNationalLegalCode());
        }
    }
}