/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 30/10/2024
 * Hora: 10:01 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Ejercicio1
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			/*Carro Mustang = new Carro();
			Mustang.Marca="Ford";
			Mustang.Modelo="Mustang";
			Mustang.Año=2012;
			
			Console.WriteLine("Carro= {0} {1} {2}", Mustang.Marca, Mustang.Modelo, Mustang.Año);
			Console.WriteLine(Mustang.Arrancar());
			Mustang.Detener();*/
			
			/*Libro Habitos = new Libro();
			Habitos.Titulo="Los 7 Habitos de los adolescentes altamente efectivos";
			Habitos.Autor="Desconocido";
			Habitos.Numero_de_Paginas=99;
			Habitos.Pagina_Activa=29;
			
			Habitos.Leer();
			Habitos.Info();*/
			
			Empleado Jose = new Empleado();
			Jose.Nombre= "Jose";
			Jose.Edad=26;
			Jose.Salario_Diario=250;
			
			Jose.Info();
			Console.WriteLine("El salario mensual es de: " + Jose.Salario_Mensual());
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}