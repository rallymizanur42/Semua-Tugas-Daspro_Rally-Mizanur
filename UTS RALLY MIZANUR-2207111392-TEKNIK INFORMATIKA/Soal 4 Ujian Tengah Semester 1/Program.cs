using System;

namespace SoalUts4
{
    class Program
    {
        static void Main(string[] args)
        {
            char InputPlayer =' ';
            int SkorLose = 0;
            int SkorSeri = 0;
            int SkorWin = 0;
            Random rng = new Random();
            

            while (InputPlayer != 'E')
            {
                Console.Write("[b]atu, [g]unting, [k]ertas, or [e]xit : ");
                InputPlayer = Convert.ToChar(Console.ReadLine());
                if (InputPlayer == 'e' )
                {
                    Console.WriteLine("Exit");
                    break;
                }
                int komputer = rng.Next(1,4);

                if (InputPlayer == 'b')
                {
                    if (komputer == 1)
                    {
                        Console.WriteLine("Komputer Memilih Batu");
                        Console.WriteLine("Seri");
                        SkorSeri++;
                    }
                    else if (komputer == 2)
                    {
                        Console.WriteLine("Komputer Memilih Gunting");
                        Console.WriteLine("Menang");
                        SkorWin++;   
                    }
                    else if (komputer == 3)
                    {
                        Console.WriteLine("Komputer Memilih Kertas");
                        Console.WriteLine("Kalah");
                        SkorLose++;   
                    }
                }
                else if (InputPlayer == 'g')
                {
                    if (komputer == 1)
                    {
                        Console.WriteLine("Komputer Memilih Batu");
                        Console.WriteLine("Kalah");
                        SkorLose++;
                    }
                    else if (komputer == 2)
                    {
                        Console.WriteLine("Komputer Memilih Gunting");
                        Console.WriteLine("Seri");
                        SkorSeri++;   
                    }
                    else if (komputer == 3)
                    {
                        Console.WriteLine("Komputer Memilih Kertas");
                        Console.WriteLine("Menang");
                        SkorWin++;   
                    }
                }    
                else if (InputPlayer == 'k')
                {
                    if (komputer == 1)
                    {
                        Console.WriteLine("Komputer Memilih Batu");
                        Console.WriteLine("Menang");
                        SkorWin++;
                    }
                    else if (komputer == 2)
                    {
                        Console.WriteLine("Komputer Memilih Gunting");
                        Console.WriteLine("Kalah");
                        SkorLose++;
                    }
                    else if (komputer == 3)
                    {
                        Console.WriteLine("Komputer Memilih Kertas");
                        Console.WriteLine("Seri");
                        SkorSeri++;
                    }
                }
                Console.WriteLine("Skor :"+SkorWin+" Menang, "+SkorLose+" Kalah, "+SkorSeri+" Seri");
                Console.WriteLine("Tekan enter untuk melanjutkan....");
                Console.ReadKey();
                Console.Clear();
            }

                
        }

    }
}

