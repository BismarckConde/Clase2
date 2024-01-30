double L1, L2, Peri, Base;
while(true)
        {
    Console.WriteLine("Seleccione el tipo de triángulo:");
    Console.WriteLine("1. Equilátero");
    Console.WriteLine("2. Isósceles");
    Console.WriteLine("3. Rectangulo");
    Console.WriteLine("0. Salir");

    Console.Write("Ingrese su opción: ");
    int opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.Write("Ingrese la longitud del lado: ");
              L1= Convert.ToDouble(Console.ReadLine());
             Peri = 3 * L1;
            Console.WriteLine($"El perímetro del equilátero es: {Peri}");
            break;

        case 2:
            Console.Write("Ingrese la longitud del lado: ");
             L1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la longitud de la base: ");
             Base = Convert.ToDouble(Console.ReadLine());
             Peri = (2 * L1) + Base;
            Console.WriteLine($"El perímetro del isósceles es: {Peri}");
            break;

        case 3:
            Console.Write("Ingrese la longitud del lado 1: ");
            L1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la longitud del lado 2: ");
            L2 = Convert.ToDouble(Console.ReadLine());
            Peri =L1 + L2 + Math.Sqrt(Math.Pow(L1, 2) + Math.Pow(L2, 2));
            Console.WriteLine($"El perímetro del rectangulo es: {Peri}");
            break;

        case 0:
            Environment.Exit(0);
            Console.WriteLine("saliendo");
            break;

        default:
            Console.WriteLine("Opción no válida. Por favor, seleccione nuevamente.");
            break;
    }
}
    
