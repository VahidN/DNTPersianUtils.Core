using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DNTPersianUtils.Core.Tests;

[TestClass]
public class IranHolidaysTests
{
    [TestMethod]
    public void Test_GetBusinessDays_works()
    {
        Assert.AreEqual(23, 1397.GetBusinessDays(6).Count());
    }
}