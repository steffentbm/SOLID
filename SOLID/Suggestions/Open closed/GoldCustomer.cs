namespace Suggestions.Open_closed
{
    public class GoldCustomer : LoungeCustomer
    {
        public override int AllowedNumberOfSandwichesToEatInLounge => 5;

        public override double GetDiscount(double originalPrice)
        {
            return originalPrice * 0.5;
        }
    }
}