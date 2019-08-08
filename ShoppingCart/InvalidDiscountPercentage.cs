using System;
using System.Runtime.Serialization;

namespace ShoppingCart
{
    [Serializable]
    internal class InvalidDiscountPercentage : Exception
    {
        public InvalidDiscountPercentage()
        {
        }

        public InvalidDiscountPercentage(string message) : base(message)
        {
        }

        public InvalidDiscountPercentage(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidDiscountPercentage(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}