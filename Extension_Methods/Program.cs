using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Extension_Methods
{
   static class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine(numbers.IEnumerableExtensions<int>());
            Console.Read();
        }
    }
    static class Extensions
    {
        public static string IEnumerableExtensions<T>(this IEnumerable<T> enumerable)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("[");
            foreach(var item in enumerable)
            {
                stringBuilder.Append(item+ " ");
                stringBuilder.Append(",");
               
            }
            stringBuilder.Append("]");
           
            return stringBuilder.ToString();
        }
    }
}
