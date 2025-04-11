using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using trabajo_OO_1;

class Juego
{
    public static void Main()
    {
        // No modificar desde aquí ...
        Personaje sacerdote = new Sacerdote("Samson", 30, 5);
        Personaje barbaro = new Barbaro("Dave", 30, 7, 10);
        Equipo tunica = new Armadura(5);
        Equipo hacha = new Arma(6);

        sacerdote.Equipar(tunica);
        barbaro.Equipar(hacha);

        Personaje? ganador = Batalla(barbaro, sacerdote);

        // ... hasta aquí

        if (ganador != null)
        {
            Console.WriteLine($"{ganador.GetNombre()} ha ganado la batalla");
        }
        else
        {
            Console.WriteLine("Nadie ha ganado la batalla");
            return;
        }

        
        Console.WriteLine("¡Ahora ingresa un nuevo personaje para enfrentar al ganador!");
        Console.Write("Nombre: ");
        string nombreNuevo = Console.ReadLine() ?? "Anonimo";

        Console.Write("Vida: ");
        int vidaNueva = int.Parse(Console.ReadLine() ?? "20");

        Console.Write("Ataque: ");
        int ataqueNuevo = int.Parse(Console.ReadLine() ?? "5");

        
        Personaje nuevo = new Picaro(nombreNuevo, vidaNueva, ataqueNuevo);

        
        Console.Write("Modificador de ataque del equipo: ");
        int modAtaque = int.Parse(Console.ReadLine() ?? "2");

        Console.Write("Modificador de armadura del equipo: ");
        int modArmadura = int.Parse(Console.ReadLine() ?? "3");

        Equipo eqNuevo = new Equipo(modAtaque, modArmadura);
        nuevo.Equipar(eqNuevo);

       
        Personaje? finalista = Batalla(ganador, nuevo);

        if (finalista != null)
        {
            Console.WriteLine($"{finalista.GetNombre()} ha ganado la batalla final");
        }
        else
        {
            Console.WriteLine("La batalla final terminó sin ganador");
        }
    }

    public static Personaje? Batalla(Personaje p1, Personaje p2)
    {
        Console.WriteLine("\n¡Comienza la batalla!");

        while (p1.GetVida() > 0 && p2.GetVida() > 0)
        {
            
            p1.Atacar(p2);
            p2.Atacar(p1);

            Console.WriteLine($"Estado: {p1.GetNombre()}({p1.GetVida()} hp) vs {p2.GetNombre()}({p2.GetVida()} hp)\n");
        }

        if (p1.GetVida() > 0 && p2.GetVida() <= 0)
            return p1;
        else if (p2.GetVida() > 0 && p1.GetVida() <= 0)
            return p2;
        else
            return null;
    }
}