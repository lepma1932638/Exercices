using System;
using System.Collections.Generic;
using System.Text;

namespace Réchauffement
{
    class De
    {
        private int valeur;
        private int nbFaces;
        private Random generateurNb;

        public int GetValeur()
        {
            return valeur;
        }

        public int GetNbFaces()
        {
            return nbFaces;
        }

        public void Initialiser(int _nbFaces)
        {
            nbFaces = _nbFaces; // Le nombre de face viendras du main
            generateurNb = new Random();
            LancerDe();
        }

        public void LancerDe()
        {
            valeur = generateurNb.Next(1, (nbFaces + 1));
        }
        
    }
}
