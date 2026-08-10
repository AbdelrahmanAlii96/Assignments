namespace Assignment_oop_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01-Q1
            /*
            A)-Composition : strong relationship Departments are part of Universtay if university not exist departments won't be exist too

            B)-Association : driver use care but not own it so both can exist independetly

            C)-Inhertince : it's (IS-A) Relationship so dog is a type of animal

            D)-Aggregation : it's (Has-A0 Relationship so teams has a player

            E)-Dependency : method depend on logger


            */
            #endregion

            #region Part01-!2
            /*
            A)-yes , child class can access Protected member of the bass class even it's in different assembly
               No , u can't accept protected field from outsite

            B)- Protected internal : accessiable anywhere in the same assembly or derved classes in thoer assemblies
                Oricate protected : acessible in the same class or dervied classes in same assembly

            C)-Sealed : when it applied to a class so the class can't be inherited .
                        when it applied to method so the method can't be an overriden

            D)-yes u can't create object from sealed class , the sealed class only prevent inhertince


            */

            #endregion
        }
    }
}
