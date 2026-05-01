bool continuar = true;

while (continuar)
{
    Console.Clear();
    Console.WriteLine("elji un numero");
    Console.WriteLine("1. Positivo o Negativo");
    Console.WriteLine("2. Entrada a la Fiesta");
    Console.WriteLine("3. Validar Contraseña");
    Console.WriteLine("4. Par o Impar");
    Console.WriteLine("5. Cine Gratis");
    Console.WriteLine("0. Salir");
    Console.Write("\nSeleccione una opción: ");

    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            Console.Write("Ingresa un número: ");
            int n1 = int.Parse(Console.ReadLine());

            string msj1 = n1 switch
            {
                > 0 => "Es positivo",
                < 0 => "Es negativo",
                _ => "Es cero"
            };
            Console.WriteLine(msj1);
            break;

        case "2":
            Console.Write("¿Qué edad tienes?: ");
            int edadFiesta = int.Parse(Console.ReadLine());

            string msj2 = edadFiesta switch
            {
                >= 18 => "¡Bienvenido a la fiesta!",
                _ => "Lo siento, eres muy joven"
            };
            Console.WriteLine(msj2);
            break;

        case "3":
            Console.Write("Ingresa la contraseña: ");
            string pass = Console.ReadLine();
            switch (pass)
            {
                case "python123":
                    Console.WriteLine("¡Contraseña correcta! Acceso concedido.");
                    break;
                default:
                    Console.WriteLine("¡Contraseña incorrecta, Autodestrucción en 5 minutos!");
                    break;
            }
            break;

        case "4":
            Console.Write("Ingresa un número entero: ");
            int numPar = int.Parse(Console.ReadLine());

            switch (numPar % 2)
            {
                case 0:
                    Console.WriteLine("El número es par.");
                    break;
                default:
                    Console.WriteLine("El número es impar.");
                    break;
            }
            break;

        case "5":
            Console.Write("¿Cuántos años tienes?: ");
            int edadCine = int.Parse(Console.ReadLine());
            Console.Write("¿Compraste palomitas? (si/no): ");
            string palomitas = Console.ReadLine().ToLower();


            switch (edadCine, palomitas)
            {
                case ( > 65, "si"):
                    Console.WriteLine("¡Felicidades! Tienes entrada gratuita al cine.");
                    break;
                default:
                    Console.WriteLine("Compra la entrada o raja de acá");
                    break;
            }
            break;

        case "0":
            continuar = false;
            Console.WriteLine("Saliendo del programa...");
            break;

        default:
            Console.WriteLine("Opción no válida.");
            break;
    }

    if (opcion != "0")
    {
        Console.WriteLine("Presiona cualquier tecla para volver al menú...");
        Console.ReadKey();
    }
}