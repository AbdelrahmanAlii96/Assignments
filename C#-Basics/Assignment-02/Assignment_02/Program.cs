using System.ComponentModel.Design;

namespace Assignment_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //double d = 99.99;
            //int x = (int)d;
            //Console.WriteLine(x);
            //it will print 9
            //we create variable d as double type and we cast it to int type 
            //so the fractional part .99 is discarded and it will print just 9
            #endregion

            #region Q2
            //int n = 5;
            //double d2 = (double)n / 2;
            //Console.WriteLine(d2);
            //we cast variable n to double type
            #endregion

            #region Q3
            //int age = int.Parse(Console.ReadLine());
            #endregion

            #region Q4
            //string s = "12a";
            //int x = int.Parse(s);
            //Console.WriteLine(x);
            //we got FormatException error because variable s is string hs '12' and number and 'a' as character
            //can't convert s as integer 
            #endregion

            #region Q5
            //string s = "12a";
            //int x;
            //if (int.TryParse(s, out x))
            //{
            //Console.WriteLine(x);
            //}
            //else
            //{
            //Console.WriteLine("Invalid");
            //}
            #endregion

            #region Q6
            //object o = 10;
            //int a = (int)o;
            //Console.WriteLine(a + 1);
            // it will print 11 because we cast o to int type and assign it to variable a with type int
            // then we pring a which is equal 10 + 1 so = 11
            #endregion

            #region Q7
            //object o = 10;
            //long x = (long)o;
            //Console.WriteLine(x);


            //InvalidCastException because we boxed o to int and we need to unboxed o to int type then long

            //object o = 10;
            //long x = (long)(int)o;
            //Console.WriteLine(x);
            #endregion


            #region Q8
            //object o = 10;
            //long x = o is long l ? l : -1;
            //Console.WriteLine(x);
            #endregion

            #region Q9
            //string? name = null;
            //Console.WriteLine(name?.Length);
            // it will pring blank line (NULL) because name is null and no length

            #endregion

            #region Q10
            //string? name2 = null;
            //int length = name2?.Length ?? 0;
            //Console.WriteLine(length);
            //it will pring 0 because ?? give default value when something is null

            #endregion

            #region Q11
            //string? s = null;
            //int x = int.TryParse(s, out var result) ? result : 0;
            //Console.WriteLine(x);

            #endregion

            #region Q12
            //string? s = null;  
            //Console.WriteLine(s!.Length);  
            // s is nullable and ! operator tell compiler no null 
            // to fix it 
            //Console.WriteLine(s?.Length ?? 0);
            #endregion

            #region Q13
            //string? s = null;
            //int x = Convert.ToInt32(s);
            //Console.WriteLine(x);
            //s is null and convert.toint32 manage nullable and convert it to 0 if null so it will print 0

            #endregion

            #region Q14
            //string? s = null;
            ////A
            //int a = int.Parse(s);
            ////B
            //int b = Convert.ToInt32(s);
            //Console.WriteLine(b);
            //it will throw ArgumentNullException because int.parse can't parse null
            #endregion

            #region Q15
            //string? user = null;
            //Console.WriteLine(user?.ToUpper() ?? "Guest");

            #endregion
        }
    }
}
