namespace FutureValue.Models
{
    public class FutureValueModel
    {
        
        public decimal MontlyInvestment { get; set; }

        public decimal YearlyInterestRate { get; set; }

        public int Years { get; set; }

        public decimal CalculateFutureValue()
        {
            int months = Years * 12;
            decimal montlyInterestRate = YearlyInterestRate / 12 / 100;
            decimal futureValue = 0;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + MontlyInvestment) * (1 + montlyInterestRate);
            }
            return futureValue;
        }
    }
}
