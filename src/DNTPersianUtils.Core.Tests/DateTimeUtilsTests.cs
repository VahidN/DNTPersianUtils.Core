using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DNTPersianUtils.Core.Tests;

[TestClass]
public class DateTimeUtilsTests
{
    [TestMethod]
    public void Test_GetAge_Returns_Correct_Age()
    {
        var now = DateTime.UtcNow;
        var dt = now.AddYears(-39);

        var actualAge = dt.GetAge(now);
        Assert.AreEqual(39, actualAge);
    }


    [TestMethod]
    public void Test_GetAgeUtc_Returns_Correct_Age()
    {
        var now = DateTime.UtcNow;
        var dt = now.AddYears(-39);

        var actualAge = dt.GetAge();
        Assert.AreEqual(39, actualAge);
    }

    [TestMethod]
    public void Test_GetAgeLocal_Returns_Correct_Age()
    {
        var now = DateTime.Now;
        var dt = now.AddYears(-39);

        var actualAge = dt.GetAge();
        Assert.AreEqual(39, actualAge);
    }
}