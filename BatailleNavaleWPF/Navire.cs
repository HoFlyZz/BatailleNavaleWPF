using System;

namespace BatailleNavale
{
    public abstract class Navire : INaivre
    {
        public int Longeur { get; }

        public bool Coule { get => EstCoule(); }

        public Case[] cases;

        //Constructeur de Navire Reçois la longeur et la postion d'un Navire
        public Navire (int longeur , Case[] carres)
        {
            Longeur = longeur;

            cases = carres;

            foreach (Case carre in cases)
            {
                carre.Navire = this;
            }
        }

        public bool EstCoule()
        {
            foreach (Case carre in cases)
            {
                if (!carre.Touche) return false;
            }
            return true;
        }
    }
}
