using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong13
{
    internal class SinhVien
    {

        public string TenSV { get; set; }
        public int TuoiSV { get; set; }
        public double DiemSV { get; set; }

        public override string ToString()
        {
            return $"{TenSV}\t{TuoiSV}\t{DiemSV}";
        }
    }
}
