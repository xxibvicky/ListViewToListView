using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewToListView
{
    public class Auto
    {
        private string kennzeichen, marke, type, farbe;
        private int ps;

        public Auto() { }

        public Auto (string kennzeichen, string marke, string type, string farbe, int ps)
        {
            this.kennzeichen = kennzeichen;
            this.marke = marke;
            this.type = type;
            this.farbe = farbe;
            this.ps = ps;
        }

        public string Kennzeichen
        {
            get { return kennzeichen; }
            set { kennzeichen = value; }
        }

        public string Marke
        {
            get { return marke; }
            set { marke = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Farbe
        {
            get { return farbe; }
            set { farbe = value; }
        }

        public int PS
        {
            get { return ps; }
            set { ps = value; }
        }

    }
}
