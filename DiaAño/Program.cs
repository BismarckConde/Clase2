int D, M;
int DDA=0;
Console.Title = " Calculo del dia del año";
Console.WriteLine(" Introduzca el dia del mes");
D = int.Parse(Console.ReadLine());
Console.WriteLine(" Introduzca el Mes del año");
M = int.Parse(Console.ReadLine());

if (D >= 1 && D <= 31 && M <= 12)
{
    switch (M)
    {
        case 1:
            DDA = D;
            break;
        case 2:
            DDA = D + 31;
      
            break;
        case 3:
            DDA = D + 59;
            break;
        case 4:
            DDA = D + 90;
            break;
        case 5:
            DDA = D + 120;
            break;
        case 6:
            DDA = D + 151;
            break;
        case 7:
            DDA = D + 181;
            break;
        case 8:
            DDA = D + 212;
            break;
        case 9:
            DDA = D + 243;
            break;
        case 10:
            DDA = D + 273;
            break;
        case 11:
            DDA = D + 304;
            break;
        case 12:
            DDA = D + 334;
            break;
        default:
            Console.WriteLine(" Datos proporcionados no validos");
            break;
           
    }
    Console.WriteLine( " El " + D + " del " + M + " es el dia " + DDA + " del año ");
}

Console.WriteLine(" Fin del programa...");
Console.ReadKey();
