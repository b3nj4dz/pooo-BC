public class Personaje
{
    public string Nombre { get; set; }
    public int Vida { get;  protected set; }
    public int Fuerza { get; set; }

    public Personaje()
    {
    }
    public Personaje(string nombre, int vida, int fuerza)
    {
        Nombre=nombre;
        Vida=vida;
        Fuerza=fuerza;
    }
    public virtual void Atacar(Personaje objetivo)
    {
        Console.WriteLine($"El {objetivo.Nombre} fue atacado por {Nombre}");
        objetivo.RecibirDano(Fuerza);
    }

    public virtual void RecibirDano(int dano)
    {
        Vida-=dano;
        if(Vida<0)Vida=0;
        Console.WriteLine($"{Nombre} atacó con una fuerza de {dano}.\nVida: {Vida}");
    }

    public override string ToString()
    {
        return $"Nombre: {Nombre}\nVida: {Vida}\nFuerza: {Fuerza}";
    }

};
