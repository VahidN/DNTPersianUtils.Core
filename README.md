DNTPersianUtils.Core
=======

[![DNTPersianUtils.Core](https://github.com/VahidN/DNTPersianUtils.Core/workflows/.NET%20Core%20Build/badge.svg)](https://github.com/VahidN/DNTPersianUtils.Core)

<div dir="rtl">
DNTPersianUtils.Core کتابخانه‌ای است متشکل از متدهای الحاقی کمکی جهت کار با فرهنگ فارسی، در برنامه‌های مبتنی بر NET Core. و همچنین NET 4.x.
برای نصب آن دستور ذیل را در کنسول پاورشل نیوگت اجرا کنید:
</div>

[![Nuget](https://img.shields.io/nuget/v/DNTPersianUtils.Core)](https://www.nuget.org/packages/DNTPersianUtils.Core/)
```
PM> Install-Package DNTPersianUtils.Core
```


لیست متدها و امکانات این کتابخانه
-----------------


|نام متد/امکانات|مثال|خروجی نمونه|
| -------| :------: | :------: |
|نمایش فارسی روز دریافتی|dt.ToPersianDateTextify()|سه شنبه ۲۱ دی ۱۳۹۵|
|نمایش دوستانه‌ی یک تاریخ و ساعت انگلیسی به شمسی|dt.ToFriendlyPersianDateTextify()|&#x202b;۱۰ روز قبل، سه شنبه ۲۱ دی ۱۳۹۵، ساعت ۱۰:۲۰|
|تبدیلگر عدد به حروف|1234567.NumberToText(Language.Persian)|یک میلیون و دویست و سی و چهار هزار و پانصد و شصت و هفت|
|نگارش اصلاح شده‌ی فرهنگ فارسی|PersianCulture.Instance <br> Thread.CurrentThread.CurrentCulture = PersianCulture.Instance;|در این فرهنگ تاریخ میلادی با شمسی جایگزین شده‌است|
|تبدیل تاریخ و زمان رشته‌ای شمسی به میلادی|"1395/11/3 7:30".ToGregorianDateTime()|new DateTime(2017, 1, 22, 7, 30, 0)|
|تبدیل تاریخ میلادی به شمسی|dt.ToLongPersianDateString()|&#x202b;21 دی 1395|
|تبدیل تاریخ میلادی به شمسی|dt.ToLongPersianDateTimeString()|&#x202b;21 دی 1395، 10:20:02 ق.ظ|
|تبدیل تاریخ میلادی به شمسی|dt.ToPersianDateTimeString("dd MMMM yyyy")|این تبدیل بر اساس فرهنگ اصلاح شده‌ی فارسی صورت می‌گیرد. مانند <br> dt.ToPersianDateTimeString("dd MMMM yyyy - HH:mm") <br> &#x202b; با این خروجی فرضی: «21 دی 1395 - 10:20»|
|تبدیل تاریخ میلادی به شمسی|dt.ToShortPersianDateString()|1395/10/21|
|تبدیل تاریخ میلادی به شمسی|dt.ToShortPersianDateTimeString()|1395/10/21 10:20|
|تاریخ روزهای ابتدا و انتهای سال شمسی|dt.GetPersianYearStartAndEndDates()|[مثال](/src/DNTPersianUtils.Core.Tests/PersianCultureTests.cs)|
|تاریخ روزهای ابتدا و انتهای ماه شمسی|dt.GetPersianMonthStartAndEndDates()|[مثال](/src/DNTPersianUtils.Core.Tests/PersianCultureTests.cs)|
|تاریخ روزهای ابتدا و انتهای هفته شمسی|dt.GetPersianWeekStartAndEndDates()|[مثال](/src/DNTPersianUtils.Core.Tests/PersianCultureTests.cs)|
|تبدیل عدد انگلیسی به فارسی|123.ToPersianNumbers()|۱۲۳|
|آیا عبارت مدنظر حاوی حروف فارسی است؟|"Abc تست".ContainsFarsi()|true|
|اصلاح ي و ك عربی به فارسی|"سنجاقك آبي".ApplyCorrectYeKe()|سنجاقک آبی|
|راست به چپ کردن یک متن ساده مخلوط برای نمایش در محیط‌های چپ به راست مانند فید خوان‌ها|"سلام Abc".ApplyRle()|Abc سلام|
|محاسبه سن|DateTime.Now.AddYears(-9).GetAge()|9|
|آیا تاریخ و زمان مدنظر آغاز سال نوی شمسی است؟|dt.IsStartOfNewYear()|true/false|
|مجموعه کلمات بی‌اثر زبان فارسی| PersianStopwords.List | مفید برای تنظیمات جستجوهای تمام متنی |
|&#x202b; نرمال کردن متون. پارامتر آن قابلیت ترکیب را دارد. | "'تست'".[NormalizePersianText](/src/DNTPersianUtils.Core.Tests/NormalizerTests.cs)(<br>PersianNormalizers.ConvertEnglishQuotes) | «تست» |
| لیست مناطق و استان‌ها | Iran.Provinces | Iran.Provinces لیست تو در توی استان‌ها و شهرهای ایران |
| مناسبت‌های تعطیلات رسمی ایران | Iran.Holidays | مناسبت‌های تعطیلات رسمی ایران از سال 1395 تا پایان سال 1402 |
| دریافت لیست روزهای کاری یک بازه زمانی | IranHolidays.GetBusinessDays() | روزهای کاری ایران از سال 1395 تا پایان سال 1402 |
|تبدیل تاریخ میلادی به قمری|new DateTime(2018, 08, 31).ToIslamicDay()|new IslamicDay(1439, 12, 19)|
|تبدیل تاریخ شمسی به قمری|IslamicDateUtils.PersianDayToIslamicDay(1397, 6, 9)|new IslamicDay(1439, 12, 19)|
|تبدیل ايران سيستم به يونيكد|"(‘®õø¢‘“) üî¤ðþ› é÷¬".FromIranSystemToUnicode()|"صنف جیگرکی (بادوامضاء)"|
|تبدیل يونيكد به ايران سيستم|"صنف جیگرکی (بادوامضاء)".FromUnicodeToIranSystem()|"(‘®õø¢‘“) üî¤ðþ› é÷¬"|

اعتبارسنج‌ها
-----------------


|نام متد/امکانات|مثال|خروجی نمونه|
| -------| :------: | :------: |
|تعیین اعتبار تاریخ و زمان رشته‌ای شمسی|"1395/12/30".IsValidPersianDateTime()<br>&#x202b;به همراه [ValidPersianDateTime] مخصوص MVC|true|
| بررسی اعتبار کد ملی | "0010350829".IsValidIranianNationalCode() <br>&#x202b;به همراه [ValidIranianNationalCode] مخصوص MVC| true |
| بررسی اعتبار کد بانکی شبا | "IR820540102680020817909002".<br>IsValidIranShebaNumber() <br>&#x202b;به همراه [ValidIranShebaNumber] مخصوص MVC| true |
| بررسی اعتبار کد بانکی شتاب | "6221061106498670".<br>IsValidIranShetabNumber() <br>&#x202b;به همراه [ValidIranShetabNumber] مخصوص MVC| true |
| بررسی اعتبار شماره موبایل | "09901464762".<br>IsValidIranianMobileNumber() <br>&#x202b;به همراه [ValidIranianMobileNumber] مخصوص MVC| true |
| بررسی اعتبار شماره تلفن | "37236445".<br>IsValidIranianPhoneNumber() <br>&#x202b;به همراه [ValidIranianPhoneNumber] مخصوص MVC| true |
| بررسی اعتبار کد پستی | "1619735744".<br>IsValidIranianPostalCode() <br>&#x202b;به همراه [ValidIranianPostalCode] مخصوص MVC| true |
| بررسی اعتبار اعداد تمام فارسی | "۹۹۹۹۹".<br>ContainsOnlyPersianNumbers() <br>&#x202b;به همراه [ShouldContainOnlyPersianNumbers] مخصوص MVC| true |
| بررسی اعتبار حروف و یا اعداد فارسی بودن تنها قسمتی از متن | "Abc تست".<br>ContainsFarsi() <br>&#x202b;به همراه [ShouldContainPersianLettersOrNumbers] مخصوص MVC| true |
| بررسی اعتبار حروف فارسی بودن تمام متن | "تست".<br>ContainsOnlyFarsiLetters() <br>&#x202b;به همراه [ShouldContainOnlyPersianLetters] مخصوص MVC| true |
| بررسی اعتبار شناسه ملی حقوقی | "14005893875".IsValidIranianNationalLegalCode() <br>&#x202b;به همراه [ValidIranianNationalLegalCodeAttribute] مخصوص MVC| true |


نحوه کار با اطلاعات استان‌ها
-----------------

```csharp
foreach (var province in Iran.Provinces)
{
     foreach (var county in province.Counties)
     {
          foreach (var district in county.Districts)
          {
                foreach (var city in district.Cities)
                {
                }
          }
     }
}
```

[مشاهده مستندات كامل اين كتابخانه](https://vahidn.github.io/DNTPersianUtils.Core/)