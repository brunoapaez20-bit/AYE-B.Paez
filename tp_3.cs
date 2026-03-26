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