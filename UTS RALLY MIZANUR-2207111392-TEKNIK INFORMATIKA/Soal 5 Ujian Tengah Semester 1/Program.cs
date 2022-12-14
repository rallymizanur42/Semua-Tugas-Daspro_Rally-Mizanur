using System;

namespace Fix
{
    class Program
    {
        static bool GameBerakhir;
        static int x, y, turn, count, current, stateEnd;
        static char[] xo = new char[9];
        static int[,] posxo = new int[9,2];
        static string MAP = "";
        static Random rng = new Random();

        static void Main(string[] args)
        {
            Init();

            while(count <= xo.Length)
            {
                Console.Clear();

                int cxo = Cekxo();
                if(cxo != -1)
                {
                    stateEnd = cxo;
                    GameBerakhir = true;
                }

                if(GameBerakhir)
                {
                    GambarMap();
                    if(stateEnd == 1)
                        System.Console.WriteLine("Anda Kalah.");
                    else if(stateEnd == 2)
                        System.Console.WriteLine("Anda Menang.");
                    else if(stateEnd == 0)
                        System.Console.WriteLine("Seri.");
                    Console.WriteLine("Main lagi [y], atau keluar [n]?");
                    var key = Console.ReadKey();
                    if(key.Key == ConsoleKey.Y)
                    {
                        Init();
                    }
                    else if(key.Key == ConsoleKey.N)
                    {
                        break;
                    }
                }
                else if(!GameBerakhir)
                {
                    GambarMap();
                    Console.Write("\nPilih posisi lalu tekan Enter.");
                    updatecurrent();
                    Console.SetCursorPosition(x, y);
                    if(turn == 0)
                    {
                        var kunci = Console.ReadKey();
                        if(kunci.Key == ConsoleKey.UpArrow || kunci.Key == ConsoleKey.W)
                        {
                            if(current > 2)
                                current -= 3;
                        }
                        else if(kunci.Key == ConsoleKey.DownArrow || kunci.Key == ConsoleKey.S)
                        {
                            if(current < 6)
                                current += 3;
                        }
                        else if(kunci.Key == ConsoleKey.LeftArrow || kunci.Key == ConsoleKey.A)
                        {
                            if(current > 0)
                                current--;
                        }
                        else if(kunci.Key == ConsoleKey.RightArrow || kunci.Key == ConsoleKey.D)
                        {
                            if(current < 8)
                                current++;
                        }
                        else if(kunci.Key == ConsoleKey.Enter)
                        {
                            if(xo[current] == ' ')
                            {
                                xo[current] = 'X';
                                updatecurrent();
                                posxo[current, 0] = x;
                                posxo[current, 1] = y;
                                count++;
                                turn = 1;
                            }
                        }
                    }
                    else
                    {
                        while(turn == 1)
                        {
                            int ch = rng.Next(9);
                            if(xo[ch] == ' ')
                            {
                                xo[ch] = 'O';
                                current = ch;
                                updatecurrent();
                                posxo[current, 0] = x;
                                posxo[current, 1] = y;
                                count++;
                                turn = 0;
                            }
                        }
                    }
                }
            }
        }

        static void Init()
        {
            GameBerakhir = false;
            x = 0;
            y = 0;
            turn = 0;
            count = 0;
            current = 0;
            stateEnd = -1;
            xo = new char[9];
            for(int i=0; i<9;i++)
                xo[i] = ' ';
            posxo = new int[9,2];
            MAP = "   |     |   \n   |     |   \n___|_____|___\n   |     |   \n   |     |   \n___|_____|___\n   |     |   \n   |     |   \n   |     |   ";
        }

        static int Cekxo()
        {
            bool line = false;
            if(CekLine(0, 1, 2) || CekLine(3, 4, 5) || CekLine(6, 7, 8) || CekLine(0, 3, 6) || CekLine(0, 4, 8) || CekLine(1, 4, 7) || CekLine(2, 5, 8) || CekLine(2, 4, 6))
                line = true;

            if(line)
            {
                if(xo[current] == 'X')
                {
                    return 2;
                }
                else if(xo[current] == 'O')
                {
                    return 1;
                }
            }
            else if(count >= xo.Length)
            {
                return 0;
            }

            return -1;
        }

        static void updatecurrent()
        {
            switch(current)
            {
                case 0:
                y = 0; x = 0;
                break;
                case 1:
                y = 0; x = 6;
                break;
                case 2:
                y = 0; x = 12;
                break;
                case 3:
                y = 4; x = 0;
                break;
                case 4:
                y = 4; x = 6;
                break;
                case 5:
                y = 4; x = 12;
                break;
                case 6:
                y = 7; x = 0;
                break;
                case 7:
                y = 7; x = 6;
                break;
                case 8:
                y = 7; x = 12;
                break;
            }
        }

        static bool CekLine(int x, int y, int z)
        {
            return (xo[z] == xo[y] && xo[x] == xo[y]) && (current == x || current == y || current == z) && (xo[z] == 'X' || xo[z] == 'O');
        }

        static void GambarMap()
        {
            Console.WriteLine(MAP);
            int X = Console.CursorLeft;
            int Y = Console.CursorTop;

            for(int i=0; i<xo.Length;i++)
            {
                if(xo[i] != ' ')
                {
                    Console.SetCursorPosition(posxo[i,0], posxo[i,1]);
                    Console.Write(xo[i]);
                }
            }

            Console.SetCursorPosition(X, Y);
        }
    }
}