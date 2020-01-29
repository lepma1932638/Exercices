using System;
using System.Collections.Generic;
using System.Text;

namespace Les_justiciés_masqués
{
    class Candidat
    {
        private string surnom;
        private string nom;
        private string pouvoir;
        private bool estSelectionne;

        public string GetSurnom()
        {
            return surnom;
        }
        public string GetNom()
        {
            return nom;
        }

        public string GetPouvoir()
        {
            return pouvoir;
        }
        public void Initialiser(string surnom, string nom, string pouvoir)
        {
            this.surnom = surnom;
            this.nom = nom;
            this.pouvoir = pouvoir;
        }

        public void Afficher()
        {
            Console.WriteLine("Surnom         :        " + surnom);
            Console.WriteLine("Nom            :        " + nom);
            Console.WriteLine("Super-Pouvoir  :        " + pouvoir);
        }
        public void Accepter()
        {
            estSelectionne = true;
        }

        public void Refuser()
        {
            estSelectionne = false;
        }

        public bool EstSelectionne()
        {
            return estSelectionne;
        }
    }
}
