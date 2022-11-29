using System.Linq;
using DNTPersianUtils.Core.IranCities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DNTPersianUtils.Core.Tests;

[TestClass]
public class IranCitiesTests
{
    [TestMethod]
    public void Test_IranProvincesCount_Is_Correct()
    {
        Assert.AreEqual(31, Iran.Provinces.Count());
    }
}