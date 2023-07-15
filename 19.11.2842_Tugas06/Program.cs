using System;

namespace _19._11._2842_Tugas06
{
    class Program
    {
        static void Main(string[] args)
        {
            Orang orang1 = new Orang("Muhammad Farhan Anggara", 28, "Jl.Sawo No.197");
            orang1.TampilanInfo();

            Orang orang2 = new Orang("Eky Sumaikik", 15, "Jl.SanaSini No.80");
            orang2.UpdateInfo();

            Console.ReadKey();
        }
    }
}
