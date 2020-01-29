using System;

namespace BatSignal
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] deplacement = new double[] { 3, 2.5, 2, 1.5, 1 };
            double[] descente = new double[] { 8.5, 5.5, 4, 2, 1.5 };

            double hauteurMin = 50;
            double hauteur = 445;
            double distance = 168;

            analyserBatParkour(ref deplacement, ref descente, ref distance, ref hauteurMin, ref hauteur);
        }

        static void analyserBatParkour(ref double[] deplacement, ref double[] descente, ref double distance, ref double hauteurMin, ref double hauteur)
        {
            

            for (int i = 0; i < deplacement.Length; i++)
            {
                double distanceCourante = 0;
                double duree = 0;
                hauteur = 445;
                distance = 168; 

                Console.WriteLine("Voici la possibilité #" + (i + 1));
                Console.WriteLine("Vitesse de deplacement: " + deplacement[i] + "\nVitesse de descente: " + descente[i] + "\nDistance: " + distance + "\nHauteur:" + hauteur + "\nHauteur du toit: " + hauteurMin);
                while(distanceCourante < distance)
                {
                    duree++;
                    distanceCourante += deplacement[i];
                    hauteur -= descente[i]; 
                }

                Console.WriteLine("Résultat\nDurée: " + duree + "\nDistance: " + distance + "\nHauteur: " + hauteur);

                if(hauteur > hauteurMin + 50)
                {
                    Console.WriteLine("Batman est passer au dessus du GCPD\n");
                }
                else if(hauteur < hauteurMin)
                {
                    Console.WriteLine("Batman s'est écrasé dans le GCPD\n");
                }
                else
                {
                    Console.WriteLine("Batman à atteri sur le toit du GCPD\n");
                }

            }
        }
    }
}
