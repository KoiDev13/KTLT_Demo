using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using KTLT_Demo.ENTITY;

namespace KTLT_Demo.DAL
{
    public class LT_DAGIAC
    {
        public static void LuuDaGiac(DAGIAC dg, string filePath)
        {
            StreamWriter file = new StreamWriter(filePath);
            file.WriteLine(dg.Dinh.Length);
            for (int i = 0; i < dg.Dinh.Length; i++)
            {
                file.WriteLine($"{dg.Dinh[i].X},{dg.Dinh[i].Y}");
            }
            file.Close();
        }
        public static DAGIAC DocDaGiac(string filePath)
        {
            DAGIAC kq;
            StreamReader file = new StreamReader(filePath);

            string s = file.ReadLine();
            int N = int.Parse(s);

            kq.Dinh = new DIEM[N];

            for (int i = 0; i < N; i++)
            {
                s = file.ReadLine();
                string[] M = s.Split(',');
                kq.Dinh[i].X = int.Parse(M[0]);
                kq.Dinh[i].Y = int.Parse(M[1]);
            }
            file.Close();
            return kq;
        }
    }
}
