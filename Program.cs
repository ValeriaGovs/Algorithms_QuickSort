using System;

namespace Algorithms_QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {

            Sort s = new Sort();
            int n = 10;
            
           for (int i = 0; i < 6; i++)
           {
               n = n*10;

               TimeTest.Test(n, s.QuickSort, "QuickSort");

           }

            Console.WriteLine("");



            Sort_0 s_0 = new Sort_0();
            n = 10;

            for (int i = 0; i < 6; i++)
            {
                n =n*10;

                TimeTest.Test(n, s_0.QuickSort, "QuickSort_0");
            }
            
        }


    }
}
