using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace DNTPersianUtils.Core.IranCities
{
    /// <summary>
    /// Iran's Cities.
    /// </summary>
    public static class Iran
    {
        /// <summary>
        /// Iran's Cities.
        /// </summary>
        public static ISet<City> Cities = new HashSet<City>(new List<City>
        {
          new City{
            ProvinceName= "همدان",
            CountyName= "همدان",
            DistrictName= "مرکزی",
            CityName= "همدان",
            CityDivisionCode= 70001
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "تبریز",
            DistrictName= "مرکزی",
            CityName= "تبریز",
            CityDivisionCode= 70002
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "مشهد",
            DistrictName= "مرکزی",
            CityName= "مشهد",
            CityDivisionCode= 70003
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "آستارا",
            DistrictName= "مرکزی",
            CityName= "آستارا",
            CityDivisionCode= 70004
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "دزفول",
            DistrictName= "مرکزی",
            CityName= "دزفول",
            CityDivisionCode= 70005
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "مراغه",
            DistrictName= "مرکزی",
            CityName= "مراغه",
            CityDivisionCode= 70006
          },
          new City{
            ProvinceName= "آذربایجان غربی",
            CountyName= "ماکو",
            DistrictName= "مرکزی",
            CityName= "ماکو",
            CityDivisionCode= 70007
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "کرمان",
            DistrictName= "مرکزی",
            CityName= "کرمان",
            CityDivisionCode= 70008
          },
          new City{
            ProvinceName= "بوشهر",
            CountyName= "بوشهر",
            DistrictName= "مرکزی",
            CityName= "بوشهر",
            CityDivisionCode= 70009
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "بندر انزلی",
            DistrictName= "مرکزی",
            CityName= "بندر انزلی",
            CityDivisionCode= 70010
          },
          new City{
            ProvinceName= "آذربایجان غربی",
            CountyName= "خوی",
            DistrictName= "مرکزی",
            CityName= "خوی",
            CityDivisionCode= 70011
          },
          new City{
            ProvinceName= "تهران",
            CountyName= "فیروز کوه",
            DistrictName= "مرکزی",
            CityName= "فیروزکوه",
            CityDivisionCode= 70012
          },
          new City{
            ProvinceName= "زنجان",
            CountyName= "زنجان",
            DistrictName= "مرکزی",
            CityName= "زنجان",
            CityDivisionCode= 70013
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "آبادان",
            DistrictName= "مرکزی",
            CityName= "آبادان",
            CityDivisionCode= 70014
          },
          new City{
            ProvinceName= "قزوین",
            CountyName= "قزوین",
            DistrictName= "مرکزی",
            CityName= "قزوین",
            CityDivisionCode= 70015
          },
          new City{
            ProvinceName= "اردبیل",
            CountyName= "اردبیل",
            DistrictName= "مرکزی",
            CityName= "اردبیل",
            CityDivisionCode= 70016
          },
          new City{
            ProvinceName= "تهران",
            CountyName= "تهران",
            DistrictName= "مرکزی",
            CityName= "تهران",
            CityDivisionCode= 70017
          },
          new City{
            ProvinceName= "خراسان جنوبی",
            CountyName= "فردوس",
            DistrictName= "مرکزی",
            CityName= "فردوس",
            CityDivisionCode= 70018
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "قوچان",
            DistrictName= "مرکزی",
            CityName= "قوچان",
            CityDivisionCode= 70019
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "اهواز",
            DistrictName= "مرکزی",
            CityName= "اهواز",
            CityDivisionCode= 70020
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "خرمشهر",
            DistrictName= "مرکزی",
            CityName= "خرمشهر",
            CityDivisionCode= 70021
          },
          new City{
            ProvinceName= "سمنان",
            CountyName= "سمنان",
            DistrictName= "مرکزی",
            CityName= "سمنان",
            CityDivisionCode= 70022
          },
          new City{
            ProvinceName= "سمنان",
            CountyName= "شاهرود",
            DistrictName= "مرکزی",
            CityName= "شاهرود",
            CityDivisionCode= 70023
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "آباده",
            DistrictName= "مرکزی",
            CityName= "آباده",
            CityDivisionCode= 70024
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "جهرم",
            DistrictName= "مرکزی",
            CityName= "جهرم",
            CityDivisionCode= 70025
          },
          new City{
            ProvinceName= "گلستان",
            CountyName= "گرگان",
            DistrictName= "مرکزی",
            CityName= "گرگان",
            CityDivisionCode= 70026
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "رشت",
            DistrictName= "مرکزی",
            CityName= "رشت",
            CityDivisionCode= 70027
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "لنگرود",
            DistrictName= "مرکزی",
            CityName= "لنگرود",
            CityDivisionCode= 70028
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "محمود آباد",
            DistrictName= "مرکزی",
            CityName= "محمود آباد",
            CityDivisionCode= 70029
          },
          new City{
            ProvinceName= "هرمزگان",
            CountyName= "بندرعباس",
            DistrictName= "مرکزی",
            CityName= "بندر عباس",
            CityDivisionCode= 70030
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "آذرشهر",
            DistrictName= "حومه",
            CityName= "آذرشهر",
            CityDivisionCode= 70031
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "فسا",
            DistrictName= "مرکزی",
            CityName= "فسا",
            CityDivisionCode= 70032
          },
          new City{
            ProvinceName= "قم",
            CountyName= "قم",
            DistrictName= "مرکزی",
            CityName= "قم",
            CityDivisionCode= 70033
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "رودسر",
            DistrictName= "مرکزی",
            CityName= "رودسر",
            CityDivisionCode= 70034
          },
          new City{
            ProvinceName= "یزد",
            CountyName= "یزد",
            DistrictName= "مرکزی",
            CityName= "یزد",
            CityDivisionCode= 70035
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "گلپایگان",
            DistrictName= "مرکزی",
            CityName= "گلپایگان",
            CityDivisionCode= 70036
          },
          new City{
            ProvinceName= "خراسان شمالی",
            CountyName= "شیروان",
            DistrictName= "مرکزی",
            CityName= "شیروان",
            CityDivisionCode= 70037
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "شوشتر",
            DistrictName= "مرکزی",
            CityName= "شوشتر",
            CityDivisionCode= 70038
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "بابلسر",
            DistrictName= "مرکزی",
            CityName= "بابلسر",
            CityDivisionCode= 70039
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "ساری",
            DistrictName= "مرکزی",
            CityName= "ساری",
            CityDivisionCode= 70040
          },
          new City{
            ProvinceName= "مرکزی",
            CountyName= "اراک",
            DistrictName= "مرکزی",
            CityName= "اراک",
            CityDivisionCode= 70041
          },
          new City{
            ProvinceName= "همدان",
            CountyName= "نهاوند",
            DistrictName= "مرکزی",
            CityName= "نهاوند",
            CityDivisionCode= 70042
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "شبستر",
            DistrictName= "مرکزی",
            CityName= "شبستر",
            CityDivisionCode= 70043
          },
          new City{
            ProvinceName= "آذربایجان غربی",
            CountyName= "ارومیه",
            DistrictName= "مرکزی",
            CityName= "ارومیه",
            CityDivisionCode= 70044
          },
          new City{
            ProvinceName= "آذربایجان غربی",
            CountyName= "تکاب",
            DistrictName= "مرکزی",
            CityName= "تکاب",
            CityDivisionCode= 70045
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "اصفهان",
            DistrictName= "مرکزی",
            CityName= "اصفهان",
            CityDivisionCode= 70046
          },
          new City{
            ProvinceName= "بوشهر",
            CountyName= "دشتستان",
            DistrictName= "مرکزی",
            CityName= "برازجان",
            CityDivisionCode= 70047
          },
          new City{
            ProvinceName= "خراسان جنوبی",
            CountyName= "بیرجند",
            DistrictName= "مرکزی",
            CityName= "بیرجند",
            CityDivisionCode= 70048
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "تربت حیدریه",
            DistrictName= "مرکزی",
            CityName= "تربت حیدریه",
            CityDivisionCode= 70049
          },
          new City{
            ProvinceName= "زنجان",
            CountyName= "ابهر",
            DistrictName= "مرکزی",
            CityName= "ابهر",
            CityDivisionCode= 70050
          },
          new City{
            ProvinceName= "سیستان و بلوچستان",
            CountyName= "زابل",
            DistrictName= "مرکزی",
            CityName= "زابل",
            CityDivisionCode= 70051
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "استهبان",
            DistrictName= "مرکزی",
            CityName= "استهبان",
            CityDivisionCode= 70052
          },
          new City{
            ProvinceName= "کردستان",
            CountyName= "سنندج",
            DistrictName= "مرکزی",
            CityName= "سنندج",
            CityDivisionCode= 70053
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "فومن",
            DistrictName= "مرکزی",
            CityName= "فومن",
            CityDivisionCode= 70054
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "لاهیجان",
            DistrictName= "مرکزی",
            CityName= "لاهیجان",
            CityDivisionCode= 70055
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "بهشهر",
            DistrictName= "مرکزی",
            CityName= "بهشهر",
            CityDivisionCode= 70056
          },
          new City{
            ProvinceName= "مرکزی",
            CountyName= "محلات",
            DistrictName= "مرکزی",
            CityName= "محلات",
            CityDivisionCode= 70057
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "مرند",
            DistrictName= "مرکزی",
            CityName= "مرند",
            CityDivisionCode= 70058
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "شهرضا",
            DistrictName= "مرکزی",
            CityName= "شهرضا",
            CityDivisionCode= 70059
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "قوچان",
            DistrictName= "باجگیران",
            CityName= "باجگیران",
            CityDivisionCode= 70060
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "کاشمر",
            DistrictName= "مرکزی",
            CityName= "کاشمر",
            CityDivisionCode= 70061
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "رشت",
            DistrictName= "سنگر",
            CityName= "سنگر",
            CityDivisionCode= 70062
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "رشت",
            DistrictName= "کوچصفهان",
            CityName= "کوچصفهان",
            CityDivisionCode= 70063
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "سیاهکل",
            DistrictName= "مرکزی",
            CityName= "سیاهکل",
            CityDivisionCode= 70064
          },
          new City{
            ProvinceName= "مرکزی",
            CountyName= "آشتیان",
            DistrictName= "مرکزی",
            CityName= "آشتیان",
            CityDivisionCode= 70065
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "بناب",
            DistrictName= "مرکزی",
            CityName= "بناب",
            CityDivisionCode= 70066
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "خوانسار",
            DistrictName= "مرکزی",
            CityName= "خوانسار",
            CityDivisionCode= 70067
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "کاشان",
            DistrictName= "مرکزی",
            CityName= "کاشان",
            CityDivisionCode= 70068
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "شادگان",
            DistrictName= "مرکزی",
            CityName= "شادگان",
            CityDivisionCode= 70069
          },
          new City{
            ProvinceName= "سمنان",
            CountyName= "دامغان",
            DistrictName= "مرکزی",
            CityName= "دامغان",
            CityDivisionCode= 70070
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "داراب",
            DistrictName= "مرکزی",
            CityName= "داراب",
            CityDivisionCode= 70071
          },
          new City{
            ProvinceName= "کرمانشاه",
            CountyName= "دالاهو",
            DistrictName= "مرکزی",
            CityName= "کرند غرب",
            CityDivisionCode= 70072
          },
          new City{
            ProvinceName= "کرمانشاه",
            CountyName= "سنقر",
            DistrictName= "مرکزی",
            CityName= "سنقر",
            CityDivisionCode= 70073
          },
          new City{
            ProvinceName= "کرمانشاه",
            CountyName= "صحنه",
            DistrictName= "مرکزی",
            CityName= "صحنه",
            CityDivisionCode= 70074
          },
          new City{
            ProvinceName= "کرمانشاه",
            CountyName= "کرمانشاه",
            DistrictName= "مرکزی",
            CityName= "کرمانشاه",
            CityDivisionCode= 70075
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "آستانه اشرفیه",
            DistrictName= "کیاشهر",
            CityName= "کیاشهر",
            CityDivisionCode= 70076
          },
          new City{
            ProvinceName= "آذربایجان غربی",
            CountyName= "مهاباد",
            DistrictName= "مرکزی",
            CityName= "مهاباد",
            CityDivisionCode= 70077
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "نجف آباد",
            DistrictName= "مرکزی",
            CityName= "نجف آباد",
            CityDivisionCode= 70078
          },
          new City{
            ProvinceName= "چهار محال و بختیاری",
            CountyName= "شهر کرد",
            DistrictName= "مرکزی",
            CityName= "شهرکرد",
            CityDivisionCode= 70079
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "نیشابور",
            DistrictName= "مرکزی",
            CityName= "نیشابور",
            CityDivisionCode= 70080
          },
          new City{
            ProvinceName= "خراسان شمالی",
            CountyName= "بجنورد",
            DistrictName= "مرکزی",
            CityName= "بجنورد",
            CityDivisionCode= 70081
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "رامهرمز",
            DistrictName= "مرکزی",
            CityName= "رامهرمز",
            CityDivisionCode= 70082
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "کازرون",
            DistrictName= "مرکزی",
            CityName= "کازرون",
            CityDivisionCode= 70083
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "نی ریز",
            DistrictName= "مرکزی",
            CityName= "نی ریز",
            CityDivisionCode= 70084
          },
          new City{
            ProvinceName= "کرمانشاه",
            CountyName= "قصر شیرین",
            DistrictName= "مرکزی",
            CityName= "قصر شیرین",
            CityDivisionCode= 70085
          },
          new City{
            ProvinceName= "گلستان",
            CountyName= "بندر گز",
            DistrictName= "مرکزی",
            CityName= "بندر گز",
            CityDivisionCode= 70086
          },
          new City{
            ProvinceName= "گلستان",
            CountyName= "گمیشان",
            DistrictName= "مرکزی",
            CityName= "گمیش تپه",
            CityDivisionCode= 70087
          },
          new City{
            ProvinceName= "لرستان",
            CountyName= "خرم آباد",
            DistrictName= "مرکزی",
            CityName= "خرم آباد",
            CityDivisionCode= 70088
          },
          new City{
            ProvinceName= "مرکزی",
            CountyName= "ساوه",
            DistrictName= "مرکزی",
            CityName= "ساوه",
            CityDivisionCode= 70089
          },
          new City{
            ProvinceName= "همدان",
            CountyName= "اسد آباد",
            DistrictName= "مرکزی",
            CityName= "اسد آباد",
            CityDivisionCode= 70090
          },
          new City{
            ProvinceName= "همدان",
            CountyName= "تویسرکان",
            DistrictName= "مرکزی",
            CityName= "تویسرکان",
            CityDivisionCode= 70091
          },
          new City{
            ProvinceName= "خراسان جنوبی",
            CountyName= "طبس",
            DistrictName= "مرکزی",
            CityName= "طبس",
            CityDivisionCode= 70092
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "اسکو",
            DistrictName= "مرکزی",
            CityName= "اسکو",
            CityDivisionCode= 70093
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "خمینی شهر",
            DistrictName= "مرکزی",
            CityName= "خمینی شهر",
            CityDivisionCode= 70094
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "تربت جام",
            DistrictName= "مرکزی",
            CityName= "تربت جام",
            CityDivisionCode= 70095
          },
          new City{
            ProvinceName= "گلستان",
            CountyName= "ترکمن",
            DistrictName= "مرکزی",
            CityName= "بندر ترکمن",
            CityDivisionCode= 70096
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "رودبار",
            DistrictName= "مرکزی",
            CityName= "رودبار",
            CityDivisionCode= 70097
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "نائین",
            DistrictName= "مرکزی",
            CityName= "نائین",
            CityDivisionCode= 70098
          },
          new City{
            ProvinceName= "چهار محال و بختیاری",
            CountyName= "بروجن",
            DistrictName= "مرکزی",
            CityName= "بروجن",
            CityDivisionCode= 70099
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "آمل",
            DistrictName= "مرکزی",
            CityName= "آمل",
            CityDivisionCode= 70100
          },
          new City{
            ProvinceName= "یزد",
            CountyName= "اردکان",
            DistrictName= "مرکزی",
            CityName= "اردکان",
            CityDivisionCode= 70101
          },
          new City{
            ProvinceName= "البرز",
            CountyName= "کرج",
            DistrictName= "مرکزی",
            CityName= "کرج",
            CityDivisionCode= 70102
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "بهبهان",
            DistrictName= "مرکزی",
            CityName= "بهبهان",
            CityDivisionCode= 70103
          },
          new City{
            ProvinceName= "گلستان",
            CountyName= "گنبد کاووس",
            DistrictName= "مرکزی",
            CityName= "گنبدکاووس",
            CityDivisionCode= 70104
          },
          new City{
            ProvinceName= "همدان",
            CountyName= "ملایر",
            DistrictName= "مرکزی",
            CityName= "ملایر",
            CityDivisionCode= 70105
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "سراب",
            DistrictName= "مرکزی",
            CityName= "سراب",
            CityDivisionCode= 70106
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "شبستر",
            DistrictName= "مرکزی",
            CityName= "خامنه",
            CityDivisionCode= 70107
          },
          new City{
            ProvinceName= "آذربایجان غربی",
            CountyName= "میاندوآب",
            DistrictName= "مرکزی",
            CityName= "میاندوآب",
            CityDivisionCode= 70108
          },
          new City{
            ProvinceName= "تهران",
            CountyName= "دماوند",
            DistrictName= "مرکزی",
            CityName= "دماوند",
            CityDivisionCode= 70109
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "خواف",
            DistrictName= "مرکزی",
            CityName= "خواف",
            CityDivisionCode= 70110
          },
          new City{
            ProvinceName= "سمنان",
            CountyName= "مهدی شهر",
            DistrictName= "مرکزی",
            CityName= "مهدی شهر",
            CityDivisionCode= 70111
          },
          new City{
            ProvinceName= "کردستان",
            CountyName= "سقز",
            DistrictName= "مرکزی",
            CityName= "سقز",
            CityDivisionCode= 70112
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "بم",
            DistrictName= "مرکزی",
            CityName= "بم",
            CityDivisionCode= 70113
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "رفسنجان",
            DistrictName= "مرکزی",
            CityName= "رفسنجان",
            CityDivisionCode= 70114
          },
          new City{
            ProvinceName= "لرستان",
            CountyName= "الیگودرز",
            DistrictName= "مرکزی",
            CityName= "الیگودرز",
            CityDivisionCode= 70115
          },
          new City{
            ProvinceName= "لرستان",
            CountyName= "بروجرد",
            DistrictName= "مرکزی",
            CityName= "بروجرد",
            CityDivisionCode= 70116
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "قائم شهر",
            DistrictName= "مرکزی",
            CityName= "قائم شهر",
            CityDivisionCode= 70117
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "نوشهر",
            DistrictName= "مرکزی",
            CityName= "نوشهر",
            CityDivisionCode= 70118
          },
          new City{
            ProvinceName= "هرمزگان",
            CountyName= "بندرلنگه",
            DistrictName= "مرکزی",
            CityName= "بندر لنگه",
            CityDivisionCode= 70119
          },
          new City{
            ProvinceName= "یزد",
            CountyName= "ابرکوه",
            DistrictName= "مرکزی",
            CityName= "ابرکوه",
            CityDivisionCode= 70120
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "میانه",
            DistrictName= "مرکزی",
            CityName= "میانه",
            CityDivisionCode= 70121
          },
          new City{
            ProvinceName= "اردبیل",
            CountyName= "مشگین شهر",
            DistrictName= "مرکزی",
            CityName= "مشگین شهر",
            CityDivisionCode= 70122
          },
          new City{
            ProvinceName= "ایلام",
            CountyName= "ایلام",
            DistrictName= "مرکزی",
            CityName= "ایلام",
            CityDivisionCode= 70123
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "سبزوار",
            DistrictName= "مرکزی",
            CityName= "سبزوار",
            CityDivisionCode= 70124
          },
          new City{
            ProvinceName= "کردستان",
            CountyName= "بیجار",
            DistrictName= "مرکزی",
            CityName= "بیجار",
            CityDivisionCode= 70125
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "سیرجان",
            DistrictName= "مرکزی",
            CityName= "سیرجان",
            CityDivisionCode= 70126
          },
          new City{
            ProvinceName= "کرمانشاه",
            CountyName= "اسلام آباد غرب",
            DistrictName= "مرکزی",
            CityName= "اسلام آباد غرب",
            CityDivisionCode= 70127
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "عجب شیر",
            DistrictName= "مرکزی",
            CityName= "عجب شیر",
            CityDivisionCode= 70128
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "اردستان",
            DistrictName= "مرکزی",
            CityName= "اردستان",
            CityDivisionCode= 70129
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "فریمان",
            DistrictName= "مرکزی",
            CityName= "فریمان",
            CityDivisionCode= 70130
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "گناباد",
            DistrictName= "مرکزی",
            CityName= "گناباد",
            CityDivisionCode= 70131
          },
          new City{
            ProvinceName= "خراسان شمالی",
            CountyName= "اسفراین",
            DistrictName= "مرکزی",
            CityName= "اسفراین",
            CityDivisionCode= 70132
          },
          new City{
            ProvinceName= "زنجان",
            CountyName= "خرمدره",
            DistrictName= "مرکزی",
            CityName= "خرمدره",
            CityDivisionCode= 70133
          },
          new City{
            ProvinceName= "سمنان",
            CountyName= "گرمسار",
            DistrictName= "مرکزی",
            CityName= "گرمسار",
            CityDivisionCode= 70134
          },
          new City{
            ProvinceName= "کرمانشاه",
            CountyName= "هرسین",
            DistrictName= "مرکزی",
            CityName= "هرسین",
            CityDivisionCode= 70135
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "فریدونکنار",
            DistrictName= "مرکزی",
            CityName= "فریدونکنار",
            CityDivisionCode= 70136
          },
          new City{
            ProvinceName= "مرکزی",
            CountyName= "دلیجان",
            DistrictName= "مرکزی",
            CityName= "دلیجان",
            CityDivisionCode= 70137
          },
          new City{
            ProvinceName= "هرمزگان",
            CountyName= "میناب",
            DistrictName= "مرکزی",
            CityName= "میناب",
            CityDivisionCode= 70138
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "نطنز",
            DistrictName= "مرکزی",
            CityName= "نظنز",
            CityDivisionCode= 70139
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "بجستان",
            DistrictName= "مرکزی",
            CityName= "بجستان",
            CityDivisionCode= 70140
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "دشت آزادگان",
            DistrictName= "مرکزی",
            CityName= "سوسنگرد",
            CityDivisionCode= 70141
          },
          new City{
            ProvinceName= "سیستان و بلوچستان",
            CountyName= "زاهدان",
            DistrictName= "مرکزی",
            CityName= "زاهدان",
            CityDivisionCode= 70142
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "اقلید",
            DistrictName= "مرکزی",
            CityName= "اقلید",
            CityDivisionCode= 70143
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "لارستان",
            DistrictName= "مرکزی",
            CityName= "لار",
            CityDivisionCode= 70144
          },
          new City{
            ProvinceName= "آذربایجان غربی",
            CountyName= "شاهین دژ",
            DistrictName= "مرکزی",
            CityName= "شاهین دژ",
            CityDivisionCode= 70145
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "رشتخوار",
            DistrictName= "مرکزی",
            CityName= "رشتخوار",
            CityDivisionCode= 70146
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "شیراز",
            DistrictName= "زرقان",
            CityName= "زرقان",
            CityDivisionCode= 70147
          },
          new City{
            ProvinceName= "همدان",
            CountyName= "بهار",
            DistrictName= "مرکزی",
            CityName= "بهار",
            CityDivisionCode= 70148
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "مرودشت",
            DistrictName= "مرکزی",
            CityName= "مرودشت",
            CityDivisionCode= 70149
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "صومعه سرا",
            DistrictName= "مرکزی",
            CityName= "صومعه سرا",
            CityDivisionCode= 70150
          },
          new City{
            ProvinceName= "تهران",
            CountyName= "ورامین",
            DistrictName= "مرکزی",
            CityName= "ورامین",
            CityDivisionCode= 70151
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "درگز",
            DistrictName= "مرکزی",
            CityName= "درگز",
            CityDivisionCode= 70152
          },
          new City{
            ProvinceName= "سمنان",
            CountyName= "گرمسار",
            DistrictName= "ایوانکی",
            CityName= "ایوانکی",
            CityDivisionCode= 70153
          },
          new City{
            ProvinceName= "کرمانشاه",
            CountyName= "پاوه",
            DistrictName= "نوسود",
            CityName= "نودشه",
            CityDivisionCode= 70154
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "فیروز آباد",
            DistrictName= "مرکزی",
            CityName= "فیروزآباد",
            CityDivisionCode= 70155
          },
          new City{
            ProvinceName= "گلستان",
            CountyName= "مینودشت",
            DistrictName= "مرکزی",
            CityName= "مینودشت",
            CityDivisionCode= 70156
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "آستانه اشرفیه",
            DistrictName= "مرکزی",
            CityName= "آستانه اشرفیه",
            CityDivisionCode= 70157
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "شاهین شهر و میمه",
            DistrictName= "میمه",
            CityName= "میمه",
            CityDivisionCode= 70158
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "لنجان",
            DistrictName= "مرکزی",
            CityName= "زرین شهر",
            CityDivisionCode= 70159
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "بافت",
            DistrictName= "مرکزی",
            CityName= "بافت",
            CityDivisionCode= 70160
          },
          new City{
            ProvinceName= "اردبیل",
            CountyName= "خلخال",
            DistrictName= "مرکزی",
            CityName= "خلخال",
            CityDivisionCode= 70161
          },
          new City{
            ProvinceName= "سیستان و بلوچستان",
            CountyName= "خاش",
            DistrictName= "مرکزی",
            CityName= "خاش",
            CityDivisionCode= 70162
          },
          new City{
            ProvinceName= "آذربایجان غربی",
            CountyName= "بوکان",
            DistrictName= "مرکزی",
            CityName= "بوکان",
            CityDivisionCode= 70163
          },
          new City{
            ProvinceName= "آذربایجان غربی",
            CountyName= "سر دشت",
            DistrictName= "مرکزی",
            CityName= "سردشت",
            CityDivisionCode= 70164
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "هویزه",
            DistrictName= "مرکزی",
            CityName= "هویزه",
            CityDivisionCode= 70165
          },
          new City{
            ProvinceName= "کردستان",
            CountyName= "بانه",
            DistrictName= "مرکزی",
            CityName= "بانه",
            CityDivisionCode= 70166
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "تبریز",
            DistrictName= "مرکزی",
            CityName= "باسمنج",
            CityDivisionCode= 70167
          },
          new City{
            ProvinceName= "اردبیل",
            CountyName= "گرمی",
            DistrictName= "مرکزی",
            CityName= "گرمی",
            CityDivisionCode= 70168
          },
          new City{
            ProvinceName= "خراسان جنوبی",
            CountyName= "قائنات",
            DistrictName= "مرکزی",
            CityName= "قائن",
            CityDivisionCode= 70169
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "سرخس",
            DistrictName= "مرکزی",
            CityName= "سرخس",
            CityDivisionCode= 70170
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "گناباد",
            DistrictName= "کاخک",
            CityName= "کاخک",
            CityDivisionCode= 70171
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "زرند",
            DistrictName= "مرکزی",
            CityName= "زرند",
            CityDivisionCode= 70172
          },
          new City{
            ProvinceName= "لرستان",
            CountyName= "دورود",
            DistrictName= "مرکزی",
            CityName= "دورود",
            CityDivisionCode= 70173
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "ملکان",
            DistrictName= "مرکزی",
            CityName= "ملکان",
            CityDivisionCode= 70174
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "فریدن",
            DistrictName= "مرکزی",
            CityName= "داران",
            CityDivisionCode= 70175
          },
          new City{
            ProvinceName= "سیستان و بلوچستان",
            CountyName= "ایرانشهر",
            DistrictName= "مرکزی",
            CityName= "ایرانشهر",
            CityDivisionCode= 70176
          },
          new City{
            ProvinceName= "سیستان و بلوچستان",
            CountyName= "چاه بهار",
            DistrictName= "مرکزی",
            CityName= "چاه بهار",
            CityDivisionCode= 70177
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "شیراز",
            DistrictName= "مرکزی",
            CityName= "شیراز",
            CityDivisionCode= 70178
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "کرمان",
            DistrictName= "ماهان",
            CityName= "ماهان",
            CityDivisionCode= 70179
          },
          new City{
            ProvinceName= "کرمانشاه",
            CountyName= "سر پل ذهاب",
            DistrictName= "مرکزی",
            CityName= "سر پل ذهاب",
            CityDivisionCode= 70180
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "رشت",
            DistrictName= "خمام",
            CityName= "خمام",
            CityDivisionCode= 70181
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "نکا",
            DistrictName= "مرکزی",
            CityName= "نکا",
            CityDivisionCode= 70182
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "هشترود",
            DistrictName= "مرکزی",
            CityName= "هشترود",
            CityDivisionCode= 70183
          },
          new City{
            ProvinceName= "آذربایجان غربی",
            CountyName= "نقده",
            DistrictName= "مرکزی",
            CityName= "نقده",
            CityDivisionCode= 70184
          },
          new City{
            ProvinceName= "البرز",
            CountyName= "اشتهارد",
            DistrictName= "مرکزی",
            CityName= "اشتهارد",
            CityDivisionCode= 70185
          },
          new City{
            ProvinceName= "خراسان جنوبی",
            CountyName= "سرایان",
            DistrictName= "آیسک",
            CityName= "سرایان",
            CityDivisionCode= 70186
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "تایباد",
            DistrictName= "مرکزی",
            CityName= "تایباد",
            CityDivisionCode= 70187
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "کلات",
            DistrictName= "مرکزی",
            CityName= "کلات",
            CityDivisionCode= 70188
          },
          new City{
            ProvinceName= "خراسان شمالی",
            CountyName= "فاروج",
            DistrictName= "مرکزی",
            CityName= "فاروج",
            CityDivisionCode= 70189
          },
          new City{
            ProvinceName= "کردستان",
            CountyName= "قروه",
            DistrictName= "مرکزی",
            CityName= "قروه",
            CityDivisionCode= 70190
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "جیرفت",
            DistrictName= "مرکزی",
            CityName= "جیرفت",
            CityDivisionCode= 70191
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "طوالش",
            DistrictName= "مرکزی",
            CityName= "هشتپر",
            CityDivisionCode= 70192
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "تنکابن",
            DistrictName= "خرم آباد",
            CityName= "خرم آباد",
            CityDivisionCode= 70193
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "چالوس",
            DistrictName= "مرکزی",
            CityName= "چالوس",
            CityDivisionCode= 70194
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "رامسر",
            DistrictName= "مرکزی",
            CityName= "رامسر",
            CityDivisionCode= 70195
          },
          new City{
            ProvinceName= "مرکزی",
            CountyName= "خمین",
            DistrictName= "مرکزی",
            CityName= "خمین",
            CityDivisionCode= 70196
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "بستان آباد",
            DistrictName= "مرکزی",
            CityName= "بستان آباد",
            CityDivisionCode= 70197
          },
          new City{
            ProvinceName= "تهران",
            CountyName= "شهریار",
            DistrictName= "مرکزی",
            CityName= "شهریار",
            CityDivisionCode= 70198
          },
          new City{
            ProvinceName= "سمنان",
            CountyName= "مهدی شهر",
            DistrictName= "شهمیرزاد",
            CityName= "شهمیرزاد",
            CityDivisionCode= 70199
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "سپیدان",
            DistrictName= "مرکزی",
            CityName= "اردکان",
            CityDivisionCode= 70200
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "شهر بابک",
            DistrictName= "مرکزی",
            CityName= "شهر بابک",
            CityDivisionCode= 70201
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "شفت",
            DistrictName= "مرکزی",
            CityName= "شفت",
            CityDivisionCode= 70202
          },
          new City{
            ProvinceName= "هرمزگان",
            CountyName= "بستک",
            DistrictName= "مرکزی",
            CityName= "بستک",
            CityDivisionCode= 70203
          },
          new City{
            ProvinceName= "یزد",
            CountyName= "تفت",
            DistrictName= "مرکزی",
            CityName= "تفت",
            CityDivisionCode= 70204
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "مرند",
            DistrictName= "مرکزی",
            CityName= "زنوز",
            CityDivisionCode= 70205
          },
          new City{
            ProvinceName= "آذربایجان غربی",
            CountyName= "اشنویه",
            DistrictName= "مرکزی",
            CityName= "اشنویه",
            CityDivisionCode= 70206
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "اردستان",
            DistrictName= "زواره",
            CityName= "زواره",
            CityDivisionCode= 70207
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "مبارکه",
            DistrictName= "مرکزی",
            CityName= "مبارکه",
            CityDivisionCode= 70208
          },
          new City{
            ProvinceName= "تهران",
            CountyName= "دماوند",
            DistrictName= "مرکزی",
            CityName= "کیلان",
            CityDivisionCode= 70209
          },
          new City{
            ProvinceName= "تهران",
            CountyName= "پیشوا",
            DistrictName= "مرکزی",
            CityName= "پیشوا",
            CityDivisionCode= 70210
          },
          new City{
            ProvinceName= "خراسان جنوبی",
            CountyName= "بشرویه",
            DistrictName= "مرکزی",
            CityName= "بشرویه",
            CityDivisionCode= 70211
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "بینالود",
            DistrictName= "طرقبه",
            CityName= "طرقبه",
            CityDivisionCode= 70212
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "گناباد",
            DistrictName= "مرکزی",
            CityName= "بیدخت",
            CityDivisionCode= 70213
          },
          new City{
            ProvinceName= "گلستان",
            CountyName= "آق قلا",
            DistrictName= "مرکزی",
            CityName= "آق قلا",
            CityDivisionCode= 70214
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "رضوانشهر",
            DistrictName= "مرکزی",
            CityName= "رضوانشهر",
            CityDivisionCode= 70215
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "بابل",
            DistrictName= "مرکزی",
            CityName= "امیر کلا",
            CityDivisionCode= 70216
          },
          new City{
            ProvinceName= "یزد",
            CountyName= "بافق",
            DistrictName= "مرکزی",
            CityName= "بافق",
            CityDivisionCode= 70217
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "تبریز",
            DistrictName= "خسرو شاه",
            CityName= "خسروشاه",
            CityDivisionCode= 70218
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "هریس",
            DistrictName= "مرکزی",
            CityName= "هریس",
            CityDivisionCode= 70219
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "فلاورجان",
            DistrictName= "مرکزی",
            CityName= "فلاورجان",
            CityDivisionCode= 70220
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "بندر ماهشهر",
            DistrictName= "بندر امام خمینی",
            CityName= "بندر امام خمینی",
            CityDivisionCode= 70221
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "بندر ماهشهر",
            DistrictName= "مرکزی",
            CityName= "بندر ماهشهر",
            CityDivisionCode= 70222
          },
          new City{
            ProvinceName= "سیستان و بلوچستان",
            CountyName= "سراوان",
            DistrictName= "مرکزی",
            CityName= "سراوان",
            CityDivisionCode= 70223
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "سروستان",
            DistrictName= "مرکزی",
            CityName= "سروستان",
            CityDivisionCode= 70224
          },
          new City{
            ProvinceName= "گلستان",
            CountyName= "رامیان",
            DistrictName= "مرکزی",
            CityName= "رامیان",
            CityDivisionCode= 70225
          },
          new City{
            ProvinceName= "گلستان",
            CountyName= "علی آباد",
            DistrictName= "مرکزی",
            CityName= "علی آباد",
            CityDivisionCode= 70226
          },
          new City{
            ProvinceName= "گلستان",
            CountyName= "کلاله",
            DistrictName= "مرکزی",
            CityName= "کلاله",
            CityDivisionCode= 70227
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "رودسر",
            DistrictName= "کلاچای",
            CityName= "کلاچای",
            CityDivisionCode= 70228
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "نور",
            DistrictName= "مرکزی",
            CityName= "نور",
            CityDivisionCode= 70229
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "نور",
            DistrictName= "مرکزی",
            CityName= "رویان",
            CityDivisionCode= 70230
          },
          new City{
            ProvinceName= "مرکزی",
            CountyName= "تفرش",
            DistrictName= "مرکزی",
            CityName= "تفرش",
            CityDivisionCode= 70231
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "جلفا",
            DistrictName= "مرکزی",
            CityName= "جلفا",
            CityDivisionCode= 70232
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "فریدونشهر",
            DistrictName= "مرکزی",
            CityName= "فریدونشهر",
            CityDivisionCode= 70233
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "دشت آزادگان",
            DistrictName= "بستان",
            CityName= "بستان",
            CityDivisionCode= 70234
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "شوش",
            DistrictName= "مرکزی",
            CityName= "شوش",
            CityDivisionCode= 70235
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "لارستان",
            DistrictName= "اوز",
            CityName= "اوز",
            CityDivisionCode= 70236
          },
          new City{
            ProvinceName= "لرستان",
            CountyName= "کوهدشت",
            DistrictName= "مرکزی",
            CityName= "کوهدشت",
            CityDivisionCode= 70237
          },
          new City{
            ProvinceName= "آذربایجان غربی",
            CountyName= "شوط",
            DistrictName= "مرکزی",
            CityName= "شوط",
            CityDivisionCode= 70238
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "اندیمشک",
            DistrictName= "مرکزی",
            CityName= "اندیمشک",
            CityDivisionCode= 70239
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "ارسنجان",
            DistrictName= "مرکزی",
            CityName= "ارسنجان",
            CityDivisionCode= 70240
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "بردسیر",
            DistrictName= "مرکزی",
            CityName= "بردسیر",
            CityDivisionCode= 70241
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "بم",
            DistrictName= "مرکزی",
            CityName= "بروات",
            CityDivisionCode= 70242
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "انار",
            DistrictName= "انار",
            CityName= "انار",
            CityDivisionCode= 70243
          },
          new City{
            ProvinceName= "کرمانشاه",
            CountyName= "کنگاور",
            DistrictName= "مرکزی",
            CityName= "کنگاور",
            CityDivisionCode= 70244
          },
          new City{
            ProvinceName= "لرستان",
            CountyName= "بروجرد",
            DistrictName= "اشترینان",
            CityName= "اشترینان",
            CityDivisionCode= 70245
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "بابل",
            DistrictName= "مرکزی",
            CityName= "بابل",
            CityDivisionCode= 70246
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "عباس آباد",
            DistrictName= "مرکزی",
            CityName= "عباس آباد",
            CityDivisionCode= 70247
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "تنکابن",
            DistrictName= "مرکزی",
            CityName= "تنکابن",
            CityDivisionCode= 70248
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "سواد کوه",
            DistrictName= "مرکزی",
            CityName= "زیرآب",
            CityDivisionCode= 70249
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "سواد کوه",
            DistrictName= "مرکزی",
            CityName= "پل سفید",
            CityDivisionCode= 70250
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "گلوگاه",
            DistrictName= "مرکزی",
            CityName= "گلوگاه",
            CityDivisionCode= 70251
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "آذرشهر",
            DistrictName= "گوگان",
            CityName= "گوگان",
            CityDivisionCode= 70252
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "آذرشهر",
            DistrictName= "ممقان",
            CityName= "ممقان",
            CityDivisionCode= 70253
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "تبریز",
            DistrictName= "مرکزی",
            CityName= "سردرود",
            CityDivisionCode= 70254
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "شبستر",
            DistrictName= "تسوج",
            CityName= "تسوج",
            CityDivisionCode= 70255
          },
          new City{
            ProvinceName= "اردبیل",
            CountyName= "کوثر",
            DistrictName= "مرکزی",
            CityName= "گیوی",
            CityDivisionCode= 70256
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "کاشان",
            DistrictName= "قمصر",
            CityName= "قمصر",
            CityDivisionCode= 70257
          },
          new City{
            ProvinceName= "تهران",
            CountyName= "ری",
            DistrictName= "مرکزی",
            CityName= "ری",
            CityDivisionCode= 70258
          },
          new City{
            ProvinceName= "تهران",
            CountyName= "شمیرانات",
            DistrictName= "لواسانات",
            CityName= "تجریش",
            CityDivisionCode= 70259
          },
          new City{
            ProvinceName= "چهار محال و بختیاری",
            CountyName= "شهر کرد",
            DistrictName= "مرکزی",
            CityName= "فرخ شهر",
            CityDivisionCode= 70260
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "بینالود",
            DistrictName= "شاندیز",
            CityName= "شاندیز",
            CityDivisionCode= 70261
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "خرامه",
            DistrictName= "مرکزی",
            CityName= "خرامه",
            CityDivisionCode= 70262
          },
          new City{
            ProvinceName= "کردستان",
            CountyName= "مریوان",
            DistrictName= "مرکزی",
            CityName= "مریوان",
            CityDivisionCode= 70263
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "راور",
            DistrictName= "مرکزی",
            CityName= "راور",
            CityDivisionCode= 70264
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "املش",
            DistrictName= "مرکزی",
            CityName= "املش",
            CityDivisionCode= 70265
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "کلاردشت",
            DistrictName= "مرکزی",
            CityName= "مرزن آباد",
            CityDivisionCode= 70266
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "کلاردشت",
            DistrictName= "مرکزی",
            CityName= "کلاردشت",
            CityDivisionCode= 70267
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "مرند",
            DistrictName= "مرکزی",
            CityName= "کشکسرای",
            CityDivisionCode= 70268
          },
          new City{
            ProvinceName= "اردبیل",
            CountyName= "نمین",
            DistrictName= "مرکزی",
            CityName= "نمین",
            CityDivisionCode= 70269
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "فلاورجان",
            DistrictName= "مرکزی",
            CityName= "کلیشاد و سودرجان",
            CityDivisionCode= 70270
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "نائین",
            DistrictName= "انارک",
            CityName= "انارک",
            CityDivisionCode= 70271
          },
          new City{
            ProvinceName= "بوشهر",
            CountyName= "دشتی",
            DistrictName= "مرکزی",
            CityName= "خورموج",
            CityDivisionCode= 70272
          },
          new City{
            ProvinceName= "بوشهر",
            CountyName= "دیلم",
            DistrictName= "مرکزی",
            CityName= "بندر دیلم",
            CityDivisionCode= 70273
          },
          new City{
            ProvinceName= "تهران",
            CountyName= "شمیرانات",
            DistrictName= "رودبار قصران",
            CityName= "فشم",
            CityDivisionCode= 70274
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "مه ولات",
            DistrictName= "مرکزی",
            CityName= "فیض آباد",
            CityDivisionCode= 70275
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "ایذه",
            DistrictName= "مرکزی",
            CityName= "ایذه",
            CityDivisionCode= 70276
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "هندیجان",
            DistrictName= "مرکزی",
            CityName= "هندیجان",
            CityDivisionCode= 70277
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "قیروکارزین",
            DistrictName= "مرکزی",
            CityName= "قیر",
            CityDivisionCode= 70278
          },
          new City{
            ProvinceName= "قزوین",
            CountyName= "تاکستان",
            DistrictName= "مرکزی",
            CityName= "تاکستان",
            CityDivisionCode= 70279
          },
          new City{
            ProvinceName= "کردستان",
            CountyName= "دیواندره",
            DistrictName= "مرکزی",
            CityName= "دیواندره",
            CityDivisionCode= 70280
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "کرمان",
            DistrictName= "راین",
            CityName= "راین",
            CityDivisionCode= 70281
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "کرمان",
            DistrictName= "شهداد",
            CityName= "شهداد",
            CityDivisionCode= 70282
          },
          new City{
            ProvinceName= "کرمانشاه",
            CountyName= "پاوه",
            DistrictName= "مرکزی",
            CityName= "پاوه",
            CityDivisionCode= 70283
          },
          new City{
            ProvinceName= "کرمانشاه",
            CountyName= "گیلانغرب",
            DistrictName= "مرکزی",
            CityName= "گیلانغرب",
            CityDivisionCode= 70284
          },
          new City{
            ProvinceName= "همدان",
            CountyName= "کبودرآهنگ",
            DistrictName= "مرکزی",
            CityName= "کبودر آهنگ",
            CityDivisionCode= 70285
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "بوئین میاندشت",
            DistrictName= "مرکزی",
            CityName= "بوئین میاندشت",
            CityDivisionCode= 70286
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "آبادان",
            DistrictName= "اروند کنار",
            CityName= "اروند کنار",
            CityDivisionCode= 70287
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "امیدیه",
            DistrictName= "مرکزی",
            CityName= "امیدیه",
            CityDivisionCode= 70288
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "آغاجاری",
            DistrictName= "مرکزی",
            CityName= "آغاجاری",
            CityDivisionCode= 70289
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "مسجد سلیمان",
            DistrictName= "مرکزی",
            CityName= "مسجد سلیمان",
            CityDivisionCode= 70290
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "تنکابن",
            DistrictName= "نشتا",
            CityName= "نشتارود",
            CityDivisionCode= 70291
          },
          new City{
            ProvinceName= "مرکزی",
            CountyName= "دلیجان",
            DistrictName= "مرکزی",
            CityName= "نراق",
            CityDivisionCode= 70292
          },
          new City{
            ProvinceName= "همدان",
            CountyName= "ملایر",
            DistrictName= "سامن",
            CityName= "سامن",
            CityDivisionCode= 70293
          },
          new City{
            ProvinceName= "آذربایجان غربی",
            CountyName= "پیرانشهر",
            DistrictName= "مرکزی",
            CityName= "پیرانشهر",
            CityDivisionCode= 70294
          },
          new City{
            ProvinceName= "آذربایجان غربی",
            CountyName= "چالدران",
            DistrictName= "مرکزی",
            CityName= "سیه چشمه",
            CityDivisionCode= 70295
          },
          new City{
            ProvinceName= "آذربایجان غربی",
            CountyName= "چایپاره",
            DistrictName= "مرکزی",
            CityName= "قره ضیاء الدین",
            CityDivisionCode= 70296
          },
          new City{
            ProvinceName= "آذربایجان غربی",
            CountyName= "سلماس",
            DistrictName= "مرکزی",
            CityName= "سلماس",
            CityDivisionCode= 70297
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "سمیرم",
            DistrictName= "مرکزی",
            CityName= "سمیرم",
            CityDivisionCode= 70298
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "جغتای",
            DistrictName= "مرکزی",
            CityName= "جغتای",
            CityDivisionCode= 70299
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "درگز",
            DistrictName= "نوخندان",
            CityName= "نوخندان",
            CityDivisionCode= 70300
          },
          new City{
            ProvinceName= "سمنان",
            CountyName= "شاهرود",
            DistrictName= "بسطام",
            CityName= "بسطام",
            CityDivisionCode= 70301
          },
          new City{
            ProvinceName= "سمنان",
            CountyName= "آرادان",
            DistrictName= "مرکزی",
            CityName= "آرادان",
            CityDivisionCode= 70302
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "کرمان",
            DistrictName= "گلباف",
            CityName= "گلباف",
            CityDivisionCode= 70303
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "کرمان",
            DistrictName= "ماهان",
            CityName= "جوپار",
            CityDivisionCode= 70304
          },
          new City{
            ProvinceName= "کرمانشاه",
            CountyName= "پاوه",
            DistrictName= "نوسود",
            CityName= "نوسود",
            CityDivisionCode= 70305
          },
          new City{
            ProvinceName= "کرمانشاه",
            CountyName= "جوانرود",
            DistrictName= "مرکزی",
            CityName= "جوانرود",
            CityDivisionCode= 70306
          },
          new City{
            ProvinceName= "گلستان",
            CountyName= "کردکوی",
            DistrictName= "مرکزی",
            CityName= "کرد کوی",
            CityDivisionCode= 70307
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "سیمرغ",
            DistrictName= "مرکزی",
            CityName= "کیاکلا",
            CityDivisionCode= 70308
          },
          new City{
            ProvinceName= "هرمزگان",
            CountyName= "جاسک",
            DistrictName= "مرکزی",
            CityName= "بندر جاسک",
            CityDivisionCode= 70309
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "اسکو",
            DistrictName= "ایلخچی",
            CityName= "ایلخچی",
            CityDivisionCode= 70310
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "شبستر",
            DistrictName= "مرکزی",
            CityName= "شرفخانه",
            CityDivisionCode= 70311
          },
          new City{
            ProvinceName= "چهار محال و بختیاری",
            CountyName= "لردگان",
            DistrictName= "مرکزی",
            CityName= "لردگان",
            CityDivisionCode= 70312
          },
          new City{
            ProvinceName= "خراسان جنوبی",
            CountyName= "نهبندان",
            DistrictName= "مرکزی",
            CityName= "نهبندان",
            CityDivisionCode= 70313
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "بردسکن",
            DistrictName= "مرکزی",
            CityName= "بردسکن",
            CityDivisionCode= 70314
          },
          new City{
            ProvinceName= "زنجان",
            CountyName= "سلطانیه",
            DistrictName= "مرکزی",
            CityName= "سلطانیه",
            CityDivisionCode= 70315
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "رشت",
            DistrictName= "خشکبیجار",
            CityName= "خشکبیجار",
            CityDivisionCode= 70316
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "رودسر",
            DistrictName= "چابکسر",
            CityName= "چابکسر",
            CityDivisionCode= 70317
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "ماسال",
            DistrictName= "مرکزی",
            CityName= "ماسال",
            CityDivisionCode= 70318
          },
          new City{
            ProvinceName= "لرستان",
            CountyName= "سلسله",
            DistrictName= "مرکزی",
            CityName= "الشتر",
            CityDivisionCode= 70319
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "جویبار",
            DistrictName= "مرکزی",
            CityName= "جویبار",
            CityDivisionCode= 70320
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "رامسر",
            DistrictName= "مرکزی",
            CityName= "کتالم و سادات شهر",
            CityDivisionCode= 70321
          },
          new City{
            ProvinceName= "هرمزگان",
            CountyName= "قشم",
            DistrictName= "مرکزی",
            CityName= "قشم",
            CityDivisionCode= 70322
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "سراب",
            DistrictName= "مهربان",
            CityName= "مهربان",
            CityDivisionCode= 70323
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "شبستر",
            DistrictName= "صوفیان",
            CityName= "صوفیان",
            CityDivisionCode= 70324
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "لنجان",
            DistrictName= "باغ بهادران",
            CityName= "باغ بهادران",
            CityDivisionCode= 70325
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "خور و بیابانک",
            DistrictName= "مرکزی",
            CityName= "خور",
            CityDivisionCode= 70326
          },
          new City{
            ProvinceName= "بوشهر",
            CountyName= "کنگان",
            DistrictName= "مرکزی",
            CityName= "بندر کنگان",
            CityDivisionCode= 70327
          },
          new City{
            ProvinceName= "بوشهر",
            CountyName= "گناوه",
            DistrictName= "مرکزی",
            CityName= "بندر گناوه",
            CityDivisionCode= 70328
          },
          new City{
            ProvinceName= "خراسان جنوبی",
            CountyName= "سربیشه",
            DistrictName= "مرکزی",
            CityName= "سربیشه",
            CityDivisionCode= 70329
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "درگز",
            DistrictName= "لطف آباد",
            CityName= "لطف آباد",
            CityDivisionCode= 70330
          },
          new City{
            ProvinceName= "سیستان و بلوچستان",
            CountyName= "میرجاوه",
            DistrictName= "مرکزی",
            CityName= "میرجاوه",
            CityDivisionCode= 70331
          },
          new City{
            ProvinceName= "سیستان و بلوچستان",
            CountyName= "کنارک",
            DistrictName= "مرکزی",
            CityName= "کنارک",
            CityDivisionCode= 70332
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "ممسنی",
            DistrictName= "مرکزی",
            CityName= "نورآباد",
            CityDivisionCode= 70333
          },
          new City{
            ProvinceName= "گلستان",
            CountyName= "رامیان",
            DistrictName= "فندرسک",
            CityName= "خان ببین",
            CityDivisionCode= 70334
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "رشت",
            DistrictName= "لشت نشاء",
            CityName= "لشت نشاء",
            CityDivisionCode= 70335
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "رضوانشهر",
            DistrictName= "پره سر",
            CityName= "پره سر",
            CityDivisionCode= 70336
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "رودسر",
            DistrictName= "رحیم آباد",
            CityName= "رحیم آباد",
            CityDivisionCode= 70337
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "فومن",
            DistrictName= "مرکزی",
            CityName= "ماسوله",
            CityDivisionCode= 70338
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "لنگرود",
            DistrictName= "کومله",
            CityName= "کومله",
            CityDivisionCode= 70339
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "عباس آباد",
            DistrictName= "سلمان شهر",
            CityName= "سلمان شهر",
            CityDivisionCode= 70340
          },
          new City{
            ProvinceName= "مرکزی",
            CountyName= "زرندیه",
            DistrictName= "مرکزی",
            CityName= "مامونیه",
            CityDivisionCode= 70341
          },
          new City{
            ProvinceName= "هرمزگان",
            CountyName= "ابوموسی",
            DistrictName= "مرکزی",
            CityName= "ابوموسی",
            CityDivisionCode= 70342
          },
          new City{
            ProvinceName= "همدان",
            CountyName= "همدان",
            DistrictName= "مرکزی",
            CityName= "مریانج",
            CityDivisionCode= 70343
          },
          new City{
            ProvinceName= "یزد",
            CountyName= "مهریز",
            DistrictName= "مرکزی",
            CityName= "مهریز",
            CityDivisionCode= 70344
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "کلیبر",
            DistrictName= "مرکزی",
            CityName= "کلیبر",
            CityDivisionCode= 70345
          },
          new City{
            ProvinceName= "اردبیل",
            CountyName= "نیر",
            DistrictName= "مرکزی",
            CityName= "نیر",
            CityDivisionCode= 70346
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "اصفهان",
            DistrictName= "کوهپایه",
            CityName= "کوهپایه",
            CityDivisionCode= 70347
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "چادگان",
            DistrictName= "مرکزی",
            CityName= "چادگان",
            CityDivisionCode= 70349
          },
          new City{
            ProvinceName= "ایلام",
            CountyName= "دهلران",
            DistrictName= "مرکزی",
            CityName= "دهلران",
            CityDivisionCode= 70350
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "تربت جام",
            DistrictName= "صالح آباد",
            CityName= "صالح آباد",
            CityDivisionCode= 70351
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "نیشابور",
            DistrictName= "زبرخان",
            CityName= "درود",
            CityDivisionCode= 70352
          },
          new City{
            ProvinceName= "زنجان",
            CountyName= "خدابنده",
            DistrictName= "مرکزی",
            CityName= "قیدار",
            CityDivisionCode= 70353
          },
          new City{
            ProvinceName= "سمنان",
            CountyName= "سمنان",
            DistrictName= "سرخه",
            CityName= "سرخه",
            CityDivisionCode= 70354
          },
          new City{
            ProvinceName= "سمنان",
            CountyName= "شاهرود",
            DistrictName= "بسطام",
            CityName= "مجن",
            CityDivisionCode= 70355
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "بوانات",
            DistrictName= "مرکزی",
            CityName= "بوانات",
            CityDivisionCode= 70356
          },
          new City{
            ProvinceName= "قزوین",
            CountyName= "آبیک",
            DistrictName= "مرکزی",
            CityName= "آبیک",
            CityDivisionCode= 70357
          },
          new City{
            ProvinceName= "قزوین",
            CountyName= "آوج",
            DistrictName= "مرکزی",
            CityName= "آوج",
            CityDivisionCode= 70358
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "رابر",
            DistrictName= "مرکزی",
            CityName= "رابر",
            CityDivisionCode= 70359
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "کوهبنان",
            DistrictName= "مرکزی",
            CityName= "کوهبنان",
            CityDivisionCode= 70360
          },
          new City{
            ProvinceName= "کهگیلویه و بویراحمد",
            CountyName= "کهگیلویه",
            DistrictName= "مرکزی",
            CityName= "دهدشت",
            CityDivisionCode= 70361
          },
          new City{
            ProvinceName= "گلستان",
            CountyName= "آزاد شهر",
            DistrictName= "مرکزی",
            CityName= "آزاد شهر",
            CityDivisionCode= 70362
          },
          new City{
            ProvinceName= "لرستان",
            CountyName= "ازنا",
            DistrictName= "مرکزی",
            CityName= "ازنا",
            CityDivisionCode= 70363
          },
          new City{
            ProvinceName= "لرستان",
            CountyName= "پلدختر",
            DistrictName= "مرکزی",
            CityName= "پلدختر",
            CityDivisionCode= 70364
          },
          new City{
            ProvinceName= "لرستان",
            CountyName= "دلفان",
            DistrictName= "مرکزی",
            CityName= "نورآباد",
            CityDivisionCode= 70365
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "آمل",
            DistrictName= "لاریجان",
            CityName= "رینه",
            CityDivisionCode= 70366
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "سوادکوه شمالی",
            DistrictName= "مرکزی",
            CityName= "شیرگاه",
            CityDivisionCode= 70367
          },
          new City{
            ProvinceName= "همدان",
            CountyName= "تویسرکان",
            DistrictName= "مرکزی",
            CityName= "سرکان",
            CityDivisionCode= 70368
          },
          new City{
            ProvinceName= "آذربایجان غربی",
            CountyName= "پلدشت",
            DistrictName= "مرکزی",
            CityName= "پلدشت",
            CityDivisionCode= 70369
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "شاهین شهر و میمه",
            DistrictName= "مرکزی",
            CityName= "گز برخوار",
            CityDivisionCode= 70370
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "گلپایگان",
            DistrictName= "مرکزی",
            CityName= "گوگد",
            CityDivisionCode= 70371
          },
          new City{
            ProvinceName= "ایلام",
            CountyName= "آبدانان",
            DistrictName= "مرکزی",
            CityName= "آبدانان",
            CityDivisionCode= 70372
          },
          new City{
            ProvinceName= "ایلام",
            CountyName= "ایوان",
            DistrictName= "مرکزی",
            CityName= "ایوان",
            CityDivisionCode= 70373
          },
          new City{
            ProvinceName= "ایلام",
            CountyName= "بدره",
            DistrictName= "مرکزی",
            CityName= "بدره",
            CityDivisionCode= 70374
          },
          new City{
            ProvinceName= "ایلام",
            CountyName= "دهلران",
            DistrictName= "موسیان",
            CityName= "موسیان",
            CityDivisionCode= 70375
          },
          new City{
            ProvinceName= "ایلام",
            CountyName= "چرداول",
            DistrictName= "مرکزی",
            CityName= "سرابله",
            CityDivisionCode= 70376
          },
          new City{
            ProvinceName= "ایلام",
            CountyName= "مهران",
            DistrictName= "مرکزی",
            CityName= "مهران",
            CityDivisionCode= 70377
          },
          new City{
            ProvinceName= "ایلام",
            CountyName= "ملکشاهی",
            DistrictName= "مرکزی",
            CityName= "ارکواز",
            CityDivisionCode= 70378
          },
          new City{
            ProvinceName= "بوشهر",
            CountyName= "گناوه",
            DistrictName= "ریگ",
            CityName= "بندر ریگ",
            CityDivisionCode= 70379
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "پاسارگاد",
            DistrictName= "مرکزی",
            CityName= "سعادت شهر",
            CityDivisionCode= 70380
          },
          new City{
            ProvinceName= "کهگیلویه و بویراحمد",
            CountyName= "گچساران",
            DistrictName= "مرکزی",
            CityName= "دوگنبدان",
            CityDivisionCode= 70381
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "رودبار",
            DistrictName= "مرکزی",
            CityName= "منجیل",
            CityDivisionCode= 70382
          },
          new City{
            ProvinceName= "مرکزی",
            CountyName= "شازند",
            DistrictName= "مرکزی",
            CityName= "شازند",
            CityDivisionCode= 70383
          },
          new City{
            ProvinceName= "یزد",
            CountyName= "صدوق",
            DistrictName= "مرکزی",
            CityName= "اشکذر",
            CityDivisionCode= 70384
          },
          new City{
            ProvinceName= "یزد",
            CountyName= "یزد",
            DistrictName= "زارچ",
            CityName= "زارچ",
            CityDivisionCode= 70385
          },
          new City{
            ProvinceName= "آذربایجان غربی",
            CountyName= "سلماس",
            DistrictName= "مرکزی",
            CityName= "تازه شهر",
            CityDivisionCode= 70386
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "دهاقان",
            DistrictName= "مرکزی",
            CityName= "دهاقان",
            CityDivisionCode= 70387
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "نجف آباد",
            DistrictName= "مهردشت",
            CityName= "علویچه",
            CityDivisionCode= 70388
          },
          new City{
            ProvinceName= "ایلام",
            CountyName= "ایلام",
            DistrictName= "چوار",
            CityName= "چوار",
            CityDivisionCode= 70389
          },
          new City{
            ProvinceName= "ایلام",
            CountyName= "دره شهر",
            DistrictName= "مرکزی",
            CityName= "دره شهر",
            CityDivisionCode= 70390
          },
          new City{
            ProvinceName= "ایلام",
            CountyName= "دهلران",
            DistrictName= "زرین آباد",
            CityName= "میمه",
            CityDivisionCode= 70391
          },
          new City{
            ProvinceName= "ایلام",
            CountyName= "مهران",
            DistrictName= "صالح آباد",
            CityName= "صالح آباد",
            CityDivisionCode= 70392
          },
          new City{
            ProvinceName= "بوشهر",
            CountyName= "تنگستان",
            DistrictName= "مرکزی",
            CityName= "اهرم",
            CityDivisionCode= 70393
          },
          new City{
            ProvinceName= "تهران",
            CountyName= "دماوند",
            DistrictName= "رودهن",
            CityName= "رودهن",
            CityDivisionCode= 70394
          },
          new City{
            ProvinceName= "سیستان و بلوچستان",
            CountyName= "قصرقند",
            DistrictName= "مرکزی",
            CityName= "قصر قند",
            CityDivisionCode= 70395
          },
          new City{
            ProvinceName= "سیستان و بلوچستان",
            CountyName= "نیک شهر",
            DistrictName= "مرکزی",
            CityName= "نیک شهر",
            CityDivisionCode= 70396
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "فیروز آباد",
            DistrictName= "میمند",
            CityName= "میمند",
            CityDivisionCode= 70397
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "گراش",
            DistrictName= "مرکزی",
            CityName= "گراش",
            CityDivisionCode= 70398
          },
          new City{
            ProvinceName= "کردستان",
            CountyName= "کامیاران",
            DistrictName= "مرکزی",
            CityName= "کامیاران",
            CityDivisionCode= 70399
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "رودسر",
            DistrictName= "کلاچای",
            CityName= "واجارگاه",
            CityDivisionCode= 70400
          },
          new City{
            ProvinceName= "هرمزگان",
            CountyName= "حاجی آباد",
            DistrictName= "مرکزی",
            CityName= "حاجی آباد",
            CityDivisionCode= 70401
          },
          new City{
            ProvinceName= "یزد",
            CountyName= "میبد",
            DistrictName= "مرکزی",
            CityName= "میبد",
            CityDivisionCode= 70402
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "اصفهان",
            DistrictName= "جلگه",
            CityName= "هرند",
            CityDivisionCode= 70403
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "برخوار",
            DistrictName= "حبیب آباد",
            CityName= "حبیب آباد",
            CityDivisionCode= 70404
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "برخوار",
            DistrictName= "مرکزی",
            CityName= "دولت آباد",
            CityDivisionCode= 70405
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "برخوار",
            DistrictName= "مرکزی",
            CityName= "خورزوق",
            CityDivisionCode= 70406
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "برخوار",
            DistrictName= "مرکزی",
            CityName= "دستگرد",
            CityDivisionCode= 70407
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "تیران و کرون",
            DistrictName= "مرکزی",
            CityName= "تیران",
            CityDivisionCode= 70408
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "خمینی شهر",
            DistrictName= "مرکزی",
            CityName= "درچه پیاز",
            CityDivisionCode= 70409
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "نجف آباد",
            DistrictName= "مهردشت",
            CityName= "دهق",
            CityDivisionCode= 70410
          },
          new City{
            ProvinceName= "بوشهر",
            CountyName= "دیر",
            DistrictName= "مرکزی",
            CityName= "بندر دیر",
            CityDivisionCode= 70411
          },
          new City{
            ProvinceName= "سیستان و بلوچستان",
            CountyName= "چاه بهار",
            DistrictName= "دشتیاری",
            CityName= "نگور",
            CityDivisionCode= 70412
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "خنج",
            DistrictName= "مرکزی",
            CityName= "خنج",
            CityDivisionCode= 70413
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "کوار",
            DistrictName= "مرکزی",
            CityName= "کوار",
            CityDivisionCode= 70414
          },
          new City{
            ProvinceName= "کهگیلویه و بویراحمد",
            CountyName= "بویر احمد",
            DistrictName= "مرکزی",
            CityName= "یاسوج",
            CityDivisionCode= 70415
          },
          new City{
            ProvinceName= "هرمزگان",
            CountyName= "بندرلنگه",
            DistrictName= "مرکزی",
            CityName= "کنگ",
            CityDivisionCode= 70416
          },
          new City{
            ProvinceName= "هرمزگان",
            CountyName= "پارسیان",
            DistrictName= "مرکزی",
            CityName= "پارسیان",
            CityDivisionCode= 70417
          },
          new City{
            ProvinceName= "هرمزگان",
            CountyName= "خمیر",
            DistrictName= "مرکزی",
            CityName= "خمیر",
            CityDivisionCode= 70418
          },
          new City{
            ProvinceName= "آذربایجان غربی",
            CountyName= "خوی",
            DistrictName= "مرکزی",
            CityName= "فیرورق",
            CityDivisionCode= 70419
          },
          new City{
            ProvinceName= "اردبیل",
            CountyName= "پارس آباد",
            DistrictName= "مرکزی",
            CityName= "پارس آباد",
            CityDivisionCode= 70420
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "شاهین شهر و میمه",
            DistrictName= "میمه",
            CityName= "وزوان",
            CityDivisionCode= 70421
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "چناران",
            DistrictName= "مرکزی",
            CityName= "چناران",
            CityDivisionCode= 70422
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "خلیل آباد",
            DistrictName= "مرکزی",
            CityName= "خلیل آباد",
            CityDivisionCode= 70423
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "رامشیر",
            DistrictName= "مرکزی",
            CityName= "رامشیر",
            CityDivisionCode= 70424
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "هفتگل",
            DistrictName= "مرکزی",
            CityName= "هفتگل",
            CityDivisionCode= 70425
          },
          new City{
            ProvinceName= "آذربایجان غربی",
            CountyName= "نقده",
            DistrictName= "محمدیار",
            CityName= "محمد یار",
            CityDivisionCode= 70426
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "اصفهان",
            DistrictName= "بن رود",
            CityName= "ورزنه",
            CityDivisionCode= 70427
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "فلاورجان",
            DistrictName= "مرکزی",
            CityName= "قهدریجان",
            CityDivisionCode= 70428
          },
          new City{
            ProvinceName= "چهار محال و بختیاری",
            CountyName= "سامان",
            DistrictName= "مرکزی",
            CityName= "سامان",
            CityDivisionCode= 70429
          },
          new City{
            ProvinceName= "چهار محال و بختیاری",
            CountyName= "فارسان",
            DistrictName= "مرکزی",
            CityName= "فارسان",
            CityDivisionCode= 70430
          },
          new City{
            ProvinceName= "بوشهر",
            CountyName= "بوشهر",
            DistrictName= "خارک",
            CityName= "خارک",
            CityDivisionCode= 70431
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "جلفا",
            DistrictName= "مرکزی",
            CityName= "هادیشهر",
            CityDivisionCode= 70432
          },
          new City{
            ProvinceName= "تهران",
            CountyName= "شمیرانات",
            DistrictName= "لواسانات",
            CityName= "لواسان",
            CityDivisionCode= 70433
          },
          new City{
            ProvinceName= "اردبیل",
            CountyName= "سرعین",
            DistrictName= "مرکزی",
            CityName= "سرعین",
            CityDivisionCode= 70434
          },
          new City{
            ProvinceName= "اردبیل",
            CountyName= "بیله سوار",
            DistrictName= "مرکزی",
            CityName= "بیله سوار",
            CityDivisionCode= 70435
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "اهر",
            DistrictName= "مرکزی",
            CityName= "اهر",
            CityDivisionCode= 70436
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "کرمان",
            DistrictName= "چترود",
            CityName= "چترود",
            CityDivisionCode= 70437
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "سواد کوه",
            DistrictName= "مرکزی",
            CityName= "آلاشت",
            CityDivisionCode= 70438
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "آران و بیدگل",
            DistrictName= "مرکزی",
            CityName= "آران و بیدگل",
            CityDivisionCode= 70439
          },
          new City{
            ProvinceName= "بوشهر",
            CountyName= "دشتستان",
            DistrictName= "سعد آباد",
            CityName= "سعد آباد",
            CityDivisionCode= 70440
          },
          new City{
            ProvinceName= "خراسان جنوبی",
            CountyName= "فردوس",
            DistrictName= "مرکزی",
            CityName= "اسلامیه",
            CityDivisionCode= 70441
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "کهنوج",
            DistrictName= "مرکزی",
            CityName= "کهنوج",
            CityDivisionCode= 70442
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "عباس آباد",
            DistrictName= "سلمان شهر",
            CityName= "کلارآباد",
            CityDivisionCode= 70443
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "شاهین شهر و میمه",
            DistrictName= "مرکزی",
            CityName= "شاهین شهر",
            CityDivisionCode= 70444
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "نطنز",
            DistrictName= "امام زاده",
            CityName= "بادرود",
            CityDivisionCode= 70445
          },
          new City{
            ProvinceName= "تهران",
            CountyName= "قرچک",
            DistrictName= "مرکزی",
            CityName= "قرچک",
            CityDivisionCode= 70446
          },
          new City{
            ProvinceName= "چهار محال و بختیاری",
            CountyName= "بن",
            DistrictName= "مرکزی",
            CityName= "بن",
            CityDivisionCode= 70447
          },
          new City{
            ProvinceName= "چهار محال و بختیاری",
            CountyName= "شهر کرد",
            DistrictName= "مرکزی",
            CityName= "هفشجان",
            CityDivisionCode= 70448
          },
          new City{
            ProvinceName= "چهار محال و بختیاری",
            CountyName= "فارسان",
            DistrictName= "مرکزی",
            CityName= "جونقان",
            CityDivisionCode= 70449
          },
          new City{
            ProvinceName= "قزوین",
            CountyName= "بوئین زهرا",
            DistrictName= "مرکزی",
            CityName= "بوئین زهرا",
            CityDivisionCode= 70450
          },
          new City{
            ProvinceName= "کهگیلویه و بویراحمد",
            CountyName= "چرام",
            DistrictName= "مرکزی",
            CityName= "چرام",
            CityDivisionCode= 70451
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "آباده",
            DistrictName= "مرکزی",
            CityName= "صغاد",
            CityDivisionCode= 70452
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "بهشهر",
            DistrictName= "مرکزی",
            CityName= "رستمکلا",
            CityDivisionCode= 70453
          },
          new City{
            ProvinceName= "تهران",
            CountyName= "اسلامشهر",
            DistrictName= "مرکزی",
            CityName= "اسلامشهر",
            CityDivisionCode= 70454
          },
          new City{
            ProvinceName= "همدان",
            CountyName= "بهار",
            DistrictName= "لالجین",
            CityName= "لالجین",
            CityDivisionCode= 70455
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "شبستر",
            DistrictName= "مرکزی",
            CityName= "شند آباد",
            CityDivisionCode= 70456
          },
          new City{
            ProvinceName= "البرز",
            CountyName= "ساوجبلاغ",
            DistrictName= "مرکزی",
            CityName= "هشتگرد",
            CityDivisionCode= 70457
          },
          new City{
            ProvinceName= "البرز",
            CountyName= "نظر آباد",
            DistrictName= "مرکزی",
            CityName= "نظر آباد",
            CityDivisionCode= 70458
          },
          new City{
            ProvinceName= "مرکزی",
            CountyName= "محلات",
            DistrictName= "مرکزی",
            CityName= "نیمور",
            CityDivisionCode= 70459
          },
          new City{
            ProvinceName= "مرکزی",
            CountyName= "شازند",
            DistrictName= "مرکزی",
            CityName= "آستانه",
            CityDivisionCode= 70460
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "جهرم",
            DistrictName= "خفر",
            CityName= "خاوران",
            CityDivisionCode= 70461
          },
          new City{
            ProvinceName= "کردستان",
            CountyName= "دهگلان",
            DistrictName= "مرکزی",
            CityName= "دهگلان",
            CityDivisionCode= 70462
          },
          new City{
            ProvinceName= "کردستان",
            CountyName= "قروه",
            DistrictName= "سریش آباد",
            CityName= "سریش آباد",
            CityDivisionCode= 70463
          },
          new City{
            ProvinceName= "هرمزگان",
            CountyName= "رودان",
            DistrictName= "مرکزی",
            CityName= "دهبارز",
            CityDivisionCode= 70464
          },
          new City{
            ProvinceName= "قزوین",
            CountyName= "البرز",
            DistrictName= "مرکزی",
            CityName= "الوند",
            CityDivisionCode= 70465
          },
          new City{
            ProvinceName= "همدان",
            CountyName= "رزن",
            DistrictName= "قروه در جزین",
            CityName= "قروه در جزین",
            CityDivisionCode= 70466
          },
          new City{
            ProvinceName= "زنجان",
            CountyName= "ابهر",
            DistrictName= "مرکزی",
            CityName= "هیدج",
            CityDivisionCode= 70467
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "خرم بید",
            DistrictName= "مشهد مرغاب",
            CityName= "قادرآباد",
            CityDivisionCode= 70468
          },
          new City{
            ProvinceName= "قزوین",
            CountyName= "بوئین زهرا",
            DistrictName= "شال",
            CityName= "شال",
            CityDivisionCode= 70469
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "فراشبند",
            DistrictName= "مرکزی",
            CityName= "فراشبند",
            CityDivisionCode= 70470
          },
          new City{
            ProvinceName= "تهران",
            CountyName= "رباط کریم",
            DistrictName= "مرکزی",
            CityName= "رباط کریم",
            CityDivisionCode= 70471
          },
          new City{
            ProvinceName= "چهار محال و بختیاری",
            CountyName= "اردل",
            DistrictName= "مرکزی",
            CityName= "اردل",
            CityDivisionCode= 70472
          },
          new City{
            ProvinceName= "چهار محال و بختیاری",
            CountyName= "بروجن",
            DistrictName= "بلداجی",
            CityName= "بلداجی",
            CityDivisionCode= 70473
          },
          new City{
            ProvinceName= "چهار محال و بختیاری",
            CountyName= "بروجن",
            DistrictName= "مرکزی",
            CityName= "فرادنبه",
            CityDivisionCode= 70474
          },
          new City{
            ProvinceName= "خراسان شمالی",
            CountyName= "مانه و سملقان",
            DistrictName= "مرکزی",
            CityName= "آشخانه",
            CityDivisionCode= 70475
          },
          new City{
            ProvinceName= "زنجان",
            CountyName= "ابهر",
            DistrictName= "مرکزی",
            CityName= "صائین قلعه",
            CityDivisionCode= 70476
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "لامرد",
            DistrictName= "مرکزی",
            CityName= "لامرد",
            CityDivisionCode= 70477
          },
          new City{
            ProvinceName= "کهگیلویه و بویراحمد",
            CountyName= "دنا",
            DistrictName= "مرکزی",
            CityName= "سی سخت",
            CityDivisionCode= 70478
          },
          new City{
            ProvinceName= "گلستان",
            CountyName= "گالیکش",
            DistrictName= "مرکزی",
            CityName= "گالیکش",
            CityDivisionCode= 70479
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "رودبار",
            DistrictName= "مرکزی",
            CityName= "لوشان",
            CityDivisionCode= 70480
          },
          new City{
            ProvinceName= "مرکزی",
            CountyName= "زرندیه",
            DistrictName= "مرکزی",
            CityName= "زاویه",
            CityDivisionCode= 70481
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "لنجان",
            DistrictName= "مرکزی",
            CityName= "سده لنجان",
            CityDivisionCode= 70482
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "لنجان",
            DistrictName= "مرکزی",
            CityName= "چمگردان",
            CityDivisionCode= 70483
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "باغ ملک",
            DistrictName= "مرکزی",
            CityName= "باغ ملک",
            CityDivisionCode= 70484
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "گتوند",
            DistrictName= "مرکزی",
            CityName= "گتوند",
            CityDivisionCode= 70485
          },
          new City{
            ProvinceName= "خراسان جنوبی",
            CountyName= "قائنات",
            DistrictName= "نیمبلوک",
            CityName= "خضری دشت بیاض",
            CityDivisionCode= 70486
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "زرین دشت",
            DistrictName= "مرکزی",
            CityName= "حاجی آباد",
            CityDivisionCode= 70487
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "عنبر آباد",
            DistrictName= "مرکزی",
            CityName= "عنبر آباد",
            CityDivisionCode= 70488
          },
          new City{
            ProvinceName= "مرکزی",
            CountyName= "ساوه",
            DistrictName= "نوبران",
            CityName= "غرق آباد",
            CityDivisionCode= 70489
          },
          new City{
            ProvinceName= "مرکزی",
            CountyName= "کمیجان",
            DistrictName= "مرکزی",
            CityName= "کمیجان",
            CityDivisionCode= 70490
          },
          new City{
            ProvinceName= "هرمزگان",
            CountyName= "قشم",
            DistrictName= "هرمز",
            CityName= "هرمز",
            CityDivisionCode= 70491
          },
          new City{
            ProvinceName= "یزد",
            CountyName= "بهاباد",
            DistrictName= "مرکزی",
            CityName= "بهاباد",
            CityDivisionCode= 70492
          },
          new City{
            ProvinceName= "یزد",
            CountyName= "تفت",
            DistrictName= "نیر",
            CityName= "نیر",
            CityDivisionCode= 70493
          },
          new City{
            ProvinceName= "یزد",
            CountyName= "خاتم",
            DistrictName= "مرکزی",
            CityName= "هرات",
            CityDivisionCode= 70494
          },
          new City{
            ProvinceName= "یزد",
            CountyName= "خاتم",
            DistrictName= "مروست",
            CityName= "مروست",
            CityDivisionCode= 70495
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "لنجان",
            DistrictName= "مرکزی",
            CityName= "ورنامخواست",
            CityDivisionCode= 70496
          },
          new City{
            ProvinceName= "تهران",
            CountyName= "قدس",
            DistrictName= "مرکزی",
            CityName= "قدس",
            CityDivisionCode= 70497
          },
          new City{
            ProvinceName= "قزوین",
            CountyName= "تاکستان",
            DistrictName= "اسفرورین",
            CityName= "اسفرورین",
            CityDivisionCode= 70498
          },
          new City{
            ProvinceName= "چهار محال و بختیاری",
            CountyName= "شهر کرد",
            DistrictName= "لاران",
            CityName= "سورشجان",
            CityDivisionCode= 70499
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "لالی",
            DistrictName= "مرکزی",
            CityName= "لالی",
            CityDivisionCode= 70500
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "کوهبنان",
            DistrictName= "طغرالجرد",
            CityName= "کیانشهر",
            CityDivisionCode= 70501
          },
          new City{
            ProvinceName= "قزوین",
            CountyName= "تاکستان",
            DistrictName= "ضیاء آباد",
            CityName= "ضیاء آباد",
            CityDivisionCode= 70502
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "کازرون",
            DistrictName= "کنار تخته و کمارج",
            CityName= "کنار تخته",
            CityDivisionCode= 70503
          },
          new City{
            ProvinceName= "کرمانشاه",
            CountyName= "روانسر",
            DistrictName= "مرکزی",
            CityName= "روانسر",
            CityDivisionCode= 70504
          },
          new City{
            ProvinceName= "همدان",
            CountyName= "فامنین",
            DistrictName= "مرکزی",
            CityName= "فامنین",
            CityDivisionCode= 70505
          },
          new City{
            ProvinceName= "همدان",
            CountyName= "رزن",
            DistrictName= "مرکزی",
            CityName= "رزن",
            CityDivisionCode= 70506
          },
          new City{
            ProvinceName= "چهار محال و بختیاری",
            CountyName= "کیار",
            DistrictName= "مرکزی",
            CityName= "شلمزار",
            CityDivisionCode= 70507
          },
          new City{
            ProvinceName= "سیستان و بلوچستان",
            CountyName= "سیب سوران",
            DistrictName= "مرکزی",
            CityName= "سوران",
            CityDivisionCode= 70508
          },
          new City{
            ProvinceName= "سیستان و بلوچستان",
            CountyName= "فنوج",
            DistrictName= "مرکزی",
            CityName= "فنوج",
            CityDivisionCode= 70509
          },
          new City{
            ProvinceName= "سیستان و بلوچستان",
            CountyName= "ایرانشهر",
            DistrictName= "بمپور",
            CityName= "بمپور",
            CityDivisionCode= 70510
          },
          new City{
            ProvinceName= "سیستان و بلوچستان",
            CountyName= "زهک",
            DistrictName= "مرکزی",
            CityName= "زهک",
            CityDivisionCode= 70511
          },
          new City{
            ProvinceName= "تهران",
            CountyName= "پاکدشت",
            DistrictName= "مرکزی",
            CityName= "پاکدشت",
            CityDivisionCode= 70512
          },
          new City{
            ProvinceName= "کهگیلویه و بویراحمد",
            CountyName= "لنده",
            DistrictName= "مرکزی",
            CityName= "لنده",
            CityDivisionCode= 70513
          },
          new City{
            ProvinceName= "کهگیلویه و بویراحمد",
            CountyName= "باشت",
            DistrictName= "مرکزی",
            CityName= "باشت",
            CityDivisionCode= 70514
          },
          new City{
            ProvinceName= "آذربایجان غربی",
            CountyName= "ارومیه",
            DistrictName= "انزل",
            CityName= "قوشچی",
            CityDivisionCode= 70515
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "استهبان",
            DistrictName= "رونیز",
            CityName= "رونیز",
            CityDivisionCode= 70516
          },
          new City{
            ProvinceName= "چهار محال و بختیاری",
            CountyName= "بروجن",
            DistrictName= "گندمان",
            CityName= "گندمان",
            CityDivisionCode= 70517
          },
          new City{
            ProvinceName= "بوشهر",
            CountyName= "دشتستان",
            DistrictName= "شبانکاره",
            CityName= "شبانکاره",
            CityDivisionCode= 70518
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "فسا",
            DistrictName= "ششده و قره بلاغ",
            CityName= "ششده",
            CityDivisionCode= 70519
          },
          new City{
            ProvinceName= "ایلام",
            CountyName= "دهلران",
            DistrictName= "زرین آباد",
            CityName= "پهله",
            CityDivisionCode= 70520
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "باخرز",
            DistrictName= "مرکزی",
            CityName= "باخرز",
            CityDivisionCode= 70521
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "زاوه",
            DistrictName= "مرکزی",
            CityName= "دولت آباد",
            CityDivisionCode= 70522
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "خواف",
            DistrictName= "سنگان",
            CityName= "سنگان",
            CityDivisionCode= 70523
          },
          new City{
            ProvinceName= "خراسان شمالی",
            CountyName= "راز و جرگلان",
            DistrictName= "مرکزی",
            CityName= "راز",
            CityDivisionCode= 70524
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "میانه",
            DistrictName= "ترکمانچای",
            CityName= "ترکمانچای",
            CityDivisionCode= 70525
          },
          new City{
            ProvinceName= "بوشهر",
            CountyName= "دشتی",
            DistrictName= "کاکی",
            CityName= "کاکی",
            CityDivisionCode= 70526
          },
          new City{
            ProvinceName= "تهران",
            CountyName= "ری",
            DistrictName= "فشاپویه",
            CityName= "حسن آباد",
            CityDivisionCode= 70527
          },
          new City{
            ProvinceName= "سیستان و بلوچستان",
            CountyName= "سراوان",
            DistrictName= "جالق",
            CityName= "جالق",
            CityDivisionCode= 70528
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "لارستان",
            DistrictName= "جویم",
            CityName= "جویم",
            CityDivisionCode= 70529
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "نور",
            DistrictName= "چمستان",
            CityName= "چمستان",
            CityDivisionCode= 70530
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "کازرون",
            DistrictName= "چنار شاهیجان",
            CityName= "قائمیه",
            CityDivisionCode= 70531
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "کازرون",
            DistrictName= "خشت",
            CityName= "خشت",
            CityDivisionCode= 70532
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "باوی",
            DistrictName= "مرکزی",
            CityName= "ملاثانی",
            CityDivisionCode= 70533
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "حمیدیه",
            DistrictName= "مرکزی",
            CityName= "حمیدیه",
            CityDivisionCode= 70534
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "خرم بید",
            DistrictName= "مرکزی",
            CityName= "صفا شهر",
            CityDivisionCode= 70535
          },
          new City{
            ProvinceName= "البرز",
            CountyName= "کرج",
            DistrictName= "مرکزی",
            CityName= "ماهدشت",
            CityDivisionCode= 70536
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "فسا",
            DistrictName= "شیبکوه",
            CityName= "زاهد شهر",
            CityDivisionCode= 70537
          },
          new City{
            ProvinceName= "قزوین",
            CountyName= "قزوین",
            DistrictName= "مرکزی",
            CityName= "اقبالیه",
            CityDivisionCode= 70538
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "لنجان",
            DistrictName= "باغ بهادران",
            CityName= "چرمهین",
            CityDivisionCode= 70539
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "نجف آباد",
            DistrictName= "مرکزی",
            CityName= "گلدشت",
            CityDivisionCode= 70540
          },
          new City{
            ProvinceName= "چهار محال و بختیاری",
            CountyName= "شهر کرد",
            DistrictName= "مرکزی",
            CityName= "کیان",
            CityDivisionCode= 70541
          },
          new City{
            ProvinceName= "چهار محال و بختیاری",
            CountyName= "فارسان",
            DistrictName= "مرکزی",
            CityName= "باباحیدر",
            CityDivisionCode= 70542
          },
          new City{
            ProvinceName= "یزد",
            CountyName= "یزد",
            DistrictName= "مرکزی",
            CityName= "شاهدیه",
            CityDivisionCode= 70543
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "لنجان",
            DistrictName= "مرکزی",
            CityName= "فولاد شهر",
            CityDivisionCode= 70544
          },
          new City{
            ProvinceName= "کرمانشاه",
            CountyName= "پاوه",
            DistrictName= "باینگان",
            CityName= "باینگان",
            CityDivisionCode= 70545
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "رودبار",
            DistrictName= "مرکزی",
            CityName= "رستم آباد",
            CityDivisionCode= 70546
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "شبستر",
            DistrictName= "مرکزی",
            CityName= "سیس",
            CityDivisionCode= 70547
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "شبستر",
            DistrictName= "مرکزی",
            CityName= "وایقان",
            CityDivisionCode= 70548
          },
          new City{
            ProvinceName= "آذربایجان غربی",
            CountyName= "ارومیه",
            DistrictName= "نازلو",
            CityName= "نوشین",
            CityDivisionCode= 70549
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "لارستان",
            DistrictName= "بنارویه",
            CityName= "بنارویه",
            CityDivisionCode= 70550
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "رودبار",
            DistrictName= "عمارلو",
            CityName= "جیرنده",
            CityDivisionCode= 70551
          },
          new City{
            ProvinceName= "اردبیل",
            CountyName= "خلخال",
            DistrictName= "خورش رستم",
            CityName= "هشتجین",
            CityDivisionCode= 70552
          },
          new City{
            ProvinceName= "اردبیل",
            CountyName= "خلخال",
            DistrictName= "شاهرود",
            CityName= "کلور",
            CityDivisionCode= 70553
          },
          new City{
            ProvinceName= "ایلام",
            CountyName= "سیروان",
            DistrictName= "مرکزی",
            CityName= "لومار",
            CityDivisionCode= 70554
          },
          new City{
            ProvinceName= "سمنان",
            CountyName= "شاهرود",
            DistrictName= "بسطام",
            CityName= "کلاته خیج",
            CityDivisionCode= 70555
          },
          new City{
            ProvinceName= "سمنان",
            CountyName= "شاهرود",
            DistrictName= "بیارجمند",
            CityName= "بیارجمند",
            CityDivisionCode= 70556
          },
          new City{
            ProvinceName= "سمنان",
            CountyName= "میامی",
            DistrictName= "مرکزی",
            CityName= "میامی",
            CityDivisionCode= 70557
          },
          new City{
            ProvinceName= "مرکزی",
            CountyName= "فراهان",
            DistrictName= "مرکزی",
            CityName= "فرمهین",
            CityDivisionCode= 70558
          },
          new City{
            ProvinceName= "مرکزی",
            CountyName= "ساوه",
            DistrictName= "نوبران",
            CityName= "نوبران",
            CityDivisionCode= 70559
          },
          new City{
            ProvinceName= "یزد",
            CountyName= "یزد",
            DistrictName= "مرکزی",
            CityName= "حمیدیا",
            CityDivisionCode= 70560
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "جهرم",
            DistrictName= "کردیان",
            CityName= "قطب آباد",
            CityDivisionCode= 70561
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "خمینی شهر",
            DistrictName= "مرکزی",
            CityName= "کوشک",
            CityDivisionCode= 70562
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "مبارکه",
            DistrictName= "مرکزی",
            CityName= "دیزیچه",
            CityDivisionCode= 70563
          },
          new City{
            ProvinceName= "کرمانشاه",
            CountyName= "ثلاث باباجانی",
            DistrictName= "مرکزی",
            CityName= "تازه آباد",
            CityDivisionCode= 70564
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "صومعه سرا",
            DistrictName= "تولم",
            CityName= "مرجقل",
            CityDivisionCode= 70565
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "لنگرود",
            DistrictName= "کومله",
            CityName= "شلمان",
            CityDivisionCode= 70566
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "ساری",
            DistrictName= "چهاردانگه",
            CityName= "کیاسر",
            CityDivisionCode= 70567
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "ورزقان",
            DistrictName= "مرکزی",
            CityName= "ورزقان",
            CityDivisionCode= 70568
          },
          new City{
            ProvinceName= "اردبیل",
            CountyName= "پارس آباد",
            DistrictName= "اصلاندوز",
            CityName= "اصلاندوز",
            CityDivisionCode= 70569
          },
          new City{
            ProvinceName= "گلستان",
            CountyName= "بندر گز",
            DistrictName= "نوکنده",
            CityName= "نوکنده",
            CityDivisionCode= 70570
          },
          new City{
            ProvinceName= "هرمزگان",
            CountyName= "بندرلنگه",
            DistrictName= "کیش",
            CityName= "کیش",
            CityDivisionCode= 70571
          },
          new City{
            ProvinceName= "کهگیلویه و بویراحمد",
            CountyName= "کهگیلویه",
            DistrictName= "مرکزی",
            CityName= "سوق",
            CityDivisionCode= 70572
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "اصفهان",
            DistrictName= "جرقویه سفلی",
            CityName= "نیک آباد",
            CityDivisionCode= 70573
          },
          new City{
            ProvinceName= "کردستان",
            CountyName= "بیجار",
            DistrictName= "کرانی",
            CityName= "یاسوکند",
            CityDivisionCode= 70574
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "اصفهان",
            DistrictName= "جرقویه علیا",
            CityName= "حسن آباد",
            CityDivisionCode= 70575
          },
          new City{
            ProvinceName= "البرز",
            CountyName= "طالقان",
            DistrictName= "مرکزی",
            CityName= "طالقان",
            CityDivisionCode= 70576
          },
          new City{
            ProvinceName= "تهران",
            CountyName= "ورامین",
            DistrictName= "جواد آباد",
            CityName= "جواد آباد",
            CityDivisionCode= 70577
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "داراب",
            DistrictName= "مرکزی",
            CityName= "جنت شهر",
            CityDivisionCode= 70578
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "قلعه گنج",
            DistrictName= "مرکزی",
            CityName= "قلعه گنج",
            CityDivisionCode= 70579
          },
          new City{
            ProvinceName= "قزوین",
            CountyName= "بوئین زهرا",
            DistrictName= "رامند",
            CityName= "دانسفهان",
            CityDivisionCode= 70580
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "چاراویماق",
            DistrictName= "مرکزی",
            CityName= "قره آغاج",
            CityDivisionCode= 70581
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "هریس",
            DistrictName= "خواجه",
            CityName= "خواجه",
            CityDivisionCode= 70582
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "هریس",
            DistrictName= "مرکزی",
            CityName= "زرنق",
            CityDivisionCode= 70583
          },
          new City{
            ProvinceName= "چهار محال و بختیاری",
            CountyName= "کیار",
            DistrictName= "ناغان",
            CityName= "ناغان",
            CityDivisionCode= 70584
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "جوین",
            DistrictName= "مرکزی",
            CityName= "نقاب",
            CityDivisionCode= 70585
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "فیروزه",
            DistrictName= "مرکزی",
            CityName= "فیروزه",
            CityDivisionCode= 70586
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "لامرد",
            DistrictName= "اشکنان",
            CityName= "اشکنان",
            CityDivisionCode= 70587
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "مهر",
            DistrictName= "مرکزی",
            CityName= "مهر",
            CityDivisionCode= 70588
          },
          new City{
            ProvinceName= "همدان",
            CountyName= "بهار",
            DistrictName= "صالح آباد",
            CityName= "صالح آباد",
            CityDivisionCode= 70589
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "فلاورجان",
            DistrictName= "پیر بکران",
            CityName= "پیر بکران",
            CityDivisionCode= 70590
          },
          new City{
            ProvinceName= "اردبیل",
            CountyName= "بیله سوار",
            DistrictName= "قشلاق دشت",
            CityName= "جعفر آباد",
            CityDivisionCode= 70592
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "اردستان",
            DistrictName= "مرکزی",
            CityName= "مهاباد",
            CityDivisionCode= 70593
          },
          new City{
            ProvinceName= "تهران",
            CountyName= "بهارستان",
            DistrictName= "بوستان",
            CityName= "نسیم شهر",
            CityDivisionCode= 70594
          },
          new City{
            ProvinceName= "تهران",
            CountyName= "ملارد",
            DistrictName= "مرکزی",
            CityName= "ملارد",
            CityDivisionCode= 70595
          },
          new City{
            ProvinceName= "قزوین",
            CountyName= "البرز",
            DistrictName= "محمدیه",
            CityName= "محمدیه",
            CityDivisionCode= 70596
          },
          new City{
            ProvinceName= "زنجان",
            CountyName= "ماهنشان",
            DistrictName= "مرکزی",
            CityName= "ماه نشان",
            CityDivisionCode= 70597
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "درگز",
            DistrictName= "چاپشلو",
            CityName= "چاپشلو",
            CityDivisionCode= 70598
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "آباده",
            DistrictName= "مرکزی",
            CityName= "بهمن",
            CityDivisionCode= 70599
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "لارستان",
            DistrictName= "بیرم",
            CityName= "بیرم",
            CityDivisionCode= 70600
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "نی ریز",
            DistrictName= "آباده طشک",
            CityName= "آباده طشک",
            CityDivisionCode= 70601
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "بافت",
            DistrictName= "مرکزی",
            CityName= "بزنجان",
            CityDivisionCode= 70602
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "زرند",
            DistrictName= "مرکزی",
            CityName= "خانوک",
            CityDivisionCode= 70603
          },
          new City{
            ProvinceName= "کرمانشاه",
            CountyName= "قصر شیرین",
            DistrictName= "سومار",
            CityName= "سومار",
            CityDivisionCode= 70604
          },
          new City{
            ProvinceName= "همدان",
            CountyName= "نهاوند",
            DistrictName= "خزل",
            CityName= "فیروزان",
            CityDivisionCode= 70605
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "مبارکه",
            DistrictName= "مرکزی",
            CityName= "طالخونچه",
            CityDivisionCode= 70606
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "خور و بیابانک",
            DistrictName= "مرکزی",
            CityName= "جندق",
            CityDivisionCode= 70607
          },
          new City{
            ProvinceName= "کردستان",
            CountyName= "سروآباد",
            DistrictName= "مرکزی",
            CityName= "سرو آباد",
            CityDivisionCode= 70608
          },
          new City{
            ProvinceName= "کرمانشاه",
            CountyName= "کرمانشاه",
            DistrictName= "ماهیدشت",
            CityName= "رباط",
            CityDivisionCode= 70609
          },
          new City{
            ProvinceName= "گلستان",
            CountyName= "رامیان",
            DistrictName= "مرکزی",
            CityName= "دلند",
            CityDivisionCode= 70610
          },
          new City{
            ProvinceName= "البرز",
            CountyName= "کرج",
            DistrictName= "مرکزی",
            CityName= "محمد شهر",
            CityDivisionCode= 70611
          },
          new City{
            ProvinceName= "البرز",
            CountyName= "کرج",
            DistrictName= "مرکزی",
            CityName= "کمال شهر",
            CityDivisionCode= 70612
          },
          new City{
            ProvinceName= "البرز",
            CountyName= "کرج",
            DistrictName= "مرکزی",
            CityName= "مشکین دشت",
            CityDivisionCode= 70613
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "رفسنجان",
            DistrictName= "مرکزی",
            CityName= "مس سرچشمه",
            CityDivisionCode= 70614
          },
          new City{
            ProvinceName= "کرمانشاه",
            CountyName= "هرسین",
            DistrictName= "بیستون",
            CityName= "بیستون",
            CityDivisionCode= 70615
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "هریس",
            DistrictName= "مرکزی",
            CityName= "بخشایش",
            CityDivisionCode= 70616
          },
          new City{
            ProvinceName= "بوشهر",
            CountyName= "جم",
            DistrictName= "مرکزی",
            CityName= "جم",
            CityDivisionCode= 70617
          },
          new City{
            ProvinceName= "تهران",
            CountyName= "تهران",
            DistrictName= "مرکزی",
            CityName= "بومهن",
            CityDivisionCode= 70618
          },
          new City{
            ProvinceName= "تهران",
            CountyName= "شهریار",
            DistrictName= "مرکزی",
            CityName= "وحیدیه",
            CityDivisionCode= 70619
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "نیشابور",
            DistrictName= "زبرخان",
            CityName= "قدمگاه",
            CityDivisionCode= 70620
          },
          new City{
            ProvinceName= "زنجان",
            CountyName= "خدابنده",
            DistrictName= "افشار",
            CityName= "گرماب",
            CityDivisionCode= 70621
          },
          new City{
            ProvinceName= "زنجان",
            CountyName= "طارم",
            DistrictName= "مرکزی",
            CityName= "آب بر",
            CityDivisionCode= 70622
          },
          new City{
            ProvinceName= "سمنان",
            CountyName= "دامغان",
            DistrictName= "امیر آباد",
            CityName= "امیریه",
            CityDivisionCode= 70623
          },
          new City{
            ProvinceName= "سمنان",
            CountyName= "دامغان",
            DistrictName= "مرکزی",
            CityName= "دیباج",
            CityDivisionCode= 70624
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "جهرم",
            DistrictName= "خفر",
            CityName= "باب انار",
            CityDivisionCode= 70625
          },
          new City{
            ProvinceName= "هرمزگان",
            CountyName= "سیریک",
            DistrictName= "مرکزی",
            CityName= "سیریک",
            CityDivisionCode= 70626
          },
          new City{
            ProvinceName= "آذربایجان غربی",
            CountyName= "ماکو",
            DistrictName= "بازرگان",
            CityName= "بازرگان",
            CityDivisionCode= 70627
          },
          new City{
            ProvinceName= "آذربایجان غربی",
            CountyName= "میاندوآب",
            DistrictName= "مرحمت آباد",
            CityName= "چهار برج",
            CityDivisionCode= 70628
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "اصفهان",
            DistrictName= "جرقویه سفلی",
            CityName= "محمد آباد",
            CityDivisionCode= 70629
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "اصفهان",
            DistrictName= "جلگه",
            CityName= "اژیه",
            CityDivisionCode= 70630
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "سمیرم",
            DistrictName= "مرکزی",
            CityName= "حنا",
            CityDivisionCode= 70631
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "بوئین میاندشت",
            DistrictName= "مرکزی",
            CityName= "افوس",
            CityDivisionCode= 70632
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "فریدن",
            DistrictName= "مرکزی",
            CityName= "دامنه",
            CityDivisionCode= 70633
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "فلاورجان",
            DistrictName= "مرکزی",
            CityName= "ابریشم",
            CityDivisionCode= 70634
          },
          new City{
            ProvinceName= "تهران",
            CountyName= "ری",
            DistrictName= "کهریزک",
            CityName= "باقرشهر",
            CityDivisionCode= 70635
          },
          new City{
            ProvinceName= "خراسان جنوبی",
            CountyName= "خوسف",
            DistrictName= "مرکزی",
            CityName= "خوسف",
            CityDivisionCode= 70636
          },
          new City{
            ProvinceName= "خراسان جنوبی",
            CountyName= "درمیان",
            DistrictName= "مرکزی",
            CityName= "اسدیه",
            CityDivisionCode= 70637
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "تربت حیدریه",
            DistrictName= "کدکن",
            CityName= "کدکن",
            CityDivisionCode= 70638
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "سبزوار",
            DistrictName= "روداب",
            CityName= "روداب",
            CityDivisionCode= 70639
          },
          new City{
            ProvinceName= "زنجان",
            CountyName= "ماهنشان",
            DistrictName= "انگوران",
            CityName= "دندی",
            CityDivisionCode= 70640
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "لامرد",
            DistrictName= "اشکنان",
            CityName= "اهل",
            CityDivisionCode= 70641
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "جیرفت",
            DistrictName= "جبالبارز",
            CityName= "جبالبارز",
            CityDivisionCode= 70642
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "شهر بابک",
            DistrictName= "دهج",
            CityName= "دهج",
            CityDivisionCode= 70643
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "کرمان",
            DistrictName= "مرکزی",
            CityName= "باغین",
            CityDivisionCode= 70644
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "منوجان",
            DistrictName= "مرکزی",
            CityName= "منوجان",
            CityDivisionCode= 70645
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "رودبار",
            DistrictName= "رحمت آباد و بلوکات",
            CityName= "توتکابن",
            CityDivisionCode= 70646
          },
          new City{
            ProvinceName= "مرکزی",
            CountyName= "زرندیه",
            DistrictName= "مرکزی",
            CityName= "پرندک",
            CityDivisionCode= 70647
          },
          new City{
            ProvinceName= "هرمزگان",
            CountyName= "بندرلنگه",
            DistrictName= "شیبکوه",
            CityName= "چارک",
            CityDivisionCode= 70648
          },
          new City{
            ProvinceName= "بوشهر",
            CountyName= "تنگستان",
            DistrictName= "دلوار",
            CityName= "دلوار",
            CityDivisionCode= 70649
          },
          new City{
            ProvinceName= "تهران",
            CountyName= "دماوند",
            DistrictName= "مرکزی",
            CityName= "آبسرد",
            CityDivisionCode= 70650
          },
          new City{
            ProvinceName= "قم",
            CountyName= "قم",
            DistrictName= "جعفر آباد",
            CityName= "جعفریه",
            CityDivisionCode= 70651
          },
          new City{
            ProvinceName= "قم",
            CountyName= "قم",
            DistrictName= "نوفل لوشاتو",
            CityName= "کهک",
            CityDivisionCode= 70652
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "لامرد",
            DistrictName= "علامرودشت",
            CityName= "علامرودشت",
            CityDivisionCode= 70653
          },
          new City{
            ProvinceName= "لرستان",
            CountyName= "دوره",
            DistrictName= "چگنی",
            CityName= "سراب دوره",
            CityDivisionCode= 70654
          },
          new City{
            ProvinceName= "لرستان",
            CountyName= "رومشکان",
            DistrictName= "مرکزی",
            CityName= "چقابل",
            CityDivisionCode= 70655
          },
          new City{
            ProvinceName= "لرستان",
            CountyName= "کوهدشت",
            DistrictName= "طرهان",
            CityName= "گراب",
            CityDivisionCode= 70656
          },
          new City{
            ProvinceName= "یزد",
            CountyName= "اردکان",
            DistrictName= "مرکزی",
            CityName= "احمد آباد",
            CityDivisionCode= 70657
          },
          new City{
            ProvinceName= "تهران",
            CountyName= "شهریار",
            DistrictName= "مرکزی",
            CityName= "صبا شهر",
            CityDivisionCode= 70658
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "داورزن",
            DistrictName= "مرکزی",
            CityName= "داورزن",
            CityDivisionCode= 70659
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "بردسیر",
            DistrictName= "مرکزی",
            CityName= "گلزار",
            CityDivisionCode= 70660
          },
          new City{
            ProvinceName= "همدان",
            CountyName= "ملایر",
            DistrictName= "جوکار",
            CityName= "ازندریان",
            CityDivisionCode= 70661
          },
          new City{
            ProvinceName= "همدان",
            CountyName= "همدان",
            DistrictName= "مرکزی",
            CityName= "جورقان",
            CityDivisionCode= 70662
          },
          new City{
            ProvinceName= "تهران",
            CountyName= "بهارستان",
            DistrictName= "گلستان",
            CityName= "گلستان",
            CityDivisionCode= 70663
          },
          new City{
            ProvinceName= "بوشهر",
            CountyName= "دشتستان",
            DistrictName= "آبپخش",
            CityName= "آبپخش",
            CityDivisionCode= 70664
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "میاندورود",
            DistrictName= "مرکزی",
            CityName= "سورک",
            CityDivisionCode= 70665
          },
          new City{
            ProvinceName= "همدان",
            CountyName= "رزن",
            DistrictName= "سردرود",
            CityName= "دمق",
            CityDivisionCode= 70666
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "انار",
            DistrictName= "انار",
            CityName= "امین شهر",
            CityDivisionCode= 70667
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "کرمان",
            DistrictName= "چترود",
            CityName= "کاظم آباد",
            CityDivisionCode= 70668
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "کرمان",
            DistrictName= "ماهان",
            CityName= "محی آباد",
            CityDivisionCode= 70669
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "کرمان",
            DistrictName= "مرکزی",
            CityName= "زنگی آباد",
            CityDivisionCode= 70670
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "آران و بیدگل",
            DistrictName= "کویرات",
            CityName= "ابوزید آباد",
            CityDivisionCode= 70671
          },
          new City{
            ProvinceName= "اردبیل",
            CountyName= "اردبیل",
            DistrictName= "هیر",
            CityName= "هیر",
            CityDivisionCode= 70672
          },
          new City{
            ProvinceName= "اردبیل",
            CountyName= "مشگین شهر",
            DistrictName= "ارشق",
            CityName= "رضی",
            CityDivisionCode= 70673
          },
          new City{
            ProvinceName= "اردبیل",
            CountyName= "مشگین شهر",
            DistrictName= "مشگین شرقی",
            CityName= "لاهرود",
            CityDivisionCode= 70674
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "خرمشهر",
            DistrictName= "مینو",
            CityName= "مینوشهر",
            CityDivisionCode= 70675
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "رودبار جنوب",
            DistrictName= "مرکزی",
            CityName= "رودبار",
            CityDivisionCode= 70676
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "سیرجان",
            DistrictName= "مرکزی",
            CityName= "زید آباد",
            CityDivisionCode= 70677
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "بستان آباد",
            DistrictName= "تیکمه داش",
            CityName= "تیکمه داش",
            CityDivisionCode= 70678
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "سیرجان",
            DistrictName= "مرکزی",
            CityName= "نجف شهر",
            CityDivisionCode= 70679
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "اهر",
            DistrictName= "هوراند",
            CityName= "هوراند",
            CityDivisionCode= 70680
          },
          new City{
            ProvinceName= "زنجان",
            CountyName= "ایجرود",
            DistrictName= "مرکزی",
            CityName= "زرین آباد",
            CityDivisionCode= 70681
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "شیراز",
            DistrictName= "مرکزی",
            CityName= "داریان",
            CityDivisionCode= 70682
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "فهرج",
            DistrictName= "مرکزی",
            CityName= "فهرج",
            CityDivisionCode= 70683
          },
          new City{
            ProvinceName= "مرکزی",
            CountyName= "خنداب",
            DistrictName= "مرکزی",
            CityName= "خنداب",
            CityDivisionCode= 70684
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "کاشان",
            DistrictName= "نیاسر",
            CityName= "نیاسر",
            CityDivisionCode= 70685
          },
          new City{
            ProvinceName= "چهار محال و بختیاری",
            CountyName= "بروجن",
            DistrictName= "مرکزی",
            CityName= "سفید دشت",
            CityDivisionCode= 70686
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "باوی",
            DistrictName= "مرکزی",
            CityName= "شیبان",
            CityDivisionCode= 70687
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "باوی",
            DistrictName= "ویس",
            CityName= "ویس",
            CityDivisionCode= 70688
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "بندر ماهشهر",
            DistrictName= "مرکزی",
            CityName= "چمران",
            CityDivisionCode= 70689
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "شوش",
            DistrictName= "شاوور",
            CityName= "الوان",
            CityDivisionCode= 70690
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "هویزه",
            DistrictName= "نیسان",
            CityName= "رفیع",
            CityDivisionCode= 70691
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "اقلید",
            DistrictName= "سده",
            CityName= "سده",
            CityDivisionCode= 70692
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "ارزوئیه",
            DistrictName= "مرکزی",
            CityName= "ارزوئیه",
            CityDivisionCode= 70693
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "بردسیر",
            DistrictName= "مرکزی",
            CityName= "نگار",
            CityDivisionCode= 70694
          },
          new City{
            ProvinceName= "همدان",
            CountyName= "همدان",
            DistrictName= "شراء",
            CityName= "قهاوند",
            CityDivisionCode= 70695
          },
          new City{
            ProvinceName= "تهران",
            CountyName= "شهریار",
            DistrictName= "مرکزی",
            CityName= "شاهدشهر",
            CityDivisionCode= 70696
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "رفسنجان",
            DistrictName= "کشکوئیه",
            CityName= "کشکوئیه",
            CityDivisionCode= 70697
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "ریگان",
            DistrictName= "مرکزی",
            CityName= "محمد آباد",
            CityDivisionCode= 70698
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "ملکان",
            DistrictName= "لیلان",
            CityName= "لیلان",
            CityDivisionCode= 70699
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "خرمشهر",
            DistrictName= "مرکزی",
            CityName= "مقاومت",
            CityDivisionCode= 70700
          },
          new City{
            ProvinceName= "هرمزگان",
            CountyName= "بندرعباس",
            DistrictName= "فین",
            CityName= "فین",
            CityDivisionCode= 70701
          },
          new City{
            ProvinceName= "یزد",
            CountyName= "میبد",
            DistrictName= "ندوشن",
            CityName= "ندوشن",
            CityDivisionCode= 70702
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "مراغه",
            DistrictName= "سراجو",
            CityName= "خداجو",
            CityDivisionCode= 70703
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "چادگان",
            DistrictName= "مرکزی",
            CityName= "رزوه",
            CityDivisionCode= 70704
          },
          new City{
            ProvinceName= "تهران",
            CountyName= "ملارد",
            DistrictName= "صفادشت",
            CityName= "صفادشت",
            CityDivisionCode= 70705
          },
          new City{
            ProvinceName= "زنجان",
            CountyName= "خدابنده",
            DistrictName= "سجاس رود",
            CityName= "سجاس",
            CityDivisionCode= 70706
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "نرماشیر",
            DistrictName= "مرکزی",
            CityName= "نرماشیر",
            CityDivisionCode= 70707
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "سمیرم",
            DistrictName= "مرکزی",
            CityName= "ونک",
            CityDivisionCode= 70708
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "هریس",
            DistrictName= "مرکزی",
            CityName= "کلوانق",
            CityDivisionCode= 70709
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "اصفهان",
            DistrictName= "کوهپایه",
            CityName= "سگزی",
            CityDivisionCode= 70710
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "مرودشت",
            DistrictName= "سیدان",
            CityName= "سیدان",
            CityDivisionCode= 70711
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "جیرفت",
            DistrictName= "ساردوئیه",
            CityName= "درب بهشت",
            CityDivisionCode= 70712
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "خدا آفرین",
            DistrictName= "مرکزی",
            CityName= "خمارلو",
            CityDivisionCode= 70713
          },
          new City{
            ProvinceName= "لرستان",
            CountyName= "دورود",
            DistrictName= "سیلاخور",
            CityName= "چالانچولان",
            CityDivisionCode= 70714
          },
          new City{
            ProvinceName= "لرستان",
            CountyName= "کوهدشت",
            DistrictName= "کوهنانی",
            CityName= "کوهنانی",
            CityDivisionCode= 70715
          },
          new City{
            ProvinceName= "خراسان شمالی",
            CountyName= "جاجرم",
            DistrictName= "مرکزی",
            CityName= "جاجرم",
            CityDivisionCode= 70716
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "سراب",
            DistrictName= "مهربان",
            CityName= "شربیان",
            CityDivisionCode= 70717
          },
          new City{
            ProvinceName= "چهار محال و بختیاری",
            CountyName= "شهر کرد",
            DistrictName= "مرکزی",
            CityName= "طاقانک",
            CityDivisionCode= 70718
          },
          new City{
            ProvinceName= "لرستان",
            CountyName= "دوره",
            DistrictName= "ویسیان",
            CityName= "ویسیان",
            CityDivisionCode= 70719
          },
          new City{
            ProvinceName= "قزوین",
            CountyName= "قزوین",
            DistrictName= "مرکزی",
            CityName= "محمود آباد نمونه",
            CityDivisionCode= 70720
          },
          new City{
            ProvinceName= "چهار محال و بختیاری",
            CountyName= "کیار",
            DistrictName= "مرکزی",
            CityName= "گهرو",
            CityDivisionCode= 70721
          },
          new City{
            ProvinceName= "زنجان",
            CountyName= "خدابنده",
            DistrictName= "بزینه رود",
            CityName= "زرین رود",
            CityDivisionCode= 70722
          },
          new City{
            ProvinceName= "یزد",
            CountyName= "ابرکوه",
            DistrictName= "بهمن",
            CityName= "مهردشت",
            CityDivisionCode= 70723
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "سپیدان",
            DistrictName= "بیضا",
            CityName= "بیضا",
            CityDivisionCode= 70724
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "نیشابور",
            DistrictName= "زبرخان",
            CityName= "خرو",
            CityDivisionCode= 70725
          },
          new City{
            ProvinceName= "قزوین",
            CountyName= "تاکستان",
            DistrictName= "خرمدشت",
            CityName= "خرمدشت",
            CityDivisionCode= 70726
          },
          new City{
            ProvinceName= "چهار محال و بختیاری",
            CountyName= "کوهرنگ",
            DistrictName= "مرکزی",
            CityName= "چلگرد",
            CityDivisionCode= 70727
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "ماسال",
            DistrictName= "شاندرمن",
            CityName= "بازار جمعه",
            CityDivisionCode= 70728
          },
          new City{
            ProvinceName= "لرستان",
            CountyName= "پلدختر",
            DistrictName= "معمولان",
            CityName= "معمولان",
            CityDivisionCode= 70729
          },
          new City{
            ProvinceName= "لرستان",
            CountyName= "خرم آباد",
            DistrictName= "زاغه",
            CityName= "زاغه",
            CityDivisionCode= 70730
          },
          new City{
            ProvinceName= "بوشهر",
            CountyName= "دشتستان",
            DistrictName= "مرکزی",
            CityName= "دالکی",
            CityDivisionCode= 70731
          },
          new City{
            ProvinceName= "بوشهر",
            CountyName= "دیلم",
            DistrictName= "امام حسن",
            CityName= "امام حسن",
            CityDivisionCode= 70732
          },
          new City{
            ProvinceName= "سیستان و بلوچستان",
            CountyName= "نیمروز",
            DistrictName= "مرکزی",
            CityName= "ادیمی",
            CityDivisionCode= 70733
          },
          new City{
            ProvinceName= "سیستان و بلوچستان",
            CountyName= "هامون",
            DistrictName= "مرکزی",
            CityName= "محمد آباد",
            CityDivisionCode= 70734
          },
          new City{
            ProvinceName= "سیستان و بلوچستان",
            CountyName= "مهرستان",
            DistrictName= "مرکزی",
            CityName= "مهرستان",
            CityDivisionCode= 70735
          },
          new City{
            ProvinceName= "سیستان و بلوچستان",
            CountyName= "سرباز",
            DistrictName= "پیشین",
            CityName= "پیشین",
            CityDivisionCode= 70736
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "آباده",
            DistrictName= "مرکزی",
            CityName= "ایزد خواست",
            CityDivisionCode= 70737
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "رستم",
            DistrictName= "مرکزی",
            CityName= "مصیری",
            CityDivisionCode= 70738
          },
          new City{
            ProvinceName= "لرستان",
            CountyName= "ازنا",
            DistrictName= "جاپلق",
            CityName= "مومن آباد",
            CityDivisionCode= 70739
          },
          new City{
            ProvinceName= "لرستان",
            CountyName= "سلسله",
            DistrictName= "فیروز آباد",
            CityName= "فیروزآباد",
            CityDivisionCode= 70740
          },
          new City{
            ProvinceName= "خراسان جنوبی",
            CountyName= "طبس",
            DistrictName= "دستگردان",
            CityName= "عشق آباد",
            CityDivisionCode= 70741
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "تربت حیدریه",
            DistrictName= "بایک",
            CityName= "بایک",
            CityDivisionCode= 70742
          },
          new City{
            ProvinceName= "خراسان جنوبی",
            CountyName= "سرایان",
            DistrictName= "آیسک",
            CityName= "آیسک",
            CityDivisionCode= 70743
          },
          new City{
            ProvinceName= "خراسان جنوبی",
            CountyName= "زیرکوه",
            DistrictName= "مرکزی",
            CityName= "حاجی آباد",
            CityDivisionCode= 70744
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "تربت جام",
            DistrictName= "نصر آباد",
            CityName= "نصرآباد",
            CityDivisionCode= 70745
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "خوشاب",
            DistrictName= "مرکزی",
            CityName= "سلطان آباد",
            CityDivisionCode= 70746
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "سبزوار",
            DistrictName= "ششتمد",
            CityName= "ششتمد",
            CityDivisionCode= 70747
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "کاشمر",
            DistrictName= "کوهسرخ",
            CityName= "ریوش",
            CityDivisionCode= 70748
          },
          new City{
            ProvinceName= "کهگیلویه و بویراحمد",
            CountyName= "بهمئی",
            DistrictName= "مرکزی",
            CityName= "لیکک",
            CityDivisionCode= 70749
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "سیاهکل",
            DistrictName= "دیلمان",
            CityName= "دیلمان",
            CityDivisionCode= 70750
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "صومعه سرا",
            DistrictName= "میرزا کوچک جنگلی",
            CityName= "گوراب زرمیخ",
            CityDivisionCode= 70751
          },
          new City{
            ProvinceName= "آذربایجان غربی",
            CountyName= "ارومیه",
            DistrictName= "صومای برادوست",
            CityName= "سرو",
            CityDivisionCode= 70752
          },
          new City{
            ProvinceName= "آذربایجان غربی",
            CountyName= "خوی",
            DistrictName= "ایواوغلی",
            CityName= "ایواوغلی",
            CityDivisionCode= 70753
          },
          new City{
            ProvinceName= "آذربایجان غربی",
            CountyName= "شاهین دژ",
            DistrictName= "کشاورز",
            CityName= "کشاورز",
            CityDivisionCode= 70754
          },
          new City{
            ProvinceName= "مرکزی",
            CountyName= "کمیجان",
            DistrictName= "میلاجرد",
            CityName= "میلاجرد",
            CityDivisionCode= 70755
          },
          new City{
            ProvinceName= "سیستان و بلوچستان",
            CountyName= "سرباز",
            DistrictName= "مرکزی",
            CityName= "راسک",
            CityDivisionCode= 70756
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "کرمان",
            DistrictName= "مرکزی",
            CityName= "اختیار آباد",
            CityDivisionCode= 70757
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "جلفا",
            DistrictName= "سیه رود",
            CityName= "سیه رود",
            CityDivisionCode= 70758
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "مرند",
            DistrictName= "یامچی",
            CityName= "یامچی",
            CityDivisionCode= 70759
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "میانه",
            DistrictName= "کاغذکنان",
            CityName= "آقکند",
            CityDivisionCode= 70760
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "میانه",
            DistrictName= "کندوان",
            CityName= "ترک",
            CityDivisionCode= 70761
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "ورزقان",
            DistrictName= "خاروانا",
            CityName= "خاروانا",
            CityDivisionCode= 70762
          },
          new City{
            ProvinceName= "آذربایجان غربی",
            CountyName= "ارومیه",
            DistrictName= "سیلوانه",
            CityName= "سیلوانه",
            CityDivisionCode= 70763
          },
          new City{
            ProvinceName= "آذربایجان غربی",
            CountyName= "اشنویه",
            DistrictName= "نالوس",
            CityName= "نالوس",
            CityDivisionCode= 70764
          },
          new City{
            ProvinceName= "آذربایجان غربی",
            CountyName= "سر دشت",
            DistrictName= "وزینه",
            CityName= "میرآباد",
            CityDivisionCode= 70765
          },
          new City{
            ProvinceName= "اردبیل",
            CountyName= "گرمی",
            DistrictName= "انگوت",
            CityName= "تازه کند انگوت",
            CityDivisionCode= 70766
          },
          new City{
            ProvinceName= "اردبیل",
            CountyName= "نمین",
            DistrictName= "ویلکیج",
            CityName= "آبی بیگلو",
            CityDivisionCode= 70767
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "تیران و کرون",
            DistrictName= "کرون",
            CityName= "عسگران",
            CityDivisionCode= 70768
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "سمیرم",
            DistrictName= "پادنا",
            CityName= "کمه",
            CityDivisionCode= 70769
          },
          new City{
            ProvinceName= "ایلام",
            CountyName= "ایوان",
            DistrictName= "زرنه",
            CityName= "زرنه",
            CityDivisionCode= 70770
          },
          new City{
            ProvinceName= "تهران",
            CountyName= "اسلامشهر",
            DistrictName= "چهاردانگه",
            CityName= "چهاردانگه",
            CityDivisionCode= 70771
          },
          new City{
            ProvinceName= "تهران",
            CountyName= "پاکدشت",
            DistrictName= "شریف آباد",
            CityName= "شریف آباد",
            CityDivisionCode= 70772
          },
          new City{
            ProvinceName= "تهران",
            CountyName= "ری",
            DistrictName= "کهریزک",
            CityName= "کهریزک",
            CityDivisionCode= 70773
          },
          new City{
            ProvinceName= "چهار محال و بختیاری",
            CountyName= "لردگان",
            DistrictName= "فلارد",
            CityName= "مال خلیفه",
            CityDivisionCode= 70774
          },
          new City{
            ProvinceName= "چهار محال و بختیاری",
            CountyName= "لردگان",
            DistrictName= "خانمیرزا",
            CityName= "آلونی",
            CityDivisionCode= 70775
          },
          new City{
            ProvinceName= "خراسان جنوبی",
            CountyName= "نهبندان",
            DistrictName= "شوسف",
            CityName= "شوسف",
            CityDivisionCode= 70776
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "بردسکن",
            DistrictName= "انابد",
            CityName= "انابد",
            CityDivisionCode= 70777
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "تربت حیدریه",
            DistrictName= "جلگه رخ",
            CityName= "رباط سنگ",
            CityDivisionCode= 70778
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "خواف",
            DistrictName= "جلگه زوزن",
            CityName= "قاسم آباد",
            CityDivisionCode= 70779
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "فریمان",
            DistrictName= "قلندر آباد",
            CityName= "قلندر آباد",
            CityDivisionCode= 70780
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "مشهد",
            DistrictName= "احمد آباد",
            CityName= "ملک آباد",
            CityDivisionCode= 70781
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "مشهد",
            DistrictName= "رضویه",
            CityName= "رضویه",
            CityDivisionCode= 70782
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "نیشابور",
            DistrictName= "میان جلگه",
            CityName= "عشق آباد",
            CityDivisionCode= 70783
          },
          new City{
            ProvinceName= "خراسان شمالی",
            CountyName= "اسفراین",
            DistrictName= "بام وصفی آباد",
            CityName= "صفی آباد",
            CityDivisionCode= 70784
          },
          new City{
            ProvinceName= "خراسان شمالی",
            CountyName= "بجنورد",
            DistrictName= "گرمخان",
            CityName= "حصارگرمخان",
            CityDivisionCode= 70785
          },
          new City{
            ProvinceName= "خراسان شمالی",
            CountyName= "جاجرم",
            DistrictName= "جلگه سنخواست",
            CityName= "سنخواست",
            CityDivisionCode= 70786
          },
          new City{
            ProvinceName= "خراسان شمالی",
            CountyName= "جاجرم",
            DistrictName= "جلگه شوقان",
            CityName= "شوقان",
            CityDivisionCode= 70787
          },
          new City{
            ProvinceName= "خراسان شمالی",
            CountyName= "شیروان",
            DistrictName= "سرحد",
            CityName= "لوجلی",
            CityDivisionCode= 70788
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "امیدیه",
            DistrictName= "جایزان",
            CityName= "جایزان",
            CityDivisionCode= 70789
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "ایذه",
            DistrictName= "دهدز",
            CityName= "دهدز",
            CityDivisionCode= 70790
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "بهبهان",
            DistrictName= "زیدون",
            CityName= "سردشت",
            CityDivisionCode= 70791
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "دزفول",
            DistrictName= "سردشت",
            CityName= "سالند",
            CityDivisionCode= 70792
          },
          new City{
            ProvinceName= "زنجان",
            CountyName= "ایجرود",
            DistrictName= "حلب",
            CityName= "حلب",
            CityDivisionCode= 70793
          },
          new City{
            ProvinceName= "زنجان",
            CountyName= "طارم",
            DistrictName= "چورزق",
            CityName= "چورزق",
            CityDivisionCode= 70794
          },
          new City{
            ProvinceName= "سیستان و بلوچستان",
            CountyName= "ایرانشهر",
            DistrictName= "بزمان",
            CityName= "بزمان",
            CityDivisionCode= 70795
          },
          new City{
            ProvinceName= "سیستان و بلوچستان",
            CountyName= "خاش",
            DistrictName= "نوک آباد",
            CityName= "نوک آباد",
            CityDivisionCode= 70796
          },
          new City{
            ProvinceName= "سیستان و بلوچستان",
            CountyName= "دلگان",
            DistrictName= "مرکزی",
            CityName= "گلمورتی",
            CityDivisionCode= 70797
          },
          new City{
            ProvinceName= "سیستان و بلوچستان",
            CountyName= "زابل",
            DistrictName= "مرکزی",
            CityName= "بنجار",
            CityDivisionCode= 70798
          },
          new City{
            ProvinceName= "سیستان و بلوچستان",
            CountyName= "زاهدان",
            DistrictName= "نصرت آباد",
            CityName= "نصرت آباد",
            CityDivisionCode= 70799
          },
          new City{
            ProvinceName= "سیستان و بلوچستان",
            CountyName= "سراوان",
            DistrictName= "بم پشت",
            CityName= "سیرکان",
            CityDivisionCode= 70800
          },
          new City{
            ProvinceName= "سیستان و بلوچستان",
            CountyName= "سرباز",
            DistrictName= "سرباز",
            CityName= "سرباز",
            CityDivisionCode= 70801
          },
          new City{
            ProvinceName= "سیستان و بلوچستان",
            CountyName= "نیک شهر",
            DistrictName= "بنت",
            CityName= "بنت",
            CityDivisionCode= 70802
          },
          new City{
            ProvinceName= "سیستان و بلوچستان",
            CountyName= "نیک شهر",
            DistrictName= "لاشار",
            CityName= "اسپکه",
            CityDivisionCode= 70803
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "کازرون",
            DistrictName= "جره و بالاده",
            CityName= "بالاده",
            CityDivisionCode= 70804
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "کازرون",
            DistrictName= "کوهمره",
            CityName= "نودان",
            CityDivisionCode= 70805
          },
          new City{
            ProvinceName= "قزوین",
            CountyName= "قزوین",
            DistrictName= "الموت شرقی",
            CityName= "معلم کلایه",
            CityDivisionCode= 70806
          },
          new City{
            ProvinceName= "قزوین",
            CountyName= "قزوین",
            DistrictName= "الموت غربی",
            CityName= "رازمیان",
            CityDivisionCode= 70807
          },
          new City{
            ProvinceName= "کردستان",
            CountyName= "بانه",
            DistrictName= "آرمرده",
            CityName= "آرمرده",
            CityDivisionCode= 70808
          },
          new City{
            ProvinceName= "کردستان",
            CountyName= "بانه",
            DistrictName= "نمشیر",
            CityName= "کانی سور",
            CityDivisionCode= 70809
          },
          new City{
            ProvinceName= "کردستان",
            CountyName= "بانه",
            DistrictName= "ننور",
            CityName= "بوئین سفلی",
            CityDivisionCode= 70810
          },
          new City{
            ProvinceName= "کردستان",
            CountyName= "بیجار",
            DistrictName= "چنگ الماس",
            CityName= "بابارشانی",
            CityDivisionCode= 70811
          },
          new City{
            ProvinceName= "کردستان",
            CountyName= "دیواندره",
            DistrictName= "کرفتو",
            CityName= "زرینه",
            CityDivisionCode= 70812
          },
          new City{
            ProvinceName= "کردستان",
            CountyName= "سقز",
            DistrictName= "زیویه",
            CityName= "صاحب",
            CityDivisionCode= 70813
          },
          new City{
            ProvinceName= "کردستان",
            CountyName= "سنندج",
            DistrictName= "کلاترزان",
            CityName= "شویشه",
            CityDivisionCode= 70814
          },
          new City{
            ProvinceName= "کردستان",
            CountyName= "قروه",
            DistrictName= "چهاردولی",
            CityName= "دزج",
            CityDivisionCode= 70815
          },
          new City{
            ProvinceName= "کردستان",
            CountyName= "قروه",
            DistrictName= "مرکزی",
            CityName= "دلبران",
            CityDivisionCode= 70816
          },
          new City{
            ProvinceName= "کردستان",
            CountyName= "کامیاران",
            DistrictName= "موچش",
            CityName= "موچش",
            CityDivisionCode= 70817
          },
          new City{
            ProvinceName= "کردستان",
            CountyName= "مریوان",
            DistrictName= "سرشیو",
            CityName= "چناره",
            CityDivisionCode= 70818
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "رفسنجان",
            DistrictName= "نوق",
            CityName= "بهرمان",
            CityDivisionCode= 70819
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "فاریاب",
            DistrictName= "مرکزی",
            CityName= "فاریاب",
            CityDivisionCode= 70820
          },
          new City{
            ProvinceName= "کرمانشاه",
            CountyName= "اسلام آباد غرب",
            DistrictName= "حمیل",
            CityName= "حمیل",
            CityDivisionCode= 70821
          },
          new City{
            ProvinceName= "کرمانشاه",
            CountyName= "دالاهو",
            DistrictName= "گهواره",
            CityName= "گهواره",
            CityDivisionCode= 70822
          },
          new City{
            ProvinceName= "کرمانشاه",
            CountyName= "صحنه",
            DistrictName= "دینور",
            CityName= "میان راهان",
            CityDivisionCode= 70823
          },
          new City{
            ProvinceName= "کرمانشاه",
            CountyName= "کرمانشاه",
            DistrictName= "فیروز آباد",
            CityName= "هلشی",
            CityDivisionCode= 70824
          },
          new City{
            ProvinceName= "کرمانشاه",
            CountyName= "کرمانشاه",
            DistrictName= "کوزران",
            CityName= "کوزران",
            CityDivisionCode= 70825
          },
          new City{
            ProvinceName= "کرمانشاه",
            CountyName= "گیلانغرب",
            DistrictName= "گواور",
            CityName= "سرمست",
            CityDivisionCode= 70826
          },
          new City{
            ProvinceName= "کهگیلویه و بویراحمد",
            CountyName= "بویر احمد",
            DistrictName= "لوداب",
            CityName= "گراب سفلی",
            CityDivisionCode= 70827
          },
          new City{
            ProvinceName= "کهگیلویه و بویراحمد",
            CountyName= "بویر احمد",
            DistrictName= "مارگون",
            CityName= "مارگون",
            CityDivisionCode= 70828
          },
          new City{
            ProvinceName= "کهگیلویه و بویراحمد",
            CountyName= "کهگیلویه",
            DistrictName= "چاروسا",
            CityName= "قلعه رئیسی",
            CityDivisionCode= 70829
          },
          new City{
            ProvinceName= "کهگیلویه و بویراحمد",
            CountyName= "کهگیلویه",
            DistrictName= "دیشموک",
            CityName= "دیشموک",
            CityDivisionCode= 70830
          },
          new City{
            ProvinceName= "گلستان",
            CountyName= "گنبد کاووس",
            DistrictName= "داشلی برون",
            CityName= "اینچه برون",
            CityDivisionCode= 70831
          },
          new City{
            ProvinceName= "گلستان",
            CountyName= "مراوه تپه",
            DistrictName= "مرکزی",
            CityName= "مراوه تپه",
            CityDivisionCode= 70832
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "رودبار",
            DistrictName= "خورگام",
            CityName= "بره سر",
            CityDivisionCode= 70833
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "شفت",
            DistrictName= "احمد سرگوراب",
            CityName= "احمد سرگوراب",
            CityDivisionCode= 70834
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "طوالش",
            DistrictName= "اسالم",
            CityName= "اسالم",
            CityDivisionCode= 70835
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "طوالش",
            DistrictName= "کرگانرود",
            CityName= "لیسار",
            CityDivisionCode= 70836
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "لاهیجان",
            DistrictName= "رودبنه",
            CityName= "رودبنه",
            CityDivisionCode= 70837
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "لنگرود",
            DistrictName= "اطاقور",
            CityName= "اطاقور",
            CityDivisionCode= 70838
          },
          new City{
            ProvinceName= "لرستان",
            CountyName= "خرم آباد",
            DistrictName= "پاپی",
            CityName= "سپید دشت",
            CityDivisionCode= 70839
          },
          new City{
            ProvinceName= "لرستان",
            CountyName= "خرم آباد",
            DistrictName= "بیرانوند",
            CityName= "بیرانشهر",
            CityDivisionCode= 70840
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "آمل",
            DistrictName= "لاریجان",
            CityName= "گزنک",
            CityDivisionCode= 70841
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "بابل",
            DistrictName= "بابل کنار",
            CityName= "مرزیکلا",
            CityDivisionCode= 70842
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "بابل",
            DistrictName= "بند پی شرقی",
            CityName= "گلوگاه",
            CityDivisionCode= 70843
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "بابل",
            DistrictName= "بند پی غربی",
            CityName= "خوش رودپی",
            CityDivisionCode= 70844
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "بابل",
            DistrictName= "لاله آباد",
            CityName= "زرگر محله",
            CityDivisionCode= 70845
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "بابلسر",
            DistrictName= "بهنمیر",
            CityName= "بهنمیر",
            CityDivisionCode= 70846
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "بابلسر",
            DistrictName= "رودبست",
            CityName= "هادی شهر",
            CityDivisionCode= 70847
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "جویبار",
            DistrictName= "گیل خوران",
            CityName= "کوهی خیل",
            CityDivisionCode= 70848
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "محمود آباد",
            DistrictName= "سرخرود",
            CityName= "سرخرود",
            CityDivisionCode= 70849
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "نور",
            DistrictName= "بلده",
            CityName= "بلده",
            CityDivisionCode= 70850
          },
          new City{
            ProvinceName= "مرکزی",
            CountyName= "زرندیه",
            DistrictName= "خرقان",
            CityName= "رازقان",
            CityDivisionCode= 70851
          },
          new City{
            ProvinceName= "مرکزی",
            CountyName= "شازند",
            DistrictName= "سربند",
            CityName= "هندودر",
            CityDivisionCode= 70852
          },
          new City{
            ProvinceName= "هرمزگان",
            CountyName= "قشم",
            DistrictName= "شهاب",
            CityName= "سوزا",
            CityDivisionCode= 70853
          },
          new City{
            ProvinceName= "همدان",
            CountyName= "تویسرکان",
            DistrictName= "قلقل رود",
            CityName= "فرسفج",
            CityDivisionCode= 70854
          },
          new City{
            ProvinceName= "همدان",
            CountyName= "کبودرآهنگ",
            DistrictName= "شیرین سو",
            CityName= "شیرین سو",
            CityDivisionCode= 70855
          },
          new City{
            ProvinceName= "همدان",
            CountyName= "کبودرآهنگ",
            DistrictName= "گل تپه",
            CityName= "گل تپه",
            CityDivisionCode= 70856
          },
          new City{
            ProvinceName= "همدان",
            CountyName= "ملایر",
            DistrictName= "جوکار",
            CityName= "جوکار",
            CityDivisionCode= 70857
          },
          new City{
            ProvinceName= "یزد",
            CountyName= "صدوق",
            DistrictName= "خضرآباد",
            CityName= "خضر آباد",
            CityDivisionCode= 70858
          },
          new City{
            ProvinceName= "بوشهر",
            CountyName= "دیر",
            DistrictName= "بردخون",
            CityName= "بردخون",
            CityDivisionCode= 70859
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "شهرضا",
            DistrictName= "مرکزی",
            CityName= "منظریه",
            CityDivisionCode= 70860
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "فلاورجان",
            DistrictName= "پیر بکران",
            CityName= "بهاران شهر",
            CityDivisionCode= 70861
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "فلاورجان",
            DistrictName= "مرکزی",
            CityName= "ایمانشهر",
            CityDivisionCode= 70862
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "کاشان",
            DistrictName= "قمصر",
            CityName= "کامو و چوگان",
            CityDivisionCode= 70863
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "لنجان",
            DistrictName= "مرکزی",
            CityName= "زاینده رود",
            CityDivisionCode= 70864
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "مبارکه",
            DistrictName= "مرکزی",
            CityName= "کرکوند",
            CityDivisionCode= 70865
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "سراب",
            DistrictName= "مهربان",
            CityName= "دوزدوزان",
            CityDivisionCode= 70866
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "مهر",
            DistrictName= "گله دار",
            CityName= "گله دار",
            CityDivisionCode= 70867
          },
          new City{
            ProvinceName= "بوشهر",
            CountyName= "بوشهر",
            DistrictName= "مرکزی",
            CityName= "چغادک",
            CityDivisionCode= 70868
          },
          new City{
            ProvinceName= "بوشهر",
            CountyName= "دشتستان",
            DistrictName= "سعد آباد",
            CityName= "وحدتیه",
            CityDivisionCode= 70869
          },
          new City{
            ProvinceName= "بوشهر",
            CountyName= "دیر",
            DistrictName= "مرکزی",
            CityName= "آبدان",
            CityDivisionCode= 70870
          },
          new City{
            ProvinceName= "تهران",
            CountyName= "شهریار",
            DistrictName= "مرکزی",
            CityName= "فردوسیه",
            CityDivisionCode= 70871
          },
          new City{
            ProvinceName= "چهار محال و بختیاری",
            CountyName= "شهر کرد",
            DistrictName= "مرکزی",
            CityName= "نافچ",
            CityDivisionCode= 70872
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "شیراز",
            DistrictName= "زرقان",
            CityName= "لپوئی",
            CityDivisionCode= 70873
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "قیروکارزین",
            DistrictName= "مرکزی",
            CityName= "کارزین",
            CityDivisionCode= 70874
          },
          new City{
            ProvinceName= "قم",
            CountyName= "قم",
            DistrictName= "خلجستان",
            CityName= "دستجرد",
            CityDivisionCode= 70875
          },
          new City{
            ProvinceName= "قم",
            CountyName= "قم",
            DistrictName= "مرکزی",
            CityName= "قنوات",
            CityDivisionCode= 70876
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "دزفول",
            DistrictName= "مرکزی",
            CityName= "شهر امام",
            CityDivisionCode= 70877
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "دزفول",
            DistrictName= "مرکزی",
            CityName= "میانرود",
            CityDivisionCode= 70878
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "دزفول",
            DistrictName= "مرکزی",
            CityName= "صفی آباد",
            CityDivisionCode= 70879
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "اصفهان",
            DistrictName= "کوهپایه",
            CityName= "تودشک",
            CityDivisionCode= 70880
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "گلپایگان",
            DistrictName= "مرکزی",
            CityName= "گلشهر",
            CityDivisionCode= 70881
          },
          new City{
            ProvinceName= "سیستان و بلوچستان",
            CountyName= "هیرمند",
            DistrictName= "مرکزی",
            CityName= "دوست محمد",
            CityDivisionCode= 70882
          },
          new City{
            ProvinceName= "قزوین",
            CountyName= "آوج",
            DistrictName= "آبگرم",
            CityName= "آبگرم",
            CityDivisionCode= 70883
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "اصفهان",
            DistrictName= "جرقویه سفلی",
            CityName= "نصرآباد",
            CityDivisionCode= 70884
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "آران و بیدگل",
            DistrictName= "مرکزی",
            CityName= "نوش آباد",
            CityDivisionCode= 70885
          },
          new City{
            ProvinceName= "گلستان",
            CountyName= "آق قلا",
            DistrictName= "وشمگیر",
            CityName= "انبار آلوم",
            CityDivisionCode= 70886
          },
          new City{
            ProvinceName= "گلستان",
            CountyName= "علی آباد",
            DistrictName= "کمالان",
            CityName= "فاضل آباد",
            CityDivisionCode= 70887
          },
          new City{
            ProvinceName= "گلستان",
            CountyName= "گرگان",
            DistrictName= "بهاران",
            CityName= "سرخنکلاته",
            CityDivisionCode= 70888
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "مبارکه",
            DistrictName= "گرکن جنوبی",
            CityName= "زیباشهر",
            CityDivisionCode= 70889
          },
          new City{
            ProvinceName= "خراسان جنوبی",
            CountyName= "سرایان",
            DistrictName= "سه قلعه",
            CityName= "سه قلعه",
            CityDivisionCode= 70890
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "نیشابور",
            DistrictName= "سرولایت",
            CityName= "چکنه",
            CityDivisionCode= 70891
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "باغ ملک",
            DistrictName= "مرکزی",
            CityName= "قلعه تل",
            CityDivisionCode= 70892
          },
          new City{
            ProvinceName= "قزوین",
            CountyName= "بوئین زهرا",
            DistrictName= "دشتابی",
            CityName= "ارداق",
            CityDivisionCode= 70893
          },
          new City{
            ProvinceName= "گلستان",
            CountyName= "گمیشان",
            DistrictName= "گلدشت",
            CityName= "سیمین شهر",
            CityDivisionCode= 70894
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "تیران و کرون",
            DistrictName= "مرکزی",
            CityName= "رضوانشهر",
            CityDivisionCode= 70895
          },
          new City{
            ProvinceName= "آذربایجان غربی",
            CountyName= "بوکان",
            DistrictName= "سیمینه",
            CityName= "سیمینه",
            CityDivisionCode= 70896
          },
          new City{
            ProvinceName= "آذربایجان غربی",
            CountyName= "چالدران",
            DistrictName= "دشتک",
            CityName= "آواجیق",
            CityDivisionCode= 70897
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "نی ریز",
            DistrictName= "پشتکوه",
            CityName= "مشکان",
            CityDivisionCode= 70898
          },
          new City{
            ProvinceName= "قزوین",
            CountyName= "البرز",
            DistrictName= "محمدیه",
            CityName= "بیدستان",
            CityDivisionCode= 70899
          },
          new City{
            ProvinceName= "قزوین",
            CountyName= "قزوین",
            DistrictName= "کوهین",
            CityName= "کوهین",
            CityDivisionCode= 70900
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "اصفهان",
            DistrictName= "مرکزی",
            CityName= "بهارستان",
            CityDivisionCode= 70901
          },
          new City{
            ProvinceName= "تهران",
            CountyName= "تهران",
            DistrictName= "مرکزی",
            CityName= "پردیس",
            CityDivisionCode= 70902
          },
          new City{
            ProvinceName= "البرز",
            CountyName= "ساوجبلاغ",
            DistrictName= "مرکزی",
            CityName= "شهر جدید هشتگرد",
            CityDivisionCode= 70903
          },
          new City{
            ProvinceName= "تهران",
            CountyName= "شهریار",
            DistrictName= "مرکزی",
            CityName= "اندیشه",
            CityDivisionCode= 70904
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "کلیبر",
            DistrictName= "آبش احمد",
            CityName= "آبش احمد",
            CityDivisionCode= 70905
          },
          new City{
            ProvinceName= "آذربایجان غربی",
            CountyName= "سر دشت",
            DistrictName= "مرکزی",
            CityName= "ربط",
            CityDivisionCode= 70906
          },
          new City{
            ProvinceName= "اردبیل",
            CountyName= "نمین",
            DistrictName= "عنبران",
            CityName= "عنبران",
            CityDivisionCode= 70907
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "برخوار",
            DistrictName= "حبیب آباد",
            CityName= "کمشجه",
            CityDivisionCode= 70908
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "فریدونشهر",
            DistrictName= "مرکزی",
            CityName= "برف انبار",
            CityDivisionCode= 70909
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "کاشان",
            DistrictName= "برزک",
            CityName= "برزک",
            CityDivisionCode= 70910
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "نجف آباد",
            DistrictName= "مرکزی",
            CityName= "کهریزسنگ",
            CityDivisionCode= 70911
          },
          new City{
            ProvinceName= "ایلام",
            CountyName= "چرداول",
            DistrictName= "هلیلان",
            CityName= "توحید",
            CityDivisionCode= 70912
          },
          new City{
            ProvinceName= "خراسان شمالی",
            CountyName= "مانه و سملقان",
            DistrictName= "سملقان",
            CityName= "قاضی",
            CityDivisionCode= 70913
          },
          new City{
            ProvinceName= "خراسان شمالی",
            CountyName= "مانه و سملقان",
            DistrictName= "مانه",
            CityName= "پیش قلعه",
            CityDivisionCode= 70914
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "بوانات",
            DistrictName= "سرچهان",
            CityName= "کره ای",
            CityDivisionCode= 70915
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "زرین دشت",
            DistrictName= "ایزد خواست",
            CityName= "شهر پیر",
            CityDivisionCode= 70916
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "لارستان",
            DistrictName= "مرکزی",
            CityName= "خور",
            CityDivisionCode= 70917
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "مهر",
            DistrictName= "وراوی",
            CityName= "وراوی",
            CityDivisionCode= 70918
          },
          new City{
            ProvinceName= "گلستان",
            CountyName= "آزاد شهر",
            DistrictName= "چشمه ساران",
            CityName= "نوده خاندوز",
            CityDivisionCode= 70919
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "شبستر",
            DistrictName= "مرکزی",
            CityName= "کوزه کنان",
            CityDivisionCode= 70921
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "آران و بیدگل",
            DistrictName= "مرکزی",
            CityName= "سفید شهر",
            CityDivisionCode= 70922
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "اندیکا",
            DistrictName= "مرکزی",
            CityName= "قلعه خواجه",
            CityDivisionCode= 70923
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "استهبان",
            DistrictName= "مرکزی",
            CityName= "ایج",
            CityDivisionCode= 70924
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "مرودشت",
            DistrictName= "کامفیروز",
            CityName= "کامفیروز",
            CityDivisionCode= 70925
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "سیرجان",
            DistrictName= "پاریز",
            CityName= "پاریز",
            CityDivisionCode= 70926
          },
          new City{
            ProvinceName= "مرکزی",
            CountyName= "اراک",
            DistrictName= "مرکزی",
            CityName= "داود آباد",
            CityDivisionCode= 70927
          },
          new City{
            ProvinceName= "مرکزی",
            CountyName= "خمین",
            DistrictName= "کمره",
            CityName= "قورچی باشی",
            CityDivisionCode= 70928
          },
          new City{
            ProvinceName= "آذربایجان غربی",
            CountyName= "پیرانشهر",
            DistrictName= "لاجان",
            CityName= "گردکشانه",
            CityDivisionCode= 70929
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "تایباد",
            DistrictName= "مرکزی",
            CityName= "کاریز",
            CityDivisionCode= 70930
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "خواف",
            DistrictName= "مرکزی",
            CityName= "نشتیفان",
            CityDivisionCode= 70931
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "فریمان",
            DistrictName= "مرکزی",
            CityName= "فرهاد گرد",
            CityDivisionCode= 70932
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "آستارا",
            DistrictName= "لوندویل",
            CityName= "لوندویل",
            CityDivisionCode= 70933
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "املش",
            DistrictName= "رانکوه",
            CityName= "رانکوه",
            CityDivisionCode= 70934
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "طوالش",
            DistrictName= "حویق",
            CityName= "حویق",
            CityDivisionCode= 70935
          },
          new City{
            ProvinceName= "بوشهر",
            CountyName= "عسلویه",
            DistrictName= "مرکزی",
            CityName= "عسلویه",
            CityDivisionCode= 70936
          },
          new City{
            ProvinceName= "بوشهر",
            CountyName= "عسلویه",
            DistrictName= "مرکزی",
            CityName= "نخل تقی",
            CityDivisionCode= 70937
          },
          new City{
            ProvinceName= "بوشهر",
            CountyName= "کنگان",
            DistrictName= "مرکزی",
            CityName= "بنک",
            CityDivisionCode= 70938
          },
          new City{
            ProvinceName= "چهار محال و بختیاری",
            CountyName= "شهر کرد",
            DistrictName= "لاران",
            CityName= "سودجان",
            CityDivisionCode= 70939
          },
          new City{
            ProvinceName= "مرکزی",
            CountyName= "شازند",
            DistrictName= "زالیان",
            CityName= "توره",
            CityDivisionCode= 70940
          },
          new City{
            ProvinceName= "البرز",
            CountyName= "ساوجبلاغ",
            DistrictName= "چندار",
            CityName= "کوهسار",
            CityDivisionCode= 70941
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "زرند",
            DistrictName= "مرکزی",
            CityName= "ریحان",
            CityDivisionCode= 70942
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "زرند",
            DistrictName= "یزدان آباد",
            CityName= "یزدان شهر",
            CityDivisionCode= 70943
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "کرمان",
            DistrictName= "شهداد",
            CityName= "اندوهجرد",
            CityDivisionCode= 70944
          },
          new City{
            ProvinceName= "سیستان و بلوچستان",
            CountyName= "سیب سوران",
            DistrictName= "هیدوچ",
            CityName= "هیدوچ",
            CityDivisionCode= 70945
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "خواف",
            DistrictName= "سلامی",
            CityName= "سلامی",
            CityDivisionCode= 70946
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "رشتخوار",
            DistrictName= "جنگل",
            CityName= "جنگل",
            CityDivisionCode= 70947
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "سرخس",
            DistrictName= "مرزداران",
            CityName= "مزدآوند",
            CityDivisionCode= 70948
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "اندیمشک",
            DistrictName= "الوار گرمسیری",
            CityName= "حسینیه",
            CityDivisionCode= 70949
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "باغ ملک",
            DistrictName= "صیدون",
            CityName= "صیدون",
            CityDivisionCode= 70950
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "مرند",
            DistrictName= "مرکزی",
            CityName= "بناب مرند",
            CityDivisionCode= 70951
          },
          new City{
            ProvinceName= "آذربایجان غربی",
            CountyName= "میاندوآب",
            DistrictName= "باروق",
            CityName= "باروق",
            CityDivisionCode= 70952
          },
          new City{
            ProvinceName= "بوشهر",
            CountyName= "دشتستان",
            DistrictName= "ارم",
            CityName= "تنگ ارم",
            CityDivisionCode= 70953
          },
          new City{
            ProvinceName= "بوشهر",
            CountyName= "دشتستان",
            DistrictName= "بوشکان",
            CityName= "کلمه",
            CityDivisionCode= 70954
          },
          new City{
            ProvinceName= "خراسان جنوبی",
            CountyName= "زیرکوه",
            DistrictName= "زهان",
            CityName= "زهان",
            CityDivisionCode= 70955
          },
          new City{
            ProvinceName= "خراسان جنوبی",
            CountyName= "قائنات",
            DistrictName= "سده",
            CityName= "آرین شهر",
            CityDivisionCode= 70956
          },
          new City{
            ProvinceName= "خراسان جنوبی",
            CountyName= "قائنات",
            DistrictName= "مرکزی",
            CityName= "اسفدن",
            CityDivisionCode= 70957
          },
          new City{
            ProvinceName= "خراسان جنوبی",
            CountyName= "قائنات",
            DistrictName= "نیمبلوک",
            CityName= "نیمبلوک",
            CityDivisionCode= 70958
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "بجستان",
            DistrictName= "یونسی",
            CityName= "یونسی",
            CityDivisionCode= 70959
          },
          new City{
            ProvinceName= "لرستان",
            CountyName= "کوهدشت",
            DistrictName= "درب گنبد",
            CityName= "درب گنبد",
            CityDivisionCode= 70960
          },
          new City{
            ProvinceName= "اردبیل",
            CountyName= "نیر",
            DistrictName= "کورائیم",
            CityName= "کورائیم",
            CityDivisionCode= 70961
          },
          new City{
            ProvinceName= "تهران",
            CountyName= "شهریار",
            DistrictName= "مرکزی",
            CityName= "باغستان",
            CityDivisionCode= 70962
          },
          new City{
            ProvinceName= "البرز",
            CountyName= "کرج",
            DistrictName= "مرکزی",
            CityName= "گرمدره",
            CityDivisionCode= 70963
          },
          new City{
            ProvinceName= "قزوین",
            CountyName= "آبیک",
            DistrictName= "بشاریات",
            CityName= "خاکعلی",
            CityDivisionCode= 70964
          },
          new City{
            ProvinceName= "قزوین",
            CountyName= "تاکستان",
            DistrictName= "مرکزی",
            CityName= "نرجه",
            CityDivisionCode= 70965
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "طوالش",
            DistrictName= "حویق",
            CityName= "چوبر",
            CityDivisionCode= 70966
          },
          new City{
            ProvinceName= "ایلام",
            CountyName= "چرداول",
            DistrictName= "مرکزی",
            CityName= "آسمان آباد",
            CityDivisionCode= 70967
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "فریمان",
            DistrictName= "قلندر آباد",
            CityName= "سفید سنگ",
            CityDivisionCode= 70968
          },
          new City{
            ProvinceName= "هرمزگان",
            CountyName= "بستک",
            DistrictName= "جناح",
            CityName= "جناح",
            CityDivisionCode= 70969
          },
          new City{
            ProvinceName= "هرمزگان",
            CountyName= "حاجی آباد",
            DistrictName= "فارغان",
            CityName= "فارغان",
            CityDivisionCode= 70970
          },
          new City{
            ProvinceName= "هرمزگان",
            CountyName= "قشم",
            DistrictName= "مرکزی",
            CityName= "درگهان",
            CityDivisionCode= 70971
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "نطنز",
            DistrictName= "امام زاده",
            CityName= "خالد آباد",
            CityDivisionCode= 70972
          },
          new City{
            ProvinceName= "گلستان",
            CountyName= "آزاد شهر",
            DistrictName= "مرکزی",
            CityName= "نگین شهر",
            CityDivisionCode= 70973
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "هشترود",
            DistrictName= "نظرکهریزی",
            CityName= "نظرکهریزی",
            CityDivisionCode= 70974
          },
          new City{
            ProvinceName= "ایلام",
            CountyName= "آبدانان",
            DistrictName= "کلات",
            CityName= "مورموری",
            CityDivisionCode= 70975
          },
          new City{
            ProvinceName= "قزوین",
            CountyName= "بوئین زهرا",
            DistrictName= "مرکزی",
            CityName= "سگز آباد",
            CityDivisionCode= 70976
          },
          new City{
            ProvinceName= "یزد",
            CountyName= "اردکان",
            DistrictName= "عقدا",
            CityName= "عقدا",
            CityDivisionCode= 70977
          },
          new City{
            ProvinceName= "خراسان جنوبی",
            CountyName= "طبس",
            DistrictName= "دیهوک",
            CityName= "دیهوک",
            CityDivisionCode= 70978
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "نرماشیر",
            DistrictName= "روداب",
            CityName= "نظام شهر",
            CityDivisionCode= 70979
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "راور",
            DistrictName= "کوهساران",
            CityName= "هجدک",
            CityDivisionCode= 70980
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "عنبر آباد",
            DistrictName= "جبالبارز جنوبی",
            CityName= "مردهک",
            CityDivisionCode= 70981
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "منوجان",
            DistrictName= "آسمینون",
            CityName= "نودژ",
            CityDivisionCode= 70982
          },
          new City{
            ProvinceName= "تهران",
            CountyName= "دماوند",
            DistrictName= "رودهن",
            CityName= "آبعلی",
            CityDivisionCode= 70983
          },
          new City{
            ProvinceName= "البرز",
            CountyName= "ساوجبلاغ",
            DistrictName= "چهار باغ",
            CityName= "چهارباغ",
            CityDivisionCode= 70984
          },
          new City{
            ProvinceName= "آذربایجان غربی",
            CountyName= "شاهین دژ",
            DistrictName= "مرکزی",
            CityName= "محمود آباد",
            CityDivisionCode= 70985
          },
          new City{
            ProvinceName= "تهران",
            CountyName= "فیروز کوه",
            DistrictName= "ارجمند",
            CityName= "ارجمند",
            CityDivisionCode= 70986
          },
          new City{
            ProvinceName= "خراسان جنوبی",
            CountyName= "سربیشه",
            DistrictName= "مود",
            CityName= "مود",
            CityDivisionCode= 70987
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "کلات",
            DistrictName= "زاوین",
            CityName= "شهر زو",
            CityDivisionCode= 70988
          },
          new City{
            ProvinceName= "خراسان شمالی",
            CountyName= "گرمه",
            DistrictName= "مرکزی",
            CityName= "درق",
            CityDivisionCode= 70989
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "آباده",
            DistrictName= "مرکزی",
            CityName= "سورمق",
            CityDivisionCode= 70990
          },
          new City{
            ProvinceName= "کرمانشاه",
            CountyName= "ثلاث باباجانی",
            DistrictName= "ازگله",
            CityName= "ازگله",
            CityDivisionCode= 70991
          },
          new City{
            ProvinceName= "کرمانشاه",
            CountyName= "سنقر",
            DistrictName= "کلیائی",
            CityName= "سطر",
            CityDivisionCode= 70992
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "آمل",
            DistrictName= "دابودشت",
            CityName= "دابودشت",
            CityDivisionCode= 70993
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "بابل",
            DistrictName= "گتاب",
            CityName= "گتاب",
            CityDivisionCode= 70994
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "ساری",
            DistrictName= "دودانگه",
            CityName= "فریم",
            CityDivisionCode= 70995
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "بهشهر",
            DistrictName= "مرکزی",
            CityName= "خلیل شهر",
            CityDivisionCode= 70996
          },
          new City{
            ProvinceName= "تهران",
            CountyName= "بهارستان",
            DistrictName= "گلستان",
            CityName= "نصیرشهر",
            CityDivisionCode= 70997
          },
          new City{
            ProvinceName= "تهران",
            CountyName= "بهارستان",
            DistrictName= "گلستان",
            CityName= "صالحیه",
            CityDivisionCode= 70998
          },
          new City{
            ProvinceName= "قزوین",
            CountyName= "قزوین",
            DistrictName= "طارم سفلی",
            CityName= "سیردان",
            CityDivisionCode= 70999
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "نور",
            DistrictName= "مرکزی",
            CityName= "ایزد شهر",
            CityDivisionCode= 71000
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "زرین دشت",
            DistrictName= "مرکزی",
            CityName= "دبیران",
            CityDivisionCode= 71001
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "فسا",
            DistrictName= "نوبندگان",
            CityName= "نوبندگان",
            CityDivisionCode= 71002
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "قیروکارزین",
            DistrictName= "افزر",
            CityName= "افزر",
            CityDivisionCode= 71003
          },
          new City{
            ProvinceName= "هرمزگان",
            CountyName= "رودان",
            DistrictName= "رودخانه",
            CityName= "زیارتعلی",
            CityDivisionCode= 71004
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "کاشان",
            DistrictName= "مرکزی",
            CityName= "مشکات",
            CityDivisionCode= 71005
          },
          new City{
            ProvinceName= "بوشهر",
            CountyName= "جم",
            DistrictName= "ریز",
            CityName= "ریز",
            CityDivisionCode= 71006
          },
          new City{
            ProvinceName= "بوشهر",
            CountyName= "کنگان",
            DistrictName= "مرکزی",
            CityName= "سیراف",
            CityDivisionCode= 71007
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "شوش",
            DistrictName= "مرکزی",
            CityName= "حر",
            CityDivisionCode= 71008
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "هندیجان",
            DistrictName= "چم خلف عیسی",
            CityName= "زهره",
            CityDivisionCode= 71009
          },
          new City{
            ProvinceName= "همدان",
            CountyName= "ملایر",
            DistrictName= "زند",
            CityName= "زنگنه",
            CityDivisionCode= 71010
          },
          new City{
            ProvinceName= "همدان",
            CountyName= "نهاوند",
            DistrictName= "زرین دشت",
            CityName= "برزول",
            CityDivisionCode= 71011
          },
          new City{
            ProvinceName= "همدان",
            CountyName= "نهاوند",
            DistrictName= "گیان",
            CityName= "گیان",
            CityDivisionCode= 71012
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "تایباد",
            DistrictName= "میان ولایت",
            CityName= "مشهدریزه",
            CityDivisionCode= 71013
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "تربت جام",
            DistrictName= "بوژگان",
            CityName= "نیل شهر",
            CityDivisionCode= 71014
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "خلیل آباد",
            DistrictName= "ششطراز",
            CityName= "کندر",
            CityDivisionCode= 71015
          },
          new City{
            ProvinceName= "مرکزی",
            CountyName= "شازند",
            DistrictName= "زالیان",
            CityName= "شهر جدید مهاجران",
            CityDivisionCode= 71016
          },
          new City{
            ProvinceName= "چهار محال و بختیاری",
            CountyName= "بروجن",
            DistrictName= "مرکزی",
            CityName= "نقنه",
            CityDivisionCode= 71017
          },
          new City{
            ProvinceName= "اردبیل",
            CountyName= "مشگین شهر",
            DistrictName= "مشگین شرقی",
            CityName= "فخرآباد",
            CityDivisionCode= 71018
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "اسکو",
            DistrictName= "مرکزی",
            CityName= "شهر جدید سهند",
            CityDivisionCode= 71019
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "شاهین شهر و میمه",
            DistrictName= "مرکزی",
            CityName= "گرگاب",
            CityDivisionCode= 71020
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "شاهین شهر و میمه",
            DistrictName= "میمه",
            CityName= "لای بید",
            CityDivisionCode= 71021
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "آبادان",
            DistrictName= "مرکزی",
            CityName= "چوئبده",
            CityDivisionCode= 71022
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "شادگان",
            DistrictName= "مرکزی",
            CityName= "دارخوین",
            CityDivisionCode= 71023
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "گتوند",
            DistrictName= "عقیلی",
            CityName= "ترکالکی",
            CityDivisionCode= 71024
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "لارستان",
            DistrictName= "مرکزی",
            CityName= "لطیفی",
            CityDivisionCode= 71025
          },
          new City{
            ProvinceName= "البرز",
            CountyName= "نظر آباد",
            DistrictName= "تنکمان",
            CityName= "تنکمان",
            CityDivisionCode= 71026
          },
          new City{
            ProvinceName= "ایلام",
            CountyName= "ملکشاهی",
            DistrictName= "گچی",
            CityName= "دلگشا",
            CityDivisionCode= 71027
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "اصفهان",
            DistrictName= "مرکزی",
            CityName= "قهجاورستان",
            CityDivisionCode= 71028
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "نیشابور",
            DistrictName= "مرکزی",
            CityName= "بار",
            CityDivisionCode= 71029
          },
          new City{
            ProvinceName= "خراسان شمالی",
            CountyName= "گرمه",
            DistrictName= "مرکزی",
            CityName= "ایور",
            CityDivisionCode= 71030
          },
          new City{
            ProvinceName= "سیستان و بلوچستان",
            CountyName= "ایرانشهر",
            DistrictName= "بمپور",
            CityName= "محمدان",
            CityDivisionCode= 71031
          },
          new City{
            ProvinceName= "مرکزی",
            CountyName= "زرندیه",
            DistrictName= "مرکزی",
            CityName= "خشکرود",
            CityDivisionCode= 71032
          },
          new City{
            ProvinceName= "هرمزگان",
            CountyName= "رودان",
            DistrictName= "بیکاه",
            CityName= "بیکاه",
            CityDivisionCode= 71033
          },
          new City{
            ProvinceName= "آذربایجان غربی",
            CountyName= "خوی",
            DistrictName= "قطور",
            CityName= "قطور",
            CityDivisionCode= 71034
          },
          new City{
            ProvinceName= "آذربایجان غربی",
            CountyName= "خوی",
            DistrictName= "مرکزی",
            CityName= "دیزج دیز",
            CityDivisionCode= 71035
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "نجف آباد",
            DistrictName= "مرکزی",
            CityName= "جوزدان",
            CityDivisionCode= 71036
          },
          new City{
            ProvinceName= "البرز",
            CountyName= "ساوجبلاغ",
            DistrictName= "مرکزی",
            CityName= "گلسار",
            CityDivisionCode= 71037
          },
          new City{
            ProvinceName= "خراسان جنوبی",
            CountyName= "خوسف",
            DistrictName= "مرکزی",
            CityName= "محمدشهر",
            CityDivisionCode= 71038
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "تربت جام",
            DistrictName= "بوژگان",
            CityName= "احمدآباد صولت",
            CityDivisionCode= 71039
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "چناران",
            DistrictName= "گلبهار",
            CityName= "گلمکان",
            CityDivisionCode= 71040
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "دزفول",
            DistrictName= "سردشت",
            CityName= "حمزه",
            CityDivisionCode= 71041
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "شوشتر",
            DistrictName= "مرکزی",
            CityName= "شرافت",
            CityDivisionCode= 71042
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "گتوند",
            DistrictName= "مرکزی",
            CityName= "صالح شهر",
            CityDivisionCode= 71043
          },
          new City{
            ProvinceName= "زنجان",
            CountyName= "خدابنده",
            DistrictName= "مرکزی",
            CityName= "سهرورد",
            CityDivisionCode= 71044
          },
          new City{
            ProvinceName= "سمنان",
            CountyName= "مهدی شهر",
            DistrictName= "مرکزی",
            CityName= "درجزین",
            CityDivisionCode= 71045
          },
          new City{
            ProvinceName= "سیستان و بلوچستان",
            CountyName= "هامون",
            DistrictName= "مرکزی",
            CityName= "علی اکبر",
            CityDivisionCode= 71046
          },
          new City{
            ProvinceName= "سیستان و بلوچستان",
            CountyName= "سراوان",
            DistrictName= "مرکزی",
            CityName= "گشت",
            CityDivisionCode= 71047
          },
          new City{
            ProvinceName= "سیستان و بلوچستان",
            CountyName= "سراوان",
            DistrictName= "مرکزی",
            CityName= "محمدی",
            CityDivisionCode= 71048
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "اقلید",
            DistrictName= "سده",
            CityName= "دژکرد",
            CityDivisionCode= 71049
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "داراب",
            DistrictName= "فورگ",
            CityName= "فدامی",
            CityDivisionCode= 71050
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "قیروکارزین",
            DistrictName= "مرکزی",
            CityName= "امام شهر",
            CityDivisionCode= 71051
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "قیروکارزین",
            DistrictName= "مرکزی",
            CityName= "مبارک آباد",
            CityDivisionCode= 71052
          },
          new City{
            ProvinceName= "قزوین",
            CountyName= "البرز",
            DistrictName= "محمدیه",
            CityName= "شریفیه",
            CityDivisionCode= 71053
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "شهر بابک",
            DistrictName= "دهج",
            CityName= "جوزم",
            CityDivisionCode= 71054
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "شهر بابک",
            DistrictName= "مرکزی",
            CityName= "خورسند",
            CityDivisionCode= 71055
          },
          new City{
            ProvinceName= "کهگیلویه و بویراحمد",
            CountyName= "بویر احمد",
            DistrictName= "مرکزی",
            CityName= "مادوان",
            CityDivisionCode= 71056
          },
          new City{
            ProvinceName= "گلستان",
            CountyName= "گرگان",
            DistrictName= "مرکزی",
            CityName= "جلین",
            CityDivisionCode= 71057
          },
          new City{
            ProvinceName= "هرمزگان",
            CountyName= "پارسیان",
            DistrictName= "کوشکنار",
            CityName= "کوشکنار",
            CityDivisionCode= 71058
          },
          new City{
            ProvinceName= "هرمزگان",
            CountyName= "خمیر",
            DistrictName= "رویدر",
            CityName= "رویدر",
            CityDivisionCode= 71059
          },
          new City{
            ProvinceName= "هرمزگان",
            CountyName= "میناب",
            DistrictName= "توکهور",
            CityName= "هشتبندی",
            CityDivisionCode= 71060
          },
          new City{
            ProvinceName= "یزد",
            CountyName= "میبد",
            DistrictName= "مرکزی",
            CityName= "بفروئیه",
            CityDivisionCode= 71061
          },
          new City{
            ProvinceName= "قم",
            CountyName= "قم",
            DistrictName= "سلفچگان",
            CityName= "سلفچگان",
            CityDivisionCode= 71062
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "تنکابن",
            DistrictName= "مرکزی",
            CityName= "شیرود",
            CityDivisionCode= 71063
          },
          new City{
            ProvinceName= "اردبیل",
            CountyName= "پارس آباد",
            DistrictName= "تازه کند",
            CityName= "تازه کند",
            CityDivisionCode= 71064
          },
          new City{
            ProvinceName= "ایلام",
            CountyName= "آبدانان",
            DistrictName= "سراب باغ",
            CityName= "سراب باغ",
            CityDivisionCode= 71065
          },
          new City{
            ProvinceName= "کرمانشاه",
            CountyName= "روانسر",
            DistrictName= "شاهو",
            CityName= "شاهو",
            CityDivisionCode= 71066
          },
          new City{
            ProvinceName= "خراسان جنوبی",
            CountyName= "درمیان",
            DistrictName= "قهستان",
            CityName= "قهستان",
            CityDivisionCode= 71067
          },
          new City{
            ProvinceName= "خراسان جنوبی",
            CountyName= "درمیان",
            DistrictName= "گزیک",
            CityName= "طبس مسینا",
            CityDivisionCode= 71068
          },
          new City{
            ProvinceName= "خراسان شمالی",
            CountyName= "گرمه",
            DistrictName= "مرکزی",
            CityName= "گرمه",
            CityDivisionCode= 71069
          },
          new City{
            ProvinceName= "هرمزگان",
            CountyName= "بشاگرد",
            DistrictName= "مرکزی",
            CityName= "سردشت",
            CityDivisionCode= 71070
          },
          new City{
            ProvinceName= "هرمزگان",
            CountyName= "بشاگرد",
            DistrictName= "گوهران",
            CityName= "گوهران",
            CityDivisionCode= 71071
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "شوش",
            DistrictName= "شاوور",
            CityName= "شاوور",
            CityDivisionCode= 71072
          },
          new City{
            ProvinceName= "سیستان و بلوچستان",
            CountyName= "کنارک",
            DistrictName= "زرآباد",
            CityName= "زرآباد",
            CityDivisionCode= 71073
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "بردسیر",
            DistrictName= "لاله زار",
            CityName= "لاله زار",
            CityDivisionCode= 71074
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "شیراز",
            DistrictName= "ارژن",
            CityName= "خانه زنیان",
            CityDivisionCode= 71075
          },
          new City{
            ProvinceName= "البرز",
            CountyName= "کرج",
            DistrictName= "آسارا",
            CityName= "آسارا",
            CityDivisionCode= 71076
          },
          new City{
            ProvinceName= "زنجان",
            CountyName= "زنجان",
            DistrictName= "قره پشتلو",
            CityName= "ارمخانخانه",
            CityDivisionCode= 71077
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "فیروزه",
            DistrictName= "طاغنکوه",
            CityName= "همت آباد",
            CityDivisionCode= 71078
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "مه ولات",
            DistrictName= "شادمهر",
            CityName= "شادمهر",
            CityDivisionCode= 71079
          },
          new City{
            ProvinceName= "بوشهر",
            CountyName= "دشتی",
            DistrictName= "شنبه و طسوج",
            CityName= "شنبه",
            CityDivisionCode= 71080
          },
          new City{
            ProvinceName= "کهگیلویه و بویراحمد",
            CountyName= "دنا",
            DistrictName= "پاتاوه",
            CityName= "پاتاوه",
            CityDivisionCode= 71081
          },
          new City{
            ProvinceName= "کهگیلویه و بویراحمد",
            CountyName= "بویر احمد",
            DistrictName= "کبگیان",
            CityName= "چیتاب",
            CityDivisionCode= 71082
          },
          new City{
            ProvinceName= "کردستان",
            CountyName= "دهگلان",
            DistrictName= "بلبان آباد",
            CityName= "بلبان آباد",
            CityDivisionCode= 71083
          },
          new City{
            ProvinceName= "هرمزگان",
            CountyName= "بندرعباس",
            DistrictName= "قلعه قاضی",
            CityName= "قلعه قاضی",
            CityDivisionCode= 71084
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "مرودشت",
            DistrictName= "درودزن",
            CityName= "رامجرد",
            CityDivisionCode= 71085
          },
          new City{
            ProvinceName= "هرمزگان",
            CountyName= "میناب",
            DistrictName= "سندرک",
            CityName= "سندرک",
            CityDivisionCode= 71086
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "رفسنجان",
            DistrictName= "فردوس",
            CityName= "صفائیه",
            CityDivisionCode= 71087
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "فراشبند",
            DistrictName= "دهرم",
            CityName= "دهرم",
            CityDivisionCode= 71088
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "نی ریز",
            DistrictName= "قطرویه",
            CityName= "قطرویه",
            CityDivisionCode= 71089
          },
          new City{
            ProvinceName= "کردستان",
            CountyName= "مریوان",
            DistrictName= "مرکزی",
            CityName= "کانی دینار",
            CityDivisionCode= 71090
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "فراشبند",
            DistrictName= "مرکزی",
            CityName= "نوجین",
            CityDivisionCode= 71091
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "لنگرود",
            DistrictName= "مرکزی",
            CityName= "چاف و چمخاله",
            CityDivisionCode= 71092
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "شهر بابک",
            DistrictName= "مرکزی",
            CityName= "خاتون آباد",
            CityDivisionCode= 71093
          },
          new City{
            ProvinceName= "خراسان رضوی",
            CountyName= "بردسکن",
            DistrictName= "شهرآباد",
            CityName= "شهرآباد",
            CityDivisionCode= 71094
          },
          new City{
            ProvinceName= "بوشهر",
            CountyName= "جم",
            DistrictName= "ریز",
            CityName= "انارستان",
            CityDivisionCode= 71095
          },
          new City{
            ProvinceName= "خراسان شمالی",
            CountyName= "فاروج",
            DistrictName= "خبوشان",
            CityName= "تیتکانلو",
            CityDivisionCode= 71096
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "رشت",
            DistrictName= "کوچصفهان",
            CityName= "لولمان",
            CityDivisionCode= 71097
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "داراب",
            DistrictName= "فورگ",
            CityName= "دوبرجی",
            CityDivisionCode= 71098
          },
          new City{
            ProvinceName= "هرمزگان",
            CountyName= "بندرعباس",
            DistrictName= "تخت",
            CityName= "تخت",
            CityDivisionCode= 71099
          },
          new City{
            ProvinceName= "مرکزی",
            CountyName= "خنداب",
            DistrictName= "قره چای",
            CityName= "جاورسیان",
            CityDivisionCode= 71100
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "اقلید",
            DistrictName= "حسن آباد",
            CityName= "حسن آباد",
            CityDivisionCode= 71101
          },
          new City{
            ProvinceName= "مرکزی",
            CountyName= "اراک",
            DistrictName= "ساروق",
            CityName= "ساروق",
            CityDivisionCode= 71102
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "نائین",
            DistrictName= "مرکزی",
            CityName= "بافران",
            CityDivisionCode= 71103
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "خور و بیابانک",
            DistrictName= "مرکزی",
            CityName= "فرخی",
            CityDivisionCode= 71104
          },
          new City{
            ProvinceName= "هرمزگان",
            CountyName= "حاجی آباد",
            DistrictName= "احمدی",
            CityName= "سرگز",
            CityDivisionCode= 71105
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "لارستان",
            DistrictName= "صحرای باغ",
            CityName= "عماد ده",
            CityDivisionCode= 71106
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "سروستان",
            DistrictName= "کوهنجان",
            CityName= "کوهنجان",
            CityDivisionCode= 71107
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "شیراز",
            DistrictName= "مرکزی",
            CityName= "شهر جدید صدرا",
            CityDivisionCode= 71108
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "مهر",
            DistrictName= "اسیر",
            CityName= "اسیر",
            CityDivisionCode= 71109
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "گتوند",
            DistrictName= "مرکزی",
            CityName= "جنت مکان",
            CityDivisionCode= 71110
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "جهرم",
            DistrictName= "سیمکان",
            CityName= "دوزه",
            CityDivisionCode= 71111
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "سپیدان",
            DistrictName= "همایجان",
            CityName= "هماشهر",
            CityDivisionCode= 71112
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "عنبر آباد",
            DistrictName= "مرکزی",
            CityName= "دوساری",
            CityDivisionCode= 71113
          },
          new City{
            ProvinceName= "خراسان جنوبی",
            CountyName= "بشرویه",
            DistrictName= "ارسک",
            CityName= "ارسک",
            CityDivisionCode= 71114
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "دزفول",
            DistrictName= "چغامیش",
            CityName= "چغامیش",
            CityDivisionCode= 71115
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "گتوند",
            DistrictName= "عقیلی",
            CityName= "سماله",
            CityDivisionCode= 71116
          },
          new City{
            ProvinceName= "خراسان جنوبی",
            CountyName= "درمیان",
            DistrictName= "گزیک",
            CityName= "گزیک",
            CityDivisionCode= 71117
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "شوشتر",
            DistrictName= "شعیبیه",
            CityName= "گوریه",
            CityDivisionCode= 71118
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "باغ ملک",
            DistrictName= "میداود",
            CityName= "میداود",
            CityDivisionCode= 71119
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "ممسنی",
            DistrictName= "مرکزی",
            CityName= "خومه زار",
            CityDivisionCode= 71120
          },
          new City{
            ProvinceName= "لرستان",
            CountyName= "الیگودرز",
            DistrictName= "زز و ماهرو",
            CityName= "شول آباد",
            CityDivisionCode= 71121
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "شوش",
            DistrictName= "فتح المبین",
            CityName= "فتح المبین",
            CityDivisionCode= 71122
          },
          new City{
            ProvinceName= "تهران",
            CountyName= "پاکدشت",
            DistrictName= "مرکزی",
            CityName= "فرون آباد",
            CityDivisionCode= 71123
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "رامشیر",
            DistrictName= "مشراگه",
            CityName= "مشراگه",
            CityDivisionCode= 71124
          },
          new City{
            ProvinceName= "لرستان",
            CountyName= "دلفان",
            DistrictName= "کاکاوند",
            CityName= "هفت چشمه",
            CityDivisionCode= 71125
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "برخوار",
            DistrictName= "حبیب آباد",
            CityName= "شاپورآباد",
            CityDivisionCode= 71126
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "دهاقان",
            DistrictName= "مرکزی",
            CityName= "گلشن",
            CityDivisionCode= 71127
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "نوشهر",
            DistrictName= "کجور",
            CityName= "پول",
            CityDivisionCode= 71128
          },
          new City{
            ProvinceName= "اردبیل",
            CountyName= "مشگین شهر",
            DistrictName= "مرادلو",
            CityName= "مرادلو",
            CityDivisionCode= 71129
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "بوانات",
            DistrictName= "سرچهان",
            CityName= "حسامی",
            CityDivisionCode= 71130
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "سیرجان",
            DistrictName= "پاریز",
            CityName= "هماشهر",
            CityDivisionCode= 71131
          },
          new City{
            ProvinceName= "آذربایجان غربی",
            CountyName= "مهاباد",
            DistrictName= "خلیفان",
            CityName= "خلیفان",
            CityDivisionCode= 71132
          },
          new City{
            ProvinceName= "بوشهر",
            CountyName= "دیر",
            DistrictName= "مرکزی",
            CityName= "بردستان",
            CityDivisionCode= 71133
          },
          new City{
            ProvinceName= "ایلام",
            CountyName= "ملکشاهی",
            DistrictName= "گچی",
            CityName= "مهر",
            CityDivisionCode= 71134
          },
          new City{
            ProvinceName= "آذربایجان غربی",
            CountyName= "خوی",
            DistrictName= "صفائیه",
            CityName= "زرآباد",
            CityDivisionCode= 71135
          },
          new City{
            ProvinceName= "آذربایجان غربی",
            CountyName= "شوط",
            DistrictName= "قره قویون",
            CityName= "مرگنلر",
            CityDivisionCode= 71136
          },
          new City{
            ProvinceName= "آذربایجان غربی",
            CountyName= "پلدشت",
            DistrictName= "ارس",
            CityName= "نازک علیا",
            CityDivisionCode= 71137
          },
          new City{
            ProvinceName= "چهار محال و بختیاری",
            CountyName= "فارسان",
            DistrictName= "مرکزی",
            CityName= "پردنجان",
            CityDivisionCode= 71138
          },
          new City{
            ProvinceName= "چهار محال و بختیاری",
            CountyName= "کیار",
            DistrictName= "مرکزی",
            CityName= "دستناء",
            CityDivisionCode= 71139
          },
          new City{
            ProvinceName= "چهار محال و بختیاری",
            CountyName= "لردگان",
            DistrictName= "منج",
            CityName= "منج",
            CityDivisionCode= 71140
          },
          new City{
            ProvinceName= "چهار محال و بختیاری",
            CountyName= "بن",
            DistrictName= "مرکزی",
            CityName= "وردنجان",
            CityDivisionCode= 71141
          },
          new City{
            ProvinceName= "مرکزی",
            CountyName= "اراک",
            DistrictName= "معصومیه",
            CityName= "کارچان",
            CityDivisionCode= 71142
          },
          new City{
            ProvinceName= "سمنان",
            CountyName= "دامغان",
            DistrictName= "مرکزی",
            CityName= "کلاته",
            CityDivisionCode= 71143
          },
          new City{
            ProvinceName= "هرمزگان",
            CountyName= "سیریک",
            DistrictName= "مرکزی",
            CityName= "گروک",
            CityDivisionCode= 71144
          },
          new City{
            ProvinceName= "کردستان",
            CountyName= "سروآباد",
            DistrictName= "اورامان",
            CityName= "اورامان تخت",
            CityDivisionCode= 71145
          },
          new City{
            ProvinceName= "کردستان",
            CountyName= "مریوان",
            DistrictName= "خاوومیر آباد",
            CityName= "برده رشه",
            CityDivisionCode= 71146
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "دزفول",
            DistrictName= "مرکزی",
            CityName= "شمس آباد",
            CityDivisionCode= 71147
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "فسا",
            DistrictName= "ششده و قره بلاغ",
            CityName= "قره بلاغ",
            CityDivisionCode= 71148
          },
          new City{
            ProvinceName= "زنجان",
            CountyName= "زنجان",
            DistrictName= "زنجانرود",
            CityName= "نیک پی",
            CityDivisionCode= 71149
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "ساری",
            DistrictName= "کلیجان رستاق",
            CityName= "پایین هولار",
            CityDivisionCode= 71150
          },
          new City{
            ProvinceName= "هرمزگان",
            CountyName= "پارسیان",
            DistrictName= "کوشکنار",
            CityName= "دشتی",
            CityDivisionCode= 71151
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "قائم شهر",
            DistrictName= "مرکزی",
            CityName= "ارطه",
            CityDivisionCode= 71152
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "چالوس",
            DistrictName= "مرکزی",
            CityName= "هچیرود",
            CityDivisionCode= 71153
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "آذرشهر",
            DistrictName= "گوگان",
            CityName= "تیمورلو",
            CityDivisionCode= 71154
          },
          new City{
            ProvinceName= "همدان",
            CountyName= "اسد آباد",
            DistrictName= "پیرسلمان",
            CityName= "آجین",
            CityDivisionCode= 71155
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "خمینی شهر",
            DistrictName= "مرکزی",
            CityName= "اصغرآباد",
            CityDivisionCode= 71156
          },
          new City{
            ProvinceName= "کرمانشاه",
            CountyName= "پاوه",
            DistrictName= "باینگان",
            CityName= "بانوره",
            CityDivisionCode= 71157
          },
          new City{
            ProvinceName= "کرمانشاه",
            CountyName= "دالاهو",
            DistrictName= "مرکزی",
            CityName= "ریجاب",
            CityDivisionCode= 71158
          },
          new City{
            ProvinceName= "گلستان",
            CountyName= "رامیان",
            DistrictName= "مرکزی",
            CityName= "تاتار علیا",
            CityDivisionCode= 71159
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "نطنز",
            DistrictName= "مرکزی",
            CityName= "طرق رود",
            CityDivisionCode= 71160
          },
          new City{
            ProvinceName= "همدان",
            CountyName= "بهار",
            DistrictName= "لالجین",
            CityName= "مهاجران",
            CityDivisionCode= 71161
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "برخوار",
            DistrictName= "مرکزی",
            CityName= "سین",
            CityDivisionCode= 71162
          },
          new City{
            ProvinceName= "سمنان",
            CountyName= "آرادان",
            DistrictName= "کهن آباد",
            CityName= "کهن آباد",
            CityDivisionCode= 71163
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "جیرفت",
            DistrictName= "اسماعیلی",
            CityName= "بلوک",
            CityDivisionCode= 71164
          },
          new City{
            ProvinceName= "اردبیل",
            CountyName= "پارس آباد",
            DistrictName= "اسلام آباد",
            CityName= "اسلام آباد",
            CityDivisionCode= 71165
          },
          new City{
            ProvinceName= "اردبیل",
            CountyName= "مشگین شهر",
            DistrictName= "قصابه",
            CityName= "قصابه",
            CityDivisionCode= 71166
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "رابر",
            DistrictName= "هنزا",
            CityName= "هنزا",
            CityDivisionCode= 71167
          },
          new City{
            ProvinceName= "گیلان",
            CountyName= "فومن",
            DistrictName= "سردارجنگل",
            CityName= "ماکلوان",
            CityDivisionCode= 71168
          },
          new City{
            ProvinceName= "ایلام",
            CountyName= "دره شهر",
            DistrictName= "ماژین",
            CityName= "ماژین",
            CityDivisionCode= 71169
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "لنجان",
            DistrictName= "مرکزی",
            CityName= "باغشاد",
            CityDivisionCode= 71170
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "آمل",
            DistrictName= "امامزاده عبدالله",
            CityName= "امامزاده عبدالله",
            CityDivisionCode= 71171
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "مرودشت",
            DistrictName= "کر",
            CityName= "خانیمن",
            CityDivisionCode= 71172
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "رستم",
            DistrictName= "سورنا",
            CityName= "کوپن",
            CityDivisionCode= 71173
          },
          new City{
            ProvinceName= "سمنان",
            CountyName= "شاهرود",
            DistrictName= "مرکزی",
            CityName= "رودیان",
            CityDivisionCode= 71174
          },
          new City{
            ProvinceName= "تهران",
            CountyName= "رباط کریم",
            DistrictName= "مرکزی",
            CityName= "شهر جدید پرند",
            CityDivisionCode= 71175
          },
          new City{
            ProvinceName= "تهران",
            CountyName= "شمیرانات",
            DistrictName= "رودبار قصران",
            CityName= "شمشک",
            CityDivisionCode= 71176
          },
          new City{
            ProvinceName= "مرکزی",
            CountyName= "فراهان",
            DistrictName= "خنجین",
            CityName= "خنجین",
            CityDivisionCode= 71177
          },
          new City{
            ProvinceName= "مرکزی",
            CountyName= "شازند",
            DistrictName= "قره کهریز",
            CityName= "شهباز",
            CityDivisionCode= 71178
          },
          new City{
            ProvinceName= "کهگیلویه و بویراحمد",
            CountyName= "چرام",
            DistrictName= "سرفاریاب",
            CityName= "سرفاریاب",
            CityDivisionCode= 71179
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "رودبار جنوب",
            DistrictName= "جازموریان",
            CityName= "زهکلوت",
            CityDivisionCode= 71180
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "بردسیر",
            DistrictName= "مرکزی",
            CityName= "دشتکار",
            CityDivisionCode= 71181
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "ریگان",
            DistrictName= "گنبکی",
            CityName= "گنبکی",
            CityDivisionCode= 71182
          },
          new City{
            ProvinceName= "بوشهر",
            CountyName= "دیر",
            DistrictName= "مرکزی",
            CityName= "دوراهک",
            CityDivisionCode= 71183
          },
          new City{
            ProvinceName= "بوشهر",
            CountyName= "تنگستان",
            DistrictName= "مرکزی",
            CityName= "آباد",
            CityDivisionCode= 71184
          },
          new City{
            ProvinceName= "بوشهر",
            CountyName= "دشتستان",
            DistrictName= "بوشکان",
            CityName= "بوشکان",
            CityDivisionCode= 71185
          },
          new City{
            ProvinceName= "بوشهر",
            CountyName= "دشتی",
            DistrictName= "کاکی",
            CityName= "بادوله",
            CityDivisionCode= 71186
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "سیرجان",
            DistrictName= "گلستان",
            CityName= "خواجوشهر",
            CityDivisionCode= 71187
          },
          new City{
            ProvinceName= "مازندران",
            CountyName= "نوشهر",
            DistrictName= "کجور",
            CityName= "کجور",
            CityDivisionCode= 71188
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "پاسارگاد",
            DistrictName= "پاسارگاد",
            CityName= "مادرسلیمان",
            CityDivisionCode= 71189
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "خرامه",
            DistrictName= "کربال",
            CityName= "سلطان شهر",
            CityDivisionCode= 71190
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "ممسنی",
            DistrictName= "ماهور میلاتی",
            CityName= "بابامنیر",
            CityDivisionCode= 71191
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "بوانات",
            DistrictName= "مزایجان",
            CityName= "مزایجان",
            CityDivisionCode= 71192
          },
          new City{
            ProvinceName= "چهار محال و بختیاری",
            CountyName= "اردل",
            DistrictName= "مرکزی",
            CityName= "دشتک",
            CityDivisionCode= 71193
          },
          new City{
            ProvinceName= "چهار محال و بختیاری",
            CountyName= "اردل",
            DistrictName= "مرکزی",
            CityName= "کاج",
            CityDivisionCode= 71194
          },
          new City{
            ProvinceName= "چهار محال و بختیاری",
            CountyName= "فارسان",
            DistrictName= "جونقان",
            CityName= "چلیچه",
            CityDivisionCode= 71195
          },
          new City{
            ProvinceName= "چهار محال و بختیاری",
            CountyName= "فارسان",
            DistrictName= "مرکزی",
            CityName= "گوجان",
            CityDivisionCode= 71196
          },
          new City{
            ProvinceName= "چهار محال و بختیاری",
            CountyName= "اردل",
            DistrictName= "میانکوه",
            CityName= "سرخون",
            CityDivisionCode= 71197
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "اندیمشک",
            DistrictName= "الوار گرمسیری",
            CityName= "بیدروبه",
            CityDivisionCode= 71198
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "اهواز",
            DistrictName= "مرکزی",
            CityName= "الهایی",
            CityDivisionCode= 71199
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "شوشتر",
            DistrictName= "مرکزی",
            CityName= "سرداران",
            CityDivisionCode= 71200
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "مسجد سلیمان",
            DistrictName= "گلگیر",
            CityName= "گلگیر",
            CityDivisionCode= 71201
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "شادگان",
            DistrictName= "خنافره",
            CityName= "خنافره",
            CityDivisionCode= 71202
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "دشت آزادگان",
            DistrictName= "مرکزی",
            CityName= "کوت سیدنعیم",
            CityDivisionCode= 71203
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "دشت آزادگان",
            DistrictName= "مرکزی",
            CityName= "ابوحمیظه",
            CityDivisionCode= 71204
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "بهبهان",
            DistrictName= "مرکزی",
            CityName= "منصوریه",
            CityDivisionCode= 71205
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "اندیکا",
            DistrictName= "آبژدان",
            CityName= "آبژدان",
            CityDivisionCode= 71206
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "دزفول",
            DistrictName= "مرکزی",
            CityName= "سیاه منصور",
            CityDivisionCode= 71207
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "اندیمشک",
            DistrictName= "مرکزی",
            CityName= "آزادی",
            CityDivisionCode= 71208
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "بهبهان",
            DistrictName= "تشان",
            CityName= "تشان",
            CityDivisionCode= 71209
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "اندیمشک",
            DistrictName= "مرکزی",
            CityName= "چم گلک",
            CityDivisionCode= 71210
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "فلاورجان",
            DistrictName= "قهدریجان",
            CityName= "زازران",
            CityDivisionCode= 71211
          },
          new City{
            ProvinceName= "خوزستان",
            CountyName= "کارون",
            DistrictName= "مرکزی",
            CityName= "کوت عبدالله",
            CityDivisionCode= 71212
          },
          new City{
            ProvinceName= "گلستان",
            CountyName= "کلاله",
            DistrictName= "پیشکمر",
            CityName= "فراغی",
            CityDivisionCode= 71213
          },
          new City{
            ProvinceName= "کردستان",
            CountyName= "بیجار",
            DistrictName= "چنگ الماس",
            CityName= "پیرتاج",
            CityDivisionCode= 71214
          },
          new City{
            ProvinceName= "کردستان",
            CountyName= "بیجار",
            DistrictName= "مرکزی",
            CityName= "توپ آغاج",
            CityDivisionCode= 71215
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "اصفهان",
            DistrictName= "مرکزی",
            CityName= "زیار",
            CityDivisionCode= 71216
          },
          new City{
            ProvinceName= "هرمزگان",
            CountyName= "بندرلنگه",
            DistrictName= "مهران",
            CityName= "لمزان",
            CityDivisionCode= 71217
          },
          new City{
            ProvinceName= "هرمزگان",
            CountyName= "میناب",
            DistrictName= "مرکزی",
            CityName= "تیرور",
            CityDivisionCode= 71218
          },
          new City{
            ProvinceName= "هرمزگان",
            CountyName= "سیریک",
            DistrictName= "بمانی",
            CityName= "کوهستک",
            CityDivisionCode= 71219
          },
          new City{
            ProvinceName= "هرمزگان",
            CountyName= "بندرعباس",
            DistrictName= "مرکزی",
            CityName= "تازیان پائین",
            CityDivisionCode= 71220
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "مهر",
            DistrictName= "وراوی",
            CityName= "خوزی",
            CityDivisionCode= 71221
          },
          new City{
            ProvinceName= "کرمان",
            CountyName= "سیرجان",
            DistrictName= "بلورد",
            CityName= "بلورد",
            CityDivisionCode= 71222
          },
          new City{
            ProvinceName= "مرکزی",
            CountyName= "ساوه",
            DistrictName= "مرکزی",
            CityName= "آوه",
            CityDivisionCode= 71223
          },
          new City{
            ProvinceName= "هرمزگان",
            CountyName= "بستک",
            DistrictName= "کوخرد هرنگ",
            CityName= "کوخردهرنگ",
            CityDivisionCode= 71224
          },
          new City{
            ProvinceName= "اصفهان",
            CountyName= "کاشان",
            DistrictName= "قمصر",
            CityName= "جوشقان قالی",
            CityDivisionCode= 71225
          },
          new City{
            ProvinceName= "خراسان شمالی",
            CountyName= "شیروان",
            DistrictName= "قوشخانه",
            CityName= "قوشخانه",
            CityDivisionCode= 71226
          },
          new City{
            ProvinceName= "فارس",
            CountyName= "فسا",
            DistrictName= "شیبکوه",
            CityName= "میانشهر",
            CityDivisionCode= 71227
          },
          new City{
            ProvinceName= "گلستان",
            CountyName= "علی آباد",
            DistrictName= "مرکزی",
            CityName= "مزرعه",
            CityDivisionCode= 71228
          },
          new City{
            ProvinceName= "ایلام",
            CountyName= "چرداول",
            DistrictName= "زاگرس",
            CityName= "بلاوه",
            CityDivisionCode= 71229
          },
          new City{
            ProvinceName= "ایلام",
            CountyName= "چرداول",
            DistrictName= "شباب",
            CityName= "شباب",
            CityDivisionCode= 71230
          },
          new City{
            ProvinceName= "البرز",
            CountyName= "فردیس",
            DistrictName= "مرکزی",
            CityName= "فردیس",
            CityDivisionCode= 71231
          },
          new City{
            ProvinceName= "چهار محال و بختیاری",
            CountyName= "کوهرنگ",
            DistrictName= "بازفت",
            CityName= "بازفت",
            CityDivisionCode= 71232
          },
          new City{
            ProvinceName= "چهار محال و بختیاری",
            CountyName= "لردگان",
            DistrictName= "رودشت",
            CityName= "سردشت لردگان",
            CityDivisionCode= 71233
          },
          new City{
            ProvinceName= "چهار محال و بختیاری",
            CountyName= "کوهرنگ",
            DistrictName= "دوآب صمصامی",
            CityName= "صمصامی",
            CityDivisionCode= 71234
          },
          new City{
            ProvinceName= "کرمانشاه",
            CountyName= "کنگاور",
            DistrictName= "مرکزی",
            CityName= "گودین",
            CityDivisionCode= 71235
          },
          new City{
            ProvinceName= "چهار محال و بختیاری",
            CountyName= "شهر کرد",
            DistrictName= "لاران",
            CityName= "هارونی",
            CityDivisionCode= 71236
          },
          new City{
            ProvinceName= "خراسان شمالی",
            CountyName= "مانه و سملقان",
            DistrictName= "سملقان",
            CityName= "آوا",
            CityDivisionCode= 71237
          },
          new City{
            ProvinceName= "خراسان شمالی",
            CountyName= "بجنورد",
            DistrictName= "مرکزی",
            CityName= "چناران شهر",
            CityDivisionCode= 71238
          },
          new City{
            ProvinceName= "خراسان شمالی",
            CountyName= "شیروان",
            DistrictName= "مرکزی",
            CityName= "زیارت",
            CityDivisionCode= 71239
          },
          new City{
            ProvinceName= "زنجان",
            CountyName= "خدابنده",
            DistrictName= "مرکزی",
            CityName= "کرسف",
            CityDivisionCode= 71240
          },
          new City{
            ProvinceName= "زنجان",
            CountyName= "خدابنده",
            DistrictName= "مرکزی",
            CityName= "نوربهار",
            CityDivisionCode= 71241
          },
          new City{
            ProvinceName= "گلستان",
            CountyName= "علی آباد",
            DistrictName= "مرکزی",
            CityName= "سنگدوین",
            CityDivisionCode= 71242
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "میانه",
            DistrictName= "مرکزی",
            CityName= "آچاچی",
            CityDivisionCode= 71243
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "عجب شیر",
            DistrictName= "قلعه چای",
            CityName= "جوان قلعه",
            CityDivisionCode= 71244
          },
          new City{
            ProvinceName= "آذربایجان شرقی",
            CountyName= "ملکان",
            DistrictName= "مرکزی",
            CityName= "مبارک شهر",
            CityDivisionCode= 71245
          }
        });

        private static readonly Lazy<ISet<Province>> _provincesProvider =
                new Lazy<ISet<Province>>(getProvinces, LazyThreadSafetyMode.ExecutionAndPublication);

        /// <summary>
        /// Iran's Provinces.
        /// </summary>
        public static ISet<Province> Provinces { get; } = _provincesProvider.Value;

        private static ISet<Province> getProvinces()
        {
            var provinces = new HashSet<Province>();
            foreach (var provinceName in Cities.Select(x => x.ProvinceName).Distinct())
            {
                provinces.Add(new Province { ProvinceName = provinceName });
            }

            foreach (var province in provinces)
            {
                foreach (var thisProvince in Cities.Where(x => x.ProvinceName == province.ProvinceName))
                {
                    province.Counties.Add(new County { CountyName = thisProvince.CountyName });
                }

                foreach (var county in province.Counties)
                {
                    foreach (var thisCounty in Cities.Where(x =>
                            x.ProvinceName == province.ProvinceName && x.CountyName == county.CountyName))
                    {
                        county.Districts.Add(new District { DistrictName = thisCounty.DistrictName });
                    }
                }

                foreach (var county in province.Counties)
                {
                    foreach (var district in county.Districts)
                    {
                        foreach (var thisDistrict in Cities.Where(x =>
                           x.ProvinceName == province.ProvinceName &&
                           x.CountyName == county.CountyName &&
                           x.DistrictName == district.DistrictName))
                        {
                            district.Cities.Add(new City
                            {
                                CityName = thisDistrict.CityName,
                                CityDivisionCode = thisDistrict.CityDivisionCode,
                                CountyName = county.CountyName,
                                DistrictName = district.DistrictName,
                                ProvinceName = province.ProvinceName
                            });
                        }
                    }
                }
            }

            return provinces;
        }
    }
}