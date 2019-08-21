namespace Suggestions.Open_closed
{
    public class SilverCustomer : LoungeCustomer
    {
        public override int AllowedNumberOfSandwichesToEatInLounge => 2;

        public override double GetDiscount(double originalPrice)
        {
            return originalPrice * 0.25;
        }
    }
}