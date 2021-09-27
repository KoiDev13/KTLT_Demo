using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using KTLT_Demo.ENTITY;
using KTLT_Demo.DAL;

namespace KTLT_Demo.Business
{
    public class XL_TAMGIAC
    {
        public static void LuuTamGiac(TAMGIAC tg, string filePath)
        {
            StreamWriter file = new StreamWriter(filePath);
            file.WriteLine($"{tg.A.X}, {tg.A.Y}");
            file.WriteLine($"{tg.B.X}, {tg.B.Y}");
            file.WriteLine($"{tg.C.X}, {tg.C.Y}");
            file.Close();
        }

        public static TAMGIAC KhoiTaoTamGiac(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            TAMGIAC tg;
            tg.A.X = x1;
            tg.A.Y = y1;
            tg.B.X = x2;
            tg.B.Y = y2;
            tg.C.X = x3;
            tg.C.Y = y3;
            return tg;
        }
        
        public static DIEM DocTamGiac(string FilePath)
        {
            StreamReader file = new StreamReader(FilePath);
            string s = file.ReadLine();

            DIEM kq;
            string[] M = s.Split(',');
            kq.X = int.Parse(M[0]);
            kq.Y = int.Parse(M[1]);

            file.Close();
            return kq;
        }

        public static double TinhChuVi(TAMGIAC tg)
        {
            double a, b, c;
            a = XL_DIEM.TinhKhoangCach(tg.B, tg.C);
            b = XL_DIEM.TinhKhoangCach(tg.A, tg.C);
            c = XL_DIEM.TinhKhoangCach(tg.B, tg.A);
            return a + b + c;
        }
    }
}
