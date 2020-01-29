using System;

namespace La_reconstruction
{
    class Program
    {
        static void Main(string[] args)
        {
            Batiment[] rue1 = new Batiment[3]; // Un tableau contenant 3 cases
            Batiment[] rue2 = new Batiment[2]; // Un tableau contenant 2 cases

            /* Batiment batiment1 = new Batiment();
               Batiment batiment2 = new Batiment();
               Batiment batiment3 = new Batiment();
               Batiment batiment4 = new Batiment();
               Batiment batiment5 = new Batiment(); 
               
             batiment1.Initialiser("Maison Stéphane", 4, 50000, 60, 50, Batiment.TypeBatiment.RESIDENTIEL);
             rue1[0] = batiment1;
             
             */ // Pas obligatoire, car on s'en fou de savoir qu'elle est le nom du batiment, on fait juste en associer un à une pos du tab

            // CRÉATION DES BATIMENTS SUR LA RUE #3

            rue1[0] = new Batiment();
            rue1[0].Initialiser("Maison Stéphane", 4, 50000, 60, 50, Batiment.TypeBatiment.RESIDENTIEL); // Le batiment, au lieux de s'appeller batiment1, il s'appel le nom du tab avec la pos

            rue1[1] = new Batiment();
            rue1[1].Initialiser("PlatineInc", 20, 250000, 180, 90, Batiment.TypeBatiment.COMMERCIAL);

            rue1[2] = new Batiment();
            rue1[2].Initialiser("Maison Bob", 6, 80000, 90, 50, Batiment.TypeBatiment.RESIDENTIEL);

            // CRÉATION DES BATIMENTS SUR LA RUE #2

            rue2[0] = new Batiment();
            rue2[0].Initialiser("HollyWood Resto", 12, 120000, 80, 70, Batiment.TypeBatiment.COMMERCIAL);

            rue2[1] = new Batiment();
            rue2[1].Initialiser("Alcan", 112, 1150000, 220, 330, Batiment.TypeBatiment.INDUSTRIEL);

            AfficherRue1(rue1);
            AfficherRue2(rue2);
        }

        static void AfficherRue1(Batiment[] rue1) // Je peux lui donner le nom que je veux a rue1, mais je dois changer le rue1 dans le foreach si je fais sa
        {
            Console.WriteLine("\nAfficher rue, méthode #1");
            foreach (Batiment building in rue1)
            {
                building.Afficher(); // Ici building fait référence à tous les batiments des rues que leur nom sont ex: rue1[0]
            }
        }

        static void AfficherRue2(Batiment[] rue2)
        {
            Console.WriteLine("\nAfficher rue, méthode #1");
            foreach (Batiment building in rue2)
            {
                Console.WriteLine(building.GetNom() + " (" + building.GetTypeBatiment() + ")");
            }
        }
    }
}
