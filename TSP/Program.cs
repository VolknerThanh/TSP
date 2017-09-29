using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TSP
{
    class Program
    {
        /*
         * ===========================================================
                   _____ _ _                _____       _       
                  / ____(_) |              |  __ \     (_)      
                 | (___  _| |_   _____ _ __| |__) |__ _ _ _ __  
                  \___ \| | \ \ / / _ \ '__|  _  // _` | | '_ \ 
                  ____) | | |\ V /  __/ |  | | \ \ (_| | | | | |
                 |_____/|_|_| \_/ \___|_|  |_|  \_\__,_|_|_| |_|
         * ===========================================================
         */

        static void Main(string[] args)
        {
            CMap map = new CMap("dothi.txt");
            map.Xuat();
            /*
            int[,] a = new int[5, 5];
            StreamReader sr = new StreamReader("test.txt");
            for (int i = 0; i < 5; i++)
            {
                string[] s = sr.ReadLine().Split(' ');
                for (int j = 0; j < 5; j++)
                {
                    a[i, j] = int.Parse(s[j]);
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            */
            map.solve();
        }
    }
}
