using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using KTLT_Demo.ENTITY;
using Newtonsoft.Json;

namespace KTLT_Demo.DAL
{
    public class LT_DAGIAC
    {
        public static void LuuDaGiac(DAGIAC dg, string filePath)
        {
            StreamWriter file = new StreamWriter(filePath);

            string jsonText = JsonConvert.SerializeObject(dg);
            file.Write(jsonText);

            file.Close();
        }
        public static DAGIAC DocDaGiac(string filePath)
        {
            StreamReader file = new StreamReader(filePath);

            string jsonText = file.ReadToEnd();

            DAGIAC kq = JsonConvert.DeserializeObject<DAGIAC>(jsonText);
            
            file.Close();
            return kq;
        }
    }
}
