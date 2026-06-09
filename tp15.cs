int[,] matriz =
{
    {1,2,3},
    {4,5,6},
    {7,8,9}
};
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine(matriz[i,j] + "");
    }
    Console.WriteLine();
}


int[,] matriz2 =
{
    {10,20,30 },
    {40,50,60 },
    {70,80,90 }
};
int sumatotal = 0;

for (int i = 0; i < 3; i++)
{
    for (int b = 0; b < 3; b++)
    {
        sumatotal += matriz2[i,b];
    }
}
Console.WriteLine("la suma total de todo los numeros son:"+sumatotal);

int[,] matriz3 =
{
    {1,2,3,5},
    {8,13,21,34},
    {55,89,144,233},
    {377,610,987,2}
};
Console.Write("ingrese el numero de la fila (0-3):");
int fila = int.Parse(Console.ReadLine());
Console.Write("ingrese el numero de la columna (0-3):");
int columna = int.Parse(Console.ReadLine());
int  elemento = matriz3[fila, columna];
Console.WriteLine($"el elemento en la coordenada [{fila}][{columna}] es:{elemento}");

int[,] matriz4 =
{
    {15,34,23,56},
    {78,89,56,23},
    {36,67,59,93},
    {100,50,70,80}
};
int maximo = matriz4[0, 0];

Console.WriteLine("ejercicio 4");
for (int i = 0; i < 4; i++)
{
    for (int h = 0;h < 4; h++)
    {
        if (matriz4[i,h] > maximo)
        {
            maximo = matriz4[i, h];
        }
    }
}
Console.WriteLine("el numero mas grande de la matriz es :" +maximo);