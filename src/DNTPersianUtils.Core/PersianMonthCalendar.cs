using System.Collections.Generic;

namespace DNTPersianUtils.Core
{
    /// <summary>
    /// مناسب جهت ساخت و نمایش یک تقویم شمسی
    /// </summary>
    public static class PersianMonthCalendar
    {
        /// <summary>
        /// خانه‌های جدول یک ماه شمسی را باز می‌گرداند.
        /// اگر خانه‌ای اطلاعاتی نداشت، آن خانه با نال پر می‌شود
        /// </summary>
        public static IEnumerable<PersianDay?> CreatePersianMonthCalendar(this int persianYear, int persianMonth)
        {
            var monthCells = new List<PersianDay?>();
            for (var idx = 0; idx <= 41; idx++)
            {
                monthCells.Add(item: null);
            }

            var startDay = persianYear.GetPersianWeekDayNumber(persianMonth) - 1;
            int i, j;
            for (i = startDay; i <= 6; i++)
            {
                var curDay = i - startDay + 1;
                var holidays = persianYear.ToPersianDate(persianMonth, curDay).GetHolidays();
                monthCells[i] = new PersianDay
                {
                    Year = persianYear,
                    Month = persianMonth,
                    Day = curDay,
                    Holidays = holidays
                };
            }

            var noOfDays = persianYear.GetPersianMonthLastDay(persianMonth);
            var k = 7;
            for (j = 6 - startDay + 1; j <= noOfDays - 1; j++)
            {
                var curDay = j + 1;
                var holidays = persianYear.ToPersianDate(persianMonth, curDay).GetHolidays();
                monthCells[k] = new PersianDay
                {
                    Year = persianYear,
                    Month = persianMonth,
                    Day = curDay,
                    Holidays = holidays
                };
                k++;
            }

            RemoveLastNullRow(monthCells);
            return monthCells;
        }

        private static void RemoveLastNullRow(List<PersianDay?> monthCells)
        {
            // Calendar rows
            // 0,  1,  2,  3,  4,  5,  6
            // 7,  8,  9,  10, 11, 12, 13
            // 14, 15, 16, 17, 18, 19, 20
            // 21, 22, 23, 24, 25, 26, 27
            // 28, 29, 30, 31, 32, 33, 34
            // 35, 36, 37, 38, 39, 40, 41

            const int beginningOfLastRowIndex = 35;
            if (monthCells[beginningOfLastRowIndex] is null)
            {
                monthCells.RemoveRange(beginningOfLastRowIndex, 7);
            }
        }
    }
}