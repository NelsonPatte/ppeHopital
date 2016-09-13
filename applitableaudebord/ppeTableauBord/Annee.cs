﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ppeTableauBord
{
    class Annee
    {
        Int32 id;
        String libelle;

        public Annee (Int32 pId, String pLibelle)
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
        public override string ToString()
        {
            return id + " " + libelle;
        }
        
    }
}
