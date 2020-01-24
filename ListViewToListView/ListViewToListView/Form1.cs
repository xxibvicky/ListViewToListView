using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Data;
using System.Data.OleDb;

namespace ListViewToListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        internal List<Auto> autos;
        internal ListViewItem lvItem;
        XmlSerializer serializer;
        Datenbank db;
        OleDbDataReader dr;
        string sql;
        

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new Datenbank();

            listView1.FullRowSelect = true;
            listView2.FullRowSelect = true;

            autos = new List<Auto>();

            //autos.Add(new Auto("MI 19ET", "Peugeot", "514", "grau", 140));
            //autos.Add(new Auto("MI 456FB", "Opel", "Calibra", "schwarz", 150));
            //autos.Add(new Auto("MI 522ET", "VW", "Up", "gelb", 75));

            //einlesenAutos();

            deserialisieren();
        }

        internal void einlesenAutos()
        {
            listView1.Items.Clear();
            foreach(Auto a in autos)
            {
                lvItem = new ListViewItem(a.Kennzeichen);
                lvItem.SubItems.Add(a.Marke);
                lvItem.SubItems.Add(a.Type);
                lvItem.SubItems.Add(a.Farbe);
                lvItem.SubItems.Add(a.PS.ToString());
                listView1.Items.Add(lvItem);
            }

        }

        private void btnLV1Clear_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void btnInListeSpeichern_Click(object sender, EventArgs e)
        {
            autos = new List<Auto>();
            for(int i = 0; i<listView1.Items.Count; i++)
            {
                Auto a = new Auto();
                a.Kennzeichen = listView1.Items[i].SubItems[0].Text;
                a.Marke = listView1.Items[i].SubItems[1].Text;
                a.Type = listView1.Items[i].SubItems[2].Text;
                a.Farbe = listView1.Items[i].SubItems[3].Text;
                a.PS = Convert.ToInt32(listView1.Items[i].SubItems[4].Text);
                autos.Add(a);
            }
            serialisieren();
        }

        internal void serialisieren()
        {
            try
            {
                serializer = new XmlSerializer(autos.GetType());
                FileStream fs = new FileStream("autos.xml", FileMode.Create, FileAccess.Write, FileShare.None);
                serializer.Serialize(fs, autos);
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal void deserialisieren()
        {
            try
            {
                serializer = new XmlSerializer(autos.GetType());
                FileStream fs = new FileStream("autos.xml", FileMode.Open, FileAccess.Read, FileShare.None);
                autos = (List<Auto>)serializer.Deserialize(fs);
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnListeEinlesen_Click(object sender, EventArgs e)
        {
            einlesenAutos();
        }

        internal void einsRechts()
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Kein Item ausgewählt!");
            }
            else
            {
                lvItem = listView1.SelectedItems[0];
                int inde = lvItem.Index;
                listView1.Items.RemoveAt(inde);
                listView2.Items.Add(lvItem);
            }
        }

        private void btnEinsRechts_Click(object sender, EventArgs e)
        {
            einsRechts();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            einsRechts();
        }

        internal void einsLinks()
        {
            if (listView2.SelectedItems.Count == 0)
            {
                MessageBox.Show("Kein Item ausgewählt!");
            }
            else
            {
                lvItem = listView2.SelectedItems[0];
                int inde = lvItem.Index;
                listView2.Items.RemoveAt(inde);
                listView1.Items.Add(lvItem);
            }
        }

        private void btnEinsLinks_Click(object sender, EventArgs e)
        {
            einsLinks();
        }

        private void listView2_DoubleClick(object sender, EventArgs e)
        {
            einsLinks();
        }

        private void btnAlleRechts_Click(object sender, EventArgs e)
        {
            int anzahl = listView1.Items.Count;
            for(int i = 0; i<anzahl; i++)
            {
                lvItem = listView1.Items[0];
                listView1.Items.RemoveAt(0);
                listView2.Items.Add(lvItem);
            }
        }

        private void btnAlleLinks_Click(object sender, EventArgs e)
        {
            int anzahl = listView2.Items.Count;
            for (int i = 0; i < anzahl; i++)
            {
                lvItem = listView2.Items[0];
                listView2.Items.RemoveAt(0);
                listView1.Items.Add(lvItem);
            }
        }

        private void btnDBeinlesen_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            dr = db.Einlesen("Select * from Auto;");

            while(dr.Read())
            {
                lvItem = new ListViewItem(dr[0].ToString());
                lvItem.SubItems.Add(dr[1].ToString());
                lvItem.SubItems.Add(dr[2].ToString());
                lvItem.SubItems.Add(dr[3].ToString());
                lvItem.SubItems.Add(dr[4].ToString());
                listView2.Items.Add(lvItem);
            }
        }

        private void btnLV2Clear_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
        }

        private void btnInDBSpeichern_Click(object sender, EventArgs e)
        {
            sql = "delete * from Auto;";

            MessageBox.Show(sql);
            db.Ausfuehren(sql);

            for(int i = 0; i<listView2.Items.Count; i++)
            {
                lvItem = listView2.Items[1];
                string kz = lvItem.SubItems[0].Text;
                string marke = lvItem.SubItems[1].Text;
                string type = lvItem.SubItems[2].Text;
                string farbe = lvItem.SubItems[3].Text;
                int ps = Convert.ToInt32(lvItem.SubItems[4].Text);
                sql = "Insert into Auto (Kennzeichen, Marke, Type, Farbe, PS) values ('" + kz + "', '" + marke + "', '" + type + "', '" + farbe + "', " + ps + ");";
                MessageBox.Show(sql);
                db.Ausfuehren(sql);
            }
        }
    }
}
