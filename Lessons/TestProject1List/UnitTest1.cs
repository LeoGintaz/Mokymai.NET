namespace TestProject1List
{
    [TestClass]
    public class List1
    {
        [TestMethod]
        public void Didziausias()
        {
            List<int> fake = new List<int> { 5, 1, 6, 8, 7 };
            int expected = 8;
            var actual = Lists.Program.Didziausias(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void VienuDidesnis()
        {
            List<int> fake = new List<int> { 5, 1, 6, 8, 7 };
            int expected = 9;
            var actual = Lists.Program.VienuDidesnis(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void VienuDidesnis2()
        {
            List<int> fake = new List<int> { 5, 1, 6, 8, 7 };
            List<int> expected = new List<int> { 5, 1, 6, 8, 7, 9 };
            var actual = Lists.Program.VienuDidesnis2(fake);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}