using System;

namespace QUIZ090919
{
    class BangunRuang
    {
        public void VolumeBalok()
        {

            int panjang, lebar, tinggi, volume;

            Console.WriteLine("Menghitung Volume Balok");

            Console.Write("Masukan Nilai Panjang : ");
            panjang = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukan Nilai Lebar : ");
            lebar = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukan Nilai Tinggi : ");
            tinggi = Convert.ToInt32(Console.ReadLine());


            volume = panjang * lebar * tinggi ;


            Console.WriteLine("Volume Balok Adalah "+volume);
        }
        public void VolumeKubus()
        {
            int sisi ;

            Console.WriteLine("Menghitung Volume Kubus");

            Console.Write("Masukan Nilai sisi : ");
            sisi = Convert.ToInt32(Console.ReadLine());

            int volume = sisi * sisi * sisi ;

            Console.WriteLine("Volume Kubus adalah "+volume);
        }
    }
}