namespace Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();

            var list = new GenericList<Book>();
            list.Add(book);

          
        }
    }
}
