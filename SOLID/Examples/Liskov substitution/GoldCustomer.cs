namespace Examples.Liskov_substitution
{
    public class GoldCustomer : Customer
    {
        public override double GetPrice()
        {
            return 100;
        }

        public override void AddBonusPoints(int points)
        {
            BonusPoints += points;
        }
    }
}