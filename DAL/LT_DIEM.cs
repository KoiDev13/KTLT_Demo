using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using KTLT_Demo.ENTITY;
using Newtonsoft.Json;

namespace KTLT_Demo.DAL
{
    public class LT_DIEM
    {
        public static void LuuDiem(DIEM a, string filePath)
        {
            StreamWriter file = new StreamWriter(filePath);
            string json = JsonConvert.SerializeObject(a);
            file.Write(json);
            file.Close();
        }

        public static DIEM DocDiem(string FilePath)
        {
            StreamReader file = new StreamReader(FilePath);
            string jsonText = file.ReadLine();
            file.Close();

            DIEM kq = JsonConvert.DeserializeObject<DIEM>(jsonText);
            return kq;
        }
    }
}
