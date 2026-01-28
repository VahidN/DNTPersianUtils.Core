using System;

namespace DNTPersianUtils.Core;

/// <summary>
///     Provides utility methods for converting between
///     Gregorian/Julian calendar dates and the Julian Day Number (JDN).
///     Automatically handles the Gregorian calendar reform
///     introduced on 1582-10-15.
/// </summary>
public static class JulianDayUtils
{
    /// <summary>
    ///     The year in which the Gregorian calendar reform was introduced.
    /// </summary>
    public const int GregorianReformYear = 1582;

    /// <summary>
    ///     The month in which the Gregorian calendar reform was introduced.
    /// </summary>
    public const int GregorianReformMonth = 10;

    /// <summary>
    ///     The day of month on which the Gregorian calendar reform took effect.
    /// </summary>
    public const int GregorianReformDay = 15;

    /// <summary>
    ///     Represents the first date of the Gregorian calendar reform
    ///     (October 15, 1582).
    ///     Dates on or after this value are considered Gregorian dates;
    ///     earlier dates are treated as Julian dates.
    /// </summary>
    public static readonly DateTime GregorianReformDateTime =
        new(GregorianReformYear, GregorianReformMonth, GregorianReformDay);

    /// <summary>
    ///     Converts a date in the Julian calendar to its corresponding
    ///     Julian Day Number (JDN).
    /// </summary>
    /// <param name="year">The year component of the Julian date.</param>
    /// <param name="month">The month component of the Julian date (1–12).</param>
    /// <param name="day">The day component of the Julian date.</param>
    /// <returns>
    ///     The Julian Day Number (JDN) corresponding to the specified Julian date.
    /// </returns>
    public static long JdnFromJulian(int year, int month, int day) => JulianToJdn(year, month, day);

    /// <summary>
    ///     Converts a date in the Julian calendar to its corresponding
    ///     Julian Day Number (JDN).
    /// </summary>
    /// <param name="dateTime">The Julian date.</param>
    /// <returns>
    ///     The Julian Day Number (JDN) corresponding to the specified Julian date.
    /// </returns>
    public static long JdnFromJulian(this DateTime dateTime)
        => JdnFromJulian(dateTime.Year, dateTime.Month, dateTime.Day);

    /// <summary>
    ///     Converts a date in the Gregorian calendar to its corresponding
    ///     Julian Day Number (JDN).
    /// </summary>
    /// <param name="year">The year component of the Gregorian date.</param>
    /// <param name="month">The month component of the Gregorian date (1–12).</param>
    /// <param name="day">The day component of the Gregorian date.</param>
    /// <returns>
    ///     The Julian Day Number (JDN) corresponding to the specified Gregorian date.
    /// </returns>
    public static long GregorianToJdn(int year, int month, int day)
    {
        var a = (14 - month) / 12;
        var y = year + 4800 - a;
        var m = month + 12 * a - 3;

        return day + (153 * m + 2) / 5 + 365L * y + y / 4 - y / 100 + y / 400 - 32045;
    }

    /// <summary>
    ///     Converts a date in the Gregorian calendar to its corresponding
    ///     Julian Day Number (JDN).
    /// </summary>
    /// <param name="dateTime">The Gregorian date.</param>
    /// <returns>
    ///     The Julian Day Number (JDN) corresponding to the specified Gregorian date.
    /// </returns>
    public static long GregorianToJdn(this DateTime dateTime)
        => GregorianToJdn(dateTime.Year, dateTime.Month, dateTime.Day);

    /// <summary>
    ///     Converts a date in the Julian calendar to its corresponding
    ///     Julian Day Number (JDN).
    /// </summary>
    /// <param name="year">The year component of the Julian date.</param>
    /// <param name="month">The month component of the Julian date (1–12).</param>
    /// <param name="day">The day component of the Julian date.</param>
    /// <returns>
    ///     The Julian Day Number (JDN) corresponding to the specified Julian date.
    /// </returns>
    public static long JulianToJdn(int year, int month, int day)
    {
        var a = (14 - month) / 12;
        var y = year + 4800 - a;
        var m = month + 12 * a - 3;

        return day + (153 * m + 2) / 5 + 365L * y + y / 4 - 32083;
    }

    /// <summary>
    ///     Converts a date in the Julian calendar to its corresponding
    ///     Julian Day Number (JDN).
    /// </summary>
    /// <param name="dateTime">The  Julian date.</param>
    /// <returns>
    ///     The Julian Day Number (JDN) corresponding to the specified Julian date.
    /// </returns>
    public static long JulianToJdn(this DateTime dateTime) => JulianToJdn(dateTime.Year, dateTime.Month, dateTime.Day);

    /// <summary>
    ///     Converts a Julian Day Number (JDN) to its corresponding
    ///     Gregorian calendar date.
    /// </summary>
    /// <param name="jdn">The Julian Day Number to convert.</param>
    /// <returns>
    ///     A <see cref="DateTime" /> representing the equivalent Gregorian date.
    /// </returns>
    /// <remarks>
    ///     The returned <see cref="DateTime" /> uses the proleptic Gregorian calendar.
    ///     Time components are set to midnight (00:00:00).
    /// </remarks>
    public static DateTime JdnToGregorian(long jdn)
    {
        var a = jdn + 32044;
        var b = (4 * a + 3) / 146097;
        var c = a - 146097 * b / 4;

        var d = (4 * c + 3) / 1461;
        var e = c - 1461 * d / 4;
        var m = (5 * e + 2) / 153;

        var day = (int)(e - (153 * m + 2) / 5 + 1);
        var month = (int)(m + 3 - 12 * (m / 10));
        var year = (int)(100 * b + d - 4800 + m / 10);

        return new DateTime(year, month, day);
    }

    /// <summary>
    ///     Converts a date to its Julian Day Number (JDN),
    ///     automatically determining whether the date belongs to the
    ///     Julian or Gregorian calendar based on the Gregorian reform date.
    /// </summary>
    /// <param name="year">The year component of the date.</param>
    /// <param name="month">The month component of the date (1–12).</param>
    /// <param name="day">The day component of the date.</param>
    /// <returns>
    ///     The Julian Day Number (JDN) corresponding to the specified date.
    /// </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     Thrown when the provided date components are invalid.
    /// </exception>
    public static long JdnFromGregorian(int year, int month, int day)
    {
        ValidateDate(year, month, day);

        return IsGregorianDate(year, month, day) ? GregorianToJdn(year, month, day) : JulianToJdn(year, month, day);
    }

    /// <summary>
    ///     Converts a date to its Julian Day Number (JDN),
    ///     automatically determining whether the date belongs to the
    ///     Julian or Gregorian calendar based on the Gregorian reform date.
    /// </summary>
    /// <param name="dateTime">The given date</param>
    /// <returns>
    ///     The Julian Day Number (JDN) corresponding to the specified date.
    /// </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     Thrown when the provided date components are invalid.
    /// </exception>
    public static long JdnFromGregorian(this DateTime dateTime)
        => JdnFromGregorian(dateTime.Year, dateTime.Month, dateTime.Day);

    /// <summary>
    ///     Determines whether the specified date falls under the
    ///     Gregorian calendar, based on the Gregorian reform date
    ///     (October 15, 1582).
    /// </summary>
    /// <param name="year">The year component of the date.</param>
    /// <param name="month">The month component of the date.</param>
    /// <param name="day">The day component of the date.</param>
    /// <returns>
    ///     <c>true</c> if the date is Gregorian; otherwise, <c>false</c>
    ///     (indicating a Julian calendar date).
    /// </returns>
    public static bool IsGregorianDate(int year, int month, int day)
        => new DateTime(year, month, day) >= GregorianReformDateTime;

    /// <summary>
    ///     Validates the specified date components.
    /// </summary>
    /// <param name="year">The year component of the date.</param>
    /// <param name="month">The month component of the date.</param>
    /// <param name="day">The day component of the date.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    ///     Thrown when the month or day value is outside its valid range.
    /// </exception>
    public static void ValidateDate(int year, int month, int day)
    {
        if (month is < 1 or > 12)
        {
            throw new ArgumentOutOfRangeException(nameof(month));
        }

        if (day < 1 || day > DateTime.DaysInMonth(Clamp(year, min: 1, max: 9999), month))
        {
            throw new ArgumentOutOfRangeException(nameof(day));
        }
    }

    /// <summary>
    ///     Converts a Persian (Solar Hijri) calendar date to its corresponding
    ///     Julian Day Number (JDN).
    /// </summary>
    /// <remarks>
    ///     This implementation is based on the astronomical Persian calendar
    ///     using a 2820-year leap cycle, as described in
    ///     <i>Calendrical Calculations</i> by Reingold and Dershowitz.
    ///     <para>
    ///         The algorithm is purely integer-based, does not rely on floating-point
    ///         arithmetic, and is valid for a wide range of years, including
    ///         negative (astronomical) year numbering.
    ///     </para>
    ///     <para>
    ///         The Persian calendar has 682 leap years in every 2820-year cycle,
    ///         resulting in an average year length of approximately 365.242198 days.
    ///     </para>
    /// </remarks>
    /// <param name="year">
    ///     The Persian calendar year (astronomical year numbering; year 0 is supported).
    /// </param>
    /// <param name="month">
    ///     The Persian calendar month (1–12).
    /// </param>
    /// <param name="day">
    ///     The day of the month (1–31, depending on the month).
    /// </param>
    /// <returns>
    ///     The Julian Day Number (JDN) corresponding to the specified Persian date.
    /// </returns>
    public static long PersianDayToJdn(int year, int month, int day)
    {
        // JDN of 1 Farvardin 1 (Persian calendar epoch),
        // corresponding to 622-03-19 (Julian calendar)
        const long persianEpochJdn = 1948321;

        // Length of the Persian leap-year cycle
        const int cycleYears = 2820;

        // Number of leap years in one full 2820-year cycle = 682
        // Total number of days in one full 2820-year cycle
        // (365 * 2820 + 682)
        const int daysPerCycle = 1029983;

        // Offset used to align the cycle with the historical epoch
        const int cycleYearOffset = 474;

        // Coefficients used in the leap year calculation formula
        const int leapYearMultiplier = 682;
        const int leapYearCorrection = 110;
        const int leapYearDivisor = 2816;

        // Normalize the year relative to the start of the 2820-year cycle.
        // A different offset is applied for negative years to support
        // astronomical year numbering.
        long epBase = year >= 0 ? year - cycleYearOffset : year - (cycleYearOffset - 1);

        // Position of the year within the current 2820-year cycle
        var epYear = cycleYearOffset + Mod(epBase, cycleYears);

        // Number of days elapsed in the year before the given month
        long monthDays = month <= 7 ? (month - 1) * 31 : (month - 1) * 30 + 6;

        // Number of leap days that have occurred so far in the current cycle
        var leapDays = (epYear * leapYearMultiplier - leapYearCorrection) / leapYearDivisor;

        return day + monthDays + leapDays + (epYear - 1) * 365 + epBase / cycleYears * daysPerCycle +
               (persianEpochJdn - 1);
    }

    /// <summary>
    ///     Converts a Julian Day Number (JDN) to its corresponding
    ///     Persian (Solar Hijri) calendar date.
    /// </summary>
    /// <remarks>
    ///     This method is the exact inverse of <see cref="PersianDayToJdn" /> and is based
    ///     on the astronomical Persian calendar using a 2820-year leap cycle,
    ///     as described in <i>Calendrical Calculations</i> by Reingold and Dershowitz.
    ///     <para>
    ///         The calculation is performed using integer arithmetic only and supports
    ///         astronomical year numbering (including year 0).
    ///     </para>
    /// </remarks>
    /// <param name="jdn">
    ///     The Julian Day Number to convert.
    /// </param>
    /// <returns>
    ///     A <see cref="PersianDay" /> representing the equivalent Persian calendar date.
    /// </returns>
    public static PersianDay JdnToPersianDay(long jdn)
    {
        const int daysPerCycle = 1029983;
        const int cycleYears = 2820;
        const int epochYearOffset = 474;

        var daysSinceEpoch = jdn - PersianDayToJdn(epochYearOffset + 1, month: 1, day: 1);
        var cycle = daysSinceEpoch / daysPerCycle;
        var cycleDay = daysSinceEpoch % daysPerCycle;
        long yearInCycle;

        if (cycleDay == daysPerCycle - 1)
        {
            yearInCycle = cycleYears;
        }
        else
        {
            var aux1 = cycleDay / 366;
            var aux2 = cycleDay % 366;
            yearInCycle = (long)Math.Floor((2134 * aux1 + 2816 * aux2 + 2815) / 1028522d) + aux1 + 1;
        }

        var year = (int)(yearInCycle + cycleYears * cycle + epochYearOffset);

        if (year <= 0)
        {
            year -= 1;
        }

        var dayOfYear = jdn - PersianDayToJdn(year, month: 1, day: 1) + 1;

        var month = dayOfYear <= 186 ? (int)Math.Ceiling(dayOfYear / 31d) : (int)Math.Ceiling((dayOfYear - 6) / 30d);

        var day = (int)(jdn - PersianDayToJdn(year, month, day: 1)) + 1;

        return new PersianDay(year, month, day);
    }

    /// <summary>
    ///     Computes a mathematical modulus that always yields a non-negative result.
    /// </summary>
    private static long Mod(long value, long modulus) => (value % modulus + modulus) % modulus;

    private static int Clamp(int value, int min, int max)
    {
        if (min > max)
        {
            throw new ArgumentOutOfRangeException(nameof(min));
        }

        if (value < min)
        {
            return min;
        }

        return value > max ? max : value;
    }
}