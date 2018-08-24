using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DNTPersianUtils.Core.Tests
{
    [TestClass]
    public class IranHolidaysTests
    {
        [TestMethod]
        public void Test_GetBusinessDays_works()
        {
            Assert.AreEqual(expected: 23, actual: IranHolidays.GetBusinessDays(1397, 6).Count());
        }
    }
}