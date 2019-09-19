using System;

namespace QUIZ090919
{
    class Program
    {
        static void Main(string[] args)
        {
            BangunDatar obj = new BangunDatar();

            obj.LuasPersegi();
            Console.WriteLine("-------------------------");

            obj.LuasLingkaran();
            Console.WriteLine("-------------------------");

            obj.LuasSegitiga();
            Console.WriteLine("-------------------------");

            obj.BangunRuang();

        }
    }
}
