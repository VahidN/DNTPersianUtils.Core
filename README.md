DNTPersianUtils.Core
=======


<p>
  <a href="https://github.com/VahidN/DNTPersianUtils.Core">
     <img alt="GitHub Actions status" src="https://github.com/VahidN/DNTPersianUtils.Core/workflows/.NET%20Core%20Build/badge.svg">
  </a>
</p>

<div>
DNTPersianUtils.Core is a library made of additional utilities to help with Persian culture. Based on .NET Core and .NET 4.x.
For installation run the command below in Powershell with NuGet
</div>
<br \>

[![Nuget](https://img.shields.io/nuget/v/DNTPersianUtils.Core)](https://www.nuget.org/packages/DNTPersianUtils.Core/)
```
PM> Install-Package DNTPersianUtils.Core
```


Methods and Library Options
-----------------


|Method Name/Options|Example|Example Output|
| -------| :------: | :------: |
|Show input date in Farsi|dt.ToPersianDateTextify()|سه شنبه ۲۱ دی ۱۳۹۵|
|Convert date and time to Shamsi|dt.ToFriendlyPersianDateTextify()|&#x202b;۱۰ روز قبل، سه شنبه ۲۱ دی ۱۳۹۵، ساعت ۱۰:۲۰|
|Convert number to letters|1234567.NumberToText(Language.Persian)|یک میلیون و دویست و سی و چهار هزار و پانصد و شصت و هفت|
|Corrected Farsi Culture|PersianCulture.Instance <br> Thread.CurrentThread.CurrentCulture = PersianCulture.Instance;|در این فرهنگ تاریخ میلادی با شمسی جایگزین شده‌است|
|Convert Shamsi date and time to Miladi (string)|"1395/11/3 7:30".ToGregorianDateTime()|new DateTime(2017, 1, 22, 7, 30, 0)|
|Conver Shamsi date and time to Miladi|dt.ToLongPersianDateString()|&#x202b;21 دی 1395|
|Conver Shamsi date and time to Miladi|dt.ToLongPersianDateTimeString()|&#x202b;21 دی 1395، 10:20:02 ق.ظ|
|Conver Shamsi date and time to Miladi|dt.ToPersianDateTimeString("dd MMMM yyyy")|این تبدیل بر اساس فرهنگ اصلاح شده‌ی فارسی صورت می‌گیرد. مانند <br> dt.ToPersianDateTimeString("dd MMMM yyyy - HH:mm") <br> &#x202b; با این خروجی فرضی: «21 دی 1395 - 10:20»|
|Conver Shamsi date and time to Miladi|dt.ToShortPersianDateString()|1395/10/21|
|Conver Shamsi date and time to Miladi|dt.ToShortPersianDateTimeString()|1395/10/21 10:20|
|Start and end date of Shamsi year|dt.GetPersianYearStartAndEndDates()|[Example](/src/DNTPersianUtils.Core.Tests/PersianCultureTests.cs)|
|Start and end date of Shamsi month|dt.GetPersianMonthStartAndEndDates()|[Example](/src/DNTPersianUtils.Core.Tests/PersianCultureTests.cs)|
|Start and end date of Shamsi week|dt.GetPersianWeekStartAndEndDates()|[Example](/src/DNTPersianUtils.Core.Tests/PersianCultureTests.cs)|
|Convert English number to Farsi|123.ToPersianNumbers()|۱۲۳|
|Does a phrase contain Farsi?|"Abc تست".ContainsFarsi()|true|
|Use correct case of Farsi 'Y' and 'K'|"می‌شود".ApplyCorrectYeKe()|می‌شود|
|Convert written direction to right-to-left|"سلام Abc".ApplyRle()|Abc سلام|
|Calculate age|DateTime.Now.AddYears(-9).GetAge()|9|
|Is a date the start of the Shamsi year?|dt.IsStartOfNewYear()|true/false|
|Collection of neutral Farsi words| PersianStopwords.List | مفید برای تنظیمات جستجوهای تمام متنی |
|&#x202b; Normaliza text | "'تست'".[NormalizePersianText](/src/DNTPersianUtils.Core.Tests/NormalizerTests.cs)(<br>PersianNormalizers.ConvertEnglishQuotes) | «تست» |
| List Iran's provinces | Iran.Provinces | Iran.Provinces لیست تو در توی استان‌ها و شهرهای ایران |
| List Iran's holidays | Iran.Holidays | مناسبت‌های تعطیلات رسمی ایران از سال 1395 تا پایان سال 1401 |
| List business days within a range | IranHolidays.GetBusinessDays() | روزهای کاری ایران از سال 1395 تا پایان سال 1401 |
|Convert Miladi date to Lunar|new DateTime(2018, 08, 31).ToIslamicDay()|new IslamicDay(1439, 12, 19)|
|Convert Shamsi date to Lunar|IslamicDateUtils.PersianDayToIslamicDay(1397, 6, 9)|new IslamicDay(1439, 12, 19)|



Validators
-----------------


|Method's Name/Options|Examples|Example Outputs|
| -------| :------: | :------: |
|Determine validation of Shamsi date and time (string)|"1395/12/30".IsValidPersianDateTime()<br>&#x202b;به همراه [ValidPersianDateTime] مخصوص MVC|true|
| Validate national ID | "0010350829".IsValidIranianNationalCode() <br>&#x202b;به همراه [ValidIranianNationalCode] مخصوص MVC| true |
| Validate Shaba bank code | "IR820540102680020817909002".<br>IsValidIranShebaNumber() <br>&#x202b;به همراه [ValidIranShebaNumber] مخصوص MVC| true |
| Validate Shetab bank code | "6221061106498670".<br>IsValidIranShetabNumber() <br>&#x202b;به همراه [ValidIranShetabNumber] مخصوص MVC| true |
| Validate cellphone number | "09901464762".<br>IsValidIranianMobileNumber() <br>&#x202b;به همراه [ValidIranianMobileNumber] مخصوص MVC| true |
| Validate home phone number | "37236445".<br>IsValidIranianPhoneNumber() <br>&#x202b;به همراه [ValidIranianPhoneNumber] مخصوص MVC| true |
| Validate postal code | "1619735744".<br>IsValidIranianPostalCode() <br>&#x202b;به همراه [ValidIranianPostalCode] مخصوص MVC| true |
| Validate all Farsi digits | "۹۹۹۹۹".<br>ContainsOnlyPersianNumbers() <br>&#x202b;به همراه [ShouldContainOnlyPersianNumbers] مخصوص MVC| true |
| Validate Farsi letters and digits for a part of text | "Abc تست".<br>ContainsFarsi() <br>&#x202b;به همراه [ShouldContainPersianLettersOrNumbers] مخصوص MVC| true |
| Validate Farsi letters and digits for entire text | "تست".<br>ContainsOnlyFarsiLetters() <br>&#x202b;به همراه [ShouldContainOnlyPersianLetters] مخصوص MVC| true |
| Validate national birth certificate ID | "14005893875".IsValidIranianNationalLegalCode() <br>&#x202b;به همراه [ValidIranianNationalLegalCodeAttribute] مخصوص MVC| true |


Usage With Provincial Data 
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
