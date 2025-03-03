﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using DateTimeExtensions.WorkingDays;
using DateTimeExtensions.WorkingDays.CultureStrategies;


namespace DateTimeExtensions.Tests
{
    [TestFixture]
    public class en_NZCalendarTest
    {
        [Test]
        public void NewYearsDay()
        {
            var workingDayCultureInfo = new WorkingDayCultureInfo("en-NZ");

            var dateOnGregorian = new DateTime(2011, 1, 1);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
            dateOnGregorian = new DateTime(2012, 1, 1);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
            dateOnGregorian = new DateTime(2013, 1, 1);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
            dateOnGregorian = new DateTime(2014, 1, 1);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
            dateOnGregorian = new DateTime(2015, 1, 1);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
            dateOnGregorian = new DateTime(2016, 1, 1);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
            dateOnGregorian = new DateTime(2017, 1, 3);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
            dateOnGregorian = new DateTime(2018, 1, 1);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
            dateOnGregorian = new DateTime(2019, 1, 1);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
            dateOnGregorian = new DateTime(2020, 1, 1);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
        }

        [Test]
        public void DayAfterNewYearsDay()
        {
            var workingDayCultureInfo = new WorkingDayCultureInfo("en-NZ");

            var dateOnGregorian = new DateTime(2013, 1, 2);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
            dateOnGregorian = new DateTime(2014, 1, 2);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
            dateOnGregorian = new DateTime(2015, 1, 2);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
            dateOnGregorian = new DateTime(2016, 1, 4);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
            dateOnGregorian = new DateTime(2017, 1, 2);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
            dateOnGregorian = new DateTime(2018, 1, 2);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
            dateOnGregorian = new DateTime(2019, 1, 2);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
            dateOnGregorian = new DateTime(2020, 1, 2);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
        }

        [Test]
        public void EasterAnzacClash()
        {
            var workingDayCultureInfo = new WorkingDayCultureInfo("en-NZ");

            var holidays = workingDayCultureInfo.GetHolidaysOfYear(2010);
            Assert.IsTrue(holidays.Any(h => h.Name == "Easter Monday"));
            Assert.IsTrue(holidays.Any(h => h.Name == "Anzac Day"));
            Assert.IsFalse(holidays.Any(h => h.Name == "Easter Monday/Anzac Day"));

            holidays = workingDayCultureInfo.GetHolidaysOfYear(2011);
            Assert.IsFalse(holidays.Any(h => h.Name == "Easter Monday"));
            Assert.IsFalse(holidays.Any(h => h.Name == "Anzac Day"));
            Assert.IsTrue(holidays.Any(h => h.Name == "Easter Monday/Anzac Day"));

            holidays = workingDayCultureInfo.GetHolidaysOfYear(2012);
            Assert.IsTrue(holidays.Any(h => h.Name == "Easter Monday"));
            Assert.IsTrue(holidays.Any(h => h.Name == "Anzac Day"));
            Assert.IsFalse(holidays.Any(h => h.Name == "Easter Monday/Anzac Day"));

            holidays = workingDayCultureInfo.GetHolidaysOfYear(2095);
            Assert.IsFalse(holidays.Any(h => h.Name == "Easter Monday"));
            Assert.IsFalse(holidays.Any(h => h.Name == "Anzac Day"));
            Assert.IsTrue(holidays.Any(h => h.Name == "Easter Monday/Anzac Day"));
        }

        [Test]
        public void MonarchsBirthday()
        {
            var workingDayCultureInfo = new WorkingDayCultureInfo("en-NZ");

            var dateOnGregorian = new DateTime(2011, 6, 6);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
            dateOnGregorian = new DateTime(2015, 6, 1);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
            dateOnGregorian = new DateTime(2016, 6, 6);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
            dateOnGregorian = new DateTime(2019, 6, 3);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
            dateOnGregorian = new DateTime(2022, 6, 6);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
            dateOnGregorian = new DateTime(2023, 6, 5);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
            dateOnGregorian = new DateTime(2024, 6, 3);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
            dateOnGregorian = new DateTime(2025, 6, 2);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
            dateOnGregorian = new DateTime(2026, 6, 1);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
            dateOnGregorian = new DateTime(2027, 6, 7);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);

            var holidays = workingDayCultureInfo.GetHolidaysOfYear(2021);
            Assert.IsTrue(holidays.Any(h => h.Name == "Queen's Birthday"));
            holidays = workingDayCultureInfo.GetHolidaysOfYear(2022);
            Assert.IsTrue(holidays.Any(h => h.Name == "Queen's Birthday"));
            holidays = workingDayCultureInfo.GetHolidaysOfYear(2023);
            Assert.IsTrue(holidays.Any(h => h.Name == "King's Birthday"));
            holidays = workingDayCultureInfo.GetHolidaysOfYear(2024);
            Assert.IsTrue(holidays.Any(h => h.Name == "King's Birthday"));
            holidays = workingDayCultureInfo.GetHolidaysOfYear(2025);
            Assert.IsTrue(holidays.Any(h => h.Name == "King's Birthday"));
            holidays = workingDayCultureInfo.GetHolidaysOfYear(2026);
            Assert.IsTrue(holidays.Any(h => h.Name == "King's Birthday"));

        }

        [Test]
        public void Matariki()
        {
            var workingDayCultureInfo = new WorkingDayCultureInfo("en-NZ");

            var dateOnGregorian = new DateTime(2022, 6, 24);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
            dateOnGregorian = new DateTime(2023, 7, 14);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
            dateOnGregorian = new DateTime(2024, 6, 28);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
            dateOnGregorian = new DateTime(2025, 6, 20);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
            dateOnGregorian = new DateTime(2026, 7, 10);


            var holidays = workingDayCultureInfo.GetHolidaysOfYear(2021);
            Assert.IsFalse(holidays.Any(h => h.Name == "Matariki"));
            holidays = workingDayCultureInfo.GetHolidaysOfYear(2022);
            Assert.IsTrue(holidays.Any(h => h.Name == "Matariki"));
        }


        [Test]
        public void Christmas()
        {
            var workingDayCultureInfo = new WorkingDayCultureInfo("en-NZ");

            var dateOnGregorian = new DateTime(2013, 12, 25);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
            dateOnGregorian = new DateTime(2014, 12, 25);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
            dateOnGregorian = new DateTime(2015, 12, 25);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
            dateOnGregorian = new DateTime(2016, 12, 26);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
            dateOnGregorian = new DateTime(2017, 12, 25);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
            dateOnGregorian = new DateTime(2018, 12, 25);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
            dateOnGregorian = new DateTime(2019, 12, 25);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
            dateOnGregorian = new DateTime(2020, 12, 25);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
        }

        [Test]
        public void BoxingDay()
        {
            var workingDayCultureInfo = new WorkingDayCultureInfo("en-NZ");

            var dateOnGregorian = new DateTime(2013, 12, 26);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
            dateOnGregorian = new DateTime(2014, 12, 26);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
            dateOnGregorian = new DateTime(2015, 12, 28);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
            dateOnGregorian = new DateTime(2016, 12, 26);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
            dateOnGregorian = new DateTime(2017, 12, 26);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
            dateOnGregorian = new DateTime(2018, 12, 26);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
            dateOnGregorian = new DateTime(2019, 12, 26);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
            dateOnGregorian = new DateTime(2020, 12, 28);
            TestHoliday(workingDayCultureInfo, dateOnGregorian);
        }




        private void TestHoliday(IWorkingDayCultureInfo workingDayCultureInfo, DateTime dateOnGregorian)
        {
            var isHoliday = workingDayCultureInfo.IsHoliday(dateOnGregorian);
            Assert.IsTrue(isHoliday);
        }
    }
}