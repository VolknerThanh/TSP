using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TSP
{
    class CMap
    {
        int xp; // dinh xuat phat
        int[,] dothi; //Ma trận vô hướng có trọng số

        public CMap()
        {
            xp = 0;
            dothi = new int[0, 0];
        }

        public CMap(string filename)
        {
            //Chưa kiểm tra các exception
            StreamReader sr = new StreamReader(filename);
            string line = sr.ReadLine(); //Đọc dòng đầu tiên của file
            string[] s = line.Split(' '); //Tách giá trị số phần tử và đỉnh xuất phát
            int sodinh = int.Parse(s[0]); //Số đỉnh
            xp = int.Parse(s[1]);
            //Đọc ma trận
            dothi = new int[sodinh, sodinh];
            int dong = 0;
            while ((line = sr.ReadLine()) != null)
            {
                int cot = 0;
                foreach (string str in line.Split(' '))
                {
                    dothi[dong, cot++] = int.Parse(str);
                }
                dong++;
            }
        }

        public int SoDinh
        {
            get { return dothi.GetLength(0); }
        }

        public void Xuat()
        {
            Console.WriteLine("Dinh xuat phat: {0}", xp);
            Console.WriteLine("Do thi co {0} dinh", SoDinh);
            for (int i = 0; i < SoDinh; i++)
            {
                for (int j = 0; j < SoDinh; j++)
                {
                    Console.Write("{0, 4}", dothi[i, j]);
                }
                Console.WriteLine();
            }
        }
        public void solve()
        {
            algorithm.solve(dothi, xp);
        }
    }
}
