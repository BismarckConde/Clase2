Console.Title = " El sexo de una Persona ";
int edad;
string Nombre, Sexo;
Console.WriteLine(" Digitar tu nombre");
Nombre = Console.ReadLine();
Console.WriteLine(" Digite tu edad");
edad = int.Parse(Console.ReadLine());
Console.WriteLine(" Digitar tu sexo (Hombre=M y Mujer=F )");
Sexo = Console.ReadLine();
if (Sexo == "M" || Sexo == "m")
{
    Console.WriteLine("\nEl sr{0} ha sido registrado",Nombre);
}
else
{
    Console.WriteLine(" \n La Sra {0} ha sido registrada",Nombre);
}
Console.WriteLine("\n\n");
Console.WriteLine("\n----> Fin del programa");
Console.ReadKey();
 









