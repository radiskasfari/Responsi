using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4498
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek Karyawan 1
            Karyawan karyawan1 = new Karyawan();

            karyawan1.NIK = "190302123";
            karyawan1.NAMA = "Paijo";
            karyawan1.GajiBulanan = 3000000;

            // membuat objek Karyawan 2
            Karyawan karyawan2 = new Karyawan();

            karyawan2.NIK = "190302124";
            karyawan2.NAMA = "Jono";
            karyawan2.GajiBulanan = 2000000;

            //pemanggilan method
            Console.WriteLine("No. Nik/Nama\t\tGaji Bulanan");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1. {0} {1}\t{2}", karyawan1.NIK, karyawan1.NAMA, karyawan1.GajiBulanan);
            Console.WriteLine("2. {0} {1}\t{2}", karyawan2.NIK, karyawan2.NAMA, karyawan2.GajiBulanan);
            Console.WriteLine("\n");
            Console.WriteLine("Asyiiiiik kenaikan 10%!! ");
            Console.WriteLine("\n");
            Console.WriteLine("No. Nik/Nama\t\tGaji Bulanan");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1. {0} {1}\t{2}", karyawan1.NIK, karyawan1.NAMA, karyawan1.GajiBulanan + (karyawan1.GajiBulanan * 0.10));
            Console.WriteLine("2. {0} {1}\t{2}", karyawan2.NIK, karyawan2.NAMA, karyawan2.GajiBulanan + (karyawan2.GajiBulanan * 0.10));
            Console.ReadKey();
        }
    }

}