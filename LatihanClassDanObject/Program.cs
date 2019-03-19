using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClassDanObject
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek dari class Mahasiswa
            Mahasiswa saya = new Mahasiswa();
            Mahasiswa kamu = new Mahasiswa();

            // mengeset nilai properties objek saya dan kamu
            saya.Nim = "18.11.2291";
            saya.Nama = "Dewi Cantik";
            saya.Ipk = 3.58f;

            kamu.Nim = "18.11.2292";
            kamu.Nama = "Ledi";
            kamu.Ipk = 3.99f;

            // memanggil method registrasi dan isi krs
            saya.Registrasi();
            saya.IsiKrs();

            kamu.Registrasi();
            kamu.IsiKrs();

            Console.ReadKey(); 

        }
    }
}
