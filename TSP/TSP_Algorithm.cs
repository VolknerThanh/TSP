using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP
{
    class TSP_Algorithm
    {
        public static int cost = 0;
        public static LinkedList<int> ds;
        public static bool[] Checked;

        public static void solve(int[,] a, int begin)
        {
            int n = a.GetLength(0);
            Checked = new bool[n];
            ds = new LinkedList<int>();
            ds.AddLast(begin);

            while (n > 0)
            {
                // Tìm min ( min là đỉnh ) 
                int min = -1;
                for(int i = 0; i < n; i++)
                {
                    // tìm chi phí nhỏ nhất và chưa xét
                    if (a[begin, i] != 0 && Checked[i] == false)
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
                // đưa vào danh sách và đánh dấu đã xét
                ds.AddLast(min);
                if (min == -1)
                    min = 0;
                
                Checked[min] = true;
                // tính chi phí
                cost += a[begin, min];
                // reset lại đỉnh
                begin = min;
                
                n--;
            }
            // output
            foreach(var items in ds)
            {
                Console.Write(items + " ");
            }
            Console.WriteLine("costs : " + cost);
        }
    }
}
