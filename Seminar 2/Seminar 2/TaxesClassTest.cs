using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxesClass;

namespace Seminar_2
{
    [TestClass]
    public class TaxesClassTest
    {
        [TestMethod]
        public void Single_0()
        {
            Taxes taxes = new Taxes();
            double income = 0;
            double expectedTax = 0;
            double tax = taxes.Single(income);
            Assert.AreEqual(expectedTax, tax, 0.00);
        }

        [TestMethod]
        public void Single_NegativeNumber()
        {
            Taxes taxes = new Taxes();
            double income = -1000;
            double expectedTax = 0;
            double tax = taxes.Single(income);
            Assert.AreEqual(expectedTax, tax, 0.00);
        }

        [TestMethod]
        public void Single_5000()
        {
            Taxes taxes = new Taxes();
            double income = 5000;
            double expectedTax = 500;
            double tax = taxes.Single(income);
            Assert.AreEqual(expectedTax, tax, 0.00);
        }
        [TestMethod]
        public void Single_9075()
        {
            Taxes taxes = new Taxes();
            double income = 9075;
            double expectedTax = 907.5;
            double tax = taxes.Single(income);
            Assert.AreEqual(expectedTax, tax, 0.00);
        }
        [TestMethod]
        public void Single_36900()
        {
            Taxes taxes = new Taxes();
            double income = 36900;
            double expectedTax = 5081.25;
            double tax = taxes.Single(income);
            Assert.AreEqual(expectedTax, tax, 0.00);
        }
        [TestMethod]
        public void Single_20000()
        {
            Taxes taxes = new Taxes();
            double income = 20000;
            double expectedTax = 2546.25;
            double tax = taxes.Single(income);
            Assert.AreEqual(expectedTax, tax, 0.00);
        }

        [TestMethod]
        public void Single_89350()
        {
            Taxes taxes = new Taxes();
            double income = 89350;
            double expectedTax = 18193.75;
            double tax = taxes.Single(income);
            Assert.AreEqual(expectedTax, tax, 0.00);
        }

        [TestMethod]
        public void Single_186350()
        {
            Taxes taxes = new Taxes();
            double income = 186350;
            double expectedTax = 45353.75;
            double tax = taxes.Single(income);
            Assert.AreEqual(expectedTax, tax, 0.00);
        }

        [TestMethod]
        public void Single_405100()
        {
            Taxes taxes = new Taxes();
            double income = 405100;
            double expectedTax = 117541.25;
            double tax = taxes.Single(income);
            Assert.AreEqual(expectedTax, tax, 0.00);
        }

        [TestMethod]
        public void Single_406750()
        {
            Taxes taxes = new Taxes();
            double income = 406750;
            double expectedTax = 118118.75;
            double tax = taxes.Single(income);
            Assert.AreEqual(expectedTax, tax, 0.00);
        }

        [TestMethod]
        public void Single_500000()
        {
            Taxes taxes = new Taxes();
            double income = 500000;
            double expectedTax = 155045.75;
            double tax = taxes.Single(income);
            Assert.AreEqual(expectedTax, tax, 0.00);
        }

        [TestMethod]
        public void Jointly_0()
        {
            Taxes taxes = new Taxes();
            double income = 0;
            double expectedTax = 0;
            double tax = taxes.Jointly(income);
            Assert.AreEqual(expectedTax, tax, 0.00);
        }

        [TestMethod]
        public void Jointly_18150()
        {
            Taxes taxes = new Taxes();
            double income = 18150;
            double expectedTax = 1815.00;
            double tax = taxes.Jointly(income);
            Assert.AreEqual(expectedTax, tax, 0.00);
        }

        [TestMethod]
        public void Jointly_73800()
        {
            Taxes taxes = new Taxes();
            double income = 73800;
            double expectedTax = 10162.50;
            double tax = taxes.Jointly(income);
            Assert.AreEqual(expectedTax, tax, 0.00);
        }

        [TestMethod]
        public void Jointly_148850()
        {
            Taxes taxes = new Taxes();
            double income = 148850;
            double expectedTax = 28925.00;
            double tax = taxes.Jointly(income);
            Assert.AreEqual(expectedTax, tax, 0.00);
        }

        [TestMethod]
        public void Jointly_226850()
        {
            Taxes taxes = new Taxes();
            double income = 226850;
            double expectedTax = 50765.00;
            double tax = taxes.Jointly(income);
            Assert.AreEqual(expectedTax, tax, 0.00);
        }

        [TestMethod]
        public void Jointly_405100()
        {
            Taxes taxes = new Taxes();
            double income = 405100;
            double expectedTax = 109587.50;
            double tax = taxes.Jointly(income);
            Assert.AreEqual(expectedTax, tax, 0.00);
        }

        [TestMethod]
        public void Jointly_457600()
        {
            Taxes taxes = new Taxes();
            double income = 457600;
            double expectedTax = 127962.50;
            double tax = taxes.Jointly(income);
            Assert.AreEqual(expectedTax, tax, 0.00);
        }

        [TestMethod]
        public void Jointly_500000()
        {
            Taxes taxes = new Taxes();
            double income = 500000;
            double expectedTax = 144752.9;
            double tax = taxes.Jointly(income);
            Assert.AreEqual(expectedTax, tax, 0.00);
        }

        [TestMethod]
        public void Separately_0()
        {
            Taxes taxes = new Taxes();
            double income = 0;
            double expectedTax = 0;
            double tax = taxes.Separately(income);
            Assert.AreEqual(expectedTax, tax, 0.00);
        }

        [TestMethod]
        public void Separately_9075()
        {
            Taxes taxes = new Taxes();
            double income = 9075;
            double expectedTax = 907.50;
            double tax = taxes.Separately(income);
            Assert.AreEqual(expectedTax, tax, 0.00);
        }

        [TestMethod]
        public void Separately_36900()
        {
            Taxes taxes = new Taxes();
            double income = 36900;
            double expectedTax = 5081.25;
            double tax = taxes.Separately(income);
            Assert.AreEqual(expectedTax, tax, 0.00);
        }

        [TestMethod]
        public void Separately_74425()
        {
            Taxes taxes = new Taxes();
            double income = 74425;
            double expectedTax = 14462.50;
            double tax = taxes.Separately(income);
            Assert.AreEqual(expectedTax, tax, 0.00);
        }

        [TestMethod]
        public void Separately_113425()
        {
            Taxes taxes = new Taxes();
            double income = 113425;
            double expectedTax = 25382.50;
            double tax = taxes.Separately(income);
            Assert.AreEqual(expectedTax, tax, 0.00);
        }

        [TestMethod]
        public void Separately_202550()
        {
            Taxes taxes = new Taxes();
            double income = 202550;
            double expectedTax = 54793.75;
            double tax = taxes.Separately(income);
            Assert.AreEqual(expectedTax, tax, 0.00);
        }

        [TestMethod]
        public void Separately_228800()
        {
            Taxes taxes = new Taxes();
            double income = 228800;
            double expectedTax = 63981.25;
            double tax = taxes.Separately(income);
            Assert.AreEqual(expectedTax, tax, 0.00);
        }

        [TestMethod]
        public void Separately_500000()
        {
            Taxes taxes = new Taxes();
            double income = 500000;
            double expectedTax = 171376.45;
            double tax = taxes.Separately(income);
            Assert.AreEqual(expectedTax, tax, 0.00);
        }

        [TestMethod]
        public void Head_0()
        {
            Taxes taxes = new Taxes();
            double income = 0;
            double expectedTax = 0;
            double tax = taxes.Head(income);
            Assert.AreEqual(expectedTax, tax, 0.00);
        }

        [TestMethod]
        public void Head_12950()
        {
            Taxes taxes = new Taxes();
            double income = 12950;
            double expectedTax = 1295.00;
            double tax = taxes.Head(income);
            Assert.AreEqual(expectedTax, tax, 0.00);
        }

        [TestMethod]
        public void Head_49400()
        {
            Taxes taxes = new Taxes();
            double income = 49400;
            double expectedTax = 6762.50;
            double tax = taxes.Head(income);
            Assert.AreEqual(expectedTax, tax, 0.00);
        }

        [TestMethod]
        public void Head_127550()
        {
            Taxes taxes = new Taxes();
            double income = 127550;
            double expectedTax = 26300.00;
            double tax = taxes.Head(income);
            Assert.AreEqual(expectedTax, tax, 0.00);
        }

        [TestMethod]
        public void Head_206600()
        {
            Taxes taxes = new Taxes();
            double income = 206600;
            double expectedTax = 48434.00;
            double tax = taxes.Head(income);
            Assert.AreEqual(expectedTax, tax, 0.00);
        }

        [TestMethod]
        public void Head_405100()
        {
            Taxes taxes = new Taxes();
            double income = 405100;
            double expectedTax = 113939.00;
            double tax = taxes.Head(income);
            Assert.AreEqual(expectedTax, tax, 0.00);
        }

        [TestMethod]
        public void Head_432200()
        {
            Taxes taxes = new Taxes();
            double income = 432200;
            double expectedTax = 123424.00;
            double tax = taxes.Head(income);
            Assert.AreEqual(expectedTax, tax, 0.00);
        }

        [TestMethod]
        public void Head_500000()
        {
            Taxes taxes = new Taxes();
            double income = 500000;
            double expectedTax = 150272.8;
            double tax = taxes.Head(income);
            Assert.AreEqual(expectedTax, tax, 0.00);
        }
    }
}
