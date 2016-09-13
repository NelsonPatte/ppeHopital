using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ppeTableauBord
{
    class Passerelle
    {
        private static SqlConnection laConnection = null;
        private static bool seConnecter()
        {
            if (laConnection == null)
            {
                laConnection = new SqlConnection();
                laConnection.ConnectionString = "Data source=win-921c8fktgae; Initial Catalog=HopitalDepraetePatte; User ID=patte;Password=patte";
                laConnection.Open();
                System.Diagnostics.Debug.WriteLine("instanciation connexion");

            }
            else
            {
                System.Diagnostics.Debug.WriteLine("connexion existe");
            }
            return true;
        }

        public static bool seDeconnecter()
        {
            if (laConnection != null)
            {
                laConnection.Close();
                System.Diagnostics.Debug.WriteLine(laConnection.State);
                laConnection = null;
                System.Diagnostics.Debug.WriteLine("deconnexion");
            }
            return true;
        }
        public static List<Pourcentage> donnerLesPourcentages(Int32 nb)
        {
            List<Pourcentage> desPourcentages = new List<Pourcentage>();
            seConnecter();
            SqlCommand maCommande;
            string requete = "select pourcentage.id,pourcentage.taux ,annee.idAnnee,annee.libelleAnnee,mois.idMois,mois.libelleMois from pourcentage inner join mois on pourcentage.idMois=mois.idMois inner Join annee on pourcentage.idAnnee=annee.idAnnee where libelleAnnee = "+nb;
            maCommande = new SqlCommand(requete, laConnection);
            SqlDataReader unJeuResultat = maCommande.ExecuteReader();
            while (unJeuResultat.Read())
            {
                       // Annee
                Int32 idAnnee = (Int32)unJeuResultat["idAnnee"];
                string libelleAnnee = (string)unJeuResultat["libelleAnnee"];
                Annee uneAnnee = new Annee(idAnnee, libelleAnnee);
                        //Mois
                Int32 idMois = (Int32)unJeuResultat["idMois"];
                string libelleMois = (string)unJeuResultat["libelleMois"];
                Mois unMois = new Mois(idMois, libelleMois);
                        //Pourcentage
                Int32 idPourcentage = (Int32)unJeuResultat["id"];
                Int32 tauxPourcentage = (Int32)unJeuResultat["taux"];
                desPourcentages.Add(new Pourcentage(idPourcentage, tauxPourcentage,unMois,uneAnnee));
            }
            return (desPourcentages);
        }
    }
}
