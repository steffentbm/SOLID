namespace Examples.Liskov_substitution
{
    public abstract class Customer
    {
        internal int BonusPoints;

        protected Customer()
        {
            BonusPoints = 0;
        }

        public abstract double GetPrice();
        public abstract void AddBonusPoints(int points);

        public virtual int GetBonusPoints()
        {
            return BonusPoints;
        }
    }
}