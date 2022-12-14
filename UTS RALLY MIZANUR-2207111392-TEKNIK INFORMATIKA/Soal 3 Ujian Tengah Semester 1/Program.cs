using System;

namespace SoalUts3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Denda = 0;
            int Hari = 0;
            Console.Write("Jumlah Hari Peminjaman Buku : ");
            Hari = Convert.ToInt32(Console.ReadLine());
            if (Hari > 5 && Hari <=10)
            {
                Denda = (Hari - 5)*10000 ;
                Console.WriteLine("Denda : Rp."+ Denda );
            }
            else if (Hari > 10 && Hari <= 30)
            {
                Denda = (Hari - 10)*20000 + 50000;
                Console.WriteLine("Denda : Rp."+Denda);
            }
            else if (Hari > 30)
            {
                Denda = (Hari - 30)*30000+50000+400000;
                Console.WriteLine("Keanggotaan dibatalkan");
                Console.WriteLine("Denda : Rp."+ Denda);
                
            }
            else
            {
                Console.WriteLine("Tidak ada denda");
            }
            Console.ReadKey();
        }
    }
}
