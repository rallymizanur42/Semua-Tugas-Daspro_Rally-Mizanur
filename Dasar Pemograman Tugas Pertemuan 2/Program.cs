using System;

namespace daspro
{
    class Program
    {
        
        //main method berfungsi sebagai pintu masuk program 
        static void Main(string[] args)
        {
            //deklarasi variabel
            int KodeA;
            int kodeB;
            int KodeC;
            int jumlahkode;
            int hasiltambah;
            int hasilkali;
            //string untuk input 
            String tebakanA;
            String tebakanB;
            String tebakanC;
            
            //inialisasi variabel
            KodeA = 1;
            kodeB = 2;
            KodeC = 3;
            jumlahkode = 3;
            hasiltambah = KodeA+kodeB+KodeC;
            hasilkali = KodeA*kodeB*KodeC;
            //intro
            Console.WriteLine("anda adalah agen rahasi yang bertugas mendapatkan data dari server....");
            Console.WriteLine("akses ke server membutuhkan password yang tidak diketahui...");
            Console.WriteLine("password terdiri dari"+jumlahkode+ "angka");
            Console.WriteLine("jika di tambah hasilnya"+hasiltambah);
            Console.WriteLine("jika di kali hasilnya"+hasilkali);
            
            //input user
           
            Console.Write("masukkan kode 1 : ");
            tebakanA = Console.ReadLine();
            Console.Write("masukkan kode 2 : ");
            tebakanB = Console.ReadLine();
            Console.Write("masukkan kode 3 : ");
            tebakanC = Console.ReadLine();
            Console.WriteLine("menunggu inputan"+tebakanA+" "+tebakanB+" "+tebakanC+" ?");

            if(tebakanA == KodeA.ToString() && tebakanB == kodeB.ToString() && tebakanC == KodeC.ToString())
            {
                Console.WriteLine("tebakan anda benar cuy!");
            }else{
                Console.WriteLine("tebakan anda salah hahahahah!");
           }
        }
    }
}