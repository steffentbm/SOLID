using System;

namespace Examples.Liskov_substitution
{
    public class PriceEnquiry : Customer
    {
        public override double GetPrice()
        {
            return 100;
        }

        public override void AddBonusPoints(int points)
        {
            throw new NotImplementedException();
        }
    }
}