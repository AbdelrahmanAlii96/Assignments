using LINQ.DataSources;

namespace LINQ_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q-1
            //var Top3Expensive = Source.ProductList
            //    .OrderByDescending(p => p.UnitPrice)
            //    .Take(3);
            //foreach (var p in Top3Expensive)
            //{
            //    Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            //}

            #endregion

            #region Q-2
            //int PageSize = 5;
            //int PageNumber = 2;

            //var Page2 = Source.ProductList
            //    .Skip((PageNumber - 1) * PageSize)
            //    .Take(PageSize);
            //foreach (var p in Page2)
            //{
            //    Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            //}

            #endregion

            #region Q-3
            //var CheapProduts = Source.ProductList
            //    .OrderBy(p => p.UnitPrice)
            //    .TakeWhile(p => p.UnitPrice < 25);
            //foreach (var p in CheapProduts)
            //{
            //    Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            //}

            #endregion

            #region Q-4

            //bool allSeafoodInStock = Source.ProductList
            //    .Where(p => p.Category == "Seafood")
            //    .All(p => p.UnitsInStock > 0);
            //Console.WriteLine($"Are Seafood category in stock : {(allSeafoodInStock ? "yes" : "No")}");

            #endregion

            #region Q-5
            //int[] ids = { 3, 9, 13, 18 };
            //bool contains9 = ids.Contains(9);

            //Console.WriteLine($"Is this list contain 9 : {(contains9 ? "yes" : "No")}");

            #endregion

            #region Q-6
            //var groupedProducts = Source.ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        category = g.Key,
            //        count = g.Count()
            //    });

            //foreach (var group in groupedProducts)
            //{
            //    Console.WriteLine($"{group.category}: {group.count}");
            //}
            #endregion

            #region Q-7
            //var groupedNames = Source.ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        Products = g.Select(p => p.ProductName)
            //    });
            //foreach (var group in groupedNames)
            //{
            //    Console.WriteLine($"{group.Category}");
            //    foreach (var name in group.Products)
            //    {
            //        Console.WriteLine($" - {name}");
            //    }
            //}

            #endregion

            #region Q-8
            //var categoriesWithMoreThan3 = Source.ProductList
            //    .GroupBy(p => p.Category)
            //    .Where(g => g.Count() > 3)
            //    .Select(g => g.Key);

            #endregion

            #region Q-9
            //var customerGroups =
            //    from c in Source.CustomerList
            //    group c by c.Country into g
            //    select new
            //    {
            //        Country = g.Key,
            //        Count = g.Count(),
            //        TotalOrderValue = g.Sum(c => c.Orders.Sum(o => o.Total))
            //    };

            #endregion

            #region Q-10
            //int totalUnits = Source.ProductList
            //    .Sum(p => p.UnitsInStock);
            //Console.WriteLine($"Total Num of units in Stock {totalUnits}");

            #endregion

            #region Q-11
            //var minPrice = Source.ProductList.Min(p => p.UnitPrice);
            //var maxPrice = Source.ProductList.Max(p => p.UnitPrice);

            #endregion

            #region Q-12
            //var categories = Source.ProductList
            //    .Select(p => p.Category)
            //    .Distinct();

            #endregion

            #region Q-13
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };

            //var result = setA.Except(setB);
            //foreach (int i in result)
            //{
            //    Console.Write(i+ " ");
            //}
            #endregion

            #region Q-14
            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };

            //var result = list1
            //    .Except(list2, StringComparer.OrdinalIgnoreCase);

            //foreach(string i in result)
            //{
            //    Console.Write(i + " ");
            //}

            #endregion

            #region Q-15
            //var productDict = Source.ProductList
            //    .ToDictionary(p => p.ProductID);

            //var product18 = productDict[18];

            //Console.WriteLine(product18);

            #endregion

            #region Q-16
            //var first = Source.ProductList
            //    .First(p => p.UnitPrice > 50);

            //Console.WriteLine(first);
            #endregion

            #region Q-17
            //var productOver500 = Source.ProductList
            //    .FirstOrDefault(p => p.UnitPrice > 500);

            //if (productOver500 == null)
            //    Console.WriteLine("No product found");

            #endregion

            #region Q-18
            //var tableOf7 = Enumerable.Range(1, 10)
            //    .Select(n => new { n, Result = 7 * n });

            //foreach (var item in tableOf7)
            //{
            //    Console.WriteLine($"7 x {item.n} = {item.Result}");
            //}

            #endregion

            #region Q-19
            //var evens = Enumerable.Range(1, 30)
            //    .Where(n => n % 2 == 0);

            //foreach (var n in evens)
            //{
            //    Console.WriteLine(n);
            //}
            #endregion

            #region Q-20
            //var productNames = Source.ProductList
            //    .Take(3)
            //    .Select(p => p.ProductName);

            //var customerNames = Source.CustomerList
            //    .Take(3)
            //    .Select(c => c.CompanyName);

            //var combined = productNames.Concat(customerNames);

            //foreach (var name in combined)
            //{
            //    Console.WriteLine(name);
            //}

            #endregion

            #region Q-21
            //var paired = Source.ProductList
            //    .Zip(Source.CustomerList,
            //        (p, c) => $"{p.ProductName} sold to {c.CompanyName}");

            //foreach (var item in paired)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
        }
    }
}
