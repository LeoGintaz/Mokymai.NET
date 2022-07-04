namespace TestMetodai2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsMokausi()
        {
            var fake = "as labai mokausi programuoti";
            var expected = "taip";
            var actual = Metodai2.Program.Mokausi(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsMokausi2()
        {
            var fake = "aslabaimokausiprogramuoti";
            var expected = "ne";
            var actual = Metodai2.Program.Mokausi(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsMokausi3()
        {
            var fake = "mokausi programuoti labai";
            var expected = "taip";
            var actual = Metodai2.Program.Mokausi(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsMokausi4()
        {
            var fake = "as mokausi, labai stipriai";
            var expected = "taip";
            var actual = Metodai2.Program.Mokausi(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsMokausi5()
        {
            var fake = "as mokausi?";
            var expected = "taip";
            var actual = Metodai2.Program.Mokausi(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsMokausi6()
        {
            var fake = "as mokausi!";
            var expected = "taip";
            var actual = Metodai2.Program.Mokausi(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NeMokausi7()
        {
            var fake = "as studijuoju (mokausi)";
            var expected = "taip";
            var actual = Metodai2.Program.Mokausi(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsMokausiBe()
        {
            var fake = "as studijuojumokausi)";
            var expected = "ne";
            var actual = Metodai2.Program.Mokausi(fake);
            Assert.AreEqual(expected, actual);





        }
        [TestMethod]
        public void A()
        {
            var fake = "as_mokausi_programuoti";
            var expected = 0;
            var actual = Metodai2.Program.Aindex(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void A2()
        {
            var fake = "mokausi_programuoti";
            var expected = 3;
            var actual = Metodai2.Program.Aindex(fake);
            Assert.AreEqual(expected, actual);
        }
    }

}