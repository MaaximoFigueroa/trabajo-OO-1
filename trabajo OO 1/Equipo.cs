public class Equipo
{
    protected int modificadorAtaque;
    protected int modificadorArmadura;

    public Equipo(int ataque, int armadura)
    {
        modificadorAtaque = ataque;
        modificadorArmadura = armadura;
    }

    public int getModificadorAtaque() => modificadorAtaque;
    public int getModificadorArmadura() => modificadorArmadura;
}