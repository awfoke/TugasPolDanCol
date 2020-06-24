using System;
using System.Collections.Generic;
using System.Text;
using TugasPolyDanCol.ClassInduk;

namespace TugasPolyDanCol.ClassAnak
{
    class Sales : Karyawan
    {
        public double Jumlahpenjualan { get; set; }
        public int Komisi { get; set; }

        public override double Gaji()
        {
            return Jumlahpenjualan * Komisi;
        }
    }
}
