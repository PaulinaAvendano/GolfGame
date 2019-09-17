using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Terrain
    {
        private string fairway;
        private string rough;
        private string bunker;
        private string bosque;

        public Terrain(string fairway, string rough, string bunker, string bosque)
        {
            Fairway = fairway;
            Rough = rough;
            Bunker = bunker;
            Bosque = bosque;
        }

        public string Fairway
        {
            get { return this.fairway; }
            set { this.fairway = value; }
        }

        public string Rough
        {
            get { return this.rough; }
            set { this.rough = value; }
        }

        public string Bunker
        {
            get { return this.bunker; }
            set { this.bunker = value; }
        }

        public string Bosque
        {
            get { return this.bosque; }
            set { this.bosque = value; }
        }


    }

}
