using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Player
    {
        private string name;
        public Dictionary<string, Palo> palo;
        private int pos; //posición
        private int hits;

        public Player(string name, int pos, Dictionary<string,Palo> palo, int hits)
        {
            Name = name;
            Pos = pos;
            Hits = hits;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Pos
        {
            get { return this.pos; }
            set { this.pos = value; }
        }

        public int Hits
        {
            get { return this.hits; }
            set { this.hits = value; }
        }

        public void Throw(Palo club, Terrain terreno, int avance, int x)
        {
            Random random = new Random();
            int rd = random.Next(club.Mult, 100);
            x = rd / 100;
            avance = club.Dist*x;
            pos += avance;
            hits += 1;

        }
    }
}
