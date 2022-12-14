using System;

namespace SoalUts2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Jawaban = 0;
            Random rng = new Random();
            int cek = rng.Next(1, 101);
            while(Jawaban != cek)
            {
                Console.Write("Tebak Angka Antara 1-100 : ");
                Jawaban = Convert.ToInt32(Console.ReadLine());
                if (Jawaban < cek)
                {
                    Console.WriteLine("Salah. Nilai terlalu rendah.");
                }
                else if (Jawaban > cek)
                {
                    Console.WriteLine("Salah, Nilai terlalu tinggi.");
                }
                else
                {
                    Console.WriteLine("Anda Benar!");
                    Console.ReadKey();
                }
            }
        }
    }
}
