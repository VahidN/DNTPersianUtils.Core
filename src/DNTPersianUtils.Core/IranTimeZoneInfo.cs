#if !NETSTANDARD1_3
using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Threading;
using static System.TimeZoneInfo;

namespace DNTPersianUtils.Core
{
    /// <summary>
    /// IranTimeZone Info
    /// </summary>
    public static class IranTimeZoneInfo
    {
        [SuppressMessage("Microsoft.Usage", "S3011:Make sure that this accessibility bypass is safe here",
                    Justification = "We need this to correct a mistake!")]
        private static readonly FieldInfo? BaseUtcOffsetDeltaField =
            Array.Find(typeof(AdjustmentRule).GetFields(BindingFlags.NonPublic | BindingFlags.Instance),
                        fi => fi.Name.EndsWith("aseUtcOffsetDelta", StringComparison.Ordinal));

        private static readonly Lazy<TimeZoneInfo> _timeZoneBuilder =
                    new(CreateIranStandardTime, LazyThreadSafetyMode.ExecutionAndPublication);

        /// <summary>
        /// IranTimeZone Info
        /// </summary>
        public static TimeZoneInfo Instance { get; } = _timeZoneBuilder.Value;

        private static TimeZoneInfo CreateIranStandardTime()
        {
            return TZ("Iran Standard Time", 126000000000, "(UTC+03:30) Tehran", "Iran Standard Time", "Iran Daylight Time", new AdjustmentRule[] {
                    R(0, 632400480000000000, 36000000000, T(0, 3, 3, DayOfWeek.Sunday), T(863999990000, 9, 3, DayOfWeek.Monday), 0),
                    R(632401344000000000, 632715840000000000, 36000000000, T(0, 3, 4, DayOfWeek.Tuesday), T(863999990000, 9, 3, DayOfWeek.Wednesday), 0),
                    R(633347424000000000, 633662784000000000, 36000000000, T(0, 3, 3, DayOfWeek.Friday), T(863999990000, 9, 3, DayOfWeek.Saturday), 0),
                    R(633663648000000000, 633978144000000000, 36000000000, T(0, 3, 4, DayOfWeek.Sunday), T(863999990000, 9, 3, DayOfWeek.Monday), 0),
                    R(633979008000000000, 634293504000000000, 36000000000, T(0, 3, 4, DayOfWeek.Monday), T(863999990000, 9, 3, DayOfWeek.Tuesday), 0),
                    R(634294368000000000, 634608864000000000, 36000000000, T(0, 3, 4, DayOfWeek.Tuesday), T(863999990000, 9, 3, DayOfWeek.Wednesday), 0),
                    R(634609728000000000, 634925088000000000, 36000000000, T(0, 3, 3, DayOfWeek.Wednesday), T(863999990000, 9, 3, DayOfWeek.Thursday), 0),
                    R(634925952000000000, 635240448000000000, 36000000000, T(0, 3, 4, DayOfWeek.Friday), T(863999990000, 9, 3, DayOfWeek.Saturday), 0),
                    R(635241312000000000, 635555808000000000, 36000000000, T(0, 3, 4, DayOfWeek.Saturday), T(863999990000, 9, 3, DayOfWeek.Sunday), 0),
                    R(635556672000000000, 635871168000000000, 36000000000, T(0, 3, 4, DayOfWeek.Sunday), T(863999990000, 9, 3, DayOfWeek.Monday), 0),
                    R(635872032000000000, 636187392000000000, 36000000000, T(0, 3, 3, DayOfWeek.Monday), T(863999990000, 9, 3, DayOfWeek.Tuesday), 0),
                    R(636188256000000000, 636502752000000000, 36000000000, T(0, 3, 4, DayOfWeek.Wednesday), T(863999990000, 9, 3, DayOfWeek.Thursday), 0),
                    R(636503616000000000, 636818112000000000, 36000000000, T(0, 3, 4, DayOfWeek.Thursday), T(863999990000, 9, 3, DayOfWeek.Friday), 0),
                    R(636818976000000000, 637133472000000000, 36000000000, T(0, 3, 4, DayOfWeek.Friday), T(863999990000, 9, 3, DayOfWeek.Saturday), 0),
                    R(637134336000000000, 637449696000000000, 36000000000, T(0, 3, 3, DayOfWeek.Saturday), T(863999990000, 9, 3, DayOfWeek.Sunday), 0),
                    R(637450560000000000, 637765056000000000, 36000000000, T(0, 3, 4, DayOfWeek.Monday), T(863999990000, 9, 3, DayOfWeek.Tuesday), 0),
                    R(637765920000000000, 638080416000000000, 36000000000, T(0, 3, 4, DayOfWeek.Tuesday), T(863999990000, 9, 3, DayOfWeek.Wednesday), 0),
                    R(638081280000000000, 638395776000000000, 36000000000, T(0, 3, 4, DayOfWeek.Wednesday), T(863999990000, 9, 3, DayOfWeek.Thursday), 0),
                    R(638396640000000000, 3155378112000000000, 36000000000, T(0, 3, 3, DayOfWeek.Thursday), T(863999990000, 9, 3, DayOfWeek.Friday), 0),
                });
        }

        private static TimeZoneInfo TZ(string id, long baseUtcOffset, string displayName, string standardName, string daylightName, AdjustmentRule[] rules)
        {
            return CreateCustomTimeZone(id, TimeSpan.FromTicks(baseUtcOffset), displayName, standardName, daylightName, rules);
        }

        private static TransitionTime T(long timeOfDay, int month, int week, DayOfWeek dayOfWeek)
        {
            return TransitionTime.CreateFloatingDateRule(DateTime.FromBinary(timeOfDay), month, week, dayOfWeek);
        }

        private static AdjustmentRule R(long dateStart, long dateEnd, long daylightDelta, TransitionTime daylightTransitionStart, TransitionTime daylightTransitionEnd, long baseUtcOffsetDelta)
        {
            var rule = AdjustmentRule.CreateAdjustmentRule(
                DateTime.FromBinary(dateStart),
                DateTime.FromBinary(dateEnd),
                TimeSpan.FromTicks(daylightDelta),
                daylightTransitionStart, daylightTransitionEnd);
            BaseUtcOffsetDeltaField?.SetValue(rule, TimeSpan.FromTicks(baseUtcOffsetDelta));
            return rule;
        }
    }
}
#endif