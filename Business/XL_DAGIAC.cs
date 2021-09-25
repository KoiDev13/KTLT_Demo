using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using KTLT_Demo.ENTITY;
using KTLT_Demo.DAL;
using KTLT_Demo.Business;

namespace KTLT_Demo.Business
{
    
    public class XL_DAGIAC
    {
        public static bool LuuDaGiac(DAGIAC dg, string filePath)
        {
            //Kiem tra tinh hop le cua du lieu
            if (dg.Dinh.Length <= 3)
            {
                return false;
            }
            LT_DAGIAC.LuuDaGiac(dg, filePath);
            return true;
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
    }
}
