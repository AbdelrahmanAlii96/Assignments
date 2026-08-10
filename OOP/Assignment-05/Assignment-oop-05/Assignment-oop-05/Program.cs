namespace Assignment_oop_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01-Q1
            /*
            interface: it defines a contract that class must follow like it specifies what a class can do .
            interfaces :1- enable ploymarphism without inheritance .
                        2-enable multiple inhertiance of behavior
                        3-remove tight coupling between classes

            benifites : 1-Loose Coupling
                        2-Polymorphism and Flexibility
                        3-Multiple Inheritance of Behavior
            */

            #endregion

            #region Part01-Q2

            /*
            A)- Translator implements 2 interfaces but here it implemented one interface 
                so it can't detect for which interface this implementation for Greet() IEnglishSpeaker or IArabicSpeaker

            B)-we cant fix it by this way make 2 implementation for Greet() in Translater .
               It called Explicit Interface Implementation .
            ===============================================================
            class Translator : IEnglishSpeaker, IArabicSpeaker
            {
                void IEnglishSpeaker.Greet()
                {
                    Console.WriteLine("Hello");
                }

                void IArabicSpeaker.Greet()
                {
                    Console.WriteLine("Ahlan");
                }
            }
            =======================================================================
            
            C)- No, you cannot call translator.Greet() directly.
                because explicitly implemented methods are not accessible through the class itself .

            we can call each version by this way : 
            ======================================================
            Translator translator = new Translator();
            IEnglishSpeaker engsp = translator ;
            eng.Greet(); // Hello

            IArabicSpeaker arsp = translator ;
            ar.Greet(); // Ahlan
            ====================================================

            */

            #endregion

            #region Part01-Q3
            /*
            1-Shallow copy : Copies the obecjet but copies references for reference type fields .
            2-Deep copy : copies the object and all nested objects , creating fully independent duplicates .

            =========when we use each one =============
            1-Shallow copy :    1-when object contains only value types 
                                2-Shared references are intentional


            2-Deep copy :       1-object has reference type fields
                                2-You need complete independence


            ===============Risks=================
            Shallow copy : two objects , same inner references changing inner object affects both copies .

            */

            #endregion

            #region Part01-Q4
            /*
            =======Output=======
            Dev - Testing 
            QA - Testing 
            ====================

            because they have reference type like objects (Department)
            so when we change one will affact both 



            */

            #endregion
        }
    }
}
