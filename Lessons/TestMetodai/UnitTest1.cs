namespace TestMetodai2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Tarpai_Test1()
        {
            var fake = "as mokausi programuoti";
            var expected = 2;
            var actual = Metodai2.Program.Tarpai(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Tarpai_Test2()
        {
            var fake = " as mokausi programuoti ";
            var expected = 4;
            var actual = Metodai2.Program.Tarpai(fake);
            Assert.AreEqual(expected, actual);
        }
        //-----------------------------------------------------
        [TestMethod]
        public void Tarpai_Test1()
        {
            var fake = "as mokausi programuoti";
            var expected = 2;
            var actual = Metodai2.Program.Tarpai(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Tarpai_Test2()
        {
            var fake = " as mokausi programuoti ";
            var expected = 4;
            var actual = Metodai2.Program.Tarpai(fake);
            Assert.AreEqual(expected, actual);
        }







    }

}