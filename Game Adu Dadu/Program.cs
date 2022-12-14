using System;

namespace daspro
{
    class daspro
    {
        static void Main(string[] args)
        {
            intro();
            pengulangan();
            logikaplaygame();
            outro();
        }

        static void intro()
        {
            Console.WriteLine("GAME DADU");
            Console.WriteLine("PERMAINAN C# DASAR");
            Console.WriteLine("PERMAINAN INI DI MULAI OLEH KOMPUTER LALU PELAYER");
            Console.WriteLine("SILAHKAN TEKAN APA SAJA UNTUK MEMULAI");
            Console.ReadKey();
        }
        static int pengulangan()
        {
            Random pengulangan = new Random();
            int rng = pengulangan.Next(1,7);
            return rng;
        }
        static void logikaplaygame()
        {
            int player;
            int komputer;
            int ronde = 0;
            int komputerpoint= 0;
            int playerpoint= 0;

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("TEKAN ENTER UNTUK MEMULAI PERMAINAN");
                Console.WriteLine("-----------------------------------");
                Console.ReadKey();
                ronde++;
                Console.WriteLine("Jumlah ronde : "+ ronde);

                Console.WriteLine("Giliran Komputer memutar dadu");
                komputer = pengulangan();
                System.Threading.Thread.Sleep(500);
                Console.Write(".....");
                Console.Write("\b\b\b\b\b");
                Console.WriteLine("Komputer mendapakkan Dadu : "+komputer);
                Console.ReadKey();

                Console.WriteLine("Giliran Player memutar dadu");
                player = pengulangan();
                System.Threading.Thread.Sleep(500);
                Console.Write(".....");
                Console.Write("\b\b\b\b\b");
                Console.WriteLine("Player mendapakkan Dadu : "+player);

                if(player > komputer)
                {
                    playerpoint++;
                    Console.WriteLine("Player memenangkan permainan");
                }
                else if(player < komputer)
                {
                    komputerpoint++;
                    Console.WriteLine("Komputer menang");
                }
                else
                {
                    Console.WriteLine("Seri");
                }
                Console.WriteLine("Point Player : "+ playerpoint +"|| Point Komputer :"+ komputerpoint+".");
            }

            if(playerpoint > komputerpoint)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Player Menang");
                Console.WriteLine("-----------------------------------");
            }
            else if(playerpoint < komputerpoint)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Komputer Menang");
                Console.WriteLine("-----------------------------------");
            }
            
        }
        static void outro()
            {
                Console.WriteLine("Tekan mana saja untuk melihat krator game dadu sederhana ini");
                Console.ReadKey();
                Console.WriteLine(".............................................................");
                Console.WriteLine("Nama : Rally mizanur");
                Console.WriteLine("NIM  : 2207111392");
                Console.WriteLine("Kelas: Teknik Informatika-A");
                Console.WriteLine(".............................................................");
                Console.ReadKey();
            }        
    }

}
