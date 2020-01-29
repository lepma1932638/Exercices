using System;
using System.Collections.Generic;
using System.Text;

namespace La_reconstruction
{
    class Batiment
    {
        public enum TypeBatiment {RESIDENTIEL, COMMERCIAL, INDUSTRIEL}; // On le met en public, car dans le main nous l'utilisons pour attribuer un type au batiment
        private string nom;
        private int nbPieces;
        private int prixConstruction;
        private int largeur;
        private int longueur;
        private TypeBatiment typeBatiment;

        public string GetNom()
        {
            return nom;
        }

        public int GetNbPieces()
        {
            return nbPieces;
        }

        public int GetPriConstruction()
        {
            return prixConstruction;
        }

        public int GetLargeur()
        {
            return largeur;
        }

        public int GetLongueur()
        {
            return longueur;
        }

        public TypeBatiment GetTypeBatiment()
        {
            return typeBatiment;
        }

        public void Initialiser(string nom, int nbPieces, int prixConstruction, int largeur, int longueur, TypeBatiment typeBatiment) // Si nous ne voulons pas passer par le this, nous pouvons créer en parametre une nouvelle variables avec un _ devant et faire nom = _nom
        {
            this.nom = nom;
            this.nbPieces = nbPieces;
            this.prixConstruction = prixConstruction;
            this.largeur = largeur;
            this.longueur = longueur;
            this.typeBatiment = typeBatiment;
        }

        public void Afficher()
        {
            Console.WriteLine(nom + "(" + typeBatiment + ")" + " --> " + nbPieces + "P/" + prixConstruction + "$/" + CalculerSurface() + "m2");
        }

        private int CalculerSurface() // Ce void est en private, car le main, n'a pas besoin d'y accèder, on en a seulement besoin à l'interne de la classe
        {
            int surface = 0;

            surface = largeur * longueur;

            return surface;
        }
    }
}
