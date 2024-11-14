/*
 * Creado por SharpDevelop.
 * Usuario: Jose
 * Fecha: 13/11/2024
 * Hora: 1:48 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Listas
{
	class Program
	{
		public static void Main(string[] args)
		{
			ListaEstudiante x = new ListaEstudiante();
			x.Registrar();
			Console.WriteLine("El promedio de las posiciones pares es de: " + x.PromedioPar());
			Console.WriteLine("El porcentaje de notas reprobadas es de: " + x.NotasReprobadas());
			x.ModificarNota();
			x.Mostrar();

			ListaLiga y = new ListaLiga();
			y.Registrar();
			y.JuegosEmpatados();
			Console.WriteLine("Cantidad de partidos en los que hubo paliza: " + y.Paliza());
			Console.WriteLine("Promedio de Goles: " + y.PromedioGoles());

			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}