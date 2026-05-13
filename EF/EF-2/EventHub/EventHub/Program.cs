namespace EventHub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using AppDbContext EventHubDBcontext = new();
            Console.WriteLine("EventHubDb Created ");
            //i used PCM
            //1-Add-Migration "IntialCreate"
            //2-Uodate-Datbase
        }
    }
}
