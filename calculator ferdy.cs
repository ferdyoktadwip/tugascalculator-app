using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator ferdy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            int pilih;

	    Console.WriteLine("Calculator Sederhana");
            Console.WriteLine();
            Console.WriteLine("=====================");
            Console.Write("Pilih Menu : ");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("1. Penambahan ");
            Console.WriteLine();
            Console.Write("2. Pengurangan ");
            Console.WriteLine();
            Console.Write("3. Perkalian ");
            Console.WriteLine();
            Console.Write("4. Pembagian ");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Pilih Nomer (1-4) = ");
            pilih = int.Parse(Console.ReadLine());
            Console.WriteLine();


               if (pilih == 1 || pilih == 1)
            {
                Console.Write("Inputkan Nilai a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Silahkan Inputkan Nilai b = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Pertambahan(a, b));
            }

		else if (pilih == 2 || pilih == 2)
            {
                Console.Write("Inputkan Nilai a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Silahkan Inputkan Nilai b = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2} ", a, b, Pengurangan(a, b));
            }

		else if (pilih == 3 || pilih == 3)
            {
                Console.Write("Inputkan Nilai a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Inputkan Nilai b = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil Perkalian {0} * {1} = {2} ", a, b, Perkalian(a, b));
            }

		else  if (pilihan == 4 || pilih == 4)
            {
                Console.Write("Inputkan Nilai a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Inputkan Nilai b = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil Pembagian {0} / {1} = {2} ", a, b, Pembagian(a, b));

            }
            	else
            {
                Console.Write("Maaf menu yang anda pilih tidak tersedia pada pilihan yang disediakan");
            }
                Console.WriteLine();
                Console.WriteLine("\nTekan sembarang tombol untuk keluar...");
                Console.ReadKey();
        }
        static int Pertambahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a,int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
