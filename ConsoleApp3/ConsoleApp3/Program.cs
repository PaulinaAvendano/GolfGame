using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Palo> palos = new Dictionary<string, Palo>() { };

            Palo drive = new Palo("Drive", 320, 60, 100);
            Palo fierro3 = new Palo("Fierro 3", 220, 65, 100);
            Palo fierro4 = new Palo("Fierro 4", 200, 70, 100);
            Palo fierro5 = new Palo("Fierro 5", 180, 75, 100);
            Palo fierro6 = new Palo("Fierro 6", 170, 80, 100);
            Palo fierro7 = new Palo("Fierro 7", 160, 85, 100);
            Palo fierro8 = new Palo("Fierro 8", 150, 90, 100);
            Palo fierro9 = new Palo("Fierro 9", 140, 95, 100);
            Palo pitch = new Palo("Pitch", 120, 98, 100);
            Palo sand = new Palo("Sand", 100, 100);

            palos.Add("Drive", drive);
            palos.Add("Fierro 3", fierro3);
            palos.Add("Fierro 4", fierro4);
            palos.Add("Fierro 5", fierro5);
            palos.Add("Fierro 6", fierro6);
            palos.Add("Fierro 7", fierro7);
            palos.Add("Fierro 8", fierro8);
            palos.Add("Fierro 9", fierro9);
            palos.Add("Pitch", pitch);
            palos.Add("Sand", sand);

            Player P1 = new Player("Bob", 0, palos, 0);
            Player P2 = new Player("Steve", 0, palos, 0);
            Player P3 = new Player("Felipito", 0, palos, 0);
            Player P4 = new Player("George", 0, palos, 0);

            List<Player> players = new List<Player>();

            Random random = new Random();
            int num = random.Next(1, 5);

            if (num==1)
            {
                players.Add(P1);
            } else if (num==2)
            {
                players.Add(P1);
                players.Add(P2);
            } else if (num == 3)
            {
                players.Add(P1);
                players.Add(P2);
                players.Add(P3);
            } else
            {
                players.Add(P1);
                players.Add(P2);
                players.Add(P3);
                players.Add(P4);
            };

            List<Terrain> terrenos = new List<Terrain>();

            Terrain fairway = new Terrain("fairway", 70, 100, 100);
            Terrain rough = new Terrain("rough", 20, 60, 90);
            Terrain bunker = new Terrain("bunker", 5, 0, 60);
            Terrain bosque = new Terrain("bosque", 5, -20, 20);
            terrenos.Add(fairway);
            terrenos.Add(rough);
            terrenos.Add(bunker);
            terrenos.Add(bosque);

            Hole hole = new Hole(terrenos);


        }
    }
}
