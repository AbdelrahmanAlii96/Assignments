using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass_Adv_2
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; } // "Electronics", "Clothing", "Food", "Books"
        public double Price { get; set; }
        public int Stock { get; set; }


        #region Task-01
        public static List<Product> SearchProducts(List<Product> products, Func<Product, bool> filter)
        {
            List<Product> result = new List<Product>();
            foreach (Product product in products)
            {
                if (filter(product))
                {
                    result.Add(product);
                }
            }
            return result;
        }
        #endregion

        #region Task-03-1
        public static void PrintReport(List<Product> products, Action<Product> printer)
        {
            foreach (Product p in products)
            {
                printer(p);
            }
        }

        #endregion

        #region Task-03-2
        public static List<T> TransformProducts<T>(List<Product> products, Func<Product, T> transform)
        {
            List<T> result = new List<T>();
            foreach (Product p in products)
            {
                result.Add(transform(p));
            }
            return result;
        }

        #endregion

        #region Task-03-3
        public static List<Product> FilterProducts(List<Product> products , Predicate<Product> Condition)
        {
            List<Product> result = new List<Product>();
            foreach (Product p in products)
            {
                if (Condition(p))
                {
                    result.Add(p);
                }
            }
            return result;

        }

        #endregion
    }
}
