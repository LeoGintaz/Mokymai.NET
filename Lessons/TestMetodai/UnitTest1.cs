namespace TestMetodai2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsMokausi()
        {
            var fake = "as mokausi programuoti";
            var expected = "taip";
            var actual = Metodai2.Program.Mokausi(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NeMokausi()
        {
            var fake = "as veikiu beleka";
            var expected = "ne";
            var actual = Metodai2.Program.Mokausi(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsMokausiBe()
        {
            var fake = "as_mokausi_programuoti";
            var expected = "taip";
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