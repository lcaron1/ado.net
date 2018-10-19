using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JoyeuxAnniversaire
{
    class Anniversaire
    {
        private DateTime dateAnniversaire;
        private int id;
        private string nom;
        private string nomPseudonyme;
        private string prenom;
        private string prenomPseudonyme;

        public Anniversaire(int id, DateTime dateAnniversaire, string prenomPseudonyme, string prenom, string nomPseudonyme, string nom)
        {
            this.id = id;
            this.nom = nom;
            this.nomPseudonyme = nomPseudonyme;
            this.prenom = prenom;
            this.prenomPseudonyme = prenomPseudonyme;
            this.dateAnniversaire = dateAnniversaire;
        }
        public Anniversaire(DateTime dateAnniversaire, string prenomPseudonyme, string prenom, string nom, string nomPseudonyme)
        {

            this.nom = nom;
            this.nomPseudonyme = nomPseudonyme;
            this.prenom = prenom;
            this.prenomPseudonyme = prenomPseudonyme;
            this.dateAnniversaire = dateAnniversaire;
        }
        public string ToString()
        {
            return string.Format("Id : {0} , date Anniversaire : {1},prenom pseudonyme : {2} ,prenom : {3}, nom  : {4}, nom Pseudonyme : {5}",this.id, this.dateAnniversaire, this.prenomPseudonyme, this.prenom, this.nom, this.nomPseudonyme);
        }
        public DateTime DateAnniversaire
        {
            get
            {
                return this.dateAnniversaire;
            }
        }
        public int Id
        {
            get
            {
                return this.id;
            }
        }
        public string Nom
        {
            get
            {
                return this.nom;
            }
        }
        public string Prenom
        {
            get
            {
                return this.prenom;
            }
        }
        public string NomPseudonyme
        {
            get
            {
                return this.nomPseudonyme;
            }
        }
        public string PrenomPseudonyme
        {
            get
            {
                return this.prenomPseudonyme;
            }
        }

    }
}
