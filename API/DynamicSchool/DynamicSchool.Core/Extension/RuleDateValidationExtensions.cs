using System;

namespace DynamicSchool.Core.Extension
{
    public static class RuleDateValidationExtensions
    {
        public static bool HasAge(this DateTime date, int age)
        {
            return (date.Subtract(DateTime.Today).TotalDays / 365.2425) >= age;
        }
    }
}
