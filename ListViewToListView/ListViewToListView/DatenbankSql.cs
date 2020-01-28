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
            catch (Exception ex)
            {
                throw new Exception("Verbindung konnte nicht geöffnet werden! \n" + ex.Message);
            }
            
        }

        public MySqlDataReader Einlesen(string sql)
        {
            try
            {
                verbindung.Close();
                verbindung.Open();
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
                verbindung.Close();
                verbindung.Open();
                cmd = new MySqlCommand(sql, verbindung);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Fehler beim Ausführen:\n" + ex.Message);
            }
        }

        public Int32 BerechnenInt(string sql)
        {
            try
            {
                verbindung.Close();
                verbindung.Open();
                cmd = new MySqlCommand(sql, verbindung);
                Int32 x = Convert.ToInt32(cmd.ExecuteScalar());
                return x;
            }
            catch (Exception ex)
            {
                throw new Exception("Fehler beim Berechnen mit Int:\n" + ex.Message);
            }
        }

        public double BerechnenDouble(string sql)
        {
            try
            {
                verbindung.Close();
                verbindung.Open();
                cmd = new MySqlCommand(sql, verbindung);
                double x = Convert.ToDouble(cmd.ExecuteScalar());
                return x;
            }
            catch (Exception ex)
            {
                throw new Exception("Fehler beim Berechnen mit Double:\n" + ex.Message);
            }
        }
    }
}
