using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ListViewToListView
{
    class DatenbankSql
    {
        private MySqlConnection verbindung;
        private MySqlCommand cmd;
        private string cn;

        public DatenbankSql()
        {
            cn = "server=localhost;database=autos; uid=root";
            verbindung = new MySqlConnection(cn);
            
            try
            {
                verbindung.Open();
            }
            catch (Exception)
            {
                throw new Exception("Verbindung konnte nicht geöffnet werden!");
            }
            
        }

        public MySqlDataReader Einlesen(string sql)
        {
            try
            {
                cmd = new MySqlCommand(sql, verbindung);
                return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                throw new Exception("Fehler beim Einlesen:\n" + ex.Message);
            }
        }

        public void Ausfuehren(string sql)
        {
            try
            {
                cmd = new MySqlCommand(sql, verbindung);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Fehler beim Ausführen:\n" + ex.Message);
            }
        }
    }
}
