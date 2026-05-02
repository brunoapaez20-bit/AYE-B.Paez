Console.Write("Escribe una frase: ");
string frase = Console.ReadLine().ToLower();
int contador = 0;
char[] vocales = { 'a', 'e', 'i', 'o', 'u' };

foreach (char c in frase)
{
    if (Array.Exists(vocales, v => v == c)) contador++;
}
Console.WriteLine($"Total de vocales: {contador}");

Console.Write("Escribe algo para invertir: ");
string texto = Console.ReadLine();
char[] caracteres = texto.ToCharArray();
Array.Reverse(caracteres);
Console.WriteLine(new string(caracteres));

Console.Write("Ingresa un número entero: ");
string numStr = Console.ReadLine();
int suma = 0;

foreach (char c in numStr)
{
    if (char.IsDigit(c)) suma += (int)char.GetNumericValue(c);
}
Console.WriteLine($"La suma de los dígitos es: {suma}");

string parrafo = "El gato negro saltó sobre el muro gris mientras el gato blanco dormía.";
Console.WriteLine($"Texto original: {parrafo}");

Console.Write("Palabra prohibida: ");
string prohibida = Console.ReadLine();
Console.Write("Palabra de reemplazo: ");
string reemplazo = Console.ReadLine();

string resultado = parrafo.Replace(prohibida, reemplazo);
Console.WriteLine($"Resultado: {resultado}");

Console.Write("Ingresa tu nombre y apellido: ");
string nombreCompleto = Console.ReadLine().Trim();
string[] partes = nombreCompleto.Split(' ');

if (partes.Length >= 2)
{
    string iniciales = $"{partes[0][0]}.{partes[partes.Length - 1][0]}.";
    Console.WriteLine($"Iniciales: {iniciales}");
    Console.WriteLine($"Primer nombre: {partes[0]}");
    Console.WriteLine($"Apellido: {partes[partes.Length - 1]}");
}



Console.Write("Escribe una palabra: ");
string palabra = Console.ReadLine().ToLower().Replace(" ", "");

caracteres = palabra.ToCharArray();
Array.Reverse(caracteres);

string invertida = new string(caracteres);

if (palabra == invertida)
    Console.WriteLine("Es un palíndromo.");
else
    Console.WriteLine("No es un palíndromo.");

