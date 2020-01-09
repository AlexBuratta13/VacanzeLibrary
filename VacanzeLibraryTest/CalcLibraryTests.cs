using Microsoft.VisualStudio.TestTools.UnitTesting;
using VacanzeLibrary;

namespace VacanzeLibraryTest
{
    [TestClass]
    public class CalcLibraryTests
    {
        [TestMethod]
        public void MaxTest()
        {
            int num1 = 5;
            int num2 = 2;
            int ris = CalcLibrary.Max(num1, num2);
            int ris_aspettato = 5;
            Assert.AreEqual(ris, ris_aspettato);
        }
        [TestMethod]
        public void MinTest()
        {
            int num1 = 5;
            int num2 = 2;
            int ris = CalcLibrary.Min(num1, num2);
            int ris_aspettato = 2;
            Assert.AreEqual(ris, ris_aspettato);
        }
        [TestMethod]
        public void MediaTest()
        {
            double num1 = 5;
            double num2 = 2;
            double ris = CalcLibrary.Media(num1, num2);
            double ris_aspettato = 3.5;
            Assert.AreEqual(ris, ris_aspettato);
        }
        public void Max1Test()
        {
            int num1 = 3;
            int num2 = 4;
            int ris = CalcLibrary.Max(num1, num2);
            int ris_aspettato = 4;
            Assert.AreEqual(ris, ris_aspettato);
        }
        [TestMethod]
        public void Min1Test()
        {
            int num1 = 3;
            int num2 = 4;
            int ris = CalcLibrary.Min(num1, num2);
            int ris_aspettato = 3;
            Assert.AreEqual(ris, ris_aspettato);
        }
        [TestMethod]
        public void Media1Test()
        {
            double num1 = 3;
            double num2 = 4;
            double ris = CalcLibrary.Media(num1, num2);
            double ris_aspettato = 3.5;
            Assert.AreEqual(ris, ris_aspettato);
        }
        public void Max2Test()
        {
            int num1 = 7;
            int num2 = 7;
            int ris = CalcLibrary.Max(num1, num2);
            int ris_aspettato = 7;
            Assert.AreEqual(ris, ris_aspettato);
        }
        [TestMethod]
        public void Min2Test()
        {
            int num1 = 7;
            int num2 = 7;
            int ris = CalcLibrary.Min(num1, num2);
            int ris_aspettato = 7;
            Assert.AreEqual(ris, ris_aspettato);
        }
        [TestMethod]
        public void Media2Test()
        {
            double num1 = 7;
            double num2 = 7;
            double ris = CalcLibrary.Media(num1, num2);
            double ris_aspettato = 7;
            Assert.AreEqual(ris, ris_aspettato);
        }
    }
}
