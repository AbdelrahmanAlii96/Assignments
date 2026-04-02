using Ass_Adv_1.BaseClass;
using Ass_Adv_1.DefaultConstrain;
using Ass_Adv_1.GenericConstrains;

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

            //Check GenericInterface folder
            //Printer<Document> Doc = new Printer<Document>();
            //Printer<Photo> Ph = new Printer<Photo>();
            //Doc.Printitem(new Document());
            //Ph.Printitem(new Photo());

            #endregion

            #region Q-11
            //restrict a type parameter so that it must inherit from a specific base class. 
            //This ensures that the generic type has all members of that base class

            //Check GenericConstrains folder
            //AnimalHandler<Dog> animalHandler = new AnimalHandler<Dog>();
            //animalHandler.Feed(new Dog());

            #endregion


            #region Q-12
            //you can apply multiple constraints to a generic type parameter using the where keyword.
            //You can combine: 1 - Base class constraint
            //                  2-Interface constraints
            //                  3-Constructor constraint new ()
            // base class should come first then interface then new ()


            // Check GenericConstrains folder
            //Trainer<Dog> DogTrainer = new Trainer<Dog>();
            //DogTrainer.Work();

            //Trainer<Cat> CatTrainer = new Trainer<Cat>();
            //CatTrainer.Work();


            #endregion

            #region Q-13
            //Default used to produce the default value of a type parameter , when you don't know actual type at compile time
            //ValueOrDefault<int> xint = new ValueOrDefault<int>();
            //ValueOrDefault<string> xstring = new ValueOrDefault<string>();

            //Console.WriteLine($"int  default is  {xint.GetValueOrDefualt()}");
            //Console.WriteLine($"string  default is {xstring.GetValueOrDefualt()}");

            #endregion

            #region Q-14
            //SafeList<int> intlist = new SafeList<int>();
            //intlist.add(1);
            //intlist.add(2);
            //intlist.add(3);

            //Console.WriteLine(intlist.GetItem(5));

            #endregion

            #region Q-15
            //Covariance allows you to use a more derived type than originally specified
            //out T can only appear in output positions.

            #endregion

            #region Q-16
            // Contravariance allows you to use a less derived type than originally specified 
            // in T can only appear in input positions.

            #endregion

            #region Q-17
            // 1- Covariance (out keyword) : use a more derived type than originally specified .
            //                             : Output only (return)


            // 2 - Contravariance (in keyword) : use a less derived type than originally specified.
            //                                 : Input only (parameter)
            #endregion

            #region Q-18
            // Each closed generic type has its own copy of static fields. 
            // List<int> and List<string> have separate static data .

            #endregion

            #region Q-19
            // you can inherit from a generic class in a few different ways depending on whether 
            // you want to keep the type parameter generic or fix it to a specific type.


            #endregion


        }
    }
}
