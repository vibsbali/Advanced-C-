using System;

namespace NullableTypes
{
    class Program
    {
        static void Main()
        {
            DateTime? date = null;

            //using null collase operator
            DateTime date2 = date ?? DateTime.Today;
            //using tertiary operator
            DateTime date3 = date != null ? date.GetValueOrDefault() : DateTime.Today;

        }
    }
}
