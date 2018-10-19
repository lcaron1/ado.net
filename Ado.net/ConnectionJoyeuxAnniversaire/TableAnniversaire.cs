using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;


namespace JoyeuxAnniversaire
{
    class TableAnniversaire
    {
        private MySqlConnection cnx;
        private MySqlCommand SelectAnniversaire;
        private MySqlCommand cmdSql;

        public TableAnniversaire()
        {
            this.cnx = connectionJoyeuxAnniversaire.GetConnection();
        }
        public int CompteOccurences()
        {
            int comptage = 0;
            this.cnx.Open();
            SelectAnniversaire = new MySqlCommand("Select count(*) from anniversaire", this.cnx);
            comptage = Convert.ToInt32(SelectAnniversaire.ExecuteScalar());
            this.cnx.Close();
            return comptage;

        }
        public int CompteOccurences(int annee)
        {
            int comptage = 0;
            this.cnx.Open();
            MySqlCommand cmdSql = new MySqlCommand("Select count(*) from anniversaire where YEAR(dateAnniversaire) = @annee", this.cnx);
            cmdSql.Parameters.Add(new MySqlParameter("@annee", MySqlDbType.Int32));
            cmdSql.Parameters["@annee"].Value = annee;
            comptage = Convert.ToInt32(cmdSql.ExecuteScalar());
            this.cnx.Close();
            return comptage;
        }
        public void Delete(int id)
        {
        }
        public int Insert(Anniversaire nouvelAnniversaire)
        {
            this.cnx.Open();
            MySqlCommand cmdSql = new MySqlCommand("Insert into Anniversaire (dateAnniversaire,nomPseudonyme, prenomPseudonyme, nom ,prenom) values (@date , @nompseudo ,@prenompseudo , @nom , @prenom)", this.cnx);
            cmdSql.Parameters.Add(new MySqlParameter("@date", MySqlDbType.DateTime));
            cmdSql.Parameters.Add(new MySqlParameter("@nompseudo", MySqlDbType.String));
            cmdSql.Parameters.Add(new MySqlParameter("@prenompseudo", MySqlDbType.String));
            cmdSql.Parameters.Add(new MySqlParameter("@nom", MySqlDbType.String));
            cmdSql.Parameters.Add(new MySqlParameter("@prenom", MySqlDbType.String));
            MySqlDataReader reader = cmdSql.ExecuteNonQuery();

            {
            this.cnx.Close();
            return 0;
            }
        }
        public List<Anniversaire> leNomPatronymeCommencePar(string debutNom)
        {
            List<Anniversaire> annivList = new List<Anniversaire>();
            this.cnx.Open();
            MySqlCommand cmdSql = new MySqlCommand("Select Year(dateAnniversaire),Month(dateAnniversaire),Day(dateAnniversaire), id , prenomPseudonyme, nomPseudonyme ,prenom, nom from anniversaire where nom like @lettreNom", this.cnx);
            cmdSql.Parameters.Add(new MySqlParameter("@lettreNom", MySqlDbType.String));
            cmdSql.Parameters["@lettreNom"].Value = debutNom +"%";
            MySqlDataReader reader = cmdSql.ExecuteReader();
            while (reader.Read())
            {DateTime dateAnniv =new DateTime(Convert.ToInt32(reader.GetValue(0)),Convert.ToInt32(reader.GetValue(1)),Convert.ToInt32(reader.GetValue(2)));
            Anniversaire anniv = new Anniversaire(Convert.ToInt32(reader.GetValue(3)) , dateAnniv, Convert.ToString(reader.GetValue(4)), Convert.ToString(reader.GetValue(5)), Convert.ToString(reader.GetValue(6)), Convert.ToString(reader.GetValue(7)));
                annivList.Add(anniv);

            }

            this.cnx.Close();
            return annivList;
        }

        public List<Anniversaire> PLusAgesQue(int age)
        {
            List<Anniversaire> annivList = new List<Anniversaire>();
            age = DateTime.Now.Year - age;
            this.cnx.Open();
            MySqlCommand cmdSql = new MySqlCommand("Select Year(dateAnniversaire),Month(dateAnniversaire),Day(dateAnniversaire), id , prenomPseudonyme, nomPseudonyme ,prenom, nom from anniversaire where Year(dateAnniversaire) < @age", this.cnx);
            cmdSql.Parameters.Add(new MySqlParameter("@age", MySqlDbType.Int32));
            cmdSql.Parameters["@age"].Value = age;
            MySqlDataReader reader = cmdSql.ExecuteReader();
            while (reader.Read())
            {
                DateTime dateAnniv = new DateTime(Convert.ToInt32(reader.GetValue(0)), Convert.ToInt32(reader.GetValue(1)), Convert.ToInt32(reader.GetValue(2)));
                Anniversaire anniv = new Anniversaire(Convert.ToInt32(reader.GetValue(3)), dateAnniv, Convert.ToString(reader.GetValue(4)), Convert.ToString(reader.GetValue(5)), Convert.ToString(reader.GetValue(6)), Convert.ToString(reader.GetValue(7)));
                annivList.Add(anniv);
            }
            this.cnx.Close();
            return annivList;
        }

        public List<Anniversaire> QuiEstNeCeJour(int jour, int mois)
        {
            List<Anniversaire> annivList = new List<Anniversaire>();
            this.cnx.Open();
            MySqlCommand cmdSql = new MySqlCommand("Select Year(dateAnniversaire),Month(dateAnniversaire),Day(dateAnniversaire), id , prenomPseudonyme, nomPseudonyme ,prenom, nom from anniversaire where Day(dateAnniversaire) = @Intjour and Month(dateAnniversaire) = @Intmois", this.cnx);
            cmdSql.Parameters.Add(new MySqlParameter("@Intjour", MySqlDbType.Int32));
            cmdSql.Parameters["@Intjour"].Value = jour;
            cmdSql.Parameters.Add(new MySqlParameter("@Intmois", MySqlDbType.Int32));
            cmdSql.Parameters["@Intmois"].Value = mois;
            MySqlDataReader reader = cmdSql.ExecuteReader();
            while (reader.Read())
            {
                DateTime dateAnniv = new DateTime(Convert.ToInt32(reader.GetValue(0)), Convert.ToInt32(reader.GetValue(1)), Convert.ToInt32(reader.GetValue(2)));
                Anniversaire anniv = new Anniversaire(Convert.ToInt32(reader.GetValue(3)), dateAnniv, Convert.ToString(reader.GetValue(4)), Convert.ToString(reader.GetValue(5)), Convert.ToString(reader.GetValue(6)), Convert.ToString(reader.GetValue(7)));
                annivList.Add(anniv);

            }
            this.cnx.Close();
            return annivList;
        }
        public List<string> RepartitonAnniversaireParMois()
        {
            return null;
        }
        public void Update(Anniversaire unAnniversaire)
        {
        }
        
    }
}
