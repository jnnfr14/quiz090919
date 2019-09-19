using System;

namespace QUIZ090919
{
    class BangunDatar{
        public void LuasPersegi()
        {
            Console.WriteLine("Menghitung Luas Persegi");


            int sisi;
            Console.Write("Masukan nilai sisi : ");
            sisi = Convert.ToInt32(Console.ReadLine());

            int luas = sisi * sisi;

            Console.WriteLine("Luas Persegi adalah "+luas);
        }

        public void LuasLingkaran()
        {
            Console.WriteLine("Menghitung Luas Lingkaran");
            
            const double phi = 3.14;
            double luas;
            int jarijari ;

            Console.Write("Masukan nilai jari-jari : ");
            jarijari = Convert.ToInt32(Console.ReadLine());


            luas = jarijari * jarijari * phi;

            Console.WriteLine("Luas Lingkaran adalah "+luas);
        }


        public void LuasSegitiga()
        {
            Console.WriteLine("Menghitung Luas Segitiga");

            int alas, tinggi;

            Console.Write("Masukan nilai alas : ");
            alas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukan nilai tinggi : ");
            tinggi = Convert.ToInt32(Console.ReadLine());

            int luas = alas * tinggi / 2;

            Console.WriteLine("Luas Segitiga adalah "+luas);
        }
        public void BangunRuang()
        {
            BangunRuang obj = new BangunRuang();

            obj.VolumeBalok();
            Console.WriteLine("-------------------------");

            obj.VolumeKubus();
        }
    }
}