using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.AccessControl;

namespace CSharpAssignment
{
    class Program
    {
        // Class-level field for scope demonstrations
        static int classField = 100;

        static void Main(string[] args)
        {
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║           C# FUNDAMENTALS - ASSIGNMENT WITH ANSWERS                ║");
            Console.WriteLine("║                      20 Questions                                  ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════╝\n");



            #region Question 1: Regions
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 2: REGIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the purpose of #region and #endregion directives in C#? 
            //    How do they help in code organization?
            //
            // ══════════════════════════════════════════════════════════════════════

            //Ans): 1-Collapsing code blocks. 2-Logical grouping . 3-readability.S

            //Nested Region Example

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion

            #region Question 2: Variable Declaration - Explicit vs Implicit
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 3: VARIABLE DECLARATION - EXPLICIT VS IMPLICIT
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the difference between explicit and implicit variable 
            //    declaration in C#? Provide examples of both.
            //
            // ══════════════════════════════════════════════════════════════════════



            // EXPLICIT DECLARATION 
            //Ans): You clearly state the data type of the variable.
            //int number = 10;
            //string name = "ahmed";


            // IMPLICIT DECLARATION 
            //Ans): You use the keyword var, and the compiler deciede the type from the assigned value.
            //var number = 10;        // int
            //var name = "Ahmed";    //  string

            #endregion

            #region Question 3: Constants
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 4: CONSTANTS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write the syntax for declaring a constant in C#. Why would you use 
            //    a constant instead of a regular variable?
            //
            // ══════════════════════════════════════════════════════════════════════
            //Ans : 
            //    1-constant’s value cannot be changed after declaration 
            //    2-Readability : like easier to understand by giving meaningful names to fixed values .
            //    3-Constants are resolved at compile time


            // Constant examples : const int Max = 100;

            #endregion

            #region Question 4: Class-level vs Method-level Scope
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 4: CLASS-LEVEL VS METHOD-LEVEL SCOPE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Explain the difference between class-level scope and method-level 
            //    scope with examples.
            //
            // ══════════════════════════════════════════════════════════════════════
            //Ans : Class-Level
            //      Declared inside a class but outside any method .
            //      Accessible by all methods in the class .
            //      Lifetime as long as the object exists .

            //Examples : 
            //class Student
            //{
            //    String name;  // class-level variable

            //    void setName(String n)
            //    {
            //        name = "Ahmed";
            //    }

            //    void display()
            //    {
            //        Console.WriteLine(name);
            //    }
            //}
            //==========================================
            // 2- Method-Level Scope (Local Variables)
            //          Declared inside a method
            //          Accessible only within that method
            //          Lifetime is only while the method is running

            //Example :
            //class Student
            //{
            //    void show()
            //    {
            //        int age = 20;  // method-level variable
            //    }
            //}


            #endregion

            #region Question 5: Block-level Scope
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 5: BLOCK-LEVEL SCOPE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is block-level scope? Give an example showing a variable that 
            //    is only accessible within a specific block.
            //
            //Ans : Block-level scope in C# means that a variable declared inside a block {.. } 
            //      and it's is only accessible within that block and not outsite of it .
            //
            //Example : 
            //if (true)
            //{
            //    int x = 10; // x is declared inside this blockand not outside of IF condition
            //    Console.WriteLine(x); // Accessible here
            //}
            //
            // ══════════════════════════════════════════════════════════════════════

            #endregion

            #region Question 6: Variable Lifetime - Local vs Static
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 6: VARIABLE LIFETIME - LOCAL VS STATIC
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is variable lifetime? Explain the lifetime of local variables 
            //    vs static variables.
            //
            //Ans : 1 -Local Variables : a-Variables declared inside a function or block.
            //                           b-Created when the function or block is entered
            //                           c-Destroyed when the function or block exits.
            //
            //      2-Static Variables : a-Variables declared with the static keyword inside a function or globally .
            //                           b-Created once when the program starts .
            //                           c-Persist for the entire duration of the program.
            //
            //
            //
            // ══════════════════════════════════════════════════════════════════════


            #endregion

            #region Question 7: Garbage Collector
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 7: GARBAGE COLLECTOR
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the Garbage Collector in C#? How does it affect the 
            //    lifetime of objects?
            //
            //  Ans:GC is an automatic memory management system 
            //      that handles allocation and deallocation of memory for objects .
            //
            //   The GC determines whether an object is reachable:
            //          If an object is referenced(directly or indirectly), it stays alive
            //          If it is unreachable, it becomes eligible for garbage collection
            //
            //
            // ══════════════════════════════════════════════════════════════════════


            #endregion

            #region Question 8: Variable Shadowing
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 8: VARIABLE SHADOWING
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is variable shadowing in C#? Does C# allow shadowing in 
            //    nested blocks within the same method?
            //
            // Ans: happens when a variable declared in an inner scope has the same name as a variable in an outer scope
            //      :not allowed  for variable shadowing in nested blocks within the same method
            //
            //
            // ══════════════════════════════════════════════════════════════════════

            #endregion

            #region Question 9: C# Naming Rules
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 9: C# NAMING RULES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: List five rules that must be followed when naming variables in C#.
            //
            // Ans : 1- Names must start with letter or _
            //       2- can contain letters , digits , _ and no spaces
            //       3- C# is case sensitive so name not equal Name
            //       4-avoid reserved keywords
            //       5-use camelCase 
            //       6-Abbreviations
            // ══════════════════════════════════════════════════════════════════════

            #endregion

            #region Question 10: Naming Conventions
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 10: NAMING CONVENTIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What naming conventions are recommended for: (a) local variables, 
            //    (b) class names, (c) constants?
            //
            // Ans : a) :use camelCase
            //       b) : PascalCase
            //       c): PascalCase
            //
            // ══════════════════════════════════════════════════════════════════════
            #endregion

            #region Question 11: Error Types
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 11: ERROR TYPES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Compare and contrast syntax errors, runtime errors, and logical 
            //    errors. Provide an example of each.
            //
            // Ans: 1-Syntax Errors : Mistakes in the code that violate the rules of the programming language.
            //              Example : Console.WriteLine("Hello World"  //Missing closing parenthesis and semicolon
            //
            //      2-Runtime Errors : Errors that occur while the program is running even though the code compiled successfully.
            //              Example : int result = 10 / 0;  //Divide by zero exception
            //
            //      3-Logical Errors : Mistakes in the program’s logic and The code runs without crashing . 
            //              Example : int a = 5;  int b = 10; int max = a; //Incorrect logic max is b not a
            //
            // ══════════════════════════════════════════════════════════════════════

            #endregion

            #region Question 12: Exception Handling Importance
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 12: EXCEPTION HANDLING IMPORTANCE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Why is exception handling important in C#? What would happen if 
            //    you don't handle exceptions?
            //
            // Ans : it's important for :   1-Prevent application Crash
            //                              2-Show user friendly
            //                              3-Log details for debugging
            //                              4-Guarantee cleanup
            //
            //
            // ══════════════════════════════════════════════════════════════════════


            #endregion

            #region Question 13: try-catch-finally
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 13: TRY-CATCH-FINALLY
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write a code example demonstrating try-catch-finally. Explain when 
            //    the finally block executes.
            //try
            //{
            //    Console.WriteLine("Inside try block");

            //    int x = 10;
            //    int y = 0;

            //    int result = x / y; // This will throw DivideByZeroException

            //    Console.WriteLine("Result: " + result);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Caught exception: " + ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Finally block always executes.");
            //}
            //
            // wheen : The finally block executes in all cases .
            // ══════════════════════════════════════════════════════════════════════

            #endregion

            #region Question 14: Common Built-in Exceptions
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 14: COMMON BUILT-IN EXCEPTIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: List and explain five common built-in exceptions in C# with 
            //    scenarios when each would occur.
            //
            // Answ : 
            // 1- NullReferenceException : when you try to use an object reference that hasn’t been initialized
            // 2-IndexOutOfRangeException : when you try to access an array or collection with an index that is outside it's range 
            // 3-DivideByZeroException : when attempting to divide a number by zero.
            // 4- FormatException : when the format of a string is invalid for conversion to another type.
            // 5-ArugmentNullExeption : when pass a Numm to method paramter
            //
            //
            //
            // ══════════════════════════════════════════════════════════════════════
            #endregion

            #region Question 15: Multiple catch Blocks
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 15: MULTIPLE CATCH BLOCKS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Why is the order of catch blocks important when handling multiple 
            //    exceptions? Write code showing correct ordering.
            //
            //
            // Ans: the order of catch blocks matters because exceptions are matched top-down ,
            //      always place more specific catches before general one
            //======Example ======
            //try
            //{
            //    int x = int.Parse("abc");
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Format exception");
            //}
            //catch (OverflowException ex)
            //{
            //    Console.WriteLine("Overflow exception");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("General exception");
            //}
            // ══════════════════════════════════════════════════════════════════════

            #endregion

            #region Question 16: throw Keyword
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 16: THROW KEYWORD
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the difference between 'throw' and 'throw ex' when 
            //    re-throwing an exception? Which one preserves the stack trace?
            //
            // Ans: 1-throw :Re-throws the original exception
            //               Preserves the original stack trace
            //
            //      2-throw ex : Re-throws the exception as if it originated here
            //                 : Resets the stack trace
            // ══════════════════════════════════════════════════════════════════════
            #endregion

            #region Question 17: Stack and Heap Memory
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 17: STACK AND HEAP MEMORY
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Explain the differences between Stack and Heap memory in C#. 
            //    What types of data are stored in each?
            //
            // Ans:
            // 1- Stack Memory : the stack sotres method calls and local variables 
            //                   memory is allocated and released auto using LIFO(last in first out) 
            //                   type of data : Value types
            // 2 - Heap Memory : the Heap stores objects created using new
            //                 : Memory is manged by Garbage Collector (GC)
            //                  type of date : Objects
            //
            // ══════════════════════════════════════════════════════════════════════


            #endregion

            #region Question 18: Value Types vs Reference Types
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 18: VALUE TYPES VS REFERENCE TYPES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write a code example showing how value types and reference types 
            //    behave differently when assigned to another variable.
            //
            // 1-Value Type Example : struct , int , char , bool
            //=====Example======
            //int a = 10;
            //int b = a; // copy of value

            //b = 20;

            //Console.WriteLine("Value Type:");
            //Console.WriteLine($"a = {a}"); // 10
            //Console.WriteLine($"b = {b}"); // 20
            //========================================
            //
            // 2- Reference Type Example : class , interface , array , string
            //=========Example============
            //class Person
            //{
            //    public string Name;
            //}
            //Person p1 = new Person();
            //p1.Name = "Alice";

            //Person p2 = p1; // reference copy (same object)

            //p2.Name = "Bob";

            //Console.WriteLine("\nReference Type:");
            //Console.WriteLine($"p1.Name = {p1.Name}"); // Bob
            //Console.WriteLine($"p2.Name = {p2.Name}"); // Bob
            // ══════════════════════════════════════════════════════════════════════

            #endregion

            #region Question 19: Object in C#
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 19: OBJECT IN C#
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Why is 'object' considered the base type of all types in C#? 
            //    What methods does every type inherit from System.Object?
            //
            // Ans:
            //      object is the root of the C# type hierarchy.
            //      All types inherit a shared set of methods from System.Object.
            // Methods: 1 - ToString() :strong representation
            //          2 - Equals() : value comparsion
            //          3- GetHashCode : hash-based collections
            //          4- Gettype() : runtime type information
            //
            // ══════════════════════════════════════════════════════════════════════

            #endregion

        }



    }


}