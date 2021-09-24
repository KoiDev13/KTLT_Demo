using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace KTLT_Demo.Business
{
    public struct DAGIAC
    {
        public DIEM[] Dinh;
    }
    public class XL_DAGIAC
    {
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
        public static DAGIAC KhoiTaoDaGiac(string dinh)
        {
            DAGIAC dg;
            // dinh = "(1,3)|(2,6)|(5,1)"
            string[] M = dinh.Split("|");
            dg.Dinh = new DIEM[M.Length];
            for (int i = 0; i < dg.Dinh.Length; i++)
            {

                string s = M[i].Substring(1, M[i].Length - 2);
                string[] K = s.Split(",");
                dg.Dinh[i].X = int.Parse(K[0]);
                dg.Dinh[i].Y = int.Parse(K[1]);
            }
            return dg;
        }
        public static void LuuDaGiac(DG dg, string filePath)
        {
            StreamWriter file = new StreamWriter(filePath);
            file.WriteLine($"{tg.A.X}, {tg.A.Y}");
            file.WriteLine($"{tg.B.X}, {tg.B.Y}");
            file.WriteLine($"{tg.C.X}, {tg.C.Y}");
            file.Close();
        }
    }
}
