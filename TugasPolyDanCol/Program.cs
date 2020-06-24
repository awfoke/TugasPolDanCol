using System;
using System.Collections.Generic;
using TugasPolyDanCol.ClassAnak;
using TugasPolyDanCol.ClassInduk;

namespace TugasPolyDanCol
{
    class Program
    {
        static void Main(string[] args)
        {
            KaryawanTetap karyawantetap = new KaryawanTetap
            {
                Nik = "081-391-353",
                Nama = "Aldi",
                Gajibulanan = 50000000
            };

            KaryawanHarian karyawanharian = new KaryawanHarian
            {
                Nik = "081-391-354",
                Nama = "Pra",
                Upahperjam = 20000,
                Jumlahjamkerja = 8
            };

            Sales sales = new Sales
            {
                Nik = "081-391-355",
                Nama = "Bowo",
                Komisi = 50000,
                Jumlahpenjualan = 65
            };

            List<Karyawan> listkaryawan = new List<Karyawan>
            {
                karyawantetap,
                karyawanharian,
                sales
            };

            int noUrut = 1;

            foreach (Karyawan karyawan in listkaryawan)
            {
                Console.WriteLine("{0}. NIK: {1}, NAMA: {2}, GAJI: {3}",
                    noUrut, karyawan.Nik, karyawan.Nama, karyawan.Gaji());

                noUrut++;
            }
        }
    }
}
