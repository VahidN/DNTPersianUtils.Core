using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DNTPersianUtils.Core.Tests
{
    [TestClass]
    public class IranCodesUtilsTests
    {
        [DataTestMethod]
        [DataRow("1619735744")]
        public void ValidIranianPostalCodesTest(string code)
        {
            Assert.IsTrue(code.IsValidIranianPostalCode());
        }

        [DataTestMethod]
        [DataRow("11619735744")]
        [DataRow("0000073574")]
        [DataRow("0200073574")]
        [DataRow("2222273574")]
        [DataRow("1111735744")]
        [DataRow("1961535744")]
        public void InvalidIranianPostalCodesTest(string code)
        {
            Assert.IsFalse(code.IsValidIranianPostalCode());
        }

        [DataTestMethod]
        [DataRow("37236445")]
        public void ValidIranianPhoneNumbersTest(string code)
        {
            Assert.IsTrue(code.IsValidIranianPhoneNumber());
        }

        [DataTestMethod]
        [DataRow("07236445")]
        [DataRow("7236445")]
        [DataRow("17236445")]
        public void InvalidIranianPhoneNumbersTest(string code)
        {
            Assert.IsFalse(code.IsValidIranianPhoneNumber());
        }

        [DataTestMethod]
        [DataRow("+989355214655")]
        [DataRow("989355214655")]
        [DataRow("00989355214655")]
        [DataRow("09355214655")]
        [DataRow("09901464762")]
        [DataRow("9901464762")]
        public void ValidIranianMobileNumbersTest(string code)
        {
            Assert.IsTrue(code.IsValidIranianMobileNumber());
        }

        [DataTestMethod]
        [DataRow("0935521465")]
        public void InvalidIranianMobileNumbersTest(string code)
        {
            Assert.IsFalse(code.IsValidIranianMobileNumber());
        }
    }
}