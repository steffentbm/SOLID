namespace Examples.Liskov_substitution
{
    public abstract class Customer
    {
        protected Customer()
        {
            BonusPoints = 0;
        }

        internal int BonusPoints;

        public abstract double GetPrice();
        public abstract void AddBonusPoints(int points);

        public virtual int GetBonusPoints()
        {
            return BonusPoints;
        }
    }
}