using System;

namespace Examples.Open_closed
{
    public enum CustomerType
    {
        Bronze,
        Silver,
        Gold
    }

    public class Customer
    {
        private readonly CustomerType _customerType;

        public Customer(CustomerType type)
        {
            _customerType = type;
        }

        public bool HasAccessToLounge => _customerType == CustomerType.Gold || _customerType == CustomerType.Silver;

        public int AllowedNumberOfSandwichesToEatInLounge
        {
            get
            {
                switch (_customerType)
                {
                    case CustomerType.Gold:
                        return 5;
                    case CustomerType.Silver:
                        return 2;
                    default:
                        throw new UnauthorizedAccessException("No peasants in the lounge!");
                }
            }
        }

        public double GetDiscount(double originalPrice)
        {
            switch (_customerType)
            {
                case CustomerType.Gold:
                    return originalPrice * 0.50;
                case CustomerType.Silver:
                    return originalPrice * 0.25;
                case CustomerType.Bronze:
                    return originalPrice * 0.10;
                default:
                    return 0;
            }
        }
    }
}