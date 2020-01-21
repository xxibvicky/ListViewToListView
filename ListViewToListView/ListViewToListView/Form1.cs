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

        private void Form1_Load(object sender, EventArgs e)
        {
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
    }
}
