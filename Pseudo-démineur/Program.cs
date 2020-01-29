using System;

namespace Pseudo_démineur
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] map =
            {
                {1, 2, 1, 1, 0},
                {-1, 2, -1, 1, 0},
                {1, 2, 1, 1, 0},
                {1, 1, 1, 0, 0},
                {1, -1, 1, 0, 0}
            };

            AfficherMap(ref map);

        }

        static void AfficherMap(ref int[,] map)
        {
            Console.Clear();
            int y = 0;
            int z = 0;
            for (int i = 0; i < 25; i++)
            {
                if (map[y, z] < 8)
                {
                    Console.Write("*|");
                }
                else
                {
                    if (map[y, z] - 10 == -1)
                    {
                        Console.Write("M|");
                        System.Threading.Thread.Sleep(3000);
                        AfficherFin();
                    }
                    else
                    {
                        Console.Write(map[y, z] - 10 + "|");
                    }
                }
                if (i == 4 || i == 9 || i == 14 || i == 19 || i == 24)
                {
                    y++;
                    z = 0;
                    Console.WriteLine("");
                }
                else
                {
                    z++;
                }
            }
            SaisirPosition(ref map);
        }
        static void SaisirPosition(ref int[,] map)
        {
            int xpos = 0;
            int ypos = 0;

            try
            {
                Console.Write("Saisissez la position X (Horizontal) que vous voulez: ");
                xpos = Convert.ToInt32(Console.ReadLine());
            }

            catch (Exception)
            {
                Console.WriteLine("Entrez un nombre valide");
            }

            try
            {
                Console.Write("Saisissez la position Y (Verticale que vous voulez: ");
                ypos = Convert.ToInt32(Console.ReadLine());
            }

            catch (Exception)
            {
                Console.WriteLine("Entrez un nombre valide");
            }

            map[ypos, xpos] +=10 ;
            AfficherMap(ref map);
        }

        static void AfficherFin()
        {
            Console.Clear();
            Console.WriteLine("Vous avez perdu !");
            System.Threading.Thread.Sleep(3000);
            Environment.Exit(-1);
        }
    }
}
