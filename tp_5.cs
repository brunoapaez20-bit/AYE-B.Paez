Console.WriteLine("Ejercicio 1");
string passSecreta = "profe123";
string intento = "";

while (intento != passSecreta)
{
    Console.Write("Ingresa la contraseña: ");
    intento = Console.ReadLine();

    if (intento != passSecreta)
    {
        Console.WriteLine("Inténtalo de nuevo");
    }
}

Console.WriteLine("Entrando");

Console.WriteLine("Ejercicio 2");

for (int i = 5; i >= 1; i--)
{
    Console.WriteLine(i);
}

Console.WriteLine("¡Listo para despegar!");
Console.WriteLine("¡Despegue!");

Console.WriteLine("Ejercicio 3");
int numeroSecreto = 7;
int adivinanza = 0;

while (adivinanza != numeroSecreto)
{
    Console.Write("Adivina el número secreto: ");
    adivinanza = Convert.ToInt32(Console.ReadLine());

    if (adivinanza == numeroSecreto)
    {
        Console.WriteLine("¡Felicidades! Adivinaste el número.");
    }
}

Console.WriteLine("Ejercicio 4");
int sumaTotal = 0;
int numeroIngresado = -1; 

while (numeroIngresado != 0)
{
    Console.Write("Ingresa un número (0 para terminar): ");
    numeroIngresado = Convert.ToInt32(Console.ReadLine());

    sumaTotal = sumaTotal + numeroIngresado;
}

Console.WriteLine("La suma total es: " + sumaTotal);
