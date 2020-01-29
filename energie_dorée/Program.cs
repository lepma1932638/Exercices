using System;

namespace energie_dorée
{
    class Program
    {
        static void Main(string[] args)
        {
            int na = 0;
            int h2o = 0;
            int kr = 0;
            int h2 = 0;
            int oh = 0;
            int na2 = 0;
            int kro3h = 0;

            try
            {
               Console.WriteLine("Na ->");
               na = Convert.ToInt32(Console.ReadLine());
            }

            catch (Exception)
            {
                Console.WriteLine("Entré un nombre");
            }

            try
            {
                Console.WriteLine("H2O ->");
                h2o = Convert.ToInt32(Console.ReadLine());
            }

            catch (Exception)
            {
                Console.WriteLine("Entré un nombre");
            }

            try
            {
                Console.WriteLine("Kr ->");
                kr = Convert.ToInt32(Console.ReadLine());
            }

            catch (Exception)
            {
                Console.WriteLine("Entré un nombre");
            }

            while(na >= 2 && h2o >= 4)
            {
                h2 += 2;
                oh += 4;
                na2 += 2;

                na += -2;
                h2o += -4;
            }

            Console.WriteLine("Réaction Chimique#1:\nNa: " + na + "\nH2O: " + h2o + "\nKr: " + kr + "\nH2: " + h2 +"\nOH: " + oh + "\nNa2" + na2);

            while (oh >= 3 && kr >= 1)
            {
                kro3h += 1;
                h2 += 1;

                oh += -3;
                kr += -1;
            }

            Console.WriteLine("Réaction Chimique#1:\nNa: " + na + "\nH2O: " + h2o + "\nKr: " + kr + "\nH2: " + h2 + "\nOH: " + oh + "\nNa2" + na2 + "\nKrO3H: " + kro3h);





        }
    }
}
