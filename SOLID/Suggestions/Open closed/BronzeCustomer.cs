namespace Suggestions.Open_closed
{
    public class BronzeCustomer : Customer
    {
        public override double GetDiscount(double originalPrice)
        {
            return originalPrice * 0.1;
        }
    }
}