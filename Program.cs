Console.Clear();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Victor hugo Sujo Juarez");

Console.WriteLine();

Console.WriteLine("3.-D");

Console.WriteLine();


Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Areas y perimetros");

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();

Console.WriteLine("1. Cuadrado");
Console.WriteLine("2. Rectangulo");
Console.WriteLine("3. Triangulo equilatero");

Console.WriteLine();
Console.Write("Elige una opcion: ");

Console.ForegroundColor = ConsoleColor.Green;
int opcion = int.Parse(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.White;

if (opcion == 1)
{
    Console.Write("Ingresa el lado: ");

    Console.ForegroundColor = ConsoleColor.Green;
    double lado = double.Parse(Console.ReadLine());

    double area = lado * lado;
    double perimetro = lado * 4;

    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Area: ");

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"{area:F2}");

    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Perimetro: ");

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"{perimetro:F2}");
}

else if (opcion == 2)
{
    Console.Write("Ingresa el largo: ");

    Console.ForegroundColor = ConsoleColor.Green;
    double largo = double.Parse(Console.ReadLine());

    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Ingresa el ancho: ");

    Console.ForegroundColor = ConsoleColor.Green;
    double ancho = double.Parse(Console.ReadLine());

    double area = largo * ancho;
    double perimetro = (largo + ancho) * 2;

    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Area: ");

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"{area:F2}");

    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Perimetro: ");

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"{perimetro:F2}");
}

else if (opcion == 3)
{
    Console.Write("Ingresa el lado: ");

    Console.ForegroundColor = ConsoleColor.Green;
    double lado = double.Parse(Console.ReadLine());

    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Ingresa la altura: ");

    Console.ForegroundColor = ConsoleColor.Green;
    double altura = double.Parse(Console.ReadLine());

    double area = (lado * altura) / 2;
    double perimetro = lado * 3;

    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Area: ");

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"{area:F2}");

    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Perimetro: ");

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"{perimetro:F2}");
}

else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Opcion incorrecta");
}

Console.ForegroundColor = ConsoleColor.White;

