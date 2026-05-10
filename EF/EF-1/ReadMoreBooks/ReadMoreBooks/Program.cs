namespace ReadMoreBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using BookStoreContext AppDbContext = new();
            Console.WriteLine("Database Created");
            //i used PCM
            //1-Add-Migration "IntialCreate"
            //2-Uodate-Datbase

        }
    }
}
