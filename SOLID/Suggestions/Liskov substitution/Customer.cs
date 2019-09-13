namespace Suggestions.Liskov_substitution
{
    public class Customer : ICanGetPrice, IHasBonusPoints
    {
        private int _bonusPoints;

        public Customer()
        {
            _bonusPoints = 0;
        }

        public double GetPrice()
        {
            return 100;
        }

        public void AddBonusPoints(int points)
        {
            _bonusPoints += points;
        }

        public int GetBonusPoints()
        {
            return _bonusPoints;
        }
    }
}