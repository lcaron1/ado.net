using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;


namespace JoyeuxAnniversaire
{
    static class connectionJoyeuxAnniversaire
    {
        static private MySqlConnection cnx;
        static private string sConnection;

        static connectionJoyeuxAnniversaire()
        {
            sConnection ="host=localhost; database=anniv; user=root; password=siojjr";
            cnx = new MySqlConnection(sConnection);
        }
        static public MySqlConnection GetConnection()
        {
            return cnx;
        }
    }
}
