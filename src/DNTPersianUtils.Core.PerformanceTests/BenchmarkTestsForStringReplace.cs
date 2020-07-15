using System.Text;
using BenchmarkDotNet.Attributes;

namespace DNTPersianUtils.Core.PerformanceTests
{
    public class BenchmarkTestsForStringReplace
    {
        [Benchmark(Baseline = true)]
        public void ToPersianNumbersUsingStringReplace()
        {
            var result = toPersianNumbersUsingReplace("1234");
        }

        [Benchmark]
        public void ToPersianNumbersUsingStringBuilder()
        {
            var result = toPersianNumbersUsingStringBuilder("1234");
        }

        [Benchmark]
        public void ToPersianNumbersUsingToCharArray()
        {
            var result = toPersianNumbersUsingToCharArray("1234");
        }

        private static string toPersianNumbersUsingReplace(string data)
        {
            if (string.IsNullOrWhiteSpace(data)) return string.Empty;
            return
                toEnglishNumbers(data)
                .Replace("0", "\u06F0")
                .Replace("1", "\u06F1")
                .Replace("2", "\u06F2")
                .Replace("3", "\u06F3")
                .Replace("4", "\u06F4")
                .Replace("5", "\u06F5")
                .Replace("6", "\u06F6")
                .Replace("7", "\u06F7")
                .Replace("8", "\u06F8")
                .Replace("9", "\u06F9")
                .Replace(".", ",");
        }

        private static string toEnglishNumbers(string data)
        {
            if (string.IsNullOrWhiteSpace(data)) return string.Empty;
            return
               data.Replace("\u0660", "0") //٠
                   .Replace("\u06F0", "0") //۰
                   .Replace("\u0661", "1") //١
                   .Replace("\u06F1", "1") //۱
                   .Replace("\u0662", "2") //٢
                   .Replace("\u06F2", "2") //۲
                   .Replace("\u0663", "3") //٣
                   .Replace("\u06F3", "3") //۳
                   .Replace("\u0664", "4") //٤
                   .Replace("\u06F4", "4") //۴
                   .Replace("\u0665", "5") //٥
                   .Replace("\u06F5", "5") //۵
                   .Replace("\u0666", "6") //٦
                   .Replace("\u06F6", "6") //۶
                   .Replace("\u0667", "7") //٧
                   .Replace("\u06F7", "7") //۷
                   .Replace("\u0668", "8") //٨
                   .Replace("\u06F8", "8") //۸
                   .Replace("\u0669", "9") //٩
                   .Replace("\u06F9", "9") //۹
                   ;
        }

        private static string toPersianNumbersUsingStringBuilder(string data)
        {
            if (string.IsNullOrWhiteSpace(data)) return string.Empty;

            var strBuilder = new StringBuilder(data);
            for (var i = 0; i < strBuilder.Length; i++)
            {
                switch (strBuilder[i])
                {
                    case '0':
                    case '\u0660':
                        strBuilder[i] = '\u06F0';
                        break;

                    case '1':
                    case '\u0661':
                        strBuilder[i] = '\u06F1';
                        break;

                    case '2':
                    case '\u0662':
                        strBuilder[i] = '\u06F2';
                        break;

                    case '3':
                    case '\u0663':
                        strBuilder[i] = '\u06F3';
                        break;

                    case '4':
                    case '\u0664':
                        strBuilder[i] = '\u06F4';
                        break;

                    case '5':
                    case '\u0665':
                        strBuilder[i] = '\u06F5';
                        break;

                    case '6':
                    case '\u0666':
                        strBuilder[i] = '\u06F6';
                        break;

                    case '7':
                    case '\u0667':
                        strBuilder[i] = '\u06F7';
                        break;

                    case '8':
                    case '\u0668':
                        strBuilder[i] = '\u06F8';
                        break;

                    case '9':
                    case '\u0669':
                        strBuilder[i] = '\u06F9';
                        break;

                    default:
                        strBuilder[i] = strBuilder[i];
                        break;
                }
            }

            return strBuilder.ToString();
        }

        private static string toPersianNumbersUsingToCharArray(string data)
        {
            if (string.IsNullOrWhiteSpace(data)) return string.Empty;

            var letters = data.ToCharArray();
            for (var i = 0; i < letters.Length; i++)
            {
                switch (letters[i])
                {
                    case '0':
                    case '\u0660':
                        letters[i] = '\u06F0';
                        break;

                    case '1':
                    case '\u0661':
                        letters[i] = '\u06F1';
                        break;

                    case '2':
                    case '\u0662':
                        letters[i] = '\u06F2';
                        break;

                    case '3':
                    case '\u0663':
                        letters[i] = '\u06F3';
                        break;

                    case '4':
                    case '\u0664':
                        letters[i] = '\u06F4';
                        break;

                    case '5':
                    case '\u0665':
                        letters[i] = '\u06F5';
                        break;

                    case '6':
                    case '\u0666':
                        letters[i] = '\u06F6';
                        break;

                    case '7':
                    case '\u0667':
                        letters[i] = '\u06F7';
                        break;

                    case '8':
                    case '\u0668':
                        letters[i] = '\u06F8';
                        break;

                    case '9':
                    case '\u0669':
                        letters[i] = '\u06F9';
                        break;

                    default:
                        letters[i] = letters[i];
                        break;
                }
            }

            return new string(letters);
        }

        private static void replaceChar(char chr, char[] strBuilder, int i)
        {
            switch (strBuilder[i])
            {
                case '0':
                case '\u0660':
                    strBuilder[i] = '\u06F0';
                    break;

                case '1':
                case '\u0661':
                    strBuilder[i] = '\u06F1';
                    break;

                case '2':
                case '\u0662':
                    strBuilder[i] = '\u06F2';
                    break;

                case '3':
                case '\u0663':
                    strBuilder[i] = '\u06F3';
                    break;

                case '4':
                case '\u0664':
                    strBuilder[i] = '\u06F4';
                    break;

                case '5':
                case '\u0665':
                    strBuilder[i] = '\u06F5';
                    break;

                case '6':
                case '\u0666':
                    strBuilder[i] = '\u06F6';
                    break;

                case '7':
                case '\u0667':
                    strBuilder[i] = '\u06F7';
                    break;

                case '8':
                case '\u0668':
                    strBuilder[i] = '\u06F8';
                    break;

                case '9':
                case '\u0669':
                    strBuilder[i] = '\u06F9';
                    break;

                default:
                    strBuilder[i] = strBuilder[i];
                    break;
            }
        }
    }
}