using System;
using System.Collections.Generic;
using System.Text;
using TugasPolyDanCol.ClassInduk;

namespace TugasPolyDanCol.ClassAnak
{
    class KaryawanTetap : Karyawan
    {
        public double Gajibulanan { get; set; }
        public override double Gaji()
        {
            return Gajibulanan;
        }
    }
}
