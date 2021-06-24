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

            return monthCells;
        }
    }
}