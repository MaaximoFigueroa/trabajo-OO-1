using System;

public class Barbaro : Personaje
{
    private int furia;

    public Barbaro(string nombre, int vida, int ataque, int furia) : base(nombre, vida, ataque)
    {
        this.furia = furia;
    }

    public override void Atacar(Personaje objetivo)
    {
        int danio = GetAtaque();

        if (furia >= 3)
        {
            Console.WriteLine($"{nombre} ataca furioso");
            danio = (int)Math.Round(danio * 1.15);
            furia -= 3;
        }
        else
        {
            Console.WriteLine($"{nombre} está cansado");
            danio = (int)Math.Round(danio * 0.5);
        }

        Console.WriteLine($"{nombre} ataca a {objetivo.GetNombre()}");
        objetivo.RecibirDanio(danio);
    }
}