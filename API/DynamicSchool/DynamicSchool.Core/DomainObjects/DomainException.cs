using System;

namespace DynamicSchool.Core.DomainObjects
{
    public class DomainException : Exception
    {
        public DomainException()
        {
        }

        public DomainException(string message): base(message)
        {
        }

        protected DomainException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
