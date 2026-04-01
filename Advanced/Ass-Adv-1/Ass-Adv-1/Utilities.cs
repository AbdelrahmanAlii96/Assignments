using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass_Adv_1
{
    public static class Utilities
    {
        public static void swap<T>(ref T A, ref T B)
        {
            T temp = A;
            A = B;
            B = temp;
        }

        public static T FindMax<T>(T A, T B) where T : IComparable<T>
        {
            if (A.CompareTo(B) > 0)
            {
                return A;
            }
            else
            {
                return B;
            }
        }
    }
}
