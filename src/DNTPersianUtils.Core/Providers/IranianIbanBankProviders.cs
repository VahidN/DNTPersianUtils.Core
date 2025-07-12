using System;
using System.Collections.Generic;
using System.Linq;

namespace DNTPersianUtils.Core;

/// <summary>
///     مشخصات بانك‌هاي ايراني
/// </summary>
public static class IranianIbanBankProviders
{
    /// <summary>
    ///     مشخصات بانك‌هاي ايراني
    /// </summary>
    public static IList<BankCardProvider> Items => new List<BankCardProvider>
    {
        new()
        {
            Id = "010",
            Abbreviation = "BMKR",
            FullName = "بانک مرکزی",
            ShortName = "بانک مرکزی",
            EnglishName = "Central Bank of Iran"
        },
        new()
        {
            Id = "011",
            Abbreviation = "SMIN",
            FullName = "بانک صنعت و معدن",
            ShortName = "بانک صنعت و معدن",
            EnglishName = "Bank of Industry and Mine"
        },
        new()
        {
            Id = "012",
            Abbreviation = "BKSH",
            FullName = "بانک کشاورزی",
            ShortName = "بانک کشاورزی",
            EnglishName = "Bank Keshavarzi"
        },
        new()
        {
            Id = "013",
            Abbreviation = "BMEL",
            FullName = "بانک ملت",
            ShortName = "بانک ملت",
            EnglishName = "Bank Mellat"
        },
        new()
        {
            Id = "014",
            Abbreviation = "BSEP",
            FullName = "بانک سپه",
            ShortName = "بانک سپه",
            EnglishName = "Bank Sepah"
        },
        new()
        {
            Id = "015",
            Abbreviation = "BSDR",
            FullName = "بانک صادرات ایران",
            ShortName = "بانک صادرات ایران",
            EnglishName = "Bank Saderat Iran"
        },
        new()
        {
            Id = "016",
            Abbreviation = "BTEJ",
            FullName = "بانک تجارت",
            ShortName = "بانک تجارت",
            EnglishName = "Bank Tejarat"
        },
        new()
        {
            Id = "017",
            Abbreviation = "BMEL",
            FullName = "بانک ملی ایران",
            ShortName = "بانک ملی ایران",
            EnglishName = "Bank Melli Iran"
        },
        new()
        {
            Id = "018",
            Abbreviation = "BMSK",
            FullName = "بانک مسکن",
            ShortName = "بانک مسکن",
            EnglishName = "Bank Maskan"
        },
        new()
        {
            Id = "019",
            Abbreviation = "BPST",
            FullName = "پست بانک ایران",
            ShortName = "پست بانک ایران",
            EnglishName = "Post Bank of Iran"
        },
        new()
        {
            Id = "020",
            Abbreviation = "BENI",
            FullName = "بانک اقتصاد نوین",
            ShortName = "بانک اقتصاد نوین",
            EnglishName = "Bank Eqtesad Novin"
        },
        new()
        {
            Id = "021",
            Abbreviation = "BPAR",
            FullName = "بانک پارسیان",
            ShortName = "بانک پارسیان",
            EnglishName = "Bank Parsian"
        },
        new()
        {
            Id = "022",
            Abbreviation = "BPSG",
            FullName = "بانک پاسارگاد",
            ShortName = "بانک پاسارگاد",
            EnglishName = "Bank Pasargad"
        },
        new()
        {
            Id = "023",
            Abbreviation = "BSMN",
            FullName = "بانک سامان",
            ShortName = "بانک سامان",
            EnglishName = "Bank Saman"
        },
        new()
        {
            Id = "024",
            Abbreviation = "BSIN",
            FullName = "بانک سینا",
            ShortName = "بانک سینا",
            EnglishName = "Bank Sina"
        },
        new()
        {
            Id = "025",
            Abbreviation = "BRES",
            FullName = "بانک قرض‌الحسنه رسالت",
            ShortName = "بانک قرض‌الحسنه رسالت",
            EnglishName = "Resalat Qarzolhasaneh Bank"
        },
        new()
        {
            Id = "026",
            Abbreviation = "BMHR",
            FullName = "بانک مهر ایران",
            ShortName = "بانک مهر ایران",
            EnglishName = "Mehr Iran Qarzolhasaneh Bank"
        },
        new()
        {
            Id = "027",
            Abbreviation = "BAYN",
            FullName = "بانک آینده",
            ShortName = "بانک آینده",
            EnglishName = "Bank Ayandeh"
        },
        new()
        {
            Id = "028",
            Abbreviation = "BANS",
            FullName = "بانک انصار",
            ShortName = "بانک انصار",
            EnglishName = "Bank Ansar"
        },
        new()
        {
            Id = "029",
            Abbreviation = "BKAR",
            FullName = "بانک کارآفرین",
            ShortName = "بانک کارآفرین",
            EnglishName = "Bank Karafarin"
        },
        new()
        {
            Id = "030",
            Abbreviation = "BTAO",
            FullName = "بانک توسعه تعاون",
            ShortName = "بانک توسعه تعاون",
            EnglishName = "Bank Tose’e Ta’avon"
        },
        new()
        {
            Id = "031",
            Abbreviation = "BTOS",
            FullName = "بانک توسعه صادرات",
            ShortName = "بانک توسعه صادرات",
            EnglishName = "Export Development Bank of Iran"
        },
        new()
        {
            Id = "032",
            Abbreviation = "BSHR",
            FullName = "بانک شهر",
            ShortName = "بانک شهر",
            EnglishName = "Bank Shahr"
        },
        new()
        {
            Id = "033",
            Abbreviation = "BGHA",
            FullName = "بانک قوامین",
            ShortName = "بانک قوامین",
            EnglishName = "Bank Ghavamin"
        },
        new()
        {
            Id = "034",
            Abbreviation = "BTUR",
            FullName = "بانک گردشگری",
            ShortName = "بانک گردشگری",
            EnglishName = "Tourism Bank"
        },
        new()
        {
            Id = "035",
            Abbreviation = "BIZM",
            FullName = "بانک ایران زمین",
            ShortName = "بانک ایران زمین",
            EnglishName = "Bank Iran Zamin"
        },
        new()
        {
            Id = "036",
            Abbreviation = "BASK",
            FullName = "مؤسسه اعتباری عسکریه",
            ShortName = "مؤسسه اعتباری عسکریه",
            EnglishName = "Askarieh Credit Institution"
        },
        new()
        {
            Id = "037",
            Abbreviation = "BKOS",
            FullName = "مؤسسه اعتباری کوثر",
            ShortName = "مؤسسه اعتباری کوثر",
            EnglishName = "Kosar Credit Institution"
        },
        new()
        {
            Id = "038",
            Abbreviation = "BDAY",
            FullName = "بانک دی",
            ShortName = "بانک دی",
            EnglishName = "Bank Dey"
        },
        new()
        {
            Id = "039",
            Abbreviation = "BMID",
            FullName = "بانک خاورمیانه",
            ShortName = "بانک خاورمیانه",
            EnglishName = "Middle East Bank"
        },
        new()
        {
            Id = "040",
            Abbreviation = "BSAR",
            FullName = "بانک سرمایه",
            ShortName = "بانک سرمایه",
            EnglishName = "Bank Sarmayeh"
        },
        new()
        {
            Id = "041",
            Abbreviation = "BIRV",
            FullName = "بانک ایران‌ونزوئلا",
            ShortName = "بانک ایران‌ونزوئلا",
            EnglishName = "Iran-Venezuela Bank"
        },
        new()
        {
            Id = "042",
            Abbreviation = "BNOR",
            FullName = "مؤسسه اعتباری نور",
            ShortName = "مؤسسه اعتباری نور",
            EnglishName = "Noor Credit Institution"
        },
        new()
        {
            Id = "053",
            Abbreviation = "BKAR",
            FullName = "بانک کارآفرین",
            ShortName = "بانک کارآفرین",
            EnglishName = "Bank Karafarin"
        },
        new()
        {
            Id = "054",
            Abbreviation = "BPAR",
            FullName = "بانک پارسیان",
            ShortName = "بانک پارسیان",
            EnglishName = "Bank Parsian"
        },
        new()
        {
            Id = "056",
            Abbreviation = "BSMN",
            FullName = "بانک سامان",
            ShortName = "بانک سامان",
            EnglishName = "Bank Saman"
        },
        new()
        {
            Id = "060",
            Abbreviation = "BMHR",
            FullName = "بانک مهر ایران",
            ShortName = "بانک مهر ایران",
            EnglishName = "Mehr Iran Qarzolhasaneh Bank"
        },
        new()
        {
            Id = "062",
            Abbreviation = "BAYN",
            FullName = "بانک آینده",
            ShortName = "بانک آینده",
            EnglishName = "Bank Ayandeh"
        }
    };

    /// <summary>
    ///     بر اساس iban؛ نام بانك ارائه مي‌شود
    /// </summary>
    /// <param name="iban">iban</param>
    /// <returns>نام بانك در صورت يافت شدن</returns>
    public static BankCardProvider? GetIranianBankCardProviderByIban(this string? iban)
    {
        iban = iban?.Trim();

        if (string.IsNullOrWhiteSpace(iban) || iban.Length < 7 ||
            !iban.StartsWith(value: "IR", StringComparison.OrdinalIgnoreCase))
        {
            return null;
        }

        var bankCode = iban.Substring(startIndex: 4, length: 3);

        return Items.FirstOrDefault(p => string.Equals(p.Id, bankCode, StringComparison.Ordinal));
    }
}