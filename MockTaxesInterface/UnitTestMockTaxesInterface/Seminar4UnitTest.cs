using Microsoft.VisualStudio.TestTools.UnitTesting;
using MockTaxesInterface;

namespace UnitTestMockTaxesInterface
{
    public class MockTaxes : ITaxes
    {
        public double Single(double income)
        {
            if (income == 9075)
            {
                return 907.5;
            }
            else
                return 0;
        }

        public double MarriedFilingJointly(double income)
        {
            if (income == 73800)
            {
                return 10162.50;
            }
            else
                return 0;
        }

        public double MarriedFilingSeperately(double income)
        {
            if (income == 74425)
            {
                return 14462.50;
            }
            else
                return 0;
        }

        public double HeadOfHousehold(double income)
        {
            if (income == 206600)
            {
                return 48434.00;
            }
            else
                return 0;
        }
    }

        [TestClass]
    public class TestOfMockTaxesInterface
    {
        [TestMethod]
        public void TestOfMockSingle()
        {
            var taxes = new MockTaxes();
            var taxDetermination = new TaxDetermination(taxes);

            const string Schedule = "X";
            const double Income = 9075;
            const double ExpectedTax = 907.5;

            var ActualTax = taxDetermination.ScheduleSort(Schedule, Income);

            Assert.AreEqual(ExpectedTax, ActualTax);
        }

        [TestMethod]
        public void TestOfMockMarriedFilingJointly()
        {
            var taxes = new MockTaxes();
            var taxDetermination = new TaxDetermination(taxes);

            const string Schedule = "y1";       //Also tests conversion to upper
            const double Income = 73800;
            const double ExpectedTax = 10162.50;

            var ActualTax = taxDetermination.ScheduleSort(Schedule, Income);

            Assert.AreEqual(ExpectedTax, ActualTax);
        }

        [TestMethod]
        public void TestOfMockMarriedFilingSeperately()
        {
            var taxes = new MockTaxes();
            var taxDetermination = new TaxDetermination(taxes);

            const string Schedule = "y2";       //Also tests conversion to upper
            const double Income = 74425;
            const double ExpectedTax = 14462.50;

            var ActualTax = taxDetermination.ScheduleSort(Schedule, Income);

            Assert.AreEqual(ExpectedTax, ActualTax);
        }

        [TestMethod]
        public void TestOfMockHeadOfHousehold()
        {
            var taxes = new MockTaxes();
            var taxDetermination = new TaxDetermination(taxes);

            const string Schedule = "Z";
            const double Income = 206600;
            const double ExpectedTax = 48434.00;

            var ActualTax = taxDetermination.ScheduleSort(Schedule, Income);

            Assert.AreEqual(ExpectedTax, ActualTax);
        }
    }
}
