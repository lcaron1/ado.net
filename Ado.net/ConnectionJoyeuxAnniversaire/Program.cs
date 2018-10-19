using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;



namespace JoyeuxAnniversaire
{
    class Program
    {
        static void Main(string[] args)
        {
            TableAnniversaire ta = new TableAnniversaire();
            /*int comptage = ta.CompteOccurences();
            Console.WriteLine(comptage);
            Console.WriteLine("quelle annee ?");
            int annee = Convert.ToInt32(Console.ReadLine());
            int comptageAnnee = ta.CompteOccurences(annee);
            Console.WriteLine("il y a {0} anniversaire cette annee",comptageAnnee);
            Console.WriteLine("donner les trois premiere lettre du nom : ");
            string lettreNom = Convert.ToString(Console.ReadLine());
            List<Anniversaire> anniv = new List<Anniversaire>(ta.leNomPatronymeCommencePar(lettreNom));
            
            foreach (Anniversaire s in anniv)
            {

                Console.WriteLine(s.ToString());

            }
            Console.WriteLine("donner un jour : ");
            int jour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("donner un mois : ");
            int mois = Convert.ToInt32(Console.ReadLine());
            List<Anniversaire> anniv2 = new List<Anniversaire>(ta.QuiEstNeCeJour(jour, mois));
            foreach (Anniversaire s in anniv2)
            {
                Console.WriteLine(s.ToString());
            }

            Console.WriteLine("donner un age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            List<Anniversaire> anniv3 = new List<Anniversaire>(ta.PLusAgesQue(age));
            foreach (Anniversaire s in anniv3)
            {
                Console.WriteLine(s.ToString());
            }*/
            Console.WriteLine("date Anniversaire : ");
            DateTime dateAnniversaire = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Prenom : ");
            string Prenom = Convert.ToString(Console.ReadLine());
            Console.WriteLine("nom : ");
            string nom = Convert.ToString(Console.ReadLine());
            Console.WriteLine("prenom pseudonyme : ");
            string PrenomPseudonyme = Convert.ToString(Console.ReadLine());
            Console.WriteLine("nom pseudonyme: ");
            string nomPseudonyme = Convert.ToString(Console.ReadLine());
            Anniversaire annivFinal = new Anniversaire( dateAnniversaire, Prenom, nom, PrenomPseudonyme, nomPseudonyme);
            

            Console.ReadLine();
        }
        
    }
}
