Console.Write("Ingrese un número entero: ");
int num = int.Parse(Console.ReadLine());
bool esPrimo = num > 1;

for (int i = 2; i * i <= num; i++)
{
    if (num % i == 0)
    {
        esPrimo = false;
        break;
    }
}

if (esPrimo) Console.WriteLine("Es primo");
else Console.WriteLine("No es primo");

Console.Write("Ingrese un número entero no negativo: ");
int n = int.Parse(Console.ReadLine());
double factorial = 1; 

for (int i = 1; i <= n; i++)
{
    factorial *= i;
}

Console.WriteLine($"El factorial de {n} es: {factorial}");

Console.Write("Ingrese la cantidad de términos (n): ");
int _ = int.Parse(Console.ReadLine());
int a = 0, b = 1;

for (int i = 0; i < n; i++)
{
    Console.Write(a + " ");
    int siguiente = a + b;
    a = b;
    b = siguiente;
}

