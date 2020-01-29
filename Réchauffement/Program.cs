using System;

namespace Réchauffement
{
    class Program
    {
        static void Main(string[] args)
        {
            PremierJet();
            DeuxiemeJet();
            TroisiemeJet(2);
            QuatriemeJet(79);
            CinquiemeJet();
        }

        static void PremierJet()
        {
            int resultat = 0;

            De d4 = new De();
            d4.Initialiser(4); // 4 est pour le nombre de face
            d4.LancerDe();
            resultat = d4.GetValeur();
            d4.LancerDe();
            resultat += d4.GetValeur();
            
            resultat += 4;
            Console.WriteLine("(1) " + "2D" + d4.GetNbFaces() + " + 4  = " + resultat);
        }

        static void DeuxiemeJet()
        {
            int resultat = 0;

            De d6 = new De();
            d6.Initialiser(6);
            Console.WriteLine("(2) " + "6 fois 3D" + d6.GetNbFaces());
            for (int i = 0; i < 6; i++)
            {
                d6.LancerDe();
                resultat = d6.GetValeur();
                d6.LancerDe();
                resultat += d6.GetValeur();
                d6.LancerDe();
                resultat += d6.GetValeur();
                Console.WriteLine("> " + resultat);
                resultat = 0;
            }
        }

        static void TroisiemeJet(int force)
        {
            int resultat = 0;

            De d8 = new De();
            d8.Initialiser(8);
            d8.LancerDe();
            resultat = d8.GetValeur();

            resultat += force;
            Console.WriteLine("(3) " + "1D" + d8.GetNbFaces() + " + 2 = " + resultat);

        }

        static void QuatriemeJet(int succes) // Peut monter au dessus de 4
        {
            int resultat = 0;

            De d10 = new De();
            d10.Initialiser(10);
            d10.LancerDe();
            resultat = d10.GetValeur() * 10;
            d10.LancerDe();
            resultat += d10.GetValeur();

            if (resultat < succes)
            {
                Console.WriteLine("(4) " + resultat + " < " + succes);
            }
            else
            {
                Console.WriteLine("(4) " + resultat + " > " + succes);
            }

        }

        static void CinquiemeJet()
        {
            int resultat = 0;
            int nbrLancement = 0;
            bool loop = true;

            De d20 = new De();
            d20.Initialiser(20);
            while (loop == true)
            {
                d20.LancerDe();
                resultat = d20.GetValeur();
                nbrLancement++;
                if (resultat == 1)
                {
                    Console.WriteLine("(5) " + "Nombre de lancement de D" + d20.GetNbFaces() + " : " + nbrLancement);
                    Console.WriteLine("Résultat: " + resultat + " ÉCHEC");
                    loop = false;
                }
                else if (resultat == 20)
                {
                    Console.WriteLine("(5) " + "Nombre de lancement de D" + d20.GetNbFaces() + " : " + nbrLancement);
                    Console.WriteLine("Résultat: " + resultat + " RÉUSSITE");
                    loop = false;
                }
            }



        }
    }
}
