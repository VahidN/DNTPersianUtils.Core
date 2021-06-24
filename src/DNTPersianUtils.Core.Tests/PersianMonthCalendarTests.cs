using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DNTPersianUtils.Core.Tests
{
    [TestClass]
    public class PersianMonthCalendarTests
    {
        [TestMethod]
        public void Test_PersianMonthCalendar_Works()
        {
            var cells = PersianMonthCalendar.CreatePersianMonthCalendar(1400, 4);
            Assert.IsTrue(cells.Any());
        }
    }
}