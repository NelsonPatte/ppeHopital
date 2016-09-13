using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ppeTableauBord
{
    class Pourcentage
    {
        private Int32 id;
        private Int32 taux;
        private Mois unMois;
        private Annee uneAnnee;

        public Pourcentage(Int32 pId, Int32 pTaux, Mois pUnMois, Annee pUneAnnee)
        {
            id = pId;
            taux = pTaux;
            unMois = pUnMois;
            uneAnnee = pUneAnnee;
        }
        public Int32 getId()
        {
            return id;
        }
        public Int32 getTaux()
        {
            return taux;
        }
        public override string ToString()
        {
            string aAfficher= id+" "+taux+" "+unMois.ToString()+" "+uneAnnee.ToString();

            return aAfficher;
        }
        public string getleMois()
        {
            return unMois.getLibelle();
        }
        public string getlAnnee()
        {
            return uneAnnee.getLibelle();
        }
    }
}
