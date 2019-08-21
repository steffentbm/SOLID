namespace Suggestions.Liskov_substitution
{
    public class Customer : ICanGetPrice, IHasBonusPoints
    {
        private int _bonusPoints = 0;

        public double GetPrice()
        {
            return 100;
        }

        public void AddBonusPoints(int points)
        {
            _bonusPoints += points;
        }
    }
}