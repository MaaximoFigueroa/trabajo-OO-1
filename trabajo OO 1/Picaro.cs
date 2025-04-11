using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo_OO_1
{
    public class Picaro : Personaje
    {
        private static Random rand = new Random();

        public Picaro(string nombre, int vida, int ataque) : base(nombre, vida, ataque) { }

        public override void Atacar(Personaje objetivo)
        {
            int danio = GetAtaque();
            if (rand.Next(100) < 5)
            {
                danio *= 2;
                Console.WriteLine($"{nombre} hace un ataque crítico sorpresa!");
            }

            Console.WriteLine($"{nombre} ataca a {objetivo.GetNombre()}");
            objetivo.RecibirDanio(danio);
        }
    }
}
