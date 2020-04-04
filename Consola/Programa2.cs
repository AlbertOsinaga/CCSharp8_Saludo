using static System.Console;

namespace Consola
{
	class Programa2
	{
		static void Main()
		{
			// Despliegue en la Pantalla: “Por favor introduzca su nombre: ”
			Write("Por favor introduzca su nombre: ");

			// Cuando el Usuario termine de escribir su nombre. Leálo
			var usuario = ReadLine();

			// Despliegue en la pantalla el saludo: “Hola[Nombre del Usuario]!”
			WriteLine($"Hola {usuario}!");

			// Parada Final
			WriteLine("Bienvenid@ a C#!");
			ReadKey();
		}
	}
}

