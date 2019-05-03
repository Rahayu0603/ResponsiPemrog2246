using system;
using system.Collections.Generic;
using system.Linq;
using system.Text;
using system.Threading.Tasks;

namespace Responsipemrog2246{
    class program {

        static void main(string[]args) {
            Karyawan karyawan1 = new Karyawan("190346783", "jono", 3000000);
            Karyawan karyawan2 = new Karyawan ("190367006", "paijo", 6000000);

            Console.WriteLine(No    Nik/Nama    Gaji Bulanan");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("1.   {0} {1}     {2}", karyawan1.Nik, karyawan1.Nama, karyawan1.GajiBulanan);
            Console.WriteLine("2.   {0} {1}     {2}", karyawan2.Nik, karyawan2.Nama, karyawan2.GajiBulanan);
            Console.WriteLine();
            Console.WriteLine();

            karyawan1.GajiBulanan = karyawan1.GajiBulanan * 110 / 100;
            karyawan2.GajiBulanan = karyawan2.GajiBulanan * 110 / 100;

            Console.WriteLine("yee kenaikan gaji 10%");
            Console.WriteLine();
            Console.WriteLine(No    Nik/Nama    Gaji Bulanan");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("1.   {0} {1}     {2}", karyawan1.Nik, karyawan1.Nama, karyawan1.GajiBulanan);
            Console.WriteLine("2.   {0} {1}     {2}", karyawan2.Nik, karyawan2.Nama, karyawan2.GajiBulanan);

            Console.ReadKey();
        }
    }
}