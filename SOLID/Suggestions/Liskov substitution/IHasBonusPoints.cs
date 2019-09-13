namespace Suggestions.Liskov_substitution
{
    public interface IHasBonusPoints
    {
        void AddBonusPoints(int points);
        int GetBonusPoints();
    }
}