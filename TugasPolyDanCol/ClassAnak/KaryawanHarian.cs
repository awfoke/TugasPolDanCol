using System;
using System.Collections.Generic;
using System.Text;
using TugasPolyDanCol.ClassInduk;

namespace TugasPolyDanCol.ClassAnak
{
    class KaryawanHarian : Karyawan
    {
        public double Upahperjam { get; set; }
        public double Jumlahjamkerja { get; set; }

        public override double Gaji()
        {
            return Upahperjam * Jumlahjamkerja;
        }
    }
}
