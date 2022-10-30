using ProgramLabs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLabs.Test
{
    [TestClass()]
    public class Command_DatesTests
    {
        [TestMethod()]
        public void PowerOfTwo_8_YESreturned()
        {
            long x = 128;
            Assert.IsTrue(Command_Dates.PowerOfTwo(x));
        }
        [TestMethod()]
        public void PowerOfTwo_9_NOreturned()
        {
            long x = 9;
            Assert.IsFalse(Command_Dates.PowerOfTwo(x));
        }
        [TestMethod()]
        public void dateProcessing_8_EqualReturned()
        {
            int result = Command_Dates.dates_processing(Convert.ToDateTime("01.01.2020"), Convert.ToDateTime("08.01.2020"), Convert.ToDateTime("01.01.2020"), Convert.ToDateTime("08.01.2020"));
            int expected = 8;
            Assert.AreEqual(result, expected);
        }
        [TestMethod()]
        public void dateProcessing_9_NotEqualReturned()
        {
            int result = Command_Dates.dates_processing(Convert.ToDateTime("01.01.2020"), Convert.ToDateTime("09.01.2020"), Convert.ToDateTime("01.01.2020"), Convert.ToDateTime("09.01.2020"));
            int expected = 8;
            Assert.AreNotEqual(result, expected);
        }
        [TestMethod()]
        public void coinsDate_8_YESreturned()
        {
            int actual = 8;
            string expected = "YES";
            Assert.AreEqual(DateChecker.coinciding_dates_num(actual), expected);
        }
        [TestMethod()]
        public void coinsDate_0_STRreturned()
        {
            int actual = 0;
            string expected = "N должен быть больше 0!!";
            Assert.AreEqual(DateChecker.coinciding_dates_num(actual), expected);
        }
        [TestMethod()]
        public void coinsDate_9_NOreturned()
        {
            int actual = 9;
            string expected = "NO";
            Assert.AreEqual(DateChecker.coinciding_dates_num(actual), expected);
        }
    }
}