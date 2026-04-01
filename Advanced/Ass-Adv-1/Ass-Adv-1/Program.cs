namespace Ass_Adv_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q-1
            // Generic class uses type paramters that are replaced with actual types when we create instance
            // the type paramter T act like place holder
            // why : 1- type safty : compile time type checking
            //       2-performance : no boxing\unboxing for value types
            //       3-code reuse : one impelemntation for all types
            //       4- intellisense : better ide support

            #endregion

            #region Q-2
            //Container<int> container = new Container<int>();
            //container.Add(1);
            //container.Add(2);
            //container.Add(3);

            //Console.WriteLine(container.Get(2));

            #endregion

            #region Q-3
            // multiple type parameters : when gernarice (class - struct - method) works with more than one data type
            // instead of working with one placeholder you can use several to represent different kinds of data .

            //Pair<int, string> p1 = new Pair<int, string>(5,"Add");
            //Pair<int, string> p2 = new Pair<int, string>(10,"dele");
            //Pair<int, string> p3 = new Pair<int, string>(15, "sub");
            //Console.WriteLine(p1);
            //Console.WriteLine($"Key is {p2.Key} , Value is {p2.Value}");


            #endregion

            #region Q-4
            /*
            generic method declares its own type parameters and it can exist in both generic and non-generic classes 
            the compiler often infers the type argument.
            */

            //check class Utilities for swap function
            //======================================
            //int x = 5;
            //int y = 10;
            //Console.WriteLine($"X : {x} , Y : {y}");
            //Utilities.swap(ref x, ref y);
            //Console.WriteLine($"X : {x} , Y : {y}");

            //========================================

            //string st1 = "Cairo";
            //string st2 = "Alex";
            //Console.WriteLine($"st1 : {st1} , st2 : {st2}");
            //Utilities.swap(ref st1, ref st2);
            //Console.WriteLine($"st1 : {st1} , st2 : {st2}");


            #endregion

            #region Q-5
            // Check class utilities for the function FindMax()
            //==========================
            //int x = 5;
            //int y = 10;
            //Console.WriteLine(Utilities.FindMax(x, y));

            #endregion

            #region Q-6
            //Generic interfaces define contracts with type parameters Classes implementing them specify the actual types.

            #endregion

            #region Q-7
            //the struct constraint is used in generics to restrict a type parameter so that it can only be a value type .

            //Check ValueContainter class
            //if we use string it will give error should be numbers onlye
            //ValueContainer<int> Vcontainter1 = new ValueContainer<int>(20);
            //ValueContainer<int> Vcontainter2 = new ValueContainer<int>("S"); // Error
            //Vcontainter1.Display();

            #endregion

            #region Q-8
            //Class Constrians restricts T to reference types only.
            //This allows T to be null and enables reference comparison.

            //Check ReferenceContainer Class
            //ReferenceContainer<string> strContainer1 =new ReferenceContainer<string>("Hello");
            //ReferenceContainer<string> strContainer2 =new ReferenceContainer<string>(5); // Error because 5 is value not reference
            //strContainer1.Display();
            #endregion

            #region Q-9
            // new () constrain requires T to have a public parameterless constructor .
            //Factory<Product> productFactory = new Factory<Product>();
            //Product p = productFactory.CreateInstance();
            //Console.WriteLine(p.Name);

            #endregion

            #region Q-10
            //Interface Constrain requires T to implement a specific interface.
            //This enables calling interface methods on type parameter

            #endregion

            #region Q-11
            //restrict a type parameter so that it must inherit from a specific base class. 
            //This ensures that the generic type has all members of that base class

            #endregion


            #region Q-12
            //you can apply multiple constraints to a generic type parameter using the where keyword.
            //You can combine: 1 - Base class constraint
            //                  2-Interface constraints
            //                  3-Constructor constraint
            #endregion





        }
    }
}
