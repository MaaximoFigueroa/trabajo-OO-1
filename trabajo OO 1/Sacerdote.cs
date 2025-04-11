using System;

public class Sacerdote : Personaje
{
    private static Random rand = new Random();

    public Sacerdote(string nombre, int vida, int ataque) : base(nombre, vida, ataque) { }

    public override void RecibirDanio(int danio)
    {
        if (rand.Next(4) == 0)
        {
            danio = (int)Math.Round(danio / 2.0);
            Console.WriteLine($"Las plegarias de {nombre} han sido escuchadas");
        }
        base.RecibirDanio(danio);
    }
}