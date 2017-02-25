DNTPersianUtils.Core
=======
<div dir="rtl">
DNTPersianUtils.Core کتابخانه‌ای است متشکل از متدهای الحاقی کمکی جهت کار با فرهنگ فارسی، در برنامه‌های مبتنی بر NET Core.
برای نصب آن دستور ذیل را در کنسول پاورشل نیوگت اجرا کنید:
</div>

```
PM> Install-Package DNTPersianUtils.Core
```


لیست متدها و امکانات این کتابخانه
-----------------

|نام متد/امکانات|توضیحات|مثال|خروجی نمونه|
| -------| :------: | :------: |  :------: |  
|string ToPersianDateTextify(this DateTime dt)|نمایش فارسی روز دریافتی|dt.ToPersianDateTextify()|سه شنبه ۲۱ دی ۱۳۹۵|
|string ToFriendlyPersianDateTextify(this DateTime info)|نمایش دوستانه‌ی یک تاریخ و ساعت انگلیسی به شمسی|dt.ToFriendlyPersianDateTextify()|&#x202b;۱۰ روز قبل، سه شنبه ۲۱ دی ۱۳۹۵، ساعت ۱۰:۲۰|
|string NumberToText(this int number, Language language)|تبدیلگر عدد به حروف|1234567.NumberToText(Language.Persian)|یک میلیون و دویست و سی و چهار هزار و پانصد و شصت و هفت|
|PersianCulture|نگارش اصلاح شده‌ی فرهنگ فارسی|PersianCulture.Instance|در این فرهنگ تاریخ میلادی با شمسی جایگزین شده‌است|
|DateTime? ToGregorianDateTime(this string persianDateTime)|تبدیل تاریخ و زمان رشته‌ای شمسی به میلادی|"1395/11/3 7:30".ToGregorianDateTime()|new DateTime(2017, 1, 22, 7, 30, 0)|
|string ToLongPersianDateString(this DateTime dt)|تبدیل تاریخ میلادی به شمسی|dt.ToLongPersianDateString()|&#x202b;21 دی 1395|
|string ToLongPersianDateTimeString(this DateTime dt)|تبدیل تاریخ میلادی به شمسی|dt.ToLongPersianDateTimeString()|&#x202b;21 دی 1395، 10:20:02 ق.ظ|
|string ToPersianDateTimeString(this DateTime dateTime, string format)|تبدیل تاریخ میلادی به شمسی|dt.ToPersianDateTimeString("dd MMMM yyyy")|این تبدیل بر اساس فرهنگ اصلاح شده‌ی فارسی صورت می‌گیرد|
|string ToShortPersianDateString(this DateTimeOffset? dt)|تبدیل تاریخ میلادی به شمسی|dt.ToShortPersianDateString()|1395/10/21|
|string ToShortPersianDateTimeString(this DateTime dt)|تبدیل تاریخ میلادی به شمسی|dt.ToShortPersianDateTimeString()|1395/10/21 10:20|
|bool IsValidPersianDateTime(this string persianDateTime)|تعیین اعتبار تاریخ و زمان رشته‌ای شمسی|"1395/12/30".IsValidPersianDateTime()|true|
|string ToPersianNumbers(this int number, string format = "")|تبدیل عدد انگلیسی به فارسی|123.ToPersianNumbers()|۱۲۳|
|bool ContainsFarsi(this string txt)|آیا عبارت مدنظر حاوی حروف فارسی است؟|"Abc تست".ContainsFarsi()|true|
|string ApplyCorrectYeKe(this string data)|اصلاح ی و ک عربی به فارسی|"می‌شود".ApplyCorrectYeKe()|می‌شود|
|int GetAge(this DateTime birthday)|محاسبه سن|DateTime.Now.AddYears(-9).GetAge()|9|
|bool IsStartOfNewYear(this DateTime now, double utcDelta = 3.5)|آیا تاریخ و زمان مدنظر آغاز سال نوی شمسی است؟|dt.IsStartOfNewYear()|true/false|
|PersianStopwords|مجموعه کلمات بی‌اثر زبان فارسی| PersianStopwords.List | مفید برای تنظیمات جستجوهای تمام متنی |
|string NormalizePersianText(this string text, PersianNormalizers normalizers)|&#x202b; نرمال کردن متون. پارامتر آن قابلیت ترکیب را دارد. | "'تست'".NormalizePersianText(PersianNormalizers.ConvertEnglishQuotes) | «تست» |
|Iran| لیست مناطق و استان‌ها | Iran.Provinces | Iran.Provinces لیست تو در توی استان‌ها و شهرهای ایران |