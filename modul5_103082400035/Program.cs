using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace modul5_103082400035
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Berikut adalah pesan pertama");

            Penjumlahan p = new Penjumlahan();

            int a = 12;
            int b = 34;
            int c = 56;

            var hasil = p.JumlahTigaAngka(a, b, c);
            Console.WriteLine("Hasil: " + hasil);
        }
    }
}
