namespace TaxesClassRefactored
{
    public class Taxes
    {
        private double tax = 0;
        private double taxableIncome;
        private double incomeDeduction;
        private double taxRate;
        private double baseTax;

        public double Single(double income)
        {
            if (income > 0)
            {
                if (income <= 9075)
                {
                    taxRate = 0.1;
                    incomeDeduction = 0;
                    baseTax = 0;
                }

                if (income > 9075 && income <= 36900)
                {
                    taxRate = 0.15;
                    incomeDeduction = 9075;
                    baseTax = 907.5;
                }

                if (income > 36900 && income <= 89350)
                {
                    taxRate = 0.25;
                    incomeDeduction = 36900;
                    baseTax = 5081.25;
                }

                if (income > 89350 && income <= 186350)
                {
                    taxRate = 0.28;
                    incomeDeduction = 89350;
                    baseTax = 18193.75;
                }

                if (income > 186350 && income <= 405100)
                {
                    taxRate = 0.33;
                    incomeDeduction = 186350;
                    baseTax = 45353.75;
                }

                if (income > 405100 && income <= 406750)
                {
                    taxRate = 0.35;
                    incomeDeduction = 405100;
                    baseTax = 117541.25;
                }

                if (income > 406750)
                {
                    taxRate = 0.396;
                    incomeDeduction = 406750;
                    baseTax = 118118.75;
                }

                taxableIncome = CalcualteTaxableIncome(income, incomeDeduction);
                tax = CalculateTax(baseTax, taxableIncome, taxRate);
            }

            return tax;
        }

        public double MarriedFilingJointly(double income)
        {
            if (income > 0)
            {
                if (income <= 18150)
                {
                    taxRate = 0.1;
                    incomeDeduction = 0;
                    baseTax = 0;
                }

                if (income > 18150 && income <= 73800)
                {
                    taxRate = 0.15;
                    incomeDeduction = 18150;
                    baseTax = 1815.00;
                }

                if (income > 73800 && income <= 148850)
                {
                    taxRate = 0.25;
                    incomeDeduction = 73800;
                    baseTax = 10162.50;
                }

                if (income > 148850 && income <= 226850)
                {
                    taxRate = 0.28;
                    incomeDeduction = 148850;
                    baseTax = 28925.00;
                }

                if (income > 226850 && income <= 405100)
                {
                    taxRate = 0.33;
                    incomeDeduction = 226850;
                    baseTax = 50765.00;
                }

                if (income > 405100 && income <= 457600)
                {
                    taxRate = 0.35;
                    incomeDeduction = 405100;
                    baseTax = 109587.50;
                }

                if (income > 457600)
                {
                    taxRate = 0.396;
                    incomeDeduction = 457600;
                    baseTax = 127962.50;
                }

                taxableIncome = CalcualteTaxableIncome(income, incomeDeduction);
                tax = CalculateTax(baseTax, taxableIncome, taxRate);
            }

            return tax;
        }

        public double MarriedFilingSeparately(double income)
        {
            if (income > 0)
            {
                if (income <= 9075)
                {
                    taxRate = 0.1;
                    incomeDeduction = 0;
                    baseTax = 0;
                }

                if (income > 9075 && income <= 36900)
                {
                    taxRate = 0.15;
                    incomeDeduction = 9075;
                    baseTax = 907.50;
                }

                if (income > 36900 && income <= 74425)
                {
                    taxRate = 0.25;
                    incomeDeduction = 36900;
                    baseTax = 5081.25;
                }

                if (income > 74425 && income <= 113425)
                {
                    taxRate = 0.28;
                    incomeDeduction = 74425;
                    baseTax = 14462.50;
                }

                if (income > 113425 && income <= 202550)
                {
                    taxRate = 0.33;
                    incomeDeduction = 113425;
                    baseTax = 25382.50;
                }

                if (income > 202550 && income <= 228800)
                {
                    taxRate = 0.35;
                    incomeDeduction = 202550;
                    baseTax = 54793.75;
                }

                if (income > 228800)
                {
                    taxRate = 0.396;
                    incomeDeduction = 228800;
                    baseTax = 63981.25;
                }

                taxableIncome = CalcualteTaxableIncome(income, incomeDeduction);
                tax = CalculateTax(baseTax, taxableIncome, taxRate);
            }

            return tax;
        }

        public double HeadOfHousehold(double income)
        {
            if (income > 0)
            {
                if (income <= 12950)
                {
                    taxRate = 0.1;
                    incomeDeduction = 0;
                    baseTax = 0;
                }

                if (income > 12950 && income <= 49400)
                {
                    taxRate = 0.15;
                    incomeDeduction = 12950;
                    baseTax = 1295.00;
                }

                if (income > 49400 && income <= 127550)
                {
                    taxRate = 0.25;
                    incomeDeduction = 49400;
                    baseTax = 6762.50;
                }

                if (income > 127550 && income <= 206600)
                {
                    taxRate = 0.28;
                    incomeDeduction = 127550;
                    baseTax = 26300.00;
                }

                if (income > 206600 && income <= 405100)
                {
                    taxRate = 0.33;
                    incomeDeduction = 206600;
                    baseTax = 48434.00;
                }

                if (income > 405100 && income <= 432200)
                {
                    taxRate = 0.35;
                    incomeDeduction = 405100;
                    baseTax = 113939.00;
                }

                if (income > 432200)
                {
                    taxRate = 0.396;
                    incomeDeduction = 432200;
                    baseTax = 123424.00;
                }

                taxableIncome = CalcualteTaxableIncome(income, incomeDeduction);
                tax = CalculateTax(baseTax, taxableIncome, taxRate);
            }

            return tax;
        }

        private double CalcualteTaxableIncome(double income, double incomeDeduction)
        {
            return income - incomeDeduction;
        }

        private double CalculateTax (double baseTax, double taxableIncome, double taxRate)
        {
            return baseTax + taxableIncome * taxRate;
        }

    }
}
