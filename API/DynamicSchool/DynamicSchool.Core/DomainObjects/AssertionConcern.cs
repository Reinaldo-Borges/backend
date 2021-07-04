using System.Text.RegularExpressions;

namespace DynamicSchool.Core.DomainObjects
{
    public static class AssertionConcern
    {
        public static void EqualTo(object object1, object object2, string message)
        {
            if (!object1.Equals(object2))
            {
                throw new DomainException(message);
            }
        }
        public static void NotEqualTo(object object1, object object2, string message)
        {
            if (object1.Equals(object2))
            {
                throw new DomainException(message);
            }
        }
        public static void Match(string pattern, string value, string message)
        {
            var regex = new Regex(pattern);

            if (!regex.IsMatch(value))
            {
                throw new DomainException(message);
            }
        }
        public static void HasSize(string value, int maximo, string message)
        {
            var length = value.Trim().Length;
            if (length > maximo)
            {
                throw new DomainException(message);
            }
        }        
        public static void HasValue(string value, string message)
        {
            if (value == null || value.Trim().Length == 0)
            {
                throw new DomainException(message);
            }
        }
        public static void IsNotNull(object object1, string message)
        {
            if (object1 == null)
            {
                throw new DomainException(message);
            }
        }
        public static void Range(double value, double minimum, double maximum, string message)
        {
            if (value < minimum || value > maximum)
            {
                throw new DomainException(message);
            }
        }
        public static void Range(float value, float minimum, float maximum, string message)
        {
            if (value < minimum || value > maximum)
            {
                throw new DomainException(message);
            }
        }
        public static void Range(int value, int minimum, int maximum, string message)
        {
            if (value < minimum || value > maximum)
            {
                throw new DomainException(message);
            }
        }
        public static void Range(long value, long minimum, long maximum, string message)
        {
            if (value < minimum || value > maximum)
            {
                throw new DomainException(message);
            }
        }
        public static void Range(decimal value, decimal minimum, decimal maximum, string message)
        {
            if (value < minimum || value > maximum)
            {
                throw new DomainException(message);
            }
        }
        public static void LessThan(long value, long minimum, string message)
        {
            if (value < minimum)
            {
                throw new DomainException(message);
            }
        }
        public static void LessThan(double value, double minimum, string message)
        {
            if (value < minimum)
            {
                throw new DomainException(message);
            }
        }
        public static void LessThan(decimal value, decimal minimum, string message)
        {
            if (value < minimum)
            {
                throw new DomainException(message);
            }
        }
        public static void LessThan(int value, int minimum, string message)
        {
            if (value < minimum)
            {
                throw new DomainException(message);
            }
        }
        public static void LessThanOrEqual(long value, long minimum, string message)
        {
            if (value <= minimum)
            {
                throw new DomainException(message);
            }
        }
        public static void LessThanOrEqual(double value, double minimum, string message)
        {
            if (value <= minimum)
            {
                throw new DomainException(message);
            }
        }
        public static void LessThanOrEqual(decimal value, decimal minimum, string message)
        {
            if (value <= minimum)
            {
                throw new DomainException(message);
            }
        }
        public static void LessThanOrEqual(int value, int minimum, string message)
        {
            if (value <= minimum)
            {
                throw new DomainException(message);
            }
        }
        public static void MoreThan(long value, long minimum, string message)
        {
            if (value > minimum)
            {
                throw new DomainException(message);
            }
        }
        public static void MoreThan(double value, double minimum, string message)
        {
            if (value > minimum)
            {
                throw new DomainException(message);
            }
        }
        public static void MoreThan(decimal value, decimal minimum, string message)
        {
            if (value > minimum)
            {
                throw new DomainException(message);
            }
        }
        public static void MoreThan(int value, int minimum, string message)
        {
            if (value > minimum)
            {
                throw new DomainException(message);
            }
        }
        public static void MoreThanOrEqual(long value, long minimum, string message)
        {
            if (value >= minimum)
            {
                throw new DomainException(message);
            }
        }
        public static void MoreThanOrEqual(double value, double minimum, string message)
        {
            if (value >= minimum)
            {
                throw new DomainException(message);
            }
        }
        public static void MoreThanOrEqual(decimal value, decimal minimum, string message)
        {
            if (value >= minimum)
            {
                throw new DomainException(message);
            }
        }
        public static void MoreThanOrEqual(int value, int minimum, string message)
        {
            if (value >= minimum)
            {
                throw new DomainException(message);
            }
        }
        public static void IsFalse(bool boolvalue, string message)
        {
            if (!boolvalue)
            {
                throw new DomainException(message);
            }
        }
        public static void IsTrue(bool boolvalue, string message)
        {
            if (boolvalue)
            {
                throw new DomainException(message);
            }
        }
    }
}
