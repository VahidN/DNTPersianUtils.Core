using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Threading;
using static System.TimeZoneInfo;

namespace DNTPersianUtils.Core;

/// <summary>
///     تعريف اختصاصي منطقه زماني ايران؛ به دليل عدم وجود آن در يكسري از سيستم عامل‌هاي لينوكسي و همچنين عدم به روز رساني
///     آن
///     در تعدادي ديگر
/// </summary>
public static class IranTimeZoneInfo
{
    [SuppressMessage(category: "Microsoft.Usage",
        checkId: "S3011:Make sure that this accessibility bypass is safe here",
        Justification = "We need this to correct a mistake!")]
    private static readonly FieldInfo? _baseUtcOffsetDeltaField =
        Array.Find(typeof(AdjustmentRule).GetFields(BindingFlags.NonPublic | BindingFlags.Instance),
            fi => fi.Name.EndsWith(value: "aseUtcOffsetDelta", StringComparison.Ordinal));

    private static readonly Lazy<TimeZoneInfo> _timeZoneBuilder =
        new(CreateIranStandardTime, LazyThreadSafetyMode.ExecutionAndPublication);

    /// <summary>
    ///     IranTimeZone Info
    /// </summary>
    public static TimeZoneInfo Instance { get; } = _timeZoneBuilder.Value;

    private static TimeZoneInfo CreateIranStandardTime()
        => TZ(id: "Iran Standard Time", baseUtcOffset: 126000000000, displayName: "(UTC+03:30) Tehran",
            standardName: "Iran Standard Time", daylightName: "Iran Daylight Time", new[]
            {
                R(dateStart: 0, dateEnd: 632400480000000000, daylightDelta: 36000000000,
                    T(timeOfDay: 0, month: 3, week: 3,
                        DayOfWeek.Sunday), T(timeOfDay: 863999990000, month: 9, week: 3,
                        DayOfWeek.Monday), baseUtcOffsetDelta: 0),
                R(dateStart: 632401344000000000, dateEnd: 632715840000000000, daylightDelta: 36000000000,
                    T(timeOfDay: 0, month: 3, week: 4,
                        DayOfWeek.Tuesday), T(timeOfDay: 863999990000, month: 9, week: 3,
                        DayOfWeek.Wednesday), baseUtcOffsetDelta: 0),
                R(dateStart: 633347424000000000, dateEnd: 633662784000000000, daylightDelta: 36000000000,
                    T(timeOfDay: 0, month: 3, week: 3,
                        DayOfWeek.Friday), T(timeOfDay: 863999990000, month: 9, week: 3,
                        DayOfWeek.Saturday), baseUtcOffsetDelta: 0),
                R(dateStart: 633663648000000000, dateEnd: 633978144000000000, daylightDelta: 36000000000,
                    T(timeOfDay: 0, month: 3, week: 4,
                        DayOfWeek.Sunday), T(timeOfDay: 863999990000, month: 9, week: 3,
                        DayOfWeek.Monday), baseUtcOffsetDelta: 0),
                R(dateStart: 633979008000000000, dateEnd: 634293504000000000, daylightDelta: 36000000000,
                    T(timeOfDay: 0, month: 3, week: 4,
                        DayOfWeek.Monday), T(timeOfDay: 863999990000, month: 9, week: 3,
                        DayOfWeek.Tuesday), baseUtcOffsetDelta: 0),
                R(dateStart: 634294368000000000, dateEnd: 634608864000000000, daylightDelta: 36000000000,
                    T(timeOfDay: 0, month: 3, week: 4,
                        DayOfWeek.Tuesday), T(timeOfDay: 863999990000, month: 9, week: 3,
                        DayOfWeek.Wednesday), baseUtcOffsetDelta: 0),
                R(dateStart: 634609728000000000, dateEnd: 634925088000000000, daylightDelta: 36000000000,
                    T(timeOfDay: 0, month: 3, week: 3,
                        DayOfWeek.Wednesday), T(timeOfDay: 863999990000, month: 9, week: 3,
                        DayOfWeek.Thursday), baseUtcOffsetDelta: 0),
                R(dateStart: 634925952000000000, dateEnd: 635240448000000000, daylightDelta: 36000000000,
                    T(timeOfDay: 0, month: 3, week: 4,
                        DayOfWeek.Friday), T(timeOfDay: 863999990000, month: 9, week: 3,
                        DayOfWeek.Saturday), baseUtcOffsetDelta: 0),
                R(dateStart: 635241312000000000, dateEnd: 635555808000000000, daylightDelta: 36000000000,
                    T(timeOfDay: 0, month: 3, week: 4,
                        DayOfWeek.Saturday), T(timeOfDay: 863999990000, month: 9, week: 3,
                        DayOfWeek.Sunday), baseUtcOffsetDelta: 0),
                R(dateStart: 635556672000000000, dateEnd: 635871168000000000, daylightDelta: 36000000000,
                    T(timeOfDay: 0, month: 3, week: 4,
                        DayOfWeek.Sunday), T(timeOfDay: 863999990000, month: 9, week: 3,
                        DayOfWeek.Monday), baseUtcOffsetDelta: 0),
                R(dateStart: 635872032000000000, dateEnd: 636187392000000000, daylightDelta: 36000000000,
                    T(timeOfDay: 0, month: 3, week: 3,
                        DayOfWeek.Monday), T(timeOfDay: 863999990000, month: 9, week: 3,
                        DayOfWeek.Tuesday), baseUtcOffsetDelta: 0),
                R(dateStart: 636188256000000000, dateEnd: 636502752000000000, daylightDelta: 36000000000,
                    T(timeOfDay: 0, month: 3, week: 4,
                        DayOfWeek.Wednesday), T(timeOfDay: 863999990000, month: 9, week: 3,
                        DayOfWeek.Thursday), baseUtcOffsetDelta: 0),
                R(dateStart: 636503616000000000, dateEnd: 636818112000000000, daylightDelta: 36000000000,
                    T(timeOfDay: 0, month: 3, week: 4,
                        DayOfWeek.Thursday), T(timeOfDay: 863999990000, month: 9, week: 3,
                        DayOfWeek.Friday), baseUtcOffsetDelta: 0),
                R(dateStart: 636818976000000000, dateEnd: 637133472000000000, daylightDelta: 36000000000,
                    T(timeOfDay: 0, month: 3, week: 4,
                        DayOfWeek.Friday), T(timeOfDay: 863999990000, month: 9, week: 3,
                        DayOfWeek.Saturday), baseUtcOffsetDelta: 0),
                R(dateStart: 637134336000000000, dateEnd: 637449696000000000, daylightDelta: 36000000000,
                    T(timeOfDay: 0, month: 3, week: 3,
                        DayOfWeek.Saturday), T(timeOfDay: 863999990000, month: 9, week: 3,
                        DayOfWeek.Sunday), baseUtcOffsetDelta: 0),
                R(dateStart: 637450560000000000, dateEnd: 637765056000000000, daylightDelta: 36000000000,
                    T(timeOfDay: 0, month: 3, week: 4,
                        DayOfWeek.Monday), T(timeOfDay: 863999990000, month: 9, week: 3,
                        DayOfWeek.Tuesday), baseUtcOffsetDelta: 0),
                R(dateStart: 637765920000000000, dateEnd: 638080416000000000, daylightDelta: 36000000000,
                    T(timeOfDay: 0, month: 3, week: 4,
                        DayOfWeek.Tuesday), T(timeOfDay: 863999990000, month: 9, week: 3,
                        DayOfWeek.Wednesday), baseUtcOffsetDelta: 0)
            });

    private static TimeZoneInfo TZ(string id, long baseUtcOffset, string displayName,
        string standardName, string daylightName, AdjustmentRule[] rules)
        => CreateCustomTimeZone(id, TimeSpan.FromTicks(baseUtcOffset), displayName,
            standardName, daylightName, rules);

    private static TransitionTime T(long timeOfDay, int month, int week,
        DayOfWeek dayOfWeek)
        => TransitionTime.CreateFloatingDateRule(DateTime.FromBinary(timeOfDay), month, week,
            dayOfWeek);

    private static AdjustmentRule R(long dateStart, long dateEnd, long daylightDelta,
        TransitionTime daylightTransitionStart, TransitionTime daylightTransitionEnd, long baseUtcOffsetDelta)
    {
        var rule = AdjustmentRule.CreateAdjustmentRule(DateTime.FromBinary(dateStart), DateTime.FromBinary(dateEnd),
            TimeSpan.FromTicks(daylightDelta), daylightTransitionStart, daylightTransitionEnd);

        _baseUtcOffsetDeltaField?.SetValue(rule, TimeSpan.FromTicks(baseUtcOffsetDelta));

        return rule;
    }
}