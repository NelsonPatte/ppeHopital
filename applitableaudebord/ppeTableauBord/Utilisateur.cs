using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ppeTableauBord
{
    class Utilisateur
    {
        Int32 id;
        String pseudo;
        String mdp;

        public Utilisateur (Int32 pId, String pPseudo, String pMdp)
        {
            id = pId;
            pseudo = pPseudo;
            mdp = pMdp;

        }
        public Int32 getId()
        {
            return id;
        }
        public String getpseudo()
        {
            return pseudo;
        }
    }
}
