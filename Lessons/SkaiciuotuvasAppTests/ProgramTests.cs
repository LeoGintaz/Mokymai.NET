using Microsoft.VisualStudio.TestTools.UnitTesting;
using SkaiciuotuvasApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSkaiciuotuvas.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void SuperSkaiciuotuvasTest()
        {
            {
                var fake_moves = new string[] { "1", "1", "15", "45", "2", "2", "10", "3" };
                var expected = 50d;

                Program.Reset();
                foreach (var move in fake_moves)
                {
                    Program.SuperSkaiciuotuvas(move);
                }
                var actual = SkaiciuotuvasApp.Program.Rezultatas();

                Assert.AreEqual(expected, actual);
            }
        }
    }
}