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
        
        }







    }

}