using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DNTPersianUtils.Core.Tests;

[TestClass]
public class IranCodesUtilsTests
{
    [DataTestMethod]
    [DataRow(data: "1619735744")]
    [DataRow(data: "1416932790")]
    [DataRow(data: "1458963210")]
    [DataRow(data: "3456789123")]
    [DataRow(data: "9876543210")]
    [DataRow(data: "5174643119")]
    [DataRow(data: "1961535744")]
    [DataRow(data: "6615853966")]
    [DataRow(data: "1517863332")]
    public void ValidIranianPostalCodesTest(string code) => Assert.IsTrue(code.IsValidIranianPostalCode());

    [DataTestMethod]
    [DataRow(data: "11619735744")]
    [DataRow(data: "0000073574")]
    [DataRow(data: "0200073574")]
    [DataRow(data: "2222273574")]
    [DataRow(data: "1111735744")]
    [DataRow(data: "1111111111")]
    [DataRow(data: "0123456789")] // نامعتبر (شروع با ۰)
    [DataRow(data: "2987654321")] // نامعتبر (شروع با ۲)
    [DataRow(data: "1428963210")] // نامعتبر (وجود ۲ در پنج رقم اول)
    [DataRow(data: "14589")] // نامعتبر (طول کمتر از ۱۰)    
    public void InvalidIranianPostalCodesTest(string code) => Assert.IsFalse(code.IsValidIranianPostalCode());

    [DataTestMethod]
    [DataRow(data: "37236445")]
    public void ValidIranianPhoneNumbersTest(string code) => Assert.IsTrue(code.IsValidIranianPhoneNumber());

    [DataTestMethod]
    [DataRow(data: "07236445")]
    [DataRow(data: "7236445")]
    [DataRow(data: "17236445")]
    public void InvalidIranianPhoneNumbersTest(string code) => Assert.IsFalse(code.IsValidIranianPhoneNumber());

    [DataTestMethod]
    [DataRow(data: "+989355214655")]
    [DataRow(data: "989355214655")]
    [DataRow(data: "00989355214655")]
    [DataRow(data: "09355214655")]
    [DataRow(data: "09901464762")]
    [DataRow(data: "9901464762")]
    public void ValidIranianMobileNumbersTest(string code) => Assert.IsTrue(code.IsValidIranianMobileNumber());

    [DataTestMethod]
    [DataRow(data: "0935521465")]
    public void InvalidIranianMobileNumbersTest(string code) => Assert.IsFalse(code.IsValidIranianMobileNumber());
}