namespace Suggestions.Liskov_substitution
{
    public class Enquiry : ICanGetPrice
    {
        public double GetPrice()
        {
            return 100;
        }
    }
}