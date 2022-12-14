using System;
using System.Text;
using System.IO;
using System.Collections.Generic;

namespace SoalUts1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nama             : ");
            String Nama = Console.ReadLine();
            Console.WriteLine("NIM              : ");
            String NIM = Console.ReadLine();
            Console.WriteLine("Konsentrasi      : ");
            String Konsentrasi = Console.ReadLine().ToUpper();

            Console.WriteLine("|********************************|");
            Console.WriteLine("{0, -8} {1, 25}","|Nama : ",Nama+"|");
            Console.WriteLine("{0, -16} {1, 17}","|",NIM+"|");
            Console.WriteLine("|--------------------------------|");
            Console.WriteLine("{0, -16} {1, 17}","|",Konsentrasi+"|");
            Console.WriteLine("|********************************|");
        }

    }
}