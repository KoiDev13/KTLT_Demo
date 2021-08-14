using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace KTLT_Demo.Business
{
    public struct DIEM
    {
        public int X;
        public int Y;
    }
    public class XL_DIEM
    {
        public static double TinhKhoangCach(DIEM a, DIEM b)
        {
            return Math.Sqrt((a.X - b.Y) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y));
        }

        public static void LuuDiem(DIEM a, string filePath)
        {
            StreamWriter file = new StreamWriter(filePath);
            file.Write($"{a.X},{a.Y}");
            file.Close();
        }
    }
}
