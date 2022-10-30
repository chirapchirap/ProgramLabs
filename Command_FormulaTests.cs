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
    public class Command_FormulaTests
    {
        [TestMethod()]
        public void formula_countTest1()
        {
            double actualY = 12134;
            double actualX = 66432;
            double actualZ = 4234;
            if (actualZ == -1 || actualZ == 0) { Assert.Fail(); }
            double actualRes = Command_Formula.formula_count(ref actualY, ref actualX, ref actualZ);
            double expected = 21;
            Assert.AreNotEqual(actualRes, expected);
        }
        [TestMethod()]
        public void formula_countTest2()
        {
            double actualY = 12;
            double actualX = 6;
            double actualZ = 4;
            if (actualZ == -1 || actualZ == 0) { Assert.Fail(); }
            double actualRes = Command_Formula.formula_count(ref actualY, ref actualX, ref actualZ);
            double expected = 3;
            Assert.AreEqual(actualRes, expected);
        }
    }
}