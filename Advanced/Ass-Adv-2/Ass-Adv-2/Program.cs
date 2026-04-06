namespace Ass_Adv_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List of Products
            List<Product> catalog = new()
            {
                new Product {Id=1, Name="Laptop", Category="Electronics", Price=1200, Stock=10},
                new Product {Id=2,Name="Phone", Category="Electronics", Price=800, Stock=25},
                new Product {Id=3, Name="T-Shirt", Category="Clothing", Price=30, Stock=100 },
                new Product { Id=4, Name="Jeans", Category="Clothing", Price=60, Stock=50 },
                new Product {Id=5, Name="Chocolate", Category="Food", Price=5, Stock=200 },
                new Product {Id=6, Name="Coffee Beans", Category="Food", Price=15, Stock=80},
                new Product {Id=7, Name="C# Book", Category="Books", Price=45, Stock=30},
                new Product {Id=8, Name="Novel", Category="Books", Price=20, Stock=60},
                new Product {Id=9,Name="Headphones", Category="Electronics", Price=150, Stock=40},
                new Product {Id=10, Name="Jacket", Category="Clothing", Price=120, Stock=15}
            };


            #region Task-01

            // All Electronics products  
            List<Product> Electronics = Product.SearchProducts(catalog, C => C.Category == "Electronics");

            //Products cheaper than $50
            List<Product> cheapProducts = Product.SearchProducts(catalog, C => C.Price < 50);

            //Products that are in stock (Stock > 0) 
            List<Product> inStock = Product.SearchProducts(catalog, C => C.Stock > 0);

            //Clothing products under $100 
            List<Product> clothing = Product.SearchProducts(catalog, C => C.Category == "Clothing" && C.Price < 100);



            //Console.WriteLine("--- Electronics ---");
            //Product.PrintReport(Electronics, P => Console.WriteLine($"{P.Name} - ${P.Price} (Stock:{P.Stock})"));

            //Console.WriteLine("\n--- Under $50 ---");
            //Product.PrintReport(cheapProducts, P => Console.WriteLine($"{P.Name} - ${P.Price} (Stock:{P.Stock})"));

            //Console.WriteLine("\n--- In Stock ---");
            //Product.PrintReport(inStock, P => Console.WriteLine($"{P.Name} - ${P.Price} (Stock:{P.Stock})"));

            //Console.WriteLine("\n--- Clothing under $100 ---");
            //Product.PrintReport(clothing, P => Console.WriteLine($"{P.Name} - ${P.Price} (Stock:{P.Stock})"));


            #endregion

            #region Task-03-1

            Action<Product> ShortReport = p => Console.WriteLine($"{p.Name} - ${p.Price}");
            Action<Product> DetailedReport = p => Console.WriteLine($"[{p.Category}] {p.Name} | Price: ${p.Price} | Stock: {p.Stock}");

            //Product.PrintReport(catalog, ShortReport);
            //Product.PrintReport(catalog, DetailedReport);
            //Product.PrintReport(Electronics, ShortReport);
            //Product.PrintReport(Electronics, DetailedReport);

            #endregion

            #region Task-03-2
            ////Summary List
            //var Summary = Product.TransformProducts(catalog, C => $"{C.Name} (${C.Price})");

            //Console.WriteLine("\n--- Summary List ---");
            //foreach (var s in Summary)
            //{
            //    Console.WriteLine(s);
            //}

            ////Price Lable
            //var Lables = Product.TransformProducts(catalog, C => C.Price > 100 ? "Expensive!" : "Affordable");

            //Console.WriteLine("\n--- Price Lables ---");
            //for (int i = 0; i < catalog.Count; i++)
            //{
            //    Console.WriteLine($"{catalog[i].Name}: {Lables[i]}");
            //}

            #endregion

            #region Task-03-3
            //List<Product> LowStock = Product.FilterProducts(catalog, C => C.Stock < 20);
            ////we can make action delegate and use PrintReport method we made before
            //Action<Product> lowstockprint = p => Console.WriteLine($"[LOW STOCK] {p.Name}: only {p.Stock} left!");

            //Console.WriteLine("\n--- Low Stock Alert ---");
            //Product.PrintReport(LowStock, lowstockprint);

            #endregion









        }
    }
}
