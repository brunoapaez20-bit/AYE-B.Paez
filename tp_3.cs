 string ejercicio1(int n)
{
    string resultado;
    if (n > 0)
        resultado = "es positivo";
    else if (n <  18)
        resultado = "es negativo";
    else
        resultado = "0";
    return resultado;
}

Console.WriteLine(ejercicio1(Convert.ToInt32(Console.ReadLine())));


string ejercicio2(int n)
{
    string resultado;
    if (n > 0
 )
        resultado = "bienvenido a la fiesta";
    else if (n < 0)
        resultado = "losiento eres muy joven";
    else
        resultado = "bievienido a la fiesta";
    return resultado;
}

Console.WriteLine(ejercicio2(Convert.ToInt32(Console.ReadLine())));

Console.WriteLine("Ejercicio 3");
Console.Write("Ingresa la contraseña: ");
string password = Console.ReadLine();

if (password == "python123")
{
    Console.WriteLine("¡Contraseña correcta! Acceso concedido.");
}
else
{
    Console.WriteLine("¡Contraseña incorrecta, Autodestrucción en 5 minutos!");
}

Console.WriteLine("Ejercicio 4: Par o Impar?");
Console.Write("Ingresa un número entero: ");
int num = int.Parse(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("El número es par.");
}
else
{
    Console.WriteLine("El número es impar");
}

Console.WriteLine("Ejercicio 5: Entrada gratis?");
Console.Write("¿Cuántos años tienes?: ");
int edad = int.Parse(Console.ReadLine());

Console.Write("¿Compraste palomitas? (si/no): ");
string palomitas = Console.ReadLine().ToLower();

if (edad > 65 && palomitas == "si")
{
    Console.WriteLine("¡Felicidades! Tienes entrada gratuita al cine.");
}
else
{
    Console.WriteLine("Compra la entrada o raja de acá");
}

