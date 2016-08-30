namespace Advanced
{
    public class Nullable<T> where T : struct
    {
        public Nullable()
        {
            //default constructor for creating an empty object
        }

        private readonly object value;
        public Nullable(T value)
        {
            //boxing
            this.value = value;
        }

        public bool HasValue => value != null;

        public T GetValueOrDefault()
        {
            if (HasValue)
            {
                //Unboxing
                return (T)value;
            }

            return default(T);
        }
    }
}