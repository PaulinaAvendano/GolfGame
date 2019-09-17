using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Terrain
    {
        public string type;
        public int p; //probabilidad de que caiga en ese terreno
        public int p1; //1er num del intervalo de porcentaje de penalizacion
        public int p2; //2do num del intervalo de porcentaje de penalizacion
        public Terrain(string type, int p, int p1, int p2)
        {

        }
    }

}
