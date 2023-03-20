using System;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {

            int hasil, operasi, a, b;
            Console.Title = "Aplikasi Calculator";
            Console.Write("Pilih menu Kalkulator\n\n");
            Console.Write("1. Penambahan\n");
            Console.Write("2. Pengurangan\n");
            Console.Write("3. Perkalian\n");
            Console.Write("4. Pembagian\n\n");
            Console.Write("Input nomor menu [1..4]:");
            operasi = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            if (operasi >= 1 && operasi <= 4)
            {
                Console.Write("Inputkan nilai a = ");
                a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Inputkan nilai b = ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n");
                switch (operasi)
                {
                    case 1:
                        hasil = a + b;
                        Console.WriteLine("hasil penambahan = " + a + " + " +  b  + " = " + hasil);
                        Console.WriteLine(" ");
                        Console.WriteLine("Tekan sembarang key untuk keluar");
                        break;

                    case 2:
                        hasil = a - b;
                        Console.WriteLine("hasil penambahan = " + a + " - " + b + " = " + hasil);
                        Console.WriteLine(" ");
                        Console.WriteLine("Tekan sembarang key untuk keluar");
                        break;

                    case 3:
                        hasil = a * b;
                        Console.WriteLine("hasil penambahan = " + a + " x " + b + " = " + hasil);
                        Console.WriteLine(" ");
                        Console.WriteLine("Tekan sembarang key untuk keluar");
                        break;

                    case 4:
                        hasil = a / b;
                        Console.WriteLine("hasil penambahan = " + a + " / " + b + " = " + hasil);
                        Console.WriteLine(" ");
                        Console.WriteLine("Tekan sembarang key untuk keluar");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Maaf, menu yang anda pilih tidak tersedia");
                Console.WriteLine(" ");
                Console.WriteLine("Tekan sembarang key untuk keluar");
            }

            Console.ReadLine();

        }
    }
}
