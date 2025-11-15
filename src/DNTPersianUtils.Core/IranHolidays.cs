using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using static System.FormattableString;

namespace DNTPersianUtils.Core;

/// <summary>
///     مناسبت‌های تعطیلات رسمی ایران
/// </summary>
public static class IranHolidays
{
    private const string Nowrooz = "عید نوروز";
    private const string Salenow = "جشن نوروز/جشن سال نو";
    private const string RoozeJomhoori = "روز جمهوری اسلامی ایران";
    private const string Sizdah = "جشن سیزده به در";
    private const string Taasooa = "تاسوعای حسینی";
    private const string Aashooraa = "عاشورای حسینی";
    private const string Mabas = "مبعث رسول اکرم";
    private const string RoozePedar = "ولادت امام علی علیه السلام و روز پدر";
    private const string RehlateEmaam = "رحلت حضرت امام خمینی";
    private const string PaanzdaheKhordaad = "قیام 15 خرداد";
    private const string NimehShabaan = "ولادت حضرت قائم عجل الله تعالی فرجه و جشن نیمه شعبان";
    private const string ShahaadateHazrazteAli = "شهادت حضرت علی علیه السلام";
    private const string EideFetr = "عید سعید فطر";
    private const string TatilBeMonaasebateEideFetr = "تعطیل به مناسبت عید سعید فطر";
    private const string ShahaadatEmaamJafar = "شهادت امام جعفر صادق علیه السلام";
    private const string EideGhorbaan = "عید سعید قربان";
    private const string EideGhadir = "عید سعید غدیر خم";
    private const string Arbaein = "اربعین حسینی";
    private const string RehlateRasool = "رحلت رسول اکرم؛ شهادت امام حسن مجتبی علیه السلام";
    private const string ShahaadateEmaamReza = "شهادت امام رضا علیه السلام";
    private const string TavallodeRasool = "میلاد رسول اکرم و امام جعفر صادق علیه السلام";
    private const string TavallodeMasih = "زادروز حضرت مسیح";
    private const string PiroozieEnghelaab = "پیروزی انقلاب اسلامی";
    private const string ShahaadateHazrazteZahraa = "شهادت حضرت فاطمه زهرا سلام الله علیها";
    private const string MelliShodaneNaft = "روز ملی شدن صنعت نفت ایران";
    private const string ShahaadateHazrazteAsgari = "شهادت امام حسن‌عسکری و آغاز امامت حضرت ولی‌عصر(عج)";
    private const string ValaadateHazrazteMahdi = "ولادت حضرت قائم (عج)";
    private const string RoozeAkhareSaal = "آخرین روز سال";
    private const string ShahadataPresidentRaeesi = "عزای عمومی شهادت رییس جمهور";

    /// <summary>
    ///     سال شروع تعاریف مناسبت‌های تعطیل در این کتابخانه
    /// </summary>
    public const int StartYear = 1395;

    /// <summary>
    ///     سال خاتمه تعاریف مناسبت‌های تعطیل در این کتابخانه
    /// </summary>
    public const int EndYear = 1404;

    private static readonly Lazy<ISet<IranHoliday>> _holidayProvider =
        new(getIranHolidays, LazyThreadSafetyMode.ExecutionAndPublication);

    /// <summary>
    ///     مناسبت‌های تعطیلات رسمی ایران
    /// </summary>
    public static ISet<IranHoliday> Instance { get; } = _holidayProvider.Value;

    private static HashSet<IranHoliday> getIranHolidays()
    {
        var persianCalendar = new PersianCalendar();

        var holidays = new HashSet<IranHoliday>
        {
            // ----------------------- سال 1395
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1395, month: 1, day: 1, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Salenow
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1395, month: 1, day: 2, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Nowrooz
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1395, month: 1, day: 3, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Nowrooz
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1395, month: 1, day: 4, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Nowrooz
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1395, month: 1, day: 12, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = RoozeJomhoori
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1395, month: 1, day: 13, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Sizdah
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1395, month: 2, day: 2, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = RoozePedar
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1395, month: 2, day: 16, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Mabas
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1395, month: 3, day: 2, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = NimehShabaan
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1395, month: 3, day: 14, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = RehlateEmaam
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1395, month: 3, day: 15, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = PaanzdaheKhordaad
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1395, month: 4, day: 7, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadateHazrazteAli
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1395, month: 4, day: 16, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = EideFetr
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1395, month: 4, day: 17, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = TatilBeMonaasebateEideFetr
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1395, month: 5, day: 9, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadatEmaamJafar
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1395, month: 6, day: 22, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = EideGhorbaan
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1395, month: 6, day: 30, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = EideGhadir
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1395, month: 7, day: 20, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Taasooa
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1395, month: 7, day: 21, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Aashooraa
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1395, month: 8, day: 30, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Arbaein
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1395, month: 9, day: 8, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = RehlateRasool
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1395, month: 9, day: 10, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadateEmaamReza
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1395, month: 9, day: 27, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = TavallodeRasool
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1395, month: 10, day: 5, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = TavallodeMasih
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1395, month: 11, day: 22, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = PiroozieEnghelaab
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1395, month: 12, day: 12, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadateHazrazteZahraa
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1395, month: 12, day: 29, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = MelliShodaneNaft
            },

            // ----------------------- سال 1396
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1396, month: 1, day: 1, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Salenow
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1396, month: 1, day: 2, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Nowrooz
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1396, month: 1, day: 3, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Nowrooz
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1396, month: 1, day: 4, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Nowrooz
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1396, month: 1, day: 12, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = RoozeJomhoori
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1396, month: 1, day: 13, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Sizdah
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1396, month: 1, day: 22, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = RoozePedar
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1396, month: 2, day: 5, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Mabas
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1396, month: 2, day: 22, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = NimehShabaan
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1396, month: 3, day: 14, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = RehlateEmaam
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1396, month: 3, day: 15, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = PaanzdaheKhordaad
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1396, month: 3, day: 26, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadateHazrazteAli
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1396, month: 4, day: 5, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = EideFetr
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1396, month: 4, day: 6, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = TatilBeMonaasebateEideFetr
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1396, month: 4, day: 29, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadatEmaamJafar
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1396, month: 6, day: 10, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = EideGhorbaan
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1396, month: 6, day: 18, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = EideGhadir
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1396, month: 7, day: 8, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Taasooa
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1396, month: 7, day: 9, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Aashooraa
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1396, month: 8, day: 18, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Arbaein
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1396, month: 8, day: 26, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = RehlateRasool
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1396, month: 8, day: 28, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadateEmaamReza
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1396, month: 9, day: 6, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadateHazrazteAsgari
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1396, month: 9, day: 15, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = TavallodeRasool
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1396, month: 11, day: 22, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = PiroozieEnghelaab
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1396, month: 12, day: 1, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadateHazrazteZahraa
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1396, month: 12, day: 29, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = MelliShodaneNaft
            },

            // ----------------------- سال 1397
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1397, month: 1, day: 1, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Salenow
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1397, month: 1, day: 2, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Nowrooz
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1397, month: 1, day: 3, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Nowrooz
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1397, month: 1, day: 4, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Nowrooz
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1397, month: 1, day: 11, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = RoozePedar
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1397, month: 1, day: 12, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = RoozeJomhoori
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1397, month: 1, day: 13, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Sizdah
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1397, month: 1, day: 25, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Mabas
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1397, month: 2, day: 12, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = NimehShabaan
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1397, month: 3, day: 14, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = RehlateEmaam
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1397, month: 3, day: 15, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = PaanzdaheKhordaad
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1397, month: 3, day: 16, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadateHazrazteAli
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1397, month: 3, day: 25, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = EideFetr
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1397, month: 3, day: 26, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = TatilBeMonaasebateEideFetr
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1397, month: 4, day: 18, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadatEmaamJafar
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1397, month: 5, day: 31, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = EideGhorbaan
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1397, month: 6, day: 8, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = EideGhadir
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1397, month: 6, day: 28, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Taasooa
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1397, month: 6, day: 29, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Aashooraa
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1397, month: 8, day: 8, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Arbaein
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1397, month: 8, day: 16, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = RehlateRasool
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1397, month: 8, day: 17, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadateEmaamReza
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1397, month: 8, day: 25, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadateHazrazteAsgari
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1397, month: 9, day: 4, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = TavallodeRasool
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1397, month: 11, day: 20, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadateHazrazteZahraa
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1397, month: 11, day: 22, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = PiroozieEnghelaab
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1397, month: 12, day: 29, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = $"{MelliShodaneNaft}؛ {RoozePedar}"
            },

            // ----------------------- سال 1398
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1398, month: 1, day: 1, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Salenow
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1398, month: 1, day: 2, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Nowrooz
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1398, month: 1, day: 3, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Nowrooz
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1398, month: 1, day: 4, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Nowrooz
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1398, month: 1, day: 12, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = RoozeJomhoori
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1398, month: 1, day: 13, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Sizdah
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1398, month: 1, day: 14, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Mabas
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1398, month: 2, day: 1, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = NimehShabaan
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1398, month: 3, day: 6, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadateHazrazteAli
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1398, month: 3, day: 14, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = RehlateEmaam
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1398, month: 3, day: 15, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = $"{PaanzdaheKhordaad} و {EideFetr}"
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1398, month: 3, day: 16, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = TatilBeMonaasebateEideFetr
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1398, month: 4, day: 8, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadatEmaamJafar
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1398, month: 5, day: 21, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = EideGhorbaan
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1398, month: 5, day: 29, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = EideGhadir
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1398, month: 6, day: 18, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Taasooa
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1398, month: 6, day: 19, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Aashooraa
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1398, month: 7, day: 27, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Arbaein
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1398, month: 8, day: 5, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = RehlateRasool
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1398, month: 8, day: 7, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadateEmaamReza
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1398, month: 8, day: 15, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadateHazrazteAsgari
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1398, month: 8, day: 24, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = TavallodeRasool
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1398, month: 11, day: 9, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadateHazrazteZahraa
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1398, month: 11, day: 22, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = PiroozieEnghelaab
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1398, month: 12, day: 18, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = RoozePedar
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1398, month: 12, day: 29, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = $"{MelliShodaneNaft}؛ {RoozePedar}"
            },

            // ----------------------- سال 1399
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1399, month: 1, day: 1, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Salenow
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1399, month: 1, day: 2, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Nowrooz
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1399, month: 1, day: 3, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = $"{Nowrooz} و {Mabas}"
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1399, month: 1, day: 4, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Nowrooz
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1399, month: 1, day: 12, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = RoozeJomhoori
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1399, month: 1, day: 13, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Sizdah
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1399, month: 1, day: 21, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = NimehShabaan
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1399, month: 2, day: 26, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadateHazrazteAli
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1399, month: 3, day: 4, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = EideFetr
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1399, month: 3, day: 5, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = TatilBeMonaasebateEideFetr
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1399, month: 3, day: 14, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = RehlateEmaam
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1399, month: 3, day: 15, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = PaanzdaheKhordaad
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1399, month: 3, day: 28, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadatEmaamJafar
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1399, month: 5, day: 10, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = EideGhorbaan
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1399, month: 5, day: 18, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = EideGhadir
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1399, month: 6, day: 8, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Taasooa
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1399, month: 6, day: 9, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Aashooraa
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1399, month: 7, day: 17, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Arbaein
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1399, month: 7, day: 25, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = RehlateRasool
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1399, month: 7, day: 26, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadateEmaamReza
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1399, month: 8, day: 4, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadateHazrazteAsgari
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1399, month: 8, day: 13, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = TavallodeRasool
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1399, month: 10, day: 28, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadateHazrazteZahraa
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1399, month: 11, day: 22, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = PiroozieEnghelaab
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1399, month: 12, day: 7, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = RoozePedar
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1399, month: 12, day: 21, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Mabas
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1399, month: 12, day: 29, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = MelliShodaneNaft
            },

            // ----------------------- سال 1400
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1400, month: 01, day: 01, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Salenow
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1400, month: 01, day: 02, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Nowrooz
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1400, month: 01, day: 03, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Nowrooz
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1400, month: 01, day: 04, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Nowrooz
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1400, month: 01, day: 09, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = NimehShabaan
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1400, month: 01, day: 12, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = RoozeJomhoori
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1400, month: 01, day: 13, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Sizdah
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1400, month: 02, day: 14, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadateHazrazteAli
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1400, month: 02, day: 23, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = EideFetr
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1400, month: 02, day: 24, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = TatilBeMonaasebateEideFetr
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1400, month: 03, day: 14, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = RehlateEmaam
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1400, month: 03, day: 15, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = PaanzdaheKhordaad
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1400, month: 03, day: 16, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadatEmaamJafar
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1400, month: 04, day: 30, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = EideGhorbaan
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1400, month: 05, day: 07, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = EideGhadir
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1400, month: 05, day: 27, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Taasooa
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1400, month: 05, day: 28, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Aashooraa
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1400, month: 07, day: 05, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Arbaein
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1400, month: 07, day: 13, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = RehlateRasool
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1400, month: 07, day: 15, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadateEmaamReza
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1400, month: 07, day: 23, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadateHazrazteAsgari
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1400, month: 08, day: 02, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = TavallodeRasool
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1400, month: 10, day: 16, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadateHazrazteZahraa
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1400, month: 11, day: 22, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = PiroozieEnghelaab
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1400, month: 11, day: 26, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = RoozePedar
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1400, month: 12, day: 10, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Mabas
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1400, month: 12, day: 27, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ValaadateHazrazteMahdi
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1400, month: 12, day: 29, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = MelliShodaneNaft
            },

            // ----------------------- سال 1401

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1401, month: 01, day: 01, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Salenow
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1401, month: 01, day: 02, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Nowrooz
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1401, month: 01, day: 03, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Nowrooz
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1401, month: 01, day: 04, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Nowrooz
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1401, month: 01, day: 12, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = RoozeJomhoori
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1401, month: 01, day: 13, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Sizdah
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1401, month: 02, day: 03, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadateHazrazteAli
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1401, month: 02, day: 13, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = EideFetr
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1401, month: 02, day: 14, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = TatilBeMonaasebateEideFetr
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1401, month: 03, day: 06, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadatEmaamJafar
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1401, month: 03, day: 14, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = RehlateEmaam
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1401, month: 03, day: 15, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = PaanzdaheKhordaad
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1401, month: 04, day: 19, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = EideGhorbaan
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1401, month: 04, day: 27, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = EideGhadir
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1401, month: 05, day: 16, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Taasooa
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1401, month: 05, day: 17, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Aashooraa
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1401, month: 06, day: 26, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Arbaein
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1401, month: 07, day: 03, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = RehlateRasool
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1401, month: 07, day: 05, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadateEmaamReza
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1401, month: 07, day: 13, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadateHazrazteAsgari
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1401, month: 07, day: 22, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = TavallodeRasool
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1401, month: 10, day: 06, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadateHazrazteZahraa
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1401, month: 11, day: 15, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = RoozePedar
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1401, month: 11, day: 22, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = PiroozieEnghelaab
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1401, month: 11, day: 29, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Mabas
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1401, month: 12, day: 17, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ValaadateHazrazteMahdi
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1401, month: 12, day: 29, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = MelliShodaneNaft
            },

            // ----------------------- سال 1402				
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1402, month: 01, day: 01, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Salenow
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1402, month: 01, day: 02, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Nowrooz
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1402, month: 01, day: 03, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Nowrooz
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1402, month: 01, day: 04, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Nowrooz
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1402, month: 01, day: 12, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = RoozeJomhoori
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1402, month: 01, day: 13, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Sizdah
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1402, month: 01, day: 23, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadateHazrazteAli
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1402, month: 02, day: 02, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = EideFetr
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1402, month: 02, day: 03, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = TatilBeMonaasebateEideFetr
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1402, month: 02, day: 26, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadatEmaamJafar
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1402, month: 03, day: 14, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = RehlateEmaam
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1402, month: 03, day: 15, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = PaanzdaheKhordaad
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1402, month: 04, day: 08, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = EideGhorbaan
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1402, month: 04, day: 16, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = EideGhadir
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1402, month: 05, day: 05, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Taasooa
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1402, month: 05, day: 06, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Aashooraa
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1402, month: 06, day: 15, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Arbaein
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1402, month: 06, day: 23, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = RehlateRasool
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1402, month: 06, day: 25, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadateEmaamReza
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1402, month: 07, day: 02, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadateHazrazteAsgari
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1402, month: 07, day: 11, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = TavallodeRasool
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1402, month: 09, day: 26, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadateHazrazteZahraa
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1402, month: 11, day: 05, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = RoozePedar
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1402, month: 11, day: 19, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Mabas
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1402, month: 11, day: 22, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = PiroozieEnghelaab
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1402, month: 12, day: 06, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ValaadateHazrazteMahdi
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1402, month: 12, day: 29, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = MelliShodaneNaft
            },

            // ----------------------- سال 1403				
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1403, month: 01, day: 01, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Salenow
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1403, month: 01, day: 02, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Nowrooz
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1403, month: 01, day: 03, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Nowrooz
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1403, month: 01, day: 04, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Nowrooz
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1403, month: 01, day: 12, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = RoozeJomhoori
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1403, month: 01, day: 13, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Sizdah + "؛ " + ShahaadateHazrazteAli
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1403, month: 01, day: 22, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = EideFetr
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1403, month: 01, day: 23, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = TatilBeMonaasebateEideFetr
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1403, month: 02, day: 15, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadatEmaamJafar
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1403, month: 03, day: 02, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahadataPresidentRaeesi
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1403, month: 03, day: 14, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = RehlateEmaam
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1403, month: 03, day: 15, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = PaanzdaheKhordaad
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1403, month: 03, day: 28, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = EideGhorbaan
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1403, month: 04, day: 05, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = EideGhadir
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1403, month: 04, day: 25, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Taasooa
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1403, month: 04, day: 26, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Aashooraa
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1403, month: 06, day: 04, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Arbaein
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1403, month: 06, day: 12, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = RehlateRasool
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1403, month: 06, day: 14, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadateEmaamReza
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1403, month: 06, day: 22, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadateHazrazteAsgari
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1403, month: 06, day: 31, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = TavallodeRasool
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1403, month: 09, day: 15, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadateHazrazteZahraa
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1403, month: 10, day: 25, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = RoozePedar
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1403, month: 11, day: 09, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Mabas
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1403, month: 11, day: 22, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = PiroozieEnghelaab
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1403, month: 11, day: 26, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ValaadateHazrazteMahdi
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1403, month: 12, day: 29, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = MelliShodaneNaft
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1403, month: 12, day: 30, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = RoozeAkhareSaal
            },

            // ----------------------- سال 1403

            // ----------------------- سال 1404				
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1404, month: 01, day: 01, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Salenow
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1404, month: 01, day: 02, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Nowrooz + "؛ " + ShahaadateHazrazteAli
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1404, month: 01, day: 03, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Nowrooz
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1404, month: 01, day: 04, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Nowrooz
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1404, month: 01, day: 11, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = EideFetr
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1404, month: 01, day: 12, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = RoozeJomhoori + "؛ " + TatilBeMonaasebateEideFetr
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1404, month: 01, day: 13, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Sizdah
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1404, month: 02, day: 04, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadatEmaamJafar
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1404, month: 03, day: 14, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = RehlateEmaam
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1404, month: 03, day: 15, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = PaanzdaheKhordaad
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1404, month: 03, day: 16, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = EideGhorbaan
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1404, month: 03, day: 24, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = EideGhadir
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1404, month: 04, day: 14, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Taasooa
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1404, month: 04, day: 15, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Aashooraa
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1404, month: 05, day: 23, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Arbaein
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1404, month: 05, day: 31, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = RehlateRasool
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1404, month: 06, day: 2, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadateEmaamReza
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1404, month: 06, day: 10, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadateHazrazteAsgari
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1404, month: 06, day: 19, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = TavallodeRasool
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1404, month: 09, day: 3, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadateHazrazteZahraa
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1404, month: 10, day: 13, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = RoozePedar
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1404, month: 10, day: 27, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = Mabas
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1404, month: 11, day: 15, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ValaadateHazrazteMahdi
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1404, month: 11, day: 22, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = PiroozieEnghelaab
            },

            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1404, month: 12, day: 20, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = ShahaadateHazrazteAli
            },
            new()
            {
                Holiday = persianCalendar.ToDateTime(year: 1404, month: 12, day: 29, hour: 0, minute: 0, second: 0,
                    millisecond: 0),
                Description = MelliShodaneNaft
            }

            // ----------------------- سال 1404				
        };

        addFridays(holidays);

        return holidays;
    }

    /// <summary>
    ///     لیست مناسبت‌های تعطیلات رسمی ایران در این روز خاص در صورت وجود
    ///     از سال 1395 تا پایان سال 1398
    /// </summary>
    /// <param name="date">تاریخ</param>
    /// <param name="convertToIranTimeZone">
    ///     اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل
    ///     می‌کند
    /// </param>
    public static IEnumerable<string>? GetHolidays(this DateTime date, bool convertToIranTimeZone = true)
    {
        if (date.Kind == DateTimeKind.Utc && convertToIranTimeZone)
        {
            date = date.ToIranTimeZoneDateTime();
        }

        var result = Instance.Where(x => x.Holiday.Year == date.Year &&
                                         x.Holiday.Month == date.Month && x.Holiday.Day == date.Day)
            .Select(x => x.Description)
            .ToList();

        return result.Count > 0 ? result : null;
    }

#if NET6_0 || NET7_0 || NET8_0 || NET9_0 || NET10_0
    /// <summary>
    ///     لیست مناسبت‌های تعطیلات رسمی ایران در این روز خاص در صورت وجود
    ///     از سال 1395 تا پایان سال 1398
    /// </summary>
    /// <param name="date">تاریخ</param>
    /// <param name="convertToIranTimeZone">
    ///     اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل
    ///     می‌کند
    /// </param>
    public static IEnumerable<string>? GetHolidays(this DateOnly date, bool convertToIranTimeZone = true)
        => date.ToDateTime().GetHolidays(convertToIranTimeZone);
#endif

    /// <summary>
    ///     لیست مناسبت‌های تعطیلات رسمی ایران در این روز خاص در صورت وجود
    ///     از سال 1395 تا پایان سال 1398
    /// </summary>
    /// <param name="date">تاریخ</param>
    /// <param name="dateTimeOffsetPart">کدام جزء این وهله مورد استفاده قرار گیرد؟</param>
    public static IEnumerable<string>? GetHolidays(this DateTimeOffset date,
        DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
    {
        var fromDt = date.GetDateTimeOffsetPart(dateTimeOffsetPart);

        return GetHolidays(fromDt);
    }

    /// <summary>
    ///     تشخیص تعطیلات رسمی ایران
    ///     از سال 1395 تا پایان سال 1398
    /// </summary>
    /// <param name="date">تاریخ</param>
    /// <param name="convertToIranTimeZone">
    ///     اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل
    ///     می‌کند
    /// </param>
    public static bool IsHoliday(this DateTime date, bool convertToIranTimeZone = true)
    {
        if (date.Kind == DateTimeKind.Utc && convertToIranTimeZone)
        {
            date = date.ToIranTimeZoneDateTime();
        }

        return Instance.Any(x => x.Holiday.Year == date.Year &&
                                 x.Holiday.Month == date.Month && x.Holiday.Day == date.Day);
    }

#if NET6_0 || NET7_0 || NET8_0 || NET9_0 || NET10_0
    /// <summary>
    ///     تشخیص تعطیلات رسمی ایران
    ///     از سال 1395 تا پایان سال 1398
    /// </summary>
    /// <param name="date">تاریخ</param>
    /// <param name="convertToIranTimeZone">
    ///     اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل
    ///     می‌کند
    /// </param>
    public static bool IsHoliday(this DateOnly date, bool convertToIranTimeZone = true)
        => date.ToDateTime().IsHoliday(convertToIranTimeZone);
#endif

    /// <summary>
    ///     تشخیص تعطیلات رسمی ایران
    ///     از سال 1395 تا پایان سال 1398
    /// </summary>
    /// <param name="date">تاریخ</param>
    /// <param name="dateTimeOffsetPart">کدام جزء این وهله مورد استفاده قرار گیرد؟</param>
    public static bool IsHoliday(this DateTimeOffset date,
        DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
    {
        var fromDt = date.GetDateTimeOffsetPart(dateTimeOffsetPart);

        return IsHoliday(fromDt);
    }

    /// <summary>
    ///     دریافت لیست روزهای کاری ایران در یک بازه زمانی
    ///     از سال 1395 تا پایان سال 1398
    /// </summary>
    /// <param name="from">از تاریخ</param>
    /// <param name="to">تا تاریخ</param>
    /// <param name="convertToIranTimeZone">
    ///     اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل
    ///     می‌کند
    /// </param>
    /// <returns>روزهای کاری</returns>
    public static IEnumerable<DateTime> GetBusinessDays(this DateTime from,
        DateTime to,
        bool convertToIranTimeZone = true)
    {
        if (from.Kind == DateTimeKind.Utc && convertToIranTimeZone)
        {
            from = from.ToIranTimeZoneDateTime();
        }

        if (to.Kind == DateTimeKind.Utc && convertToIranTimeZone)
        {
            to = to.ToIranTimeZoneDateTime();
        }

        for (var date = from; date <= to; date = date.AddDays(value: 1))
        {
            if (!date.IsHoliday())
            {
                yield return date;
            }
        }
    }

#if NET6_0 || NET7_0 || NET8_0 || NET9_0 || NET10_0
    /// <summary>
    ///     دریافت لیست روزهای کاری ایران در یک بازه زمانی
    ///     از سال 1395 تا پایان سال 1398
    /// </summary>
    /// <param name="from">از تاریخ</param>
    /// <param name="to">تا تاریخ</param>
    /// <param name="convertToIranTimeZone">
    ///     اگر تاریخ و زمان با فرمت UTC باشند، ابتدا آن‌ها را به منطقه‌ی زمانی ایران تبدیل
    ///     می‌کند
    /// </param>
    /// <returns>روزهای کاری</returns>
    public static IEnumerable<DateTime> GetBusinessDays(this DateOnly from,
        DateOnly to,
        bool convertToIranTimeZone = true)
        => from.ToDateTime().GetBusinessDays(to.ToDateTime(), convertToIranTimeZone);
#endif

    /// <summary>
    ///     دریافت لیست روزهای کاری ایران در یک بازه زمانی
    ///     از سال 1395 تا پایان سال 1398
    /// </summary>
    /// <param name="from">از تاریخ</param>
    /// <param name="to">تا تاریخ</param>
    /// <param name="dateTimeOffsetPart">کدام جزء این وهله مورد استفاده قرار گیرد؟</param>
    /// <returns>روزهای کاری</returns>
    public static IEnumerable<DateTime> GetBusinessDays(this DateTimeOffset from,
        DateTimeOffset to,
        DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
    {
        var fromDt = from.GetDateTimeOffsetPart(dateTimeOffsetPart);
        var toDt = to.GetDateTimeOffsetPart(dateTimeOffsetPart);

        return GetBusinessDays(fromDt, toDt);
    }

    /// <summary>
    ///     دریافت لیست روزهای کاری ایران در یکسال شمسی
    ///     از سال 1395 تا پایان سال 1398
    /// </summary>
    /// <param name="persianYear">سال شمسی</param>
    /// <returns>روزهای کاری</returns>
    public static IEnumerable<DateTime> GetBusinessDays(this int persianYear)
    {
        if (!(persianYear >= StartYear || persianYear <= EndYear))
        {
            throw new ArgumentOutOfRangeException(
                Invariant($"در اینجا فقط سال‌های {StartYear} تا {EndYear} پشتیبانی می‌شوند."));
        }

        var persianYearRang = persianYear.GetPersianYearStartAndEndDates();
        var from = persianYearRang.StartDate;
        var to = persianYearRang.EndDate;

        return GetBusinessDays(from, to);
    }

    /// <summary>
    ///     دریافت لیست روزهای کاری ایران در یک ماه شمسی
    ///     از سال 1395 تا پایان سال 1398
    /// </summary>
    /// <param name="persianYear">سال شمسی</param>
    /// <param name="persianMonth">ماه شمسی</param>
    /// <returns>روزهای کاری</returns>
    public static IEnumerable<DateTime> GetBusinessDays(this int persianYear, int persianMonth)
    {
        if (!(persianYear >= StartYear || persianYear <= EndYear))
        {
            throw new ArgumentOutOfRangeException(
                Invariant($"در اینجا فقط سال‌های {StartYear} تا {EndYear} پشتیبانی می‌شوند."));
        }

        var persianMonthRang = persianYear.GetPersianMonthStartAndEndDates(persianMonth);
        var from = persianMonthRang.StartDate;
        var to = persianMonthRang.EndDate;

        return GetBusinessDays(from, to);
    }

    private static void addFridays(HashSet<IranHoliday> holidays)
    {
        var from = StartYear.GetPersianYearStartAndEndDates().StartDate;
        var to = EndYear.GetPersianYearStartAndEndDates().EndDate;

        for (var date = from; date <= to; date = date.AddDays(value: 1))
        {
            if (date.DayOfWeek == DayOfWeek.Friday)
            {
                holidays.Add(new IranHoliday
                {
                    Holiday = date,
                    Description = "روز جمعه"
                });
            }
        }
    }
}