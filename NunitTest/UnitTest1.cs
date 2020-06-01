using CiCd_WithGit.Controllers;
using NUnit.Framework;

namespace NunitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        ValuesController controller = new ValuesController();
        [Test]
        public void GetReturnsCorrectNumber()
        {
            var returnValue = controller.GetString(1);
            Assert.AreEqual("TestCiCd", returnValue.Value);
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}