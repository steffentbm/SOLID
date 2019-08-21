namespace Examples.Liskov_substitution
{
    public abstract class Customer
    {
        internal int BonusPoints = 0;

        public abstract double GetPrice();
        public abstract void AddBonusPoints(int points);
    }
}