using System;

namespace Advanced
{
    public class DiscountCalculator<T> where T : Product
    {
        public decimal CalculateDiscount(T product)
        {
            return product.Price * Convert.ToDecimal(0.909);
        }
    }
}