using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_QuickSort
{
    class Sort_0
    {
        int[] _mass;

        public void QuickSort(int[] mass)
        {
            _mass = mass;
            QuickSort(0, _mass.Length - 1);

            //foreach (int i in _mass)
            //   Console.Write($"{_mass[i]} ");
            //Console.WriteLine();
        }


        void QuickSort(int L, int R)
        {
            if (L >= R) return;


            int X = Split(L, R);

            if (X == -1) return;

            QuickSort(L, X);
            QuickSort(X+1, R);
        }



        int Split(int L = 0, int R = 0)
        {

            int l = L;
            int r = R;
            int pivot = _mass[r];


            while (l <= r)
            {
                if (_mass[l] <= pivot)
                {
                    ++l;
                    continue;
                }

                if (_mass[r] > pivot)
                {
                    --r;
                    continue;
                }

                if (l <= r)
                {
                    Swap(l, r);
                    ++l;
                    --r;
                }
            }

            if (r==R)
            {
                // этот кусок уже отсортировали. 
                return --r;
            }

            return r;

        }


        void Swap(int L, int R)
        {
            int y = _mass[L];
            _mass[L] = _mass[R];
            _mass[R] = y;
        }
    }
}
