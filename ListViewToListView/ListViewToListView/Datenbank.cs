using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace ListViewToListView
{
    class Datenbank
    {
        private OleDbConnection verbindung;
        private OleDbCommand cmd;
        private string cn;

        public Datenbank()
        {
            cn = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Autos.accdb";
            verbindung = new OleDbConnection(cn);
            verbindung.Open();
        }

        public OleDbDataReader Einlesen(string sql)
        {
            try
            {
                cmd = new OleDbCommand(sql, verbindung);
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
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
                cmd = new OleDbCommand(sql, verbindung);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Fehler beim Ausführen:\n" + ex.Message);
            }
        }
    }
}
