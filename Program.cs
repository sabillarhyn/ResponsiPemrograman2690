using System;

namespace ResponsiPemrograman2690
{
    class Program
    {
        static void Main(string[] args)
        {
            karyawan karyawan = new karyawan();
            karyawan karyawan2 = new karyawan();

            karyawan.No = "1.";
            karyawan.Nama = "Paijo";
            karyawan.Nik = 190302123;
            karyawan.GajiBulanan = 3000000;

            karyawan2.No = "2.";
            karyawan2.Nama = "Jono";
            karyawan2.Nik = 190302124;
            karyawan2.GajiBulanan = 2000000;

            Console.WriteLine("No      NIK/Nama	     	Gaji Bulanan");
            Console.WriteLine("-------------------------------------------------");
            karyawan.DataGaji();
            karyawan2.DataGaji();
            
            Console.WriteLine("Kenaikan Gaji 10%!!");
            Console.WriteLine("No      NIK/Nama	     	Gaji Bulanan");
            Console.WriteLine("-------------------------------------------------");
            karyawan.NaikGaji();
            karyawan2.NaikGaji();
        }
    }
}
