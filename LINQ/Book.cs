namespace LINQ
{
    public class Book
    {
        public string Title { get; set; }
        public float Price { get; set; }

        public override string ToString()
        {
            return string.Format($"{Title} is for {Price}");
        }
    }
}