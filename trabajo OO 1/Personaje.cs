public class Personaje
{
    protected string nombre;
    protected int vida;
    protected int ataque;
    protected Equipo? equipo;

    public Personaje(string nombre, int vida, int ataque)
    {
        this.nombre = nombre;
        this.vida = vida;
        this.ataque = ataque;
        this.equipo = null;
    }

    public string GetNombre() => nombre;

    public int GetVida() => vida;

    public virtual int GetAtaque()
    {
        int modificador = equipo?.getModificadorAtaque() ?? 0;
        return ataque + modificador;
    }

    public int GetArmadura()
    {
        return equipo?.getModificadorArmadura() ?? 0;
    }

    public virtual void Atacar(Personaje objetivo)
    {
        Console.WriteLine($"{nombre} ataca a {objetivo.GetNombre()}");
        objetivo.RecibirDanio(GetAtaque());
    }

    public virtual void RecibirDanio(int danio)
    {
        int armadura = GetArmadura();
        int danioTotal = Math.Max(1, danio - armadura);
        vida = Math.Max(0, vida - danioTotal);
        Console.WriteLine($"{nombre} recibe {danioTotal} puntos de daño." + (vida == 0 ? " Ha muerto :(" : ""));
    }

    public void Equipar(Equipo equipo)
    {
        this.equipo = equipo;
    }
}