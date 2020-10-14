using System;

namespace prov
{
    class Program
    {
        static void Main(string[] args)
        {
            int coord = 0;
            int coord2 = 4;
            string shot = "";
            bool hit = false;

            Console.WriteLine("Du ska nu få spela en del av spelet sänka skäpp.");

            Console.WriteLine("Du kommer få gissa på en koordinat i x ledet för att sänka skäppet.");

            Console.WriteLine("Vilken koordinat vill du gissa på?");

            while (hit != true)
            {
                shot = Console.ReadLine();
                hit = int.TryParse(shot, out coord);

                if (coord > 10)
                    Console.WriteLine("Det var lite för stort.");

                if (hit != true)
                    Console.WriteLine("Nä, nu skrev du något tokigt");
            }

            while (coord != 4)
            {
                shot = Console.ReadLine();

                if (coord <= 10)
                    Console.WriteLine("Miss");

                if (coord >= 10)
                    Console.WriteLine("Det är fortfarande för stort.");

                if (coord == 5 && coord == 3)
                    Console.WriteLine("Near miss");
            }

            if (coord == 4)
                Console.WriteLine("Hit");

            Console.ReadLine();
        }
    }
}
