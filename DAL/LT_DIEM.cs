using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using KTLT_Demo.ENTITY;

namespace KTLT_Demo.DAL
{
    public class LT_DIEM
    {
        public static void LuuDiem(DIEM a, string filePath)
        {
            StreamWriter file = new StreamWriter(filePath);
            file.Write($"{a.X},{a.Y}");
            file.Close();
        }

        public static DIEM DocDiem(string FilePath)
        {
            StreamReader file = new StreamReader(FilePath);
            string s = file.ReadLine();
            file.Close();

            DIEM kq;
            string[] M = s.Split(',');
            kq.X = int.Parse(M[0]);
            kq.Y = int.Parse(M[1]);
            return kq;
        }
    }
}
