using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hagasha_20._5
{
    class Program
    {
        // The function Main won't work since correct expression for an array is "int [] a"
        // and not "Int [] a"
        // In case we fix "Int" to "int" in Main function, the first number in array a will
        // be updated. Because Update function comes after initial definition of the array.

        static void Update(int[] a)
        {
            a[0] = 1;
        }
        static void Main(string[] args)
        {
            Int[] a = { 5, 4, -5 };
            Update(a);

        }
       
    }
}
