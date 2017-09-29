using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP
{
    class algorithm
    {
        public static int cost = 0;
        public static LinkedList<int> ds;
        public static bool[] IsChecked;
        
        public static int FindMin(int[,] a, int begin)
        {
            int n = a.GetLength(0);
            int min = -1;
            for (int i = 0; i < n; i++)
            {
                if (a[begin, i] != 0 && IsChecked[i] == false)
                {
                    if (min == -1)
                        min = i;
                    else
                    {
                        if (a[begin, i] < a[begin, min])
                            min = i;
                    }
                }
            }
            return min;
        }
        public static void solve(int[,] a, int begin)
        {
            // set up fields
            int n = a.GetLength(0);
            IsChecked = new bool[n];
            ds = new LinkedList<int>();
            IsChecked[begin] = true;
            ds.AddLast(begin);
            // keep the begin num to return
            int tmp = begin;
            while (n > 1)
            {
                // find min
                int min = FindMin(a, begin);
                // add to the list and checked it
                ds.AddLast(min);
                IsChecked[min] = true;
                // write down the costs
                cost += a[begin, min];
                
                begin = min;

                n--;
            }
            // return to the first begin
            ds.AddLast(tmp);
            cost += a[begin, tmp];
            // output
            foreach (var items in ds)
            {
                Console.Write(items + " ");
            }
            Console.WriteLine("costs : " + cost);
        }
    }
}
