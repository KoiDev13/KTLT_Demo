using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KTLT_Demo.Business
{
    public struct PHANSO
    {
        public int TuSo;
        public int MauSo;
    }

    public class XL_PHANSO
    {
       
        public static PHANSO CongPS(PHANSO a, PHANSO b)
        {
            PHANSO kq;
            kq.TuSo = a.TuSo * b.MauSo + a.MauSo * b.TuSo;
            kq.MauSo = a.MauSo * b.MauSo;
            return kq;
        }
    }
}
