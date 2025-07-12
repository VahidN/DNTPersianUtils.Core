using System;
using System.Collections.Generic;
using System.Linq;

namespace DNTPersianUtils.Core;

/// <summary>
///     مشخصات بانك‌هاي ايراني
/// </summary>
public static class IranianBankCardProviders
{
    /// <summary>
    ///     مشخصات بانك‌هاي ايراني
    /// </summary>
    public static IList<BankCardProvider> Items => new List<BankCardProvider>
    {
        new()
        {
            Id = "603799",
            Abbreviation = "BMEL",
            FullName = "بانک ملی ایران",
            ShortName = "بانک ملی",
            EnglishName = "Bank Melli Iran"
        },
        new()
        {
            Id = "455379",
            Abbreviation = "BMEL",
            FullName = "بانک ملی ایران",
            ShortName = "بانک ملی",
            EnglishName = "Bank Melli Iran"
        },
        new()
        {
            Id = "440796",
            Abbreviation = "BSDR",
            FullName = "بانک صادرات ایران",
            ShortName = "بانک صادرات",
            EnglishName = "Bank Saderat Iran"
        },
        new()
        {
            Id = "610433",
            Abbreviation = "BMEL",
            FullName = "بانک ملت",
            ShortName = "بانک ملت",
            EnglishName = "Bank Mellat"
        },
        new()
        {
            Id = "589210",
            Abbreviation = "BSEP",
            FullName = "بانک سپه",
            ShortName = "بانک سپه",
            EnglishName = "Bank Sepah"
        },
        new()
        {
            Id = "603769",
            Abbreviation = "BSDR",
            FullName = "بانک صادرات ایران",
            ShortName = "بانک صادرات",
            EnglishName = "Bank Saderat Iran"
        },
        new()
        {
            Id = "636795",
            Abbreviation = "MARK",
            FullName = "بانک مرکزی جمهوری اسلامی ایران",
            ShortName = "بانک مرکزی",
            EnglishName = "Central Bank of Iran"
        },
        new()
        {
            Id = "627961",
            Abbreviation = "SMIN",
            FullName = "بانک صنعت و معدن",
            ShortName = "بانک صنعت و معدن",
            EnglishName = "Bank of Industry and Mine"
        },
        new()
        {
            Id = "627648",
            Abbreviation = "BTOS",
            FullName = "بانک توسعه صادرات ایران",
            ShortName = "بانک توسعه صادرات",
            EnglishName = "Export Development Bank"
        },
        new()
        {
            Id = "589463",
            Abbreviation = "BRFW",
            FullName = "بانک رفاه کارگران",
            ShortName = "بانک رفاه",
            EnglishName = "Bank Refah"
        },
        new()
        {
            Id = "628023",
            Abbreviation = "BMSK",
            FullName = "بانک مسکن",
            ShortName = "بانک مسکن",
            EnglishName = "Bank Maskan"
        },
        new()
        {
            Id = "603770",
            Abbreviation = "BKSH",
            FullName = "بانک کشاورزی",
            ShortName = "بانک کشاورزی",
            EnglishName = "Bank Keshavarzi"
        },
        new()
        {
            Id = "627353",
            Abbreviation = "BTEJ",
            FullName = "بانک تجارت",
            ShortName = "بانک تجارت",
            EnglishName = "Bank Tejarat"
        },
        new()
        {
            Id = "585983",
            Abbreviation = "BTEJ",
            FullName = "بانک تجارت",
            ShortName = "بانک تجارت",
            EnglishName = "Bank Tejarat"
        },
        new()
        {
            Id = "627760",
            Abbreviation = "BPST",
            FullName = "پست بانک ایران",
            ShortName = "پست بانک",
            EnglishName = "Post Bank"
        },
        new()
        {
            Id = "502908",
            Abbreviation = "BTAO",
            FullName = "بانک توسعه تعاون",
            ShortName = "بانک توسعه تعاون",
            EnglishName = "Cooperative Development Bank"
        },
        new()
        {
            Id = "628157",
            Abbreviation = "TDEV",
            FullName = "موسسه اعتباری توسعه",
            ShortName = "مؤسسه توسعه",
            EnglishName = "Tose'e Credit Institution"
        },
        new()
        {
            Id = "627488",
            Abbreviation = "BKAR",
            FullName = "بانک کارآفرین",
            ShortName = "بانک کارآفرین",
            EnglishName = "Karafarin Bank"
        },
        new()
        {
            Id = "622106",
            Abbreviation = "BPAR",
            FullName = "بانک پارسیان",
            ShortName = "بانک پارسیان",
            EnglishName = "Parsian Bank"
        },
        new()
        {
            Id = "627412",
            Abbreviation = "BENI",
            FullName = "بانک اقتصاد نوین",
            ShortName = "بانک اقتصاد نوین",
            EnglishName = "Eghtesad Novin Bank"
        },
        new()
        {
            Id = "621986",
            Abbreviation = "BSMN",
            FullName = "بانک سامان",
            ShortName = "بانک سامان",
            EnglishName = "Saman Bank"
        },
        new()
        {
            Id = "502229",
            Abbreviation = "BPSG",
            FullName = "بانک پاسارگاد",
            ShortName = "بانک پاسارگاد",
            EnglishName = "Pasargad Bank"
        },
        new()
        {
            Id = "639607",
            Abbreviation = "BSAR",
            FullName = "بانک سرمایه",
            ShortName = "بانک سرمایه",
            EnglishName = "Sarmayeh Bank"
        },
        new()
        {
            Id = "639346",
            Abbreviation = "BSIN",
            FullName = "بانک سینا",
            ShortName = "بانک سینا",
            EnglishName = "Sina Bank"
        },
        new()
        {
            Id = "606373",
            Abbreviation = "BMHR",
            FullName = "بانک قرض‌الحسنه مهر ایران",
            ShortName = "بانک مهر ایران",
            EnglishName = "Mehr Iran Bank"
        },
        new()
        {
            Id = "504706",
            Abbreviation = "BSHR",
            FullName = "بانک شهر",
            ShortName = "بانک شهر",
            EnglishName = "Shahr Bank"
        },
        new()
        {
            Id = "636214",
            Abbreviation = "BAYN",
            FullName = "بانک آینده",
            ShortName = "بانک آینده",
            EnglishName = "Ayandeh Bank"
        },
        new()
        {
            Id = "627381",
            Abbreviation = "BANS",
            FullName = "بانک انصار",
            ShortName = "بانک انصار",
            EnglishName = "Ansar Bank"
        },
        new()
        {
            Id = "505416",
            Abbreviation = "BTUR",
            FullName = "بانک گردشگری",
            ShortName = "بانک گردشگری",
            EnglishName = "Tourism Bank"
        },
        new()
        {
            Id = "502938",
            Abbreviation = "BDAY",
            FullName = "بانک دی",
            ShortName = "بانک دی",
            EnglishName = "Day Bank"
        },
        new()
        {
            Id = "505785",
            Abbreviation = "BIZM",
            FullName = "بانک ایران زمین",
            ShortName = "بانک ایران زمین",
            EnglishName = "Iran Zamin Bank"
        },
        new()
        {
            Id = "504172",
            Abbreviation = "BRES",
            FullName = "بانک قرض‌الحسنه رسالت",
            ShortName = "بانک رسالت",
            EnglishName = "Resalat Qarz al-Hasaneh Bank"
        },
        new()
        {
            Id = "505809",
            Abbreviation = "BMID",
            FullName = "بانک خاورمیانه",
            ShortName = "بانک خاورمیانه",
            EnglishName = "Middle East Bank"
        },
        new()
        {
            Id = "639599",
            Abbreviation = "BGHA",
            FullName = "بانک قوامین",
            ShortName = "بانک قوامین",
            EnglishName = "Ghavamin Bank"
        },
        new()
        {
            Id = "505801",
            Abbreviation = "BKOS",
            FullName = "مؤسسه کوثر",
            ShortName = "مؤسسه کوثر",
            EnglishName = "Kosar Credit Institution"
        },
        new()
        {
            Id = "606256",
            Abbreviation = "BASK",
            FullName = "مؤسسه عسگریه",
            ShortName = "مؤسسه عسگریه",
            EnglishName = "Asgariyeh Credit Institution"
        },
        new()
        {
            Id = "581874",
            Abbreviation = "BIRV",
            FullName = "بانک ایران‌ونزوئلا",
            ShortName = "بانک ایران ونزوئلا",
            EnglishName = "Iran-Venezuela Bank"
        },
        new()
        {
            Id = "507677",
            Abbreviation = "BNOR",
            FullName = "مؤسسه نور",
            ShortName = "مؤسسه نور",
            EnglishName = "Noor Credit Institution"
        },
        new()
        {
            Id = "636949",
            Abbreviation = "BHKM",
            FullName = "بانک حکمت ایرانیان",
            ShortName = "بانک حکمت ایرانیان",
            EnglishName = "Hekmat Iranian Bank"
        },
        new()
        {
            Id = "504944",
            Abbreviation = "BMEQ",
            FullName = "بانک مهر اقتصاد",
            ShortName = "بانک مهر اقتصاد",
            EnglishName = "Mehr Eqtesad Bank"
        }
    };

    /// <summary>
    ///     بر اساس شماره كارت بانكي؛ نام بانك ارائه مي‌شود
    /// </summary>
    /// <param name="cardNumber">شماره كارت بانكي</param>
    /// <returns>نام بانك در صورت يافت شدن</returns>
    public static BankCardProvider? GetIranianBankCardProvider(this string? cardNumber)
    {
        cardNumber = cardNumber?.Trim();

        if (string.IsNullOrWhiteSpace(cardNumber) || cardNumber.Length < 6)
        {
            return null;
        }

        var bin = cardNumber.Substring(startIndex: 0, length: 6);

        return Items.FirstOrDefault(p => string.Equals(p.Id, bin, StringComparison.Ordinal));
    }
}