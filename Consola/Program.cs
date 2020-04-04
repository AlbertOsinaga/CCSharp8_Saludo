using static System.Console;

namespace Consola
{
	class Program
	{
		static void Mainn()
		{
			// Despliegue en la Pantalla: “Por favor introduzca su nombre: ”
			WriteLine("Por favor introduzca su nombre: ");

			// Cuando el Usuario termine de escribir su nombre. Leálo
			var usuario = ReadLine();

			// Despliegue en la pantalla el saludo: “Hola[Nombre del Usuario]!”
			WriteLine($"Hola {usuario}!");
		}
	}
}

