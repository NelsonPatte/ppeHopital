using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ppeTableauBord
{
    class Mois
    {
        Int32 id;
        String libelle;

        public Mois(Int32 pId, String pLibelle)
        {
            id = pId;
            libelle = pLibelle;
        }
        public Int32 getId()
        {
            return id;
        }
        public String getLibelle()
        {
            return libelle;
        }
        public override String ToString()
        {
            return id + " " + libelle;
        }
    }
}
