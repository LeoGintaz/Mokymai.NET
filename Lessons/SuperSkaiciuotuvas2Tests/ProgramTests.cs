using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperSkaiciuotuvas2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSkaiciuotuvas2.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        
        public void SuperSkaiciuotuvasTest1()
        {
            var fake_moves = new string[] { "1", "1", "15", "45", "2", "2", "10", "3" };
            var expected = 50d;

            Program.Reset();
            foreach (var move in fake_moves)
            {
                Program.SuperSkaiciuotuvas(move);
            }
            var actual = SuperSkaiciuotuvas2.Program.Rezultatas();

            Assert.AreEqual(expected, actual);
        }
    }
}