using NUnit.Framework;

namespace TestAxe
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int result = 3 + 3;
            Assert.AreEqual(5,5, "goofy ahh math");
        }
    }
}