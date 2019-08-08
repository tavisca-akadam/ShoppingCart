using System;
using System.Runtime.Serialization;

namespace ShoppingCart
{
    [Serializable]
    public class InvalidDiscountType : Exception
    {
        public InvalidDiscountType()
        {
        }

        public InvalidDiscountType(string message) : base(message)
        {
        }

        public InvalidDiscountType(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidDiscountType(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}