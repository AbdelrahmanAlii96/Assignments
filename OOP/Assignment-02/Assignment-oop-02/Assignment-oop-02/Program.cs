namespace Assignment_oop_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BankAccount accno1 = new BankAccount();
            accno1.Banalce = -50;
            //Console.WriteLine(accno1.Banalce);
            #region Part01 - Q1
            //A - 1 :- public fields and they accessable anywhere and this breaks encapsulation 
            //    2 :- No validation for withraw method


            //B -   1:- make fields private. 
            //      2- use properties to controll fields . 
            //      3- add validation withdraw method.
            // u can check class BankAccount for to show u

            //C - public fields  1-breaks encapsulation means object can't control it's own date 
            //                   2-no validation like you can't prevent negative balance or null owners
            //                   3- anyone can change data directly

            #endregion


            #region Part1 - Q2
            // field  : is a valiable declared inside a class , it stores date 
            // property : provides controll access to private fields throw get and set  and can contain logic
            // check BankAccount class to see Isoverdrawn property
            //Console.WriteLine(accno1.Isoverdrawn);
            #endregion


            #region Part1 - Q3
            //A)- this[int index] it's indexer it's allow all object of this classed accessed like an array
            //B)- we have fixed size new string[5] so it will throw IndexOutOfRangeException at runtime
            //C)- yes we have multipe indexer with differrent paramter types and usefull when we want ways to retrive date from same class

            #endregion

            #region Part1 - Q4
            /*
            A)- static means field belong to class itself and not to individual object and 
            it's shared across all order objects 
            like everytime new order is created constructor increase shared field or static field 
            so it's shared to all objects


            B)-No it can't access item directly 
            because static method belong to class itself not to any specific object
            and item it's object field so require object to be created to access it 


            */

            #endregion


            #region Part02


            #endregion
        }
    }
}
