using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgramLabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLabs.Tests
{
    [TestClass()]
    public class StringCheckerTests
    {
        [TestMethod()]
        public void check_str_one_regexTest1()
        {
            string actual = "+79998887766";
            ValidationException exception = Assert.ThrowsException<ValidationException>(() => StringChecker.check_str_one_regex(actual));
            Assert.AreEqual(exception.Message, "The first string is phone number.");
        }
        [TestMethod()]
        public void check_str_one_regexTest2()
        {
            string actual = "ho";
            ValidationException exception = Assert.ThrowsException<ValidationException>(() => StringChecker.check_str_one_regex(actual));
            Assert.AreEqual(exception.Message, "The first string doesn't match with email, ip or phone number.");
        }
        [TestMethod()]
        public void check_str_two_regexTest1()
        {
            string actual = "hello@hello.hello";
            ValidationException exception = Assert.ThrowsException<ValidationException>(() => StringChecker.check_str_two_regex(actual));
            Assert.AreEqual(exception.Message, "The second string is email.");
        }

        [TestMethod()]
        public void check_str_two_regexTest2()
        {
            string expected = "25.25.25.25";
            ValidationException exception = Assert.ThrowsException<ValidationException>(() => StringChecker.check_str_two_regex(expected));
            Assert.AreEqual(exception.Message, "The second string is IP adress.");
        }
        [TestMethod()]
        public void check_register_cmp_stringsTest1()
        {
            string str1 = "  HEllo  wor  l    D      ";
            string str2 = " HELLOW         OR   LD ";
            string expected = "2) Strings are equal(case-insensitive)";
            ValidationException exception = Assert.ThrowsException<ValidationException>(() => StringChecker.check_register_compared_strings(str1, str2));
            Assert.AreEqual(exception.Message, expected);
        }
        [TestMethod()]
        public void check_register_cmp_stringsTest2()
        {
            string str1 = "  HEllo  wor  l    D      ";
            string str2 = "OW         OR   LD ";
            string expected = "2) Strings are not equal(case-insensitive)";
            ValidationException exception = Assert.ThrowsException<ValidationException>(() => StringChecker.check_register_compared_strings(str1, str2));
            Assert.AreEqual(exception.Message, expected);
        }
        [TestMethod()]
        public void check_compared_stringsTest1()
        {
            string str1 = " HE LL O";
            string str2 = " HE LL O";
            string expected = "1) Strings are equal(case-sensitive)";
            ValidationException exception = Assert.ThrowsException<ValidationException>(() => StringChecker.check_compared_strings(str1, str2));
            Assert.AreEqual(exception.Message, expected);
        }
        [TestMethod()]
        public void check_compared_stringsTest2()
        {
            string str1 = "   LL O";
            string str2 = " HE          LL O";
            string expected = "1) Strings are not equal(case-sensitive)";
            ValidationException exception = Assert.ThrowsException<ValidationException>(() => StringChecker.check_compared_strings(str1, str2));
            Assert.AreEqual(exception.Message, expected);
        }

        [TestMethod()]
        public void check_reversed_stringsTest1()
        {
            string str1 = "HELLO";
            string str2 = "OLLEH";
            string expected = "3) One string is reversed to another";
            ValidationException exception = Assert.ThrowsException<ValidationException>(() => StringChecker.check_reversed_strings(str1, str2));
            Assert.AreEqual(exception.Message, expected);
        }
        [TestMethod()]
        public void check_reversed_stringsTest2()
        {
            string str1 = "HELLO";
            string str2 = "HELLO";
            string expected = "3) One string isn't reversed to another";
            ValidationException exception = Assert.ThrowsException<ValidationException>(() => StringChecker.check_reversed_strings(str1, str2));
            Assert.AreEqual(exception.Message, expected);
        }
    }
}
