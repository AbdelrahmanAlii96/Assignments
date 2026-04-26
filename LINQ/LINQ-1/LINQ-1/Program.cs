using LINQ.DataSources;
using System.ComponentModel.DataAnnotations;

namespace LINQ_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q-1
            //var Seafoodproducts = Source.ProductList
            //    .Where(p => p.Category == "Seafood");
            //foreach (var p in Seafoodproducts)
            //{
            //    Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            //}

            #endregion

            #region Q-2
            //var ProductsNames = Source.ProductList
            //    .Select(p => p.ProductName);
            //foreach (var name in ProductsNames)
            //{
            //    Console.WriteLine(name);
            //}

            #endregion

            #region Q-3
            //var SortedProducts = Source.ProductList
            //    .OrderBy(p => p.UnitPrice);
            //foreach (var Product in SortedProducts)
            //{
            //    Console.WriteLine($"{Product.ProductName} - {Product.UnitPrice}");
            //}

            #endregion

            #region Q-4
            //var MidProducts = Source.ProductList
            //    .Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);
            //foreach (var p in MidProducts)
            //{
            //    Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            //}

            #endregion

            #region Q-5
            //var CondimentsInStock = Source.ProductList
            //    .Where(p => p.Category == "Condiments" && p.UnitsInStock > 0);

            //foreach (var p in CondimentsInStock)
            //{
            //    Console.WriteLine($"{p.ProductName} - {p.UnitsInStock}");
            //}

            #endregion

            #region Q-6
            //var ProductInfo = Source.ProductList
            //    .Select(p => new
            //    {
            //        Name = p.ProductName,
            //        price = p.UnitPrice,
            //        StockStatus = p.UnitsInStock > 0 ? "Available" : "Out Of Stock"
            //    });
            //foreach ( var p in ProductInfo )
            //{
            //    Console.WriteLine($"{p.Name} - {p.price} - {p.StockStatus}");
            //}

            #endregion


            #region Q-7
            //var IndexedProducts = Source.ProductList
            //    .Select((p, index) => new
            //    {
            //        Index = index + 1,
            //        Name = p.ProductName
            //    });
            //foreach (var p in IndexedProducts)
            //{
            //    Console.WriteLine($"{p.Index}.{p.Name}");
            //}

            #endregion


            #region Q-8
            //var SortedProductss = Source.ProductList
            //    .OrderBy(p => p.Category)
            //    .ThenByDescending(p => p.UnitPrice);
            //foreach (var p in SortedProductss)
            //{
            //    Console.WriteLine($"{p.Category} - {p.ProductName} - {p.UnitPrice}");
            //}

            #endregion

            #region Q-9
            //var BeveragesProducts = Source.ProductList
            //    .Where(p => p.Category == "Beverages")
            //    .OrderByDescending(p => p.UnitsInStock);
            //foreach (var p in BeveragesProducts)
            //{
            //    Console.WriteLine($"{p.ProductName} - Stock: {p.UnitsInStock}");
            //}

            #endregion

            #region Q-10
            //var Orders =
            //    from c in Source.CustomerList
            //    from o in c.Orders
            //    where o.OrderDate.Year >= 1997
            //    select new
            //    {
            //        c.CustomerID,
            //        o.OrderDate
            //    };

            //foreach (var o in Orders)
            //{
            //    Console.WriteLine($"{o.CustomerID} - {o.OrderDate:d}");
            //}
            #endregion

            #region Q-11
            //var result = Source.ProductList
            //    .Select((p, index) => new
            //    {
            //        Position = index + 1,
            //        p.ProductName
            //    });

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Position}. {item.ProductName}");
            //}
            #endregion

            #region Q-12

            //string[] arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRrY" };

            //var sortedWords = arr
            //    .OrderBy(w => w.Length)
            //    .ThenBy(w => w, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in sortedWords)
            //{
            //    Console.WriteLine(word);
            //}

            #endregion

            #region Q-13
            //string[] digits =
            //{
            //    "zero","one","two","three","four",
            //    "five","six","seven","eight","nine"
            //};

            //var result = digits
            //    .Where(d => d.Length > 1 && d[1] == 'i')
            //    .Reverse();

            //foreach (var d in result)
            //{
            //    Console.WriteLine(d);
            //}

            #endregion

        }
    }
}
