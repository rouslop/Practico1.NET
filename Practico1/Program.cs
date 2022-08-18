// See https://aka.ms/new-console-template for more information
using BibliotecaClases;

Console.WriteLine("Mi Primera App");
//Console.ReadLine();
/*Persona p = new Persona();
p.Nombre = Console.ReadLine();
Console.WriteLine("Nombre: " + p.Nombre);
Console.ReadLine();*/

/*do
{
	try
	{
		Console.WriteLine("Nueva Persona");
		Persona per = new Persona();
		Console.WriteLine("Nombre: ");
		per.Nombre = Console.ReadLine();
		Console.WriteLine("Dcoumento: ");
		per.Documento = Console.ReadLine();
	}
	catch (Exception ex)
	{

		Console.WriteLine("ERROR: " + ex.Message);
	}
}
while (!Console.ReadLine().Equals("EXIT"));*/

//PARTE 2
/*
int[] aux = { 2, 3, 6, 1, 0, 8, 9, 4, 5, 56, 10, 88, 23, 44, 11 };
aux.ToList().ForEach(x => Console.WriteLine(x + "|"));
Console.WriteLine();

int[] aux2 = aux.ToList().OrderBy(x => x).ToArray();
aux2.ToList().ForEach(x => Console.WriteLine(x + "|"));
Console.WriteLine();

int[] aux3 = aux.ToList().Where(x => x < 10).OrderBy(x => x).ToArray();
aux3.ToList().ForEach(x => Console.WriteLine(x + "|"));*/

List<Persona> personas = new List<Persona>();  
do
{
    try
    {
        Console.WriteLine("Nueva Persona");
        Persona per = new Persona();
        Console.WriteLine("Nombre: ");
        per.Nombre = Console.ReadLine();
        Console.WriteLine("Apellido: ");
        per.Apellido = Console.ReadLine();
        Console.WriteLine("Dcoumento: ");
        per.Documento = Console.ReadLine();
        Console.WriteLine("Dia de nacimiento: ");
        //como leer un tipo datetime
        DateTime fecha = new DateTime();
        int dia = int.Parse(Console.ReadLine());
        Console.WriteLine("Mes de nacimiento: ");
        int mes = int.Parse(Console.ReadLine());
        Console.WriteLine("Anio de nacimiento: ");
        int year = int.Parse(Console.ReadLine());
        fecha = new DateTime(year, mes, dia);
        per.FechaNacimiento = fecha;
        personas.Add(per);
    }
    catch (Exception ex)
    {

        Console.WriteLine("ERROR: " + ex.Message);
    }
}
while (!Console.ReadLine().Equals("EXIT"));
//ordenar por edad y mostrar
personas = personas.OrderBy(p => p.FechaNacimiento).ToList();
Console.WriteLine("Personas");
Console.WriteLine("Nombre    Apellido   Documento   Fecha Nacimiento   Edad");
foreach (Persona item in personas)
{
    int edad = DateTime.Today.AddTicks(-item.FechaNacimiento.Ticks).Year - 1;
    Console.WriteLine(item.Nombre + "   " + item.Apellido + "   " + item.Documento+ "   " + item.FechaNacimiento.Date + "   " + edad);
}