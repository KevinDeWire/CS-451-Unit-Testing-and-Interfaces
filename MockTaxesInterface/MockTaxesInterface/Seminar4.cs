namespace MockTaxesInterface
{
    public interface ITaxes
    {
        double Single(double Income);
        double MarriedFilingJointly(double Income);
        double MarriedFilingSeperately(double Income);
        double HeadOfHousehold(double Income);
    }

    public class TaxDetermination
    {
       private readonly ITaxes _taxes;

       public TaxDetermination(ITaxes taxes)
        {
            _taxes = taxes;
        }

       public double ScheduleSort(string Schedule, double Income)
        {
            switch (Schedule.ToUpper())
            {
                case "X":
                    return _taxes.Single(Income);
                case "Y1":
                    return _taxes.MarriedFilingJointly(Income);
                case "Y2":
                    return _taxes.MarriedFilingSeperately(Income);
                case "Z":
                    return _taxes.HeadOfHousehold(Income);
                default:
                    return -1;
            }
        }
    }
}
