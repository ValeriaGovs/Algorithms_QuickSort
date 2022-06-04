using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_QuickSort
{
    class Sort
    {
        int[] _mass;

        public  void QuickSort(int[] mass)
        {

            _mass = mass;
            QuickSort(0, _mass.Length-1);

            /*
            foreach (int i in _mass)
                Console.Write($"{_mass[i]} ");
            Console.WriteLine();
            */
        }


        void  QuickSort( int L, int R)
        {
            if (L >= R) return;
            int X = Split( L, R);

            QuickSort( L, X-1 );
            QuickSort( X+1 , R);
        }


        int Split(int L, int R)
        {
            int x = _mass[R];
            int a = L - 1;
            for (int m = L; m <= R; m++)
                if (_mass[m] <= x)
                    Swap(++a, m);

            return a;
        }

        void Swap(int L, int R)
        {
            int y = _mass[L];
            _mass[L] = _mass[R];
            _mass[R] = y;
        }
    }
}
