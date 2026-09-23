public class Personaje
{

    public string Nombre { get; set; }
    public int Vida { get;  protected set; }
    public int Fuerza { get; set; }

    public Personaje(string nombre, int vida, int fuerza)
    {
        Nombre=nombre;
        Vida=vida;
        Fuerza=fuerza;
    }

    public virtual void Atacar(Personaje objetivo)
    {
        Console.WriteLine($"{Nombre} atacó a {objetivo.Nombre} con un golpe básico.");

        objetivo.RecibirDano(Fuerza);
    }
    public virtual void RecibirDano(int dano)
    {
        Vida-=dano;
        if(Vida<0)Vida=0;
        Console.WriteLine($"{Nombre} recibe {dano} de daño. (Vida:{Vida})\n");

    }

};
