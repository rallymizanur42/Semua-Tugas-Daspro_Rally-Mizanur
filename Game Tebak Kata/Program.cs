using System;
using System.Collections.Generic;
    namespace GameTebakKata
    {  
        class program
        {
            static string katamisteri= "spiderman";
            static int kesempatan = 5;
            static List<string> huruftebakan = new List<string>{};
            static void Main(string[] args)
            {
                intro();
                playgame();
                outro();
            }

            static void intro()
            {
                Console.WriteLine("Selamat datang, hari ini kita akan bermain tebak kata");
                Console.WriteLine($"Kamu memiliki {kesempatan} kesempatan untuk menebak kata misteri ini");
                Console.WriteLine("petunjuk adalahak kata ini merupakan nama film");
                Console.WriteLine($"kata ini terdiri dari kata {katamisteri.Length} karakter");
                Console.WriteLine("file apakah yang dapat di eksekusi");
            }

             static bool cekjawaban(string katarahasia, List<string> list)
            {
                bool status = false;
                for (int i = 0; i < katarahasia.Length; i++)
                {
                    string c = Convert.ToString(katarahasia[i]);
                    if (list.Contains(c))
                    {
                        status = true;
                    }
                    else
                        return status = false;
                    
                }
                return status;
            }
            static string cekhuruf(string katarahasia, List<string> list)
            {
                string x = "";
                for (int i = 0; i < katarahasia.Length; i++)
                {
                    string c = Convert.ToString(katarahasia[i]);
                    if (list.Contains(c))
                    {
                        x = x + c;
                    }
                    else
                    {
                        x =  x + "_";
                    }
                }
                    return x;
            }
            static void playgame()
            {
                while (kesempatan > 0)
                {
                    Console.WriteLine("apa krakter tebakanmu? (a-z) : ");
                    string input = Console.ReadLine();
                    huruftebakan.Add(input);
                    if(cekjawaban(katamisteri, huruftebakan))
                    {
                        Console.WriteLine("selamat anda berhasil");
                        Console.WriteLine($"kata misteri hari ini adalah : {katamisteri}");
                        Console.WriteLine("Silahkan Coba tebak kata lainnya !");
                        break;    
                    }
                    else if(katamisteri.Contains(input))
                    {
                        Console.WriteLine("huruf itu ada dalam kata ini");
                        Console.Write("silahkan tebak huruf lainnya....");
                        Console.WriteLine(cekhuruf(katamisteri,huruftebakan));
                    }
                    else
                    {
                        Console.WriteLine("huruf itu tidak ada dalam tebakan kata ini");
                        kesempatan--;
                        Console.WriteLine($"sisa kesempatan anda adalah : {kesempatan}");
                    }

                }
            }
            static void outro()
            {
                if(kesempatan==0)
                {
                    Console.WriteLine("maaf kesempatan anda telah habis");
                    Console.WriteLine($"kata misteri yang dimaksud adalah : {katamisteri}");
                    Console.WriteLine("terima kasih telah memainkan game...");
                    Console.WriteLine("silahkan coba tebak kata lainnya !");
                }
            }
        }

    }
