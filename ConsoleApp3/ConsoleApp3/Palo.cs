using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Palo
    {
        private string type;
        private int dist;
        private int mult;

        public Palo(string type, int dist, int mult, int a = 100)
        {
            Type = type;
            Mult = mult;
            Dist = dist;
        }

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public int Mult
        {
            get { return this.mult; }
            set { this.mult = value; }
        }

        public int Dist
        {
            get { return this.dist; }
            set { this.dist = value; }
        }

    }
}