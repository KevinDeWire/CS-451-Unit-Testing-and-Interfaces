﻿namespace TaxesClass
{
    public class Taxes
    {
        public double Single(double income)
        {
            double tax = 0;
            double taxableIncome;
            double incomeDeduction;
            double taxRate;
            double baseTax;

            if (income > 0)
            {
                if (income <= 9075)
                {
                    taxRate = 0.1;
                    incomeDeduction = 0;
                    taxableIncome = income - incomeDeduction;
                    baseTax = 0;
                    tax = baseTax + taxableIncome * taxRate;
                    return tax;
                }

                if (income <= 36900)
                {
                    taxRate = 0.15;
                    incomeDeduction = 9075;
                    taxableIncome = income - incomeDeduction;
                    baseTax = 907.5;
                    tax = baseTax + taxableIncome * taxRate;
                    return tax;
                }

                if (income <= 89350)
                {
                    taxRate = 0.25;
                    incomeDeduction = 36900;
                    taxableIncome = income - incomeDeduction;
                    baseTax = 5081.25;
                    tax = baseTax + taxableIncome * taxRate;
                    return tax;
                }

                if (income <= 186350)
                {
                    taxRate = 0.28;
                    incomeDeduction = 89350;
                    taxableIncome = income - incomeDeduction;
                    baseTax = 18193.75;
                    tax = baseTax + taxableIncome * taxRate;
                    return tax;
                }

                if (income <= 405100)
                {
                    taxRate = 0.33;
                    incomeDeduction = 186350;
                    taxableIncome = income - incomeDeduction;
                    baseTax = 45353.75;
                    tax = baseTax + taxableIncome * taxRate;
                    return tax;
                }

                if (income <= 406750)
                {
                    taxRate = 0.35;
                    incomeDeduction = 405100;
                    taxableIncome = income - incomeDeduction;
                    baseTax = 117541.25;
                    tax = baseTax + taxableIncome * taxRate;
                    return tax;
                }

                if (income > 406750)
                {
                    taxRate = 0.396;
                    incomeDeduction = 406750;
                    taxableIncome = income - incomeDeduction;
                    baseTax = 118118.75;
                    tax = baseTax + taxableIncome * taxRate;
                    return tax;
                }
            }

            return tax;
        }

        public double Jointly(double income)
        {
            double tax = 0;
            double taxableIncome;
            double incomeDeduction;
            double taxRate;
            double baseTax;

            if (income > 0)
            {
                if (income <= 18150)
                {
                    taxRate = 0.1;
                    incomeDeduction = 0;
                    taxableIncome = income - incomeDeduction;
                    baseTax = 0;
                    tax = baseTax + taxableIncome * taxRate;
                    return tax;
                }

                if (income <= 73800)
                {
                    taxRate = 0.15;
                    incomeDeduction = 18150;
                    taxableIncome = income - incomeDeduction;
                    baseTax = 1815.00;
                    tax = baseTax + taxableIncome * taxRate;
                    return tax;
                }

                if (income <= 148850)
                {
                    taxRate = 0.25;
                    incomeDeduction = 73800;
                    taxableIncome = income - incomeDeduction;
                    baseTax = 10162.50;
                    tax = baseTax + taxableIncome * taxRate;
                    return tax;
                }

                if (income <= 226850)
                {
                    taxRate = 0.28;
                    incomeDeduction = 148850;
                    taxableIncome = income - incomeDeduction;
                    baseTax = 28925.00;
                    tax = baseTax + taxableIncome * taxRate;
                    return tax;
                }

                if (income <= 405100)
                {
                    taxRate = 0.33;
                    incomeDeduction = 226850;
                    taxableIncome = income - incomeDeduction;
                    baseTax = 50765.00;
                    tax = baseTax + taxableIncome * taxRate;
                    return tax;
                }

                if (income <= 457600)
                {
                    taxRate = 0.35;
                    incomeDeduction = 405100;
                    taxableIncome = income - incomeDeduction;
                    baseTax = 109587.50;
                    tax = baseTax + taxableIncome * taxRate;
                    return tax;
                }

                if (income > 457600)
                {
                    taxRate = 0.396;
                    incomeDeduction = 457600;
                    taxableIncome = income - incomeDeduction;
                    baseTax = 127962.50;
                    tax = baseTax + taxableIncome * taxRate;
                    return tax;
                }
            }

            return tax;
        }

        public double Separately(double income)
        {
            double tax = 0;
            double taxableIncome;
            double incomeDeduction;
            double taxRate;
            double baseTax;

            if (income > 0)
            {
                if (income <= 9075)
                {
                    taxRate = 0.1;
                    incomeDeduction = 0;
                    taxableIncome = income - incomeDeduction;
                    baseTax = 0;
                    tax = baseTax + taxableIncome * taxRate;
                    return tax;
                }

                if (income <= 36900)
                {
                    taxRate = 0.15;
                    incomeDeduction = 9075;
                    taxableIncome = income - incomeDeduction;
                    baseTax = 907.50;
                    tax = baseTax + taxableIncome * taxRate;
                    return tax;
                }

                if (income <= 74425)
                {
                    taxRate = 0.25;
                    incomeDeduction = 36900;
                    taxableIncome = income - incomeDeduction;
                    baseTax = 5081.25;
                    tax = baseTax + taxableIncome * taxRate;
                    return tax;
                }

                if (income <= 113425)
                {
                    taxRate = 0.28;
                    incomeDeduction = 74425;
                    taxableIncome = income - incomeDeduction;
                    baseTax = 14462.50;
                    tax = baseTax + taxableIncome * taxRate;
                    return tax;
                }

                if (income <= 202550)
                {
                    taxRate = 0.33;
                    incomeDeduction = 113425;
                    taxableIncome = income - incomeDeduction;
                    baseTax = 25382.50;
                    tax = baseTax + taxableIncome * taxRate;
                    return tax;
                }

                if (income <= 228800)
                {
                    taxRate = 0.35;
                    incomeDeduction = 202550;
                    taxableIncome = income - incomeDeduction;
                    baseTax = 54793.75;
                    tax = baseTax + taxableIncome * taxRate;
                    return tax;
                }

                if (income > 228800)
                {
                    taxRate = 0.396;
                    incomeDeduction = 228800;
                    taxableIncome = income - incomeDeduction;
                    baseTax = 63981.25;
                    tax = baseTax + taxableIncome * taxRate;
                    return tax;
                }
            }

            return tax;
        }

        public double Head(double income)
        {
            double tax = 0;
            double taxableIncome;
            double incomeDeduction;
            double taxRate;
            double baseTax;

            if (income > 0)
            {
                if (income <= 12950)
                {
                    taxRate = 0.1;
                    incomeDeduction = 0;
                    taxableIncome = income - incomeDeduction;
                    baseTax = 0;
                    tax = baseTax + taxableIncome * taxRate;
                    return tax;
                }

                if (income <= 49400)
                {
                    taxRate = 0.15;
                    incomeDeduction = 12950;
                    taxableIncome = income - incomeDeduction;
                    baseTax = 1295.00;
                    tax = baseTax + taxableIncome * taxRate;
                    return tax;
                }

                if (income <= 127550)
                {
                    taxRate = 0.25;
                    incomeDeduction = 49400;
                    taxableIncome = income - incomeDeduction;
                    baseTax = 6762.50;
                    tax = baseTax + taxableIncome * taxRate;
                    return tax;
                }

                if (income <= 206600)
                {
                    taxRate = 0.28;
                    incomeDeduction = 127550;
                    taxableIncome = income - incomeDeduction;
                    baseTax = 26300.00;
                    tax = baseTax + taxableIncome * taxRate;
                    return tax;
                }

                if (income <= 405100)
                {
                    taxRate = 0.33;
                    incomeDeduction = 206600;
                    taxableIncome = income - incomeDeduction;
                    baseTax = 48434.00;
                    tax = baseTax + taxableIncome * taxRate;
                    return tax;
                }

                if (income <= 432200)
                {
                    taxRate = 0.35;
                    incomeDeduction = 405100;
                    taxableIncome = income - incomeDeduction;
                    baseTax = 113939.00;
                    tax = baseTax + taxableIncome * taxRate;
                    return tax;
                }

                if (income > 432200)
                {
                    taxRate = 0.396;
                    incomeDeduction = 432200;
                    taxableIncome = income - incomeDeduction;
                    baseTax = 123424.00;
                    tax = baseTax + taxableIncome * taxRate;
                    return tax;
                }
            }

            return tax;
        }
    }
}
