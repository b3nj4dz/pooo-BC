public class Guerrero:Personaje{
    public int Armadura { get; set; }

    public Guerrero()
    {
    
    }

    public Guerrero(string nombre, int vida, int fuerza, int armadura)
    :base(nombre,vida,fuerza)
    {
        Armadura=armadura;
    }

    public override string ToString()
    {
        return base.ToString()+"\nArmadura: "+Armadura;
    }

}