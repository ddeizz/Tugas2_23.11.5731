using System;
using System.Threading;


namespace CalculatorYoik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator\n");

            Console.Write("Pilih operator\n\n");
            Console.Write("1. Penambahan\n");
            Console.Write("2. Pengurangan\n");
            Console.Write("3. Perkalian\n");
            Console.Write("4. Pembagian\n\n");

            Console.Write("Tentukan Pilihan (1 sd 4) : ");
            int p;
            while (!int.TryParse(Console.ReadLine(), out p) || p < 1 || p > 4)
            {
                Console.WriteLine("Maaf, menu yang Anda pilih tidak ada. Silakan pilih kembali.");

                Thread.Sleep(3000);

                Console.Clear();
                Console.Write("Pilih Operator\n\n");
                Console.Write("1. Penambahan\n");
                Console.Write("2. Pengurangan\n");
                Console.Write("3. Perkalian\n");
                Console.Write("4. Pembagian\n\n");
                Console.Write("\nTentukan Pilihan (1 sd 4) : ");
            }


            Console.Write("\nMasukkan Nilai A = ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan Nilai B = ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (p == 1)
            {
                Console.WriteLine("\nHasil Penambahan {0} + {1} = {2}", a, b, Penambahan(a, b));
            }
            else if (p == 2)
            {
                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
            }
            else if (p == 3)
            {
                Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
            }
            else if (p == 4)
            {
                if (b == 0)
                {
                    Console.WriteLine("Pembagian dengan nol tidak dapat dilakukan");
                }
                else
                {
                    Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
                }
            }

            Console.WriteLine("\nTekan Enter Untuk Keluar");
            Console.ReadKey();
        }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
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