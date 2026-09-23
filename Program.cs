Console.WriteLine("=== INICIO DE LA BATALLA ===\n");
Guerrero arthur = new Guerrero("Arthur", 100, 15, 10);
Arquero legolas = new Arquero("Legolas", 80, 12, 30);

int ronda = 1;
// Bucle de batalla
while (arthur.Vida > 0 && legolas.Vida > 0)
{
    Console.WriteLine($"--- Ronda {ronda} ---");
    // turno 1
    arthur.Atacar(legolas);
    // condición para salir del bucle si la vida de legolas es menor o igual a 0
    if (legolas.Vida <= 0) break;
    // turno 2
    legolas.Atacar(arthur);
    ronda++;
    Console.WriteLine("Presiona ENTER para continuar a la siguiente ronda...\n");
    Console.ReadLine();
}
Console.WriteLine("=== FIN DE LA BATALLA ===");
// Mostrar el resultado de la batalla
if (arthur.Vida > 0)
{
    Console.WriteLine($"{arthur.Nombre} ha ganado la batalla con {arthur.Vida} de vida restante.");
}
else
{
    Console.WriteLine($"{legolas.Nombre} ha ganado la batalla con {legolas.Vida} de vida restante.");
}