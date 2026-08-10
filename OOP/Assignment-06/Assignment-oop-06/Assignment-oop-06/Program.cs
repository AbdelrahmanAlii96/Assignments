namespace Assignment_oop_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01-Q1
            /*
            1- Abstraction is process of exposing only what the user needs and hiding how it is implememnted .
            2-Encalpsulation is warpping data fields and method together into class and restricting direct access them

            1-Abstraction : hide complexity impelemntation
            2-Encapsulation : hide date(fields)

            1-Abstraction : tools like iinterface and abstract class
            2-Encapsulation : tools like access modifiers and proprties

            =========
            1-Abstraction : When you use an ATM, you only see options like withdraw, deposit .
            2-Encapsulation :Your bank account balance is private. You cannot directly change it .

            */

            #endregion

            #region Part01-02
            /*
            1-Abstract class: Can have both abstract and concrete(implemented) methods .
            2-Interface: Mostly method declarations only


            1-Abstract class: Can have instance variables
            2-Interface:Only constants

            1-Abstract class: A class can inherit only one
            2-Interface: A class can implement multiple interfaces

            1-Abstract class: Can have constructors
            2-Interface: Cannot have constructors
            ==================when we use ===========
            1-Use Abstract Class when: Classes share common code or you want partial implementation .
            2- Use Interface when: You need multiple inheritance or you define a contract across unrelated classes .

            */

            #endregion


            #region Part01-03
            /*
            A)-No , You can't because application class is abstract

            =============================================================

            B)- 1-PowerConsumption() : Abstract method , 
                                       Has no implementation in Appliance ,
                                       Must be implemented by every subclass .
                why ? Because each appliance consumes power differently so the base class cannot define a default .

                2-Status() : Virtual method ,
                             Provides a default implementation ,
                             Can be overridden by subclasses .
                Why ? :Because many appliances may have a common default ("Standby"), 
                   but WashingMachine need another behavior ("Washing").



                3-Label() : Concret method ,
                            Fully implemented in the base class
                why ? :it's common to all appliances and doesn’t need to change.
            =============================================================================================

            C)- it will return "Standby" , because it didn't override it

            */

            #endregion



            #region Part01-Q4
            /*
            A)-partial class : allows a class definition to be split across multiple files using the partial keyword,
                                 but at compile time all parts are combined into a single class.
                               why ? maybe multiple developers can work on different parts .
            B)- partial method : it's a method declared in one part of a partial class and optionally implemented in another.
                                 it's declaed with partial and must return void 

                                yes ,still compiles and call OnCalculated() is removed by compiler

            C)-extension method  : lets you add methods to an existing type without modifying it.
                                    Rules : 1- Static Class. 2-Static method. 3-this on 1st Param .

            D)- output will be :        Log: result = 20
                                        $20.00



            */
            #endregion
        }

    }
}
