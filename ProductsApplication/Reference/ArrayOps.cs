using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductsApplication.Reference
{
    public class ArrayOps
    {


        static void Main()
        {
            string[] tmpArray = new string[4];
            tmpArray[0] = "1mock1";
            tmpArray[1] = "3mock2";
            tmpArray[2] = "2mock3";
            tmpArray[3] = "4mock4";

            Output(tmpArray);

            System.Array.Reverse(tmpArray);

            Output(tmpArray);

            int total = 10;
            int i = 10;
            Add(i, ref total);
            Console.WriteLine(total); // shortcut/snippet = cw

            System.Array.Sort(tmpArray);

            Output(tmpArray);
        }

        private static void Output(string[] tmpArray)
        {
            Console.WriteLine("----");
            foreach (string s in tmpArray)
            {
                Console.WriteLine(s);
            }
        }


        private static void Add(int i, ref int result)
        {
            result += i;
        }
    }
}