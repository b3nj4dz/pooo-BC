public class Arquero : Personaje
{
    public int Agilidad { get; set; }
    public Arquero(string nombre, int vida, int fuerza, int agilidad)
    :base(nombre,vida,fuerza)
    {
        Agilidad=agilidad;
    }
    public override void Atacar(Personaje objetivo)
    {
        Console.WriteLine($"{Nombre} dispara una flecha certera a {objetivo.Nombre}!");
        int danoTotal = Fuerza + Agilidad;
        objetivo.RecibirDano(danoTotal);
    }
    public override void RecibirDano(int dano)
    {
        int resultado = Random.Shared.Next(100);

        if (resultado < Agilidad)
        {
            Console.WriteLine($"¡{Nombre} esquivó el ataque gracias a su agilidad!");
            return;
        }

        base.RecibirDano(dano);
    }
}