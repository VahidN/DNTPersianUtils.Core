using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DNTPersianUtils.Core.Tests;

[TestClass]
public class IslamicDateUtilsTests
{
    [DataTestMethod]
    [DataRow(2016, 10, 3, 1438, 1, 1)]
    [DataRow(2016, 11, 1, 1438, 2, 1)]
    [DataRow(2016, 12, 1, 1438, 3, 1)]
    [DataRow(2016, 12, 31, 1438, 4, 1)]
    [DataRow(2017, 1, 30, 1438, 5, 1)]
    [DataRow(2017, 2, 28, 1438, 6, 1)]
    [DataRow(2017, 3, 30, 1438, 7, 1)]
    [DataRow(2017, 4, 28, 1438, 8, 1)]
    [DataRow(2017, 5, 27, 1438, 9, 1)]
    [DataRow(2017, 6, 26, 1438, 10, 1)]
    [DataRow(2017, 7, 25, 1438, 11, 1)]
    [DataRow(2017, 8, 23, 1438, 12, 1)]
    [DataRow(2017, 9, 22, 1439, 1, 1)]
    [DataRow(2017, 10, 21, 1439, 2, 1)]
    [DataRow(2017, 11, 20, 1439, 3, 1)]
    [DataRow(2017, 12, 20, 1439, 4, 1)]
    [DataRow(2018, 1, 19, 1439, 5, 1)]
    [DataRow(2018, 2, 18, 1439, 6, 1)]
    [DataRow(2018, 3, 19, 1439, 7, 1)]
    [DataRow(2018, 4, 18, 1439, 8, 1)]
    [DataRow(2018, 5, 17, 1439, 9, 1)]
    [DataRow(2018, 6, 15, 1439, 10, 1)]
    [DataRow(2018, 7, 15, 1439, 11, 1)]
    [DataRow(2018, 8, 13, 1439, 12, 1)]
    [DataRow(2018, 9, 11, 1440, 1, 1)]
    [DataRow(2018, 10, 11, 1440, 2, 1)]
    [DataRow(2018, 11, 9, 1440, 3, 1)]
    [DataRow(2018, 12, 9, 1440, 4, 1)]
    [DataRow(2019, 1, 8, 1440, 5, 1)]
    [DataRow(2019, 2, 7, 1440, 6, 1)]
    [DataRow(2019, 3, 8, 1440, 7, 1)]
    [DataRow(2019, 4, 6, 1440, 8, 1)]
    [DataRow(2019, 5, 6, 1440, 9, 1)]
    [DataRow(2019, 6, 4, 1440, 10, 1)]
    [DataRow(2019, 7, 4, 1440, 11, 1)]
    [DataRow(2019, 8, 2, 1440, 12, 1)]
    [DataRow(2019, 8, 31, 1441, 1, 1)]
    [DataRow(2019, 9, 30, 1441, 2, 1)]
    [DataRow(2019, 10, 29, 1441, 3, 1)]
    [DataRow(2019, 11, 28, 1441, 4, 1)]
    [DataRow(2019, 12, 27, 1441, 5, 1)]
    [DataRow(2020, 1, 26, 1441, 6, 1)]
    [DataRow(2020, 2, 25, 1441, 7, 1)]
    [DataRow(2020, 3, 25, 1441, 8, 1)]
    [DataRow(2020, 4, 24, 1441, 9, 1)]
    [DataRow(2020, 5, 24, 1441, 10, 1)]
    [DataRow(2020, 6, 22, 1441, 11, 1)]
    [DataRow(2020, 7, 22, 1441, 12, 1)]
    [DataRow(2020, 8, 20, 1442, 1, 1)]
    [DataRow(2020, 9, 18, 1442, 2, 1)]
    [DataRow(2020, 10, 18, 1442, 3, 1)]
    [DataRow(2020, 11, 16, 1442, 4, 1)]
    [DataRow(2020, 12, 16, 1442, 5, 1)]
    [DataRow(2021, 1, 14, 1442, 6, 1)]
    [DataRow(2021, 2, 13, 1442, 7, 1)]
    [DataRow(2021, 3, 14, 1442, 8, 1)]
    [DataRow(2021, 4, 13, 1442, 9, 1)]
    [DataRow(2021, 5, 13, 1442, 10, 1)]
    [DataRow(2021, 6, 11, 1442, 11, 1)]
    [DataRow(2021, 7, 11, 1442, 12, 1)]
    [DataRow(2021, 8, 9, 1443, 1, 1)]
    [DataRow(2021, 9, 8, 1443, 2, 1)]
    [DataRow(2021, 10, 7, 1443, 3, 1)]
    [DataRow(2021, 11, 6, 1443, 4, 1)]
    [DataRow(2021, 12, 5, 1443, 5, 1)]
    [DataRow(2022, 1, 4, 1443, 6, 1)]
    [DataRow(2022, 2, 2, 1443, 7, 1)]
    [DataRow(2022, 3, 4, 1443, 8, 1)]
    [DataRow(2022, 4, 2, 1443, 9, 1)]
    [DataRow(2022, 5, 2, 1443, 10, 1)]
    [DataRow(2022, 5, 31, 1443, 11, 1)]
    [DataRow(2022, 6, 30, 1443, 12, 1)]
    [DataRow(2022, 7, 30, 1444, 1, 1)]
    [DataRow(2022, 8, 28, 1444, 2, 1)]
    [DataRow(2022, 9, 27, 1444, 3, 1)]
    [DataRow(2022, 10, 26, 1444, 4, 1)]
    [DataRow(2022, 11, 25, 1444, 5, 1)]
    [DataRow(2022, 12, 25, 1444, 6, 1)]
    [DataRow(2023, 1, 23, 1444, 7, 1)]
    [DataRow(2023, 2, 21, 1444, 8, 1)]
    [DataRow(2023, 3, 23, 1444, 9, 1)]
    [DataRow(2023, 4, 21, 1444, 10, 1)]
    [DataRow(2023, 5, 21, 1444, 11, 1)]
    [DataRow(2023, 6, 19, 1444, 12, 1)]
    [DataRow(2023, 7, 19, 1445, 1, 1)]
    [DataRow(2023, 8, 17, 1445, 2, 1)]
    [DataRow(2023, 9, 16, 1445, 3, 1)]
    [DataRow(2023, 10, 16, 1445, 4, 1)]
    [DataRow(2023, 11, 15, 1445, 5, 1)]
    [DataRow(2023, 12, 14, 1445, 6, 1)]
    [DataRow(2024, 1, 13, 1445, 7, 1)]
    [DataRow(2024, 2, 11, 1445, 8, 1)]
    [DataRow(2024, 3, 11, 1445, 9, 1)]
    [DataRow(2024, 4, 10, 1445, 10, 1)]
    [DataRow(2024, 5, 9, 1445, 11, 1)]
    [DataRow(2024, 6, 7, 1445, 12, 1)]
    [DataRow(2024, 7, 7, 1446, 1, 1)]
    [DataRow(2024, 8, 5, 1446, 2, 1)]
    [DataRow(2024, 9, 4, 1446, 3, 1)]
    [DataRow(2024, 10, 4, 1446, 4, 1)]
    [DataRow(2024, 11, 3, 1446, 5, 1)]
    [DataRow(2024, 12, 2, 1446, 6, 1)]
    [DataRow(2025, 1, 1, 1446, 7, 1)]
    [DataRow(2025, 1, 31, 1446, 8, 1)]
    [DataRow(2025, 3, 1, 1446, 9, 1)]
    [DataRow(2025, 3, 30, 1446, 10, 1)]
    [DataRow(2025, 4, 29, 1446, 11, 1)]
    [DataRow(2025, 5, 28, 1446, 12, 1)]
    [DataRow(2025, 6, 26, 1447, 1, 1)]
    [DataRow(2025, 7, 26, 1447, 2, 1)]
    [DataRow(2025, 8, 24, 1447, 3, 1)]
    [DataRow(2025, 9, 23, 1447, 4, 1)]
    [DataRow(2025, 10, 23, 1447, 5, 1)]
    [DataRow(2025, 11, 22, 1447, 6, 1)]
    [DataRow(2025, 12, 21, 1447, 7, 1)]
    [DataRow(2026, 1, 20, 1447, 8, 1)]
    [DataRow(2026, 2, 18, 1447, 9, 1)]
    [DataRow(2026, 3, 20, 1447, 10, 1)]
    [DataRow(2026, 4, 18, 1447, 11, 1)]
    [DataRow(2026, 5, 18, 1447, 12, 1)]
    [DataRow(2026, 6, 16, 1448, 1, 1)]
    [DataRow(2026, 7, 15, 1448, 2, 1)]
    [DataRow(2026, 8, 14, 1448, 3, 1)]
    [DataRow(2026, 9, 12, 1448, 4, 1)]
    [DataRow(2026, 10, 12, 1448, 5, 1)]
    [DataRow(2026, 11, 11, 1448, 6, 1)]
    [DataRow(2026, 12, 10, 1448, 7, 1)]
    [DataRow(2027, 1, 9, 1448, 8, 1)]
    [DataRow(2027, 2, 8, 1448, 9, 1)]
    [DataRow(2027, 3, 9, 1448, 10, 1)]
    [DataRow(2027, 4, 8, 1448, 11, 1)]
    [DataRow(2027, 5, 7, 1448, 12, 1)]
    [DataRow(2027, 6, 6, 1449, 1, 1)]
    [DataRow(2027, 7, 5, 1449, 2, 1)]
    [DataRow(2027, 8, 3, 1449, 3, 1)]
    [DataRow(2027, 9, 2, 1449, 4, 1)]
    [DataRow(2027, 10, 1, 1449, 5, 1)]
    [DataRow(2027, 10, 31, 1449, 6, 1)]
    [DataRow(2027, 11, 29, 1449, 7, 1)]
    [DataRow(2027, 12, 29, 1449, 8, 1)]
    [DataRow(2028, 1, 28, 1449, 9, 1)]
    [DataRow(2028, 2, 26, 1449, 10, 1)]
    [DataRow(2028, 3, 27, 1449, 11, 1)]
    [DataRow(2028, 4, 26, 1449, 12, 1)]
    [DataRow(2028, 5, 25, 1450, 1, 1)]
    [DataRow(2028, 6, 24, 1450, 2, 1)]
    [DataRow(2028, 7, 23, 1450, 3, 1)]
    [DataRow(2028, 8, 22, 1450, 4, 1)]
    [DataRow(2028, 9, 20, 1450, 5, 1)]
    [DataRow(2028, 10, 19, 1450, 6, 1)]
    [DataRow(2028, 11, 18, 1450, 7, 1)]
    [DataRow(2028, 12, 17, 1450, 8, 1)]
    [DataRow(2029, 1, 16, 1450, 9, 1)]
    [DataRow(2029, 2, 14, 1450, 10, 1)]
    [DataRow(2029, 3, 16, 1450, 11, 1)]
    [DataRow(2029, 4, 15, 1450, 12, 1)]
    [DataRow(2029, 5, 14, 1451, 1, 1)]
    [DataRow(2029, 6, 13, 1451, 2, 1)]
    [DataRow(2029, 7, 13, 1451, 3, 1)]
    [DataRow(2029, 8, 11, 1451, 4, 1)]
    [DataRow(2029, 9, 10, 1451, 5, 1)]
    [DataRow(2029, 10, 9, 1451, 6, 1)]
    [DataRow(2029, 11, 7, 1451, 7, 1)]
    [DataRow(2029, 12, 7, 1451, 8, 1)]
    [DataRow(2030, 1, 5, 1451, 9, 1)]
    [DataRow(2030, 2, 4, 1451, 10, 1)]
    [DataRow(2030, 3, 5, 1451, 11, 1)]
    [DataRow(2030, 4, 4, 1451, 12, 1)]
    [DataRow(2030, 5, 3, 1452, 1, 1)]
    [DataRow(2030, 6, 2, 1452, 2, 1)]
    [DataRow(2030, 7, 2, 1452, 3, 1)]
    [DataRow(2030, 8, 1, 1452, 4, 1)]
    [DataRow(2030, 8, 30, 1452, 5, 1)]
    [DataRow(2030, 9, 29, 1452, 6, 1)]
    [DataRow(2030, 10, 28, 1452, 7, 1)]
    [DataRow(2030, 11, 26, 1452, 8, 1)]
    [DataRow(2030, 12, 26, 1452, 9, 1)]
    [DataRow(2031, 1, 24, 1452, 10, 1)]
    [DataRow(2031, 2, 23, 1452, 11, 1)]
    [DataRow(2031, 3, 24, 1452, 12, 1)]
    [DataRow(2031, 4, 23, 1453, 1, 1)]
    [DataRow(2031, 5, 22, 1453, 2, 1)]
    [DataRow(2031, 6, 21, 1453, 3, 1)]
    [DataRow(2031, 7, 21, 1453, 4, 1)]
    [DataRow(2031, 8, 20, 1453, 5, 1)]
    [DataRow(2031, 9, 18, 1453, 6, 1)]
    [DataRow(2031, 10, 17, 1453, 7, 1)]
    [DataRow(2031, 11, 16, 1453, 8, 1)]
    [DataRow(2031, 12, 15, 1453, 9, 1)]
    [DataRow(2032, 1, 14, 1453, 10, 1)]
    [DataRow(2032, 2, 12, 1453, 11, 1)]
    [DataRow(2032, 3, 13, 1453, 12, 1)]
    [DataRow(2032, 4, 11, 1454, 1, 1)]
    [DataRow(2032, 5, 10, 1454, 2, 1)]
    [DataRow(2032, 6, 9, 1454, 3, 1)]
    [DataRow(2032, 7, 9, 1454, 4, 1)]
    [DataRow(2032, 8, 8, 1454, 5, 1)]
    [DataRow(2032, 9, 6, 1454, 6, 1)]
    [DataRow(2032, 10, 6, 1454, 7, 1)]
    [DataRow(2032, 11, 4, 1454, 8, 1)]
    [DataRow(2032, 12, 4, 1454, 9, 1)]
    [DataRow(2033, 1, 2, 1454, 10, 1)]
    [DataRow(2033, 2, 1, 1454, 11, 1)]
    [DataRow(2033, 3, 2, 1454, 12, 1)]
    [DataRow(2033, 4, 1, 1455, 1, 1)]
    [DataRow(2033, 4, 30, 1455, 2, 1)]
    [DataRow(2033, 5, 29, 1455, 3, 1)]
    [DataRow(2033, 6, 28, 1455, 4, 1)]
    [DataRow(2033, 7, 28, 1455, 5, 1)]
    [DataRow(2033, 8, 26, 1455, 6, 1)]
    [DataRow(2033, 9, 25, 1455, 7, 1)]
    [DataRow(2033, 10, 24, 1455, 8, 1)]
    [DataRow(2033, 11, 23, 1455, 9, 1)]
    [DataRow(2033, 12, 23, 1455, 10, 1)]
    [DataRow(2034, 1, 21, 1455, 11, 1)]
    [DataRow(2034, 2, 20, 1455, 12, 1)]
    [DataRow(2034, 3, 21, 1456, 1, 1)]
    [DataRow(2034, 4, 20, 1456, 2, 1)]
    [DataRow(2034, 5, 19, 1456, 3, 1)]
    [DataRow(2034, 6, 17, 1456, 4, 1)]
    [DataRow(2034, 7, 17, 1456, 5, 1)]
    [DataRow(2034, 8, 15, 1456, 6, 1)]
    [DataRow(2034, 9, 14, 1456, 7, 1)]
    [DataRow(2034, 10, 13, 1456, 8, 1)]
    [DataRow(2034, 11, 12, 1456, 9, 1)]
    [DataRow(2034, 12, 12, 1456, 10, 1)]
    [DataRow(2035, 1, 11, 1456, 11, 1)]
    [DataRow(2035, 2, 9, 1456, 12, 1)]
    [DataRow(2035, 3, 11, 1457, 1, 1)]
    [DataRow(2035, 4, 9, 1457, 2, 1)]
    [DataRow(2035, 5, 9, 1457, 3, 1)]
    [DataRow(2035, 6, 7, 1457, 4, 1)]
    [DataRow(2035, 7, 6, 1457, 5, 1)]
    [DataRow(2035, 8, 5, 1457, 6, 1)]
    [DataRow(2035, 9, 3, 1457, 7, 1)]
    [DataRow(2035, 10, 2, 1457, 8, 1)]
    [DataRow(2035, 11, 1, 1457, 9, 1)]
    [DataRow(2035, 12, 1, 1457, 10, 1)]
    [DataRow(2035, 12, 30, 1457, 11, 1)]
    [DataRow(2036, 1, 29, 1457, 12, 1)]
    [DataRow(2036, 2, 28, 1458, 1, 1)]
    [DataRow(2036, 3, 29, 1458, 2, 1)]
    [DataRow(2036, 4, 27, 1458, 3, 1)]
    [DataRow(2036, 5, 27, 1458, 4, 1)]
    [DataRow(2036, 6, 25, 1458, 5, 1)]
    [DataRow(2036, 7, 24, 1458, 6, 1)]
    [DataRow(2036, 8, 23, 1458, 7, 1)]
    [DataRow(2036, 9, 21, 1458, 8, 1)]
    [DataRow(2036, 10, 20, 1458, 9, 1)]
    [DataRow(2036, 11, 19, 1458, 10, 1)]
    [DataRow(2036, 12, 19, 1458, 11, 1)]
    [DataRow(2037, 1, 17, 1458, 12, 1)]
    [DataRow(2037, 2, 16, 1459, 1, 1)]
    [DataRow(2037, 3, 18, 1459, 2, 1)]
    [DataRow(2037, 4, 17, 1459, 3, 1)]
    [DataRow(2037, 5, 16, 1459, 4, 1)]
    [DataRow(2037, 6, 15, 1459, 5, 1)]
    [DataRow(2037, 7, 14, 1459, 6, 1)]
    [DataRow(2037, 8, 12, 1459, 7, 1)]
    [DataRow(2037, 9, 11, 1459, 8, 1)]
    [DataRow(2037, 10, 10, 1459, 9, 1)]
    [DataRow(2037, 11, 8, 1459, 10, 1)]
    [DataRow(2037, 12, 8, 1459, 11, 1)]
    [DataRow(2038, 1, 7, 1459, 12, 1)]
    [DataRow(2038, 2, 5, 1460, 1, 1)]
    [DataRow(2038, 3, 7, 1460, 2, 1)]
    [DataRow(2038, 4, 6, 1460, 3, 1)]
    [DataRow(2038, 5, 5, 1460, 4, 1)]
    [DataRow(2038, 6, 4, 1460, 5, 1)]
    [DataRow(2038, 7, 3, 1460, 6, 1)]
    [DataRow(2038, 8, 2, 1460, 7, 1)]
    [DataRow(2038, 8, 31, 1460, 8, 1)]
    [DataRow(2038, 9, 30, 1460, 9, 1)]
    [DataRow(2038, 10, 29, 1460, 10, 1)]
    [DataRow(2038, 11, 27, 1460, 11, 1)]
    [DataRow(2038, 12, 27, 1460, 12, 1)]
    [DataRow(2039, 1, 26, 1461, 1, 1)]
    [DataRow(2039, 2, 24, 1461, 2, 1)]
    [DataRow(2039, 3, 26, 1461, 3, 1)]
    [DataRow(2039, 4, 24, 1461, 4, 1)]
    [DataRow(2039, 5, 24, 1461, 5, 1)]
    [DataRow(2039, 6, 23, 1461, 6, 1)]
    [DataRow(2039, 7, 22, 1461, 7, 1)]
    [DataRow(2039, 8, 21, 1461, 8, 1)]
    [DataRow(2039, 9, 19, 1461, 9, 1)]
    [DataRow(2039, 10, 19, 1461, 10, 1)]
    [DataRow(2039, 11, 17, 1461, 11, 1)]
    [DataRow(2039, 12, 17, 1461, 12, 1)]
    [DataRow(2040, 1, 15, 1462, 1, 1)]
    [DataRow(2040, 2, 14, 1462, 2, 1)]
    [DataRow(2040, 3, 14, 1462, 3, 1)]
    [DataRow(2040, 4, 13, 1462, 4, 1)]
    [DataRow(2040, 5, 12, 1462, 5, 1)]
    [DataRow(2040, 6, 11, 1462, 6, 1)]
    [DataRow(2040, 7, 10, 1462, 7, 1)]
    [DataRow(2040, 8, 9, 1462, 8, 1)]
    [DataRow(2040, 9, 7, 1462, 9, 1)]
    [DataRow(2040, 10, 7, 1462, 10, 1)]
    [DataRow(2040, 11, 6, 1462, 11, 1)]
    [DataRow(2040, 12, 5, 1462, 12, 1)]
    [DataRow(2041, 1, 4, 1463, 1, 1)]
    [DataRow(2041, 2, 2, 1463, 2, 1)]
    [DataRow(2041, 3, 4, 1463, 3, 1)]
    [DataRow(2041, 4, 2, 1463, 4, 1)]
    [DataRow(2041, 5, 1, 1463, 5, 1)]
    [DataRow(2041, 5, 31, 1463, 6, 1)]
    [DataRow(2041, 6, 29, 1463, 7, 1)]
    [DataRow(2041, 7, 29, 1463, 8, 1)]
    [DataRow(2041, 8, 28, 1463, 9, 1)]
    [DataRow(2041, 9, 26, 1463, 10, 1)]
    [DataRow(2041, 10, 26, 1463, 11, 1)]
    [DataRow(2041, 11, 25, 1463, 12, 1)]
    [DataRow(2041, 12, 24, 1464, 1, 1)]
    [DataRow(2042, 1, 23, 1464, 2, 1)]
    [DataRow(2042, 2, 21, 1464, 3, 1)]
    [DataRow(2042, 3, 23, 1464, 4, 1)]
    [DataRow(2042, 4, 21, 1464, 5, 1)]
    [DataRow(2042, 5, 20, 1464, 6, 1)]
    [DataRow(2042, 6, 19, 1464, 7, 1)]
    [DataRow(2042, 7, 18, 1464, 8, 1)]
    [DataRow(2042, 8, 17, 1464, 9, 1)]
    [DataRow(2042, 9, 15, 1464, 10, 1)]
    [DataRow(2042, 10, 15, 1464, 11, 1)]
    [DataRow(2042, 11, 14, 1464, 12, 1)]
    [DataRow(2042, 12, 14, 1465, 1, 1)]
    [DataRow(2043, 1, 12, 1465, 2, 1)]
    [DataRow(2043, 2, 11, 1465, 3, 1)]
    [DataRow(2043, 3, 12, 1465, 4, 1)]
    [DataRow(2043, 4, 11, 1465, 5, 1)]
    [DataRow(2043, 5, 10, 1465, 6, 1)]
    [DataRow(2043, 6, 8, 1465, 7, 1)]
    [DataRow(2043, 7, 8, 1465, 8, 1)]
    [DataRow(2043, 8, 6, 1465, 9, 1)]
    [DataRow(2043, 9, 4, 1465, 10, 1)]
    [DataRow(2043, 10, 4, 1465, 11, 1)]
    [DataRow(2043, 11, 3, 1465, 12, 1)]
    [DataRow(2043, 12, 3, 1466, 1, 1)]
    [DataRow(2044, 1, 2, 1466, 2, 1)]
    [DataRow(2044, 1, 31, 1466, 3, 1)]
    [DataRow(2044, 3, 1, 1466, 4, 1)]
    [DataRow(2044, 3, 30, 1466, 5, 1)]
    [DataRow(2044, 4, 29, 1466, 6, 1)]
    [DataRow(2044, 5, 28, 1466, 7, 1)]
    [DataRow(2044, 6, 26, 1466, 8, 1)]
    [DataRow(2044, 7, 26, 1466, 9, 1)]
    [DataRow(2044, 8, 24, 1466, 10, 1)]
    [DataRow(2044, 9, 23, 1466, 11, 1)]
    [DataRow(2044, 10, 22, 1466, 12, 1)]
    [DataRow(2044, 11, 21, 1467, 1, 1)]
    [DataRow(2044, 12, 21, 1467, 2, 1)]
    [DataRow(2045, 1, 19, 1467, 3, 1)]
    [DataRow(2045, 2, 18, 1467, 4, 1)]
    [DataRow(2045, 3, 20, 1467, 5, 1)]
    [DataRow(2045, 4, 18, 1467, 6, 1)]
    [DataRow(2045, 5, 18, 1467, 7, 1)]
    [DataRow(2045, 6, 16, 1467, 8, 1)]
    [DataRow(2045, 7, 15, 1467, 9, 1)]
    [DataRow(2045, 8, 14, 1467, 10, 1)]
    [DataRow(2045, 9, 12, 1467, 11, 1)]
    [DataRow(2045, 10, 12, 1467, 12, 1)]
    [DataRow(2045, 11, 10, 1468, 1, 1)]
    [DataRow(2045, 12, 10, 1468, 2, 1)]
    [DataRow(2046, 1, 8, 1468, 3, 1)]
    [DataRow(2046, 2, 7, 1468, 4, 1)]
    [DataRow(2046, 3, 9, 1468, 5, 1)]
    [DataRow(2046, 4, 7, 1468, 6, 1)]
    [DataRow(2046, 5, 7, 1468, 7, 1)]
    [DataRow(2046, 6, 5, 1468, 8, 1)]
    [DataRow(2046, 7, 5, 1468, 9, 1)]
    [DataRow(2046, 8, 3, 1468, 10, 1)]
    [DataRow(2046, 9, 2, 1468, 11, 1)]
    [DataRow(2046, 10, 1, 1468, 12, 1)]
    [DataRow(2046, 10, 31, 1469, 1, 1)]
    [DataRow(2046, 11, 29, 1469, 2, 1)]
    [DataRow(2046, 12, 28, 1469, 3, 1)]
    [DataRow(2047, 1, 27, 1469, 4, 1)]
    [DataRow(2047, 2, 26, 1469, 5, 1)]
    [DataRow(2047, 3, 27, 1469, 6, 1)]
    [DataRow(2047, 4, 26, 1469, 7, 1)]
    [DataRow(2047, 5, 26, 1469, 8, 1)]
    [DataRow(2047, 6, 24, 1469, 9, 1)]
    [DataRow(2047, 7, 24, 1469, 10, 1)]
    [DataRow(2047, 8, 23, 1469, 11, 1)]
    [DataRow(2047, 9, 21, 1469, 12, 1)]
    [DataRow(2047, 10, 20, 1470, 1, 1)]
    [DataRow(2047, 11, 19, 1470, 2, 1)]
    [DataRow(2047, 12, 18, 1470, 3, 1)]
    [DataRow(2048, 1, 16, 1470, 4, 1)]
    [DataRow(2048, 2, 15, 1470, 5, 1)]
    [DataRow(2048, 3, 16, 1470, 6, 1)]
    [DataRow(2048, 4, 14, 1470, 7, 1)]
    [DataRow(2048, 5, 14, 1470, 8, 1)]
    [DataRow(2048, 6, 12, 1470, 9, 1)]
    [DataRow(2048, 7, 12, 1470, 10, 1)]
    [DataRow(2048, 8, 11, 1470, 11, 1)]
    [DataRow(2048, 9, 10, 1470, 12, 1)]
    [DataRow(2048, 10, 9, 1471, 1, 1)]
    [DataRow(2048, 11, 7, 1471, 2, 1)]
    [DataRow(2048, 12, 7, 1471, 3, 1)]
    [DataRow(2049, 1, 5, 1471, 4, 1)]
    [DataRow(2049, 2, 3, 1471, 5, 1)]
    [DataRow(2049, 3, 5, 1471, 6, 1)]
    [DataRow(2049, 4, 3, 1471, 7, 1)]
    [DataRow(2049, 5, 3, 1471, 8, 1)]
    [DataRow(2049, 6, 2, 1471, 9, 1)]
    [DataRow(2049, 7, 1, 1471, 10, 1)]
    [DataRow(2049, 7, 31, 1471, 11, 1)]
    [DataRow(2049, 8, 30, 1471, 12, 1)]
    [DataRow(2049, 9, 28, 1472, 1, 1)]
    [DataRow(2049, 10, 28, 1472, 2, 1)]
    [DataRow(2049, 11, 26, 1472, 3, 1)]
    [DataRow(2049, 12, 26, 1472, 4, 1)]
    [DataRow(2050, 1, 24, 1472, 5, 1)]
    [DataRow(2050, 2, 23, 1472, 6, 1)]
    [DataRow(2050, 3, 24, 1472, 7, 1)]
    [DataRow(2050, 4, 22, 1472, 8, 1)]
    [DataRow(2050, 5, 22, 1472, 9, 1)]
    [DataRow(2050, 6, 20, 1472, 10, 1)]
    [DataRow(2050, 7, 20, 1472, 11, 1)]
    [DataRow(2050, 8, 19, 1472, 12, 1)]
    [DataRow(2050, 9, 17, 1473, 1, 1)]
    [DataRow(2050, 10, 17, 1473, 2, 1)]
    [DataRow(2050, 11, 15, 1473, 3, 1)]
    [DataRow(2050, 12, 15, 1473, 4, 1)]
    [DataRow(2051, 1, 14, 1473, 5, 1)]
    [DataRow(2051, 2, 12, 1473, 6, 1)]
    [DataRow(2051, 3, 14, 1473, 7, 1)]
    [DataRow(2051, 4, 12, 1473, 8, 1)]
    [DataRow(2051, 5, 11, 1473, 9, 1)]
    [DataRow(2051, 6, 10, 1473, 10, 1)]
    [DataRow(2051, 7, 9, 1473, 11, 1)]
    [DataRow(2051, 8, 8, 1473, 12, 1)]
    [DataRow(2051, 9, 6, 1474, 1, 1)]
    [DataRow(2051, 10, 6, 1474, 2, 1)]
    [DataRow(2051, 11, 5, 1474, 3, 1)]
    [DataRow(2051, 12, 4, 1474, 4, 1)]
    [DataRow(2052, 1, 3, 1474, 5, 1)]
    [DataRow(2052, 2, 2, 1474, 6, 1)]
    [DataRow(2052, 3, 2, 1474, 7, 1)]
    [DataRow(2052, 4, 1, 1474, 8, 1)]
    [DataRow(2052, 4, 30, 1474, 9, 1)]
    [DataRow(2052, 5, 29, 1474, 10, 1)]
    [DataRow(2052, 6, 28, 1474, 11, 1)]
    [DataRow(2052, 7, 27, 1474, 12, 1)]
    [DataRow(2052, 8, 26, 1475, 1, 1)]
    [DataRow(2052, 9, 24, 1475, 2, 1)]
    [DataRow(2052, 10, 24, 1475, 3, 1)]
    [DataRow(2052, 11, 22, 1475, 4, 1)]
    [DataRow(2052, 12, 22, 1475, 5, 1)]
    [DataRow(2053, 1, 21, 1475, 6, 1)]
    [DataRow(2053, 2, 20, 1475, 7, 1)]
    [DataRow(2053, 3, 21, 1475, 8, 1)]
    [DataRow(2053, 4, 20, 1475, 9, 1)]
    [DataRow(2053, 5, 19, 1475, 10, 1)]
    [DataRow(2053, 6, 17, 1475, 11, 1)]
    [DataRow(2053, 7, 17, 1475, 12, 1)]
    [DataRow(2053, 8, 15, 1476, 1, 1)]
    [DataRow(2053, 9, 13, 1476, 2, 1)]
    [DataRow(2053, 10, 13, 1476, 3, 1)]
    [DataRow(2053, 11, 11, 1476, 4, 1)]
    [DataRow(2053, 12, 11, 1476, 5, 1)]
    [DataRow(2054, 1, 10, 1476, 6, 1)]
    [DataRow(2054, 2, 9, 1476, 7, 1)]
    [DataRow(2054, 3, 10, 1476, 8, 1)]
    [DataRow(2054, 4, 9, 1476, 9, 1)]
    [DataRow(2054, 5, 9, 1476, 10, 1)]
    [DataRow(2054, 6, 7, 1476, 11, 1)]
    [DataRow(2054, 7, 6, 1476, 12, 1)]
    [DataRow(2054, 8, 5, 1477, 1, 1)]
    [DataRow(2054, 9, 3, 1477, 2, 1)]
    [DataRow(2054, 10, 2, 1477, 3, 1)]
    [DataRow(2054, 11, 1, 1477, 4, 1)]
    [DataRow(2054, 11, 30, 1477, 5, 1)]
    [DataRow(2054, 12, 30, 1477, 6, 1)]
    [DataRow(2055, 1, 29, 1477, 7, 1)]
    [DataRow(2055, 2, 27, 1477, 8, 1)]
    [DataRow(2055, 3, 29, 1477, 9, 1)]
    [DataRow(2055, 4, 28, 1477, 10, 1)]
    [DataRow(2055, 5, 28, 1477, 11, 1)]
    [DataRow(2055, 6, 26, 1477, 12, 1)]
    [DataRow(2055, 7, 25, 1478, 1, 1)]
    [DataRow(2055, 8, 24, 1478, 2, 1)]
    [DataRow(2055, 9, 22, 1478, 3, 1)]
    [DataRow(2055, 10, 21, 1478, 4, 1)]
    [DataRow(2055, 11, 20, 1478, 5, 1)]
    [DataRow(2055, 12, 19, 1478, 6, 1)]
    [DataRow(2056, 1, 18, 1478, 7, 1)]
    [DataRow(2056, 2, 17, 1478, 8, 1)]
    [DataRow(2056, 3, 17, 1478, 9, 1)]
    [DataRow(2056, 4, 16, 1478, 10, 1)]
    [DataRow(2056, 5, 16, 1478, 11, 1)]
    [DataRow(2056, 6, 14, 1478, 12, 1)]
    [DataRow(2056, 7, 14, 1479, 1, 1)]
    [DataRow(2056, 8, 12, 1479, 2, 1)]
    [DataRow(2056, 9, 11, 1479, 3, 1)]
    [DataRow(2056, 10, 10, 1479, 4, 1)]
    [DataRow(2056, 11, 8, 1479, 5, 1)]
    [DataRow(2056, 12, 8, 1479, 6, 1)]
    [DataRow(2057, 1, 6, 1479, 7, 1)]
    [DataRow(2057, 2, 5, 1479, 8, 1)]
    [DataRow(2057, 3, 6, 1479, 9, 1)]
    [DataRow(2057, 4, 5, 1479, 10, 1)]
    [DataRow(2057, 5, 5, 1479, 11, 1)]
    [DataRow(2057, 6, 3, 1479, 12, 1)]
    [DataRow(2057, 7, 3, 1480, 1, 1)]
    [DataRow(2057, 8, 1, 1480, 2, 1)]
    [DataRow(2057, 8, 31, 1480, 3, 1)]
    [DataRow(2057, 9, 30, 1480, 4, 1)]
    [DataRow(2057, 10, 29, 1480, 5, 1)]
    [DataRow(2057, 11, 27, 1480, 6, 1)]
    [DataRow(2057, 12, 27, 1480, 7, 1)]
    [DataRow(2058, 1, 25, 1480, 8, 1)]
    [DataRow(2058, 2, 24, 1480, 9, 1)]
    [DataRow(2058, 3, 25, 1480, 10, 1)]
    [DataRow(2058, 4, 24, 1480, 11, 1)]
    [DataRow(2058, 5, 23, 1480, 12, 1)]
    [DataRow(2058, 6, 22, 1481, 1, 1)]
    [DataRow(2058, 7, 21, 1481, 2, 1)]
    [DataRow(2058, 8, 20, 1481, 3, 1)]
    [DataRow(2058, 9, 19, 1481, 4, 1)]
    [DataRow(2058, 10, 18, 1481, 5, 1)]
    [DataRow(2058, 11, 17, 1481, 6, 1)]
    [DataRow(2058, 12, 17, 1481, 7, 1)]
    [DataRow(2059, 1, 15, 1481, 8, 1)]
    [DataRow(2059, 2, 14, 1481, 9, 1)]
    [DataRow(2059, 3, 15, 1481, 10, 1)]
    [DataRow(2059, 4, 13, 1481, 11, 1)]
    [DataRow(2059, 5, 13, 1481, 12, 1)]
    [DataRow(2059, 6, 11, 1482, 1, 1)]
    [DataRow(2059, 7, 11, 1482, 2, 1)]
    [DataRow(2059, 8, 9, 1482, 3, 1)]
    [DataRow(2059, 9, 8, 1482, 4, 1)]
    [DataRow(2059, 10, 8, 1482, 5, 1)]
    [DataRow(2059, 11, 6, 1482, 6, 1)]
    [DataRow(2059, 12, 6, 1482, 7, 1)]
    [DataRow(2060, 1, 5, 1482, 8, 1)]
    [DataRow(2060, 2, 3, 1482, 9, 1)]
    [DataRow(2060, 3, 4, 1482, 10, 1)]
    [DataRow(2060, 4, 2, 1482, 11, 1)]
    [DataRow(2060, 5, 1, 1482, 12, 1)]
    [DataRow(2060, 5, 31, 1483, 1, 1)]
    [DataRow(2060, 6, 29, 1483, 2, 1)]
    [DataRow(2060, 7, 28, 1483, 3, 1)]
    [DataRow(2060, 8, 27, 1483, 4, 1)]
    [DataRow(2060, 9, 26, 1483, 5, 1)]
    [DataRow(2060, 10, 25, 1483, 6, 1)]
    [DataRow(2060, 11, 24, 1483, 7, 1)]
    [DataRow(2060, 12, 24, 1483, 8, 1)]
    [DataRow(2061, 1, 23, 1483, 9, 1)]
    [DataRow(2061, 2, 21, 1483, 10, 1)]
    [DataRow(2061, 3, 23, 1483, 11, 1)]
    [DataRow(2061, 4, 21, 1483, 12, 1)]
    [DataRow(2061, 5, 20, 1484, 1, 1)]
    [DataRow(2061, 6, 19, 1484, 2, 1)]
    [DataRow(2061, 7, 18, 1484, 3, 1)]
    [DataRow(2061, 8, 16, 1484, 4, 1)]
    [DataRow(2061, 9, 15, 1484, 5, 1)]
    [DataRow(2061, 10, 15, 1484, 6, 1)]
    [DataRow(2061, 11, 13, 1484, 7, 1)]
    [DataRow(2061, 12, 13, 1484, 8, 1)]
    [DataRow(2062, 1, 12, 1484, 9, 1)]
    [DataRow(2062, 2, 10, 1484, 10, 1)]
    [DataRow(2062, 3, 12, 1484, 11, 1)]
    [DataRow(2062, 4, 11, 1484, 12, 1)]
    [DataRow(2062, 5, 10, 1485, 1, 1)]
    [DataRow(2062, 6, 8, 1485, 2, 1)]
    [DataRow(2062, 7, 8, 1485, 3, 1)]
    [DataRow(2062, 8, 6, 1485, 4, 1)]
    [DataRow(2062, 9, 4, 1485, 5, 1)]
    [DataRow(2062, 10, 4, 1485, 6, 1)]
    [DataRow(2062, 11, 3, 1485, 7, 1)]
    [DataRow(2062, 12, 2, 1485, 8, 1)]
    [DataRow(2063, 1, 1, 1485, 9, 1)]
    [DataRow(2063, 1, 30, 1485, 10, 1)]
    [DataRow(2063, 3, 1, 1485, 11, 1)]
    [DataRow(2063, 3, 31, 1485, 12, 1)]
    [DataRow(2063, 4, 30, 1486, 1, 1)]
    [DataRow(2063, 5, 29, 1486, 2, 1)]
    [DataRow(2063, 6, 27, 1486, 3, 1)]
    [DataRow(2063, 7, 27, 1486, 4, 1)]
    [DataRow(2063, 8, 25, 1486, 5, 1)]
    [DataRow(2063, 9, 24, 1486, 6, 1)]
    [DataRow(2063, 10, 23, 1486, 7, 1)]
    [DataRow(2063, 11, 22, 1486, 8, 1)]
    [DataRow(2063, 12, 21, 1486, 9, 1)]
    [DataRow(2064, 1, 20, 1486, 10, 1)]
    [DataRow(2064, 2, 18, 1486, 11, 1)]
    [DataRow(2064, 3, 19, 1486, 12, 1)]
    [DataRow(2064, 4, 18, 1487, 1, 1)]
    [DataRow(2064, 5, 17, 1487, 2, 1)]
    [DataRow(2064, 6, 16, 1487, 3, 1)]
    [DataRow(2064, 7, 15, 1487, 4, 1)]
    [DataRow(2064, 8, 14, 1487, 5, 1)]
    [DataRow(2064, 9, 12, 1487, 6, 1)]
    [DataRow(2064, 10, 12, 1487, 7, 1)]
    [DataRow(2064, 11, 10, 1487, 8, 1)]
    [DataRow(2064, 12, 9, 1487, 9, 1)]
    [DataRow(2065, 1, 8, 1487, 10, 1)]
    [DataRow(2065, 2, 6, 1487, 11, 1)]
    [DataRow(2065, 3, 8, 1487, 12, 1)]
    [DataRow(2065, 4, 7, 1488, 1, 1)]
    [DataRow(2065, 5, 6, 1488, 2, 1)]
    [DataRow(2065, 6, 5, 1488, 3, 1)]
    [DataRow(2065, 7, 5, 1488, 4, 1)]
    [DataRow(2065, 8, 3, 1488, 5, 1)]
    [DataRow(2065, 9, 2, 1488, 6, 1)]
    [DataRow(2065, 10, 1, 1488, 7, 1)]
    [DataRow(2065, 10, 31, 1488, 8, 1)]
    [DataRow(2065, 11, 29, 1488, 9, 1)]
    [DataRow(2065, 12, 28, 1488, 10, 1)]
    [DataRow(2066, 1, 27, 1488, 11, 1)]
    [DataRow(2066, 2, 25, 1488, 12, 1)]
    [DataRow(2066, 3, 27, 1489, 1, 1)]
    [DataRow(2066, 4, 25, 1489, 2, 1)]
    [DataRow(2066, 5, 25, 1489, 3, 1)]
    [DataRow(2066, 6, 24, 1489, 4, 1)]
    [DataRow(2066, 7, 24, 1489, 5, 1)]
    [DataRow(2066, 8, 22, 1489, 6, 1)]
    [DataRow(2066, 9, 21, 1489, 7, 1)]
    [DataRow(2066, 10, 20, 1489, 8, 1)]
    [DataRow(2066, 11, 19, 1489, 9, 1)]
    [DataRow(2066, 12, 18, 1489, 10, 1)]
    [DataRow(2067, 1, 16, 1489, 11, 1)]
    [DataRow(2067, 2, 15, 1489, 12, 1)]
    [DataRow(2067, 3, 16, 1490, 1, 1)]
    [DataRow(2067, 4, 15, 1490, 2, 1)]
    [DataRow(2067, 5, 14, 1490, 3, 1)]
    [DataRow(2067, 6, 13, 1490, 4, 1)]
    [DataRow(2067, 7, 13, 1490, 5, 1)]
    [DataRow(2067, 8, 11, 1490, 6, 1)]
    [DataRow(2067, 9, 10, 1490, 7, 1)]
    [DataRow(2067, 10, 10, 1490, 8, 1)]
    [DataRow(2067, 11, 8, 1490, 9, 1)]
    [DataRow(2067, 12, 8, 1490, 10, 1)]
    [DataRow(2068, 1, 6, 1490, 11, 1)]
    [DataRow(2068, 2, 4, 1490, 12, 1)]
    [DataRow(2068, 3, 5, 1491, 1, 1)]
    [DataRow(2068, 4, 3, 1491, 2, 1)]
    [DataRow(2068, 5, 3, 1491, 3, 1)]
    [DataRow(2068, 6, 1, 1491, 4, 1)]
    [DataRow(2068, 7, 1, 1491, 5, 1)]
    [DataRow(2068, 7, 30, 1491, 6, 1)]
    [DataRow(2068, 8, 29, 1491, 7, 1)]
    [DataRow(2068, 9, 28, 1491, 8, 1)]
    [DataRow(2068, 10, 27, 1491, 9, 1)]
    [DataRow(2068, 11, 26, 1491, 10, 1)]
    [DataRow(2068, 12, 25, 1491, 11, 1)]
    [DataRow(2069, 1, 24, 1491, 12, 1)]
    [DataRow(2069, 2, 23, 1492, 1, 1)]
    public void VerifyIslamicDateWorks(int gYear, int gMonth, int gDay, int iYear, int iMonth, int iDay)
    {
        var jdn = IslamicDateUtils.GregorianToJdn(gYear, gMonth, gDay);
        Assert.AreEqual(jdn, IslamicDateUtils.IslamicDayToJdn(iYear, iMonth, iDay));
        Assert.AreEqual(new IslamicDay(iYear, iMonth, iDay), IslamicDateUtils.JdnToIslamicDay(jdn));
    }

    [TestMethod]
    public void VerifyPersianToIslamicWorks()
    {
        var islamicDay = IslamicDateUtils.PersianDayToIslamicDay(1397, 6, 9);
        Assert.AreEqual(new IslamicDay(1439, 12, 19), islamicDay);
    }

    [TestMethod]
    public void VerifyCivilToIslamicWorks()
    {
        var islamicDay = IslamicDateUtils.GregorianToIslamicDay(2018, 08, 31);
        Assert.AreEqual(new IslamicDay(1439, 12, 19), islamicDay);
    }

    [TestMethod]
    public void VerifyGregorianToIslamicWorks()
    {
        var islamicDay = new DateTime(2018, 08, 31).ToIslamicDay();
        Assert.AreEqual(new IslamicDay(1439, 12, 19), islamicDay);
    }

    [TestMethod]
    public void VerifyToPersianDayWorks()
    {
        var persianDay = new DateTime(2018, 08, 31).ToPersianDay();
        Assert.AreEqual(1397, persianDay.Year);
    }
}