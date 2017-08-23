using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pengamatan5
{
    class Program
    {
        static void baca(string fname)
        {
            StreamReader sr = new StreamReader(fname);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("");
            sr.Close();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Masukan nama file teks: ");
            string fname = Console.ReadLine();
            baca(fname);
            Console.WriteLine("Untuk berhenti tekan \"Esc\", untuk melanjutkan tekan tombol lainnya");
            ConsoleKeyInfo cki = Console.ReadKey();
            while(cki.Key != ConsoleKey.Escape)
            {
                StreamWriter sw = new StreamWriter(fname, true, Encoding.ASCII);
                string NextLine = "ie di tambah";
                string opik;
                Console.Write("Masukan Baris Ke 2 : ");
                opik = Console.ReadLine();              
                sw.WriteLine(NextLine);
                string tampung = opik;
                sw.Write(tampung);
                sw.Close();

                Console.WriteLine("\nBerhasil menambahkan satu baris");
                Console.WriteLine("isi file saat ini : ");
                baca(fname);
                cki = Console.ReadKey();
            }
        }
    }
}
