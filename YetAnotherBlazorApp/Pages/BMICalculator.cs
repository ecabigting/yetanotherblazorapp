namespace YetAnotherBlazorApp.Pages
{
    public partial class BMICalculator 
    {
        public decimal WeightValue {get;set;} 
        public decimal HeightValue {get;set;}
        public decimal YourBMI {get;set;}

        public void CalculateBMI()
        {
            decimal BMICalculated = WeightValue / (HeightValue * HeightValue) * 703;
            YourBMI = decimal.Round(BMICalculated, 2, MidpointRounding.AwayFromZero);
        }
    }
}
