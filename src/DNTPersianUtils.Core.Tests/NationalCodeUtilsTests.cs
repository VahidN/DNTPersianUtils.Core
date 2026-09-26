using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DNTPersianUtils.Core.Tests;

[TestClass]
public class NationalCodeUtilsTests
{
    [TestMethod] public void TestIsNumber1() => Assert.AreEqual(expected: true, "0010350829".IsNumber());

    [TestMethod] public void TestIsNumber2() => Assert.AreEqual(expected: false, "001a0350829".IsNumber());

    [TestMethod]
    public void NationalCodeValidationTest()
        => Assert.AreEqual(expected: true, "0010350829".IsValidIranianNationalCode());

    [TestMethod]
    public void NationalCodeValidationTestCorrectCode1()
        => Assert.AreEqual(expected: true, "0077611616".IsValidIranianNationalCode());

    [TestMethod]
    public void NationalCodeValidationTestCorrectCode2()
        => Assert.AreEqual(expected: true, "0081037511".IsValidIranianNationalCode());

    [TestMethod]
    public void NationalCodeValidationTestCorrectCode3()
        => Assert.AreEqual(expected: true, "172942284".IsValidIranianNationalCode());

    [TestMethod]
    public void NationalCodeValidationTestCorrectCode4()
        => Assert.AreEqual(expected: true, "81037511".IsValidIranianNationalCode());

    // http://www.fardanews.com/fa/news/127747/%D8%B1%D9%86%D8%AF%D8%AA%D8%B1%DB%8C%D9%86-%D8%B4%D9%85%D8%A7%D8%B1%D9%87-%D9%85%D9%84%DB%8C-%D8%A8%D9%84%D8%A7%DB%8C-%D8%AC%D8%A7%D9%86-%D8%B5%D8%A7%D8%AD%D8%A8%D8%B4-%D8%B4%D8%AF
    // It doesn't matter! Accepting it will cause more harm than good!
    [TestMethod]
    public void NationalCodeValidationTestCorrectCode5()
        => Assert.AreEqual(expected: false, "1111111111".IsValidIranianNationalCode());

    [TestMethod]
    [DataRow(data: "0000000000")]
    [DataRow(data: "1111111111")]
    [DataRow(data: "2222222222")]
    public void InvalidRepeatedDigitIranianNationalCodesTest(string code)
        => Assert.IsFalse(code.IsValidIranianNationalCode());

    [TestMethod]
    public void NationalCodeValidationTestCorrectCodeWithSpace()
        => Assert.AreEqual(expected: false, " 0077611616  ".IsValidIranianNationalCode());

    [TestMethod]
    public void NationalCodeValidationTestEmptyString()
        => Assert.AreEqual(expected: false, "".IsValidIranianNationalCode());

    [TestMethod]
    public void NationalCodeValidationTestShortString()
        => Assert.AreEqual(expected: false, "0254".IsValidIranianNationalCode());

    [TestMethod]
    public void NationalCodeValidationTestShortString2()
        => Assert.AreEqual(expected: false, "221".IsValidIranianNationalCode());

    [TestMethod]
    public void NationalCodeValidationTestWithDashes()
        => Assert.AreEqual(expected: false, "007-125698-4".IsValidIranianNationalCode());

    [DataTestMethod]
    [DataRow(data: "7731689956")]
    [DataRow(data: "45768676")]
    [DataRow(data: "15768643")]
    [DataRow(data: "15758648")]
    [DataRow(data: "0013542419")]
    [DataRow(data: "3240175800")]
    [DataRow(data: "3240164175")]
    [DataRow(data: "3370075024")]
    [DataRow(data: "0010532129")]
    [DataRow(data: "0860170470")]
    public void ValidIranianNationalCodesTest(string code) => Assert.IsTrue(code.IsValidIranianNationalCode());

    [DataTestMethod]
    [DataRow(data: "7731685956")]
    [DataRow(data: "c9xk9dkd")]
    [DataRow(data: "15758448")]
    [DataRow(data: "324011122")]
    [DataRow(data: "3213213")]
    public void InvalidIranianNationalCodesTest(string code) => Assert.IsFalse(code.IsValidIranianNationalCode());
}