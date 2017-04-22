using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DNTPersianUtils.Core.Tests
{
    [TestClass]
    public class NationalCodeUtilsTests
    {
        [TestMethod]
        public void TestIsNumber1()
        {
            Assert.AreEqual(true, "0010350829".IsNumber());
        }

        [TestMethod]
        public void TestIsNumber2()
        {
            Assert.AreEqual(false, "001a0350829".IsNumber());
        }

        [TestMethod]
        public void NationalCodeValidationTest()
        {
            Assert.AreEqual(true, "0010350829".IsValidIranianNationalCode());
        }

        [TestMethod]
        public void NationalCodeValidationTestCorrectCode1()
        {
            Assert.AreEqual(true, "0077611616".IsValidIranianNationalCode());
        }

        [TestMethod]
        public void NationalCodeValidationTestCorrectCode2()
        {
            Assert.AreEqual(true, "0081037511".IsValidIranianNationalCode());
        }

        [TestMethod]
        public void NationalCodeValidationTestCorrectCode3()
        {
            Assert.AreEqual(true, "172942284".IsValidIranianNationalCode());
        }

        [TestMethod]
        public void NationalCodeValidationTestCorrectCode4()
        {
            Assert.AreEqual(true, "81037511".IsValidIranianNationalCode());
        }

        [TestMethod]
        public void NationalCodeValidationTestCorrectCode5()
        {
            // http://www.fardanews.com/fa/news/127747/%D8%B1%D9%86%D8%AF%D8%AA%D8%B1%DB%8C%D9%86-%D8%B4%D9%85%D8%A7%D8%B1%D9%87-%D9%85%D9%84%DB%8C-%D8%A8%D9%84%D8%A7%DB%8C-%D8%AC%D8%A7%D9%86-%D8%B5%D8%A7%D8%AD%D8%A8%D8%B4-%D8%B4%D8%AF
            Assert.AreEqual(true, "1111111111".IsValidIranianNationalCode());
        }

        [TestMethod]
        public void NationalCodeValidationTestCorrectCodeWithSpace()
        {
            Assert.AreEqual(false, " 0077611616  ".IsValidIranianNationalCode());
        }

        [TestMethod]
        public void NationalCodeValidationTestEmptyString()
        {
            Assert.AreEqual(false, "".IsValidIranianNationalCode());
        }

        [TestMethod]
        public void NationalCodeValidationTestShortString()
        {
            Assert.AreEqual(false, "0254".IsValidIranianNationalCode());
        }

        [TestMethod]
        public void NationalCodeValidationTestWithDashes()
        {
            Assert.AreEqual(false, "007-125698-4".IsValidIranianNationalCode());
        }

        [DataTestMethod]
        [DataRow("7731689956")]
        [DataRow("45768676")]
        [DataRow("15768643")]
        [DataRow("15758648")]
        [DataRow("0013542419")]
        [DataRow("3240175800")]
        [DataRow("3240164175")]
        [DataRow("3370075024")]
        [DataRow("0010532129")]
        [DataRow("0860170470")]
        public void ValidIranianNationalCodesTest(string code)
        {
            Assert.IsTrue(code.IsValidIranianNationalCode());
        }

        [DataTestMethod]
        [DataRow("7731685956")]
        [DataRow("c9xk9dkd")]
        [DataRow("15758448")]
        [DataRow("324011122")]
        [DataRow("3213213")]
        public void InvalidIranianNationalCodesTest(string code)
        {
            Assert.IsFalse(code.IsValidIranianNationalCode());
        }
    }
}