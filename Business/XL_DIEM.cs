using KTLT_Demo.ENTITY;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using KTLT_Demo.DAL;

namespace KTLT_Demo.Business
{
    public class XL_DIEM
    {
        public static double TinhKhoangCach(DIEM a, DIEM b)
        {
            return Math.Sqrt((a.X - b.Y) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y));
        }
        public static void LuuDiem(DIEM a, string filePath)
        {
            KTLT_Demo.DAL.LT_DIEM.LuuDiem(a, filePath);
        }
        public static DIEM DocDiem(string filePath)
        {
            DIEM a = KTLT_Demo.DAL.LT_DIEM.DocDiem(filePath);
            return a;
        }
    }
}
